using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SummonersWarWeb.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/less.min.js",
                "~/Scripts/jquery-1.9.1.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery.dataTables.js"
                ));
            bundles.Add(new StyleBundle("~/Content").Include(
                "~/Content/Bootstrap/bootstrap.css"
                ));


            //        <link href= rel="stylesheet" />
            //<link href= rel="stylesheet" />

            //<link rel="stylesheet/less" type="text/css" href= />
        }
    }
}