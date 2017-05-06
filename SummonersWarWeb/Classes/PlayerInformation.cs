using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonersWarWeb.Classes.PlayerInformation
{
    public class PlayerInformation
    {
        public string tzone { get; set; }
        public WizardInfo wizard_info { get; set; }
        public int ts_val { get; set; }
        [JsonIgnore]
        public int ret_code { get; set; }
        [JsonIgnore]
        public int tvalue { get; set; }
        [JsonIgnore]
        public int tvaluelocal { get; set; }
        [JsonProperty("command")]
        public string Befehl { get; set; }
    }
    public class Upgrade
        {
            public int mana { get; set; }
            public int number { get; set; }
            public int crystal { get; set; }
        }

        public class UnitDepositorySlots
        {
            public Upgrade upgrade { get; set; }
            public int number { get; set; }
        }

        public class UnitSlots
        {
            public int number { get; set; }
        }

        public class WizardInfo
        {
            public int arena_energy_next_gain { get; set; }
            public int wizard_level { get; set; }
            public int darkportal_energy { get; set; }
            public UnitDepositorySlots unit_depository_slots { get; set; }
            public double energy_per_min { get; set; }
            public int costume_point { get; set; }
            public int social_point_max { get; set; }
            public int next_energy_gain { get; set; }
            public UnitSlots unit_slots { get; set; }
            public int wizard_energy { get; set; }
            public string wizard_last_login { get; set; }
            public int mail_box_event { get; set; }
            public int arena_energy { get; set; }
            public int social_point_current { get; set; }
            public int arena_energy_max { get; set; }
            public int wizard_id { get; set; }
            public int honor_point { get; set; }
            public string wizard_name { get; set; }
            public int darkportal_energy_max { get; set; }
            public int rep_assigned { get; set; }
            public int rep_unit_id { get; set; }
            public int wizard_mana { get; set; }
            public int pvp_event { get; set; }
            public int energy_max { get; set; }
            public int experience { get; set; }
            public int honor_medal { get; set; }
            public int wizard_crystal { get; set; }
            public int guild_point { get; set; }
            public int costume_point_max { get; set; }
        }
        
        
}