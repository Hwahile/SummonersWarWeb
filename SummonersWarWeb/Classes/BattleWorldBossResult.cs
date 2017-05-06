using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonersWarWeb.Classes.BattleWorldBossResult
{

    // Hier scheint einiges unnötig zu sein . 
    public class BattleWorldBossResult
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("wizard_info")]
        public Player PlayerData { get; set; }

        [JsonProperty("worldboss_status")]
        public WorldbossStatus WorldbossStatus { get; set; }

        [JsonProperty("my_worldboss_ranking")]
        public WorldbossRanking WorldbossRanking { get; set; }

        [JsonProperty("my_worldboss_prev_ranking")]
        public WorldbossRanking WorldbossPreviousRanking { get; set; }

        [JsonProperty("my_worldboss_best_ranking")]
        public WorldbossRanking WorldbossBestRanking { get; set; }

        [JsonProperty("my_worldboss_daily_battle_count")]
        public int? WorldbossDailyBattleCount { get; set; }

        [JsonProperty("worldboss_used_unit")]
        public List<string> WorldbossUsedMonsters { get; set; }

        [JsonProperty("reward")]
        public Reward Rewards { get; set; }


        public List<ItemList> item_list { get; set; }

        [JsonProperty("tzone")]
        public string Timezone { get; set; }
    }

    public class UnitSlots
    {
        public int number { get; set; }
    }

    public class Upgrade
    {
        public int number { get; set; }
        public int mana { get; set; }
        public int crystal { get; set; }
    }

    public class UnitDepositorySlots
    {
        public int number { get; set; }
        public Upgrade upgrade { get; set; }
    }

    public class Player
    {
        [JsonProperty("wizard_id")]
        public string Id { get; set; }
        [JsonProperty("wizard_name")]
        public string Name { get; set; }
        [JsonProperty("wizard_level")]
        public int Level { get; set; }
        [JsonProperty("experience")]
        public int Experience { get; set; }
        [JsonProperty("wizard_mana")]
        public int Mana { get; set; }
        [JsonProperty("wizard_crystal")]
        public int Crystal { get; set; }
        [JsonProperty("wizard_energy")]
        public int Energy { get; set; }
        [JsonProperty("arena_energy")]
        public int Wings { get; set; }
        [JsonProperty("arena_energy_max")]
        public int WingsMax { get; set; }
        [JsonProperty("arena_energy_next_gain")]
        public int WingsNext { get; set; }
        [JsonProperty("wizard_last_login")]
        public string LastLogin { get; set; }
        [JsonProperty("unit_slots")]
        public UnitSlots MonsterSlots { get; set; }
        [JsonProperty("energy_max")]
        public int EnergyMax { get; set; }
        [JsonProperty("energy_per_min")]
        public double EnergyPerMin { get; set; }
        [JsonProperty("social_point_current")]
        public int Socialpoints { get; set; }
        [JsonProperty("social_point_max")]
        public int SocialpointsMax { get; set; }
        // wat
        public int honor_point { get; set; }
        [JsonProperty("guild_point")]
        public int Guildpoints { get; set; }
        [JsonProperty("rep_unit_id")]
        public string RepId { get; set; }
        [JsonProperty("rep_assigned")]
        public bool RepAssigned { get; set; }
        [JsonProperty("pvp_event")]
        public bool PvPEvent { get; set; }
        [JsonProperty("mail_box_event")]
        public bool MailBoxEvent { get; set; }
        [JsonProperty("next_energy_gain")]
        public int EnergyNext { get; set; }
        [JsonProperty("unit_depository_slots")]
        public UnitDepositorySlots StorageSlots { get; set; }
        [JsonProperty("darkportal_energy")]
        public int DimensionalRiftEnergy { get; set; }
        [JsonProperty("darkportal_energy_max")]
        public int DimensionalRiftEnergyMax { get; set; }
        [JsonProperty("costume_point")]
        public int TransmogrificationPoints { get; set; }
        [JsonProperty("costume_point_max")]
        public int TransmogrificationPointsMax { get; set; }
        //wat
        public int honor_medal { get; set; }
    }

    public class WorldbossStatus
    {
        public int worldboss_id { get; set; }
        public int region_id { get; set; }
        public int status { get; set; }
        public string open_time { get; set; }
        public int open_remained_time { get; set; }
        public string battle_start_time { get; set; }
        public string battle_end_time { get; set; }
        public int dead_remained_time { get; set; }
        public string close_time { get; set; }
        public int close_remained_time { get; set; }
        public int base_hp { get; set; }
        public double hp_rate { get; set; }
        public int daily_battle_init_remained_time { get; set; }
        public int refresh_term { get; set; }
    }

    public class WorldbossRanking
    {
        public int ranking { get; set; }
        public int accumulate_damage { get; set; }
        public int rating_id { get; set; }
        public int ranking_rate { get; set; }
        public int? is_reward { get; set; }
    }

    public class Item
    {
        [JsonProperty("item_master_id")]
        public int ItemId { get; set; }

        [JsonProperty("item_quantity")]
        public int Menge { get; set; }

        public string ItemName
        {
            get
            {
                switch (ItemId)
                {
                    case 11006: return "storage_magic_low";
                    case 12006: return "storage_magic_mid";
                    case 13006: return "storage_magic_high";
                    case 11001: return "storage_water_low";
                    case 12001: return "storage_water_mid";
                    case 13001: return "storage_water_high";
                    case 11002: return "storage_fire_low";
                    case 12002: return "storage_fire_mid";
                    case 13002: return "storage_fire_high";
                    case 11003: return "storage_wind_low";
                    case 12003: return "storage_wind_mid";
                    case 13003: return "storage_wind_high";
                    case 11004: return "storage_light_low";
                    case 12004: return "storage_light_mid";
                    case 13004: return "storage_light_high";
                    case 11005: return "storage_dark_low";
                    case 12005: return "storage_dark_mid";
                    case 13005: return "storage_dark_high";
                    default: return "Unknown";
                }
            }
        }
    }

    public class CrateItem
    {
        [JsonProperty("material")]
        public Item Essence { get; set; }
        [JsonProperty("random_scroll")]
        public Item UnknownScroll { get; set; }
    }

    public class Reward
    {
        [JsonProperty("crate")]
        public CrateItem CrateItems { get; set; }
    }

    public class ItemList
    {
        [JsonProperty("wizard_id")]
        public string PlayerId { get; set; }
        public int item_master_type { get; set; }
        public int item_master_id { get; set; }
        public int item_quantity { get; set; }
    }
}