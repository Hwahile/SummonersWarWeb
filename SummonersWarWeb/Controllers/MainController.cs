using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using SummonersWarWeb.Classes.MainData;
using SummonersWarWeb.Classes.StringExtensions;
using SummonersWarWeb.Classes.BattleWorldBossResult;
using Newtonsoft.Json;

namespace SummonersWarWeb.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            string lErrorMessage = "";


            // ToDo: Hochgeladene Datei verwenden
            string lPcapPath = Server.MapPath(@"\Content\neuerertest.pcap");

            // Datei in den Reader laden
            SharpPcap.LibPcap.CaptureFileReaderDevice lPcapReader = new SharpPcap.LibPcap.CaptureFileReaderDevice(lPcapPath);

            // Dict, dass am Ende hoffentlich alles wichtige beinhaltet
            Dictionary<uint, string> lTcpData = new Dictionary<uint, string>();

            // Hier wird die .pcap Datei Packet für Packet durchgegangen, dabei werden die relevanten Daten in das Dictionary geschrieben
            SharpPcap.RawCapture lCurrentCapture = lPcapReader.GetNextPacket();
            while (lCurrentCapture != null)
            {
                PacketDotNet.Packet lCurrentPacket = PacketDotNet.Packet.ParsePacket(lCurrentCapture.LinkLayerType, lCurrentCapture.Data);
                if (lCurrentPacket != null && lCurrentPacket.PayloadPacket != null && lCurrentPacket.PayloadPacket.GetType().Name == "IPv4Packet")
                {
                    PacketDotNet.IPv4Packet lCurrentIPv4Packet = lCurrentPacket.PayloadPacket as PacketDotNet.IPv4Packet;
                    if (lCurrentIPv4Packet.PayloadPacket != null && lCurrentIPv4Packet.PayloadPacket.GetType().Name == "TcpPacket")
                    {
                        PacketDotNet.TcpPacket lCurrentTcpPacket = lCurrentIPv4Packet.PayloadPacket as PacketDotNet.TcpPacket;
                        if (lCurrentTcpPacket != null && lCurrentTcpPacket.SourcePort == 80 && lCurrentTcpPacket.PayloadData != null && lCurrentTcpPacket.PayloadData.Length > 0)
                        {
                            if (lTcpData.ContainsKey(lCurrentTcpPacket.AcknowledgmentNumber))
                            {
                                lTcpData[lCurrentTcpPacket.AcknowledgmentNumber] += Encoding.UTF8.GetString(lCurrentTcpPacket.PayloadData);
                            }
                            else
                            {
                                lTcpData.Add(lCurrentTcpPacket.AcknowledgmentNumber, Encoding.UTF8.GetString(lCurrentTcpPacket.PayloadData));
                            }
                        }
                    }
                }
                lCurrentCapture = lPcapReader.GetNextPacket();
            }

            // Liste der Packet Bodys (also den übertragenen Daten, unwichtig ist der Rest (z.B. Serverart, ..)
            List<string> lTcpBodys = new List<string>();
            try
            {
                foreach (uint lKey in lTcpData.Keys)
                {
                    // noch kaputtbar .. oder nicht - ? Wer weiß das schon. evtl mal n contains reinbauen aber yolo. erfüllt seinen Zweck
                    string lBody = lTcpData[lKey].Split(new[] { "\r\n\r\n" }, StringSplitOptions.None)[1];
                    if (!string.IsNullOrWhiteSpace(lBody))
                        lTcpBodys.Add(lBody);
                    //else können wir hier denke ich ignorieren
                }
            }
            catch (Exception pException)
            {
                lErrorMessage = "Fehler beim splitten" + pException.Message;
            }

            /* Die Daten werden dahingehend überprüft, ob sie im base64 Format sind,
             * wenn nicht können sie übersprungen werden (=> unwichtig)
             * wenn ja, wird versucht, den verschlüsselten String umzuwandeln (.json)
             *      manchmal wiederholt sich der letzte Teil des verschlüsselten Strings, hier wird versucht die Dopplung zu entfernen
             *      (bisher sind nur Dopplungen aufgefallen, die sichtbar waren (doppelte = - "Enden") => auf Erfahrungswerte warten) */
            List<string> lHopefullyJsonData = new List<string>();
            List<string> lFailedData = new List<string>();
            while (lTcpBodys.Any())
            {
                string lCurrentBody = lTcpBodys[0];
                lTcpBodys.RemoveAt(0);
                bool lFailed = false;
                if (lCurrentBody.CouldBeBase64String())
                {
                    string lTempBody = "";
                    if (Regex.Matches(lCurrentBody, @"([a-zA-Z0-9+/]+[=]{0,3})").Count > 1)
                        lTempBody = zGetDataFromCom2UsString(Regex.Replace(lCurrentBody, @"([a-zA-Z0-9+/]+[=]{0,3})(.*)", "$1"), out lFailed);
                    else
                        lTempBody = zGetDataFromCom2UsString(lCurrentBody, out lFailed);

                    if (!lFailed)
                        lHopefullyJsonData.Add(lTempBody);
                    else
                        lFailedData.Add(lCurrentBody);
                }
            }

            if (lFailedData.Any())
            {
                using (StreamWriter lWriter = new StreamWriter(@"C:\Temp\Log.txt", true))
                    foreach (string lCurr in lFailedData)
                        lWriter.WriteLine(lCurr);
            }

            // Man könnte die unwichtigen strings rausfiltern .. oder man beachtet sie einfach im foreach nicht .. ? 
            // wenn man sie vorher filtert kann man direkt rausspringen wenn keine sinnvollen Daten vorhanden sind .. tun wir dies.
            // Siehe /files2 ..
            if (lHopefullyJsonData.Any())
            {
                for (int i = 0; i < lHopefullyJsonData.Count; i++)
                {
                    string lTemp = lHopefullyJsonData[i];
                    bool lDel = false;
                    if (lTemp.Contains("CheckLoginBlock") || lTemp.Contains("CheckDarkPortalStatus") || lTemp.Contains("GetArenaLog"))
                        lDel = true;
                    // wenn mehr zeit ist.
                    else if (lTemp.Contains("DoRandomWishItem"))
                        lDel = true;


                    if (lDel)
                        lHopefullyJsonData[i] = "";
                }

            }
            lHopefullyJsonData = lHopefullyJsonData.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            if (lHopefullyJsonData.Any())
            {
                // Nun sind wir "fast" am Ziel ..  lol es müssen lediglich die json strings unterschieden und danach in die Klassen geparst werden .. lel
                lHopefullyJsonData.Sort();




                foreach (string lCurrJson in lHopefullyJsonData)
                {
                    if (lCurrJson.Contains("HubUserLogin"))
                    {
                        if (Regex.Matches(lCurrJson, "\"[0-9]+\":").Count > 1)
                        {
                            //string regexd = Regex.Replace(lCurrJson, "\"[0-9]+\":", "\"xxx\":");
                            //([{])(?<need>(\{[^\}]+\}\,*)+)*([}]) mit [${need}]
                            // Fick diesen life pls.
                            using (StreamWriter lWriter = new StreamWriter(@"C:\Temp\Json.json", false))
                                lWriter.WriteLine(lCurrJson);

                            // ERNSTHAFT FICKT EUCH !
                            string regexd = lCurrJson;
                            regexd = Regex.Replace(regexd, "\"([0-9]+)\":[{]", "{");
                            regexd = Regex.Replace(regexd, "\"([0-9]+)\":[[]", "\"Day$1\": [");
                            regexd = Regex.Replace(regexd, "([{])(?<need>({[^}]+},*)+)*([}])", "[${need}]");



                            MainData lBWBR = JsonConvert.DeserializeObject<MainData>(regexd);
                            //lBWBR.MonsterListe = lBWBR.MonsterListe.Where(x => x.Name == "Unknown").ToList();
                            // YOLO
                            lBWBR.MonsterListe = lBWBR.MonsterListe.Where(x => x.Name == "Raoq").ToList();


                            ViewData.Add("Maindata", lBWBR);
                            return View();

                        }

                        //\"\d+\"\:

                    }
                    //if (lCurrJson.Contains("BattleWorldBossResult"))
                    //{
                    //    BattleWorldBossResult lBWBR = JsonConvert.DeserializeObject<BattleWorldBossResult>(lCurrJson, new JsonSerializerSettings()
                    //    {
                    //        NullValueHandling = NullValueHandling.Ignore
                    //    });
                    //}
                }
            }

            //ViewData.Add("Test", x);
            //ViewData.Add("Trottel", pEx.Message);


            return View();
        }

        #region Entschlüsselung c2s

        public static byte[] DecompressData(byte[] inData)
        {
            byte[] lReturnData;
            using (MemoryStream outMemoryStream = new MemoryStream())
            {
                using (zlib.ZOutputStream outZStream = new zlib.ZOutputStream(outMemoryStream))
                {
                    using (Stream inMemoryStream = new MemoryStream(inData))
                    {
                        CopyStream(inMemoryStream, outZStream);
                        outZStream.finish();
                        lReturnData = outMemoryStream.ToArray();
                    }
                }
            }
            return lReturnData;
        }

        public static void CopyStream(System.IO.Stream input, System.IO.Stream output)
        {
            byte[] buffer = new byte[2000];
            int len;
            while ((len = input.Read(buffer, 0, 2000)) > 0)
            {
                output.Write(buffer, 0, len);
            }
            output.Flush();
        }

        public static string zGetDataFromCom2UsString(string pEncryptedCipher, out bool pFailure)
        {
            pFailure = false;
            try
            {
                System.Security.Cryptography.AesManaged lAM = new System.Security.Cryptography.AesManaged()
                {
                    IV = Encoding.UTF8.GetBytes("\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00"),
                    Key = Encoding.UTF8.GetBytes("Gr4S2eiNl7zq5MrU")
                };

                System.Security.Cryptography.ICryptoTransform lDecryptor = lAM.CreateDecryptor();

                byte[] cipher = Convert.FromBase64String(pEncryptedCipher);
                byte[] text_bytes = lDecryptor.TransformFinalBlock(cipher, 0, cipher.Length);

                byte[] data = DecompressData(text_bytes);
                return Encoding.UTF8.GetString(data);
            }
            catch (Exception pEx)
            {
                pFailure = true;
                return pEx.Message;
            }
        }

        #endregion Entschlüsselung c2s

        #region Noch unbenutzt

        // GET: Main/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion Noch unbenutzt
    }
}