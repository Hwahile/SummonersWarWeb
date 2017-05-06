using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// ToDo: UNIT_IDS IMMER ALS STRING, KANN DAS DER DESERIjsiodjaolizer? Evtl wizard ids auch, channel uids auch
// _extraFelder in jede klasse einbauen
namespace SummonersWarWeb.Classes.MainData
{



    /// <summary>
    ///  Die Hauptklasse
    /// </summary>
    public class MainData
    {

        
        [JsonProperty("wizard_id")]
        public string PlayerId { get; set; }
        [JsonProperty("tvaluelocal")]
        public string TimestampLocal { get; set; }
        [JsonProperty("country")]
        public string CountryCode { get; set; }
        [JsonProperty("guildwar_my_dead_unit_id_list")]
        public List<string> GuildwarDeadMonsters { get; set; }
        [JsonProperty("unit_lock_list")]
        public List<string> SavedMonsters { get; set; }
        [JsonProperty("my_worldboss_daily_battle_count")]
        public int WorldbossBattleCount { get; set; }
        [JsonProperty("island_info")]
        public List<IslandInfo> IslandInfos { get; set; }

        [JsonProperty("unit_list")]
        public List<Monster> MonsterListe { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }
        // erstmal nicht beachten
        //public string tzone { get; set; }
        //public WizardInfo wizard_info { get; set; }

        // erstmal nicht benutzen
        //public int helper_remained { get; set; }
        //public List<int> event_id_list { get; set; }
        //public List<int> quest_rewarded { get; set; }
        //public long ts_val { get; set; }
        //public long tvalue { get; set; }
        //public int push_noti_status { get; set; }
        //public string session_key { get; set; }
        //public int ret_code { get; set; }
        //public int kakao_invite { get; set; }
        //public List<object> notice_list { get; set; }
        //public string command { get; set; }
        //public int daily_reward_inactive_status { get; set; }
        //public int daily_reward_special_status { get; set; }
        //public List<long> worldboss_used_unit { get; set; }
        //public List<object> mentor_helper_list { get; set; }
        //public List<object> mentor_slot_list { get; set; }
        //public List<object> shop_daily_bonus_list { get; set; }
        //public List<object> homunculus_skill_list { get; set; }
        //public List<object> rune_lock_list { get; set; }
        //public List<object> costume_ticket_purchased_list { get; set; }
        //public ArenaShutdownInfo arena_shutdown_info { get; set; }
        //public DailyRewardInfo daily_reward_info { get; set; }
        //public DailyRewardList daily_reward_list { get; set; }
        //public DailyRewardUnitUpgradeInfo daily_reward_unit_upgrade_info { get; set; }
        //public FriendDelInterval friend_del_interval { get; set; }
        //public OppParticipationInfo opp_participation_info { get; set; }
        //public PvpInfo pvp_info { get; set; }
        //public RaidDeck raid_deck { get; set; }
        //public ShopInfo shop_info { get; set; }
        //public SummonSpecialInfo summon_special_info { get; set; }
        //public TransItemList trans_item_list { get; set; }
        //public WishList wish_list { get; set; }
        //public Guild guild { get; set; }
        //public GuildwarMatchInfo guildwar_match_info { get; set; }
        //public GuildwarParticipationInfo guildwar_participation_info { get; set; }
        //public GuildwarRankingInfo guildwar_ranking_info { get; set; }
        //public GuildwarRankingStat guildwar_ranking_stat { get; set; }
        //public GuildwarReserve guildwar_reserve { get; set; }
        //public GuildwarStatus guildwar_status { get; set; }
        //public WorldbossRanking my_worldboss_best_ranking { get; set; }
        //public WorldbossRanking my_worldboss_ranking { get; set; }
        //public WorldbossRanking my_worldboss_prev_ranking { get; set; }
        //public WorldbossStatus worldboss_status { get; set; }
        //public MentoringInfo mentoring_info { get; set; }
        //public InviteRewardIfo invite_reward_ifo { get; set; }
        //public InviteBuddy invite_buddy { get; set; }
        //public InviteAccount invite_account { get; set; }
        //public List<List<int>> guildwar_defense_unit_list { get; set; }
        //public List<BuildingList> building_list { get; set; }
        //public List<DecoList> deco_list { get; set; }
        //public List<DefenseUnitList> defense_unit_list { get; set; }
        //public List<Friend> friend_list { get; set; }
        //public List<GuildwarRewardList> guildwar_reward_list { get; set; }
        //public List<GuildMemberDefenseList> guild_member_defense_list { get; set; }
        //public List<GuildwarMember> guildwar_member_list { get; set; }
        //public List<Helper> helper_list { get; set; }
        //public List<InventoryInfo> inventory_info { get; set; }
        //public List<InviteCounterList> invite_counter_list { get; set; }
        //public List<MyAttackList> my_attack_list { get; set; }
        //public List<MenteeSlotList> mentee_slot_list { get; set; }
        //public List<MobRandomGiftList> mob_random_gift_list { get; set; }
        //public List<MobCostumeEquipList> mob_costume_equip_list { get; set; }
        //public List<MobCostumePartList> mob_costume_part_list { get; set; }
        //public List<MobList> mob_list { get; set; }
        //public List<MyAtkdefList> my_atkdef_list { get; set; }
        //public List<OppGuildMemberList> opp_guild_member_list { get; set; }
        //public List<ObstacleList> obstacle_list { get; set; }
        //public List<OppDefenseList> opp_defense_list { get; set; }
        //public List<PeriodItemList> period_item_list { get; set; }
        //public List<PvpRewardList> pvp_reward_list { get; set; }
        //public List<QuestActive> quest_active { get; set; }
        //public List<RuneCraftItemList> rune_craft_item_list { get; set; }
        //public List<RaidInfo> raid_info_list { get; set; }

        //public List<ScenarioList> scenario_list { get; set; }
        //public List<ShopBonusEvent> shop_bonus_event { get; set; }

        ///// <summary>
        ///// Unbekannte Felder, praktisch, 
        ///// um auf neue Felder seitens com2us zu reagieren ohne auf eine Fehlermeldung zu stoßen
        ///// </summary>
        //[JsonExtensionData]
        //private IDictionary<string, JToken> _extraFelder { get; set; }

    }
    public class IslandInfo
    {
        public bool open { get; set; }
        public int id { get; set; }
    }

    public class Monster
    {
        private static Dictionary<long, string> MonsterNames = new Dictionary<long, string>
        {
            // FEUER SILVER
            { 12202, "Slime" },
            { 12302, "Forest Keeper" },
            { 12402, "Mushroom" },
            { 12702, "Ghost" },
            { 12902, "Mimick" },
            { 13002, "Horned Frog" },
            { 13102, "Sandman" },
            { 12502, "Maned Boar" },
            { 12602, "Monster Flower" },
            { 13602, "Surprise Box" },
            { 16402, "Skull Soldier" },
            { 17502, "Mischievous Bat" },
            { 17602, "Battle Scorpion" },
            // FEUER UNERWECKT
            { 12802, "Low Elemental" },
            { 14202, "Angelmon" },
            { 18202, "King Angelmon" },
            { 10202, "Imp" },
            { 10302, "Pixie" },
            { 10402, "Yeti" },
            { 10602, "Hellhound" },
            { 10702, "Warbear" },
            { 10802, "Elemental" },
            { 10902, "Garuda" },
            { 12102, "Harpu" },
            { 13202, "Howl" },
            { 10102, "Fairy" },
            { 10502, "Harpy" },
            { 11002, "Inugami" },
            { 11102, "Salamander" },
            { 11302, "Serpent" },
            { 11402, "Golem" },
            { 11502, "Griffon" },
            { 11702, "Inferno" },
            { 12002, "High Elemental" },
            { 13702, "Bearman" },
            { 14002, "Werewolf" },
            { 14802, "Viking" },
            { 14902, "Amazon" },
            { 15002, "Martial Cat" },
            { 15202, "Vagabond" },
            { 15402, "Magical Archer" },
            { 15602, "Bounty Hunter" },
            { 15802, "Imp Champion" },
            { 15902, "Mystic Witch" },
            { 16002, "Grim Reaper" },
            { 16502, "Living Armor" },
            { 17202, "Drunken Master" },
            { 17702, "Minotauros" },
            { 17802, "Lizardman" },
            { 18402, "Taoist" },
            { 18502, "Beast Hunter" },
            { 18702, "Penguin Knight" },
            { 19002, "Battle Mammoth" },
            { 19302, "Cow Girl" },
            { 19502, "Charger Shark" },
            { 20202, "Martial Artist" },
            { 20302, "Mummy" },
            { 20802, "Frankenstein" },
            { 20902, "Elven Ranger" },
            { 21002, "Harg" },
            { 11202, "Nine-tailed Fox" },
            { 11602, "Undine" },
            { 11802, "Sylph" },
            { 11902, "Sylphid" },
            { 13302, "Succubus" },
            { 13402, "Joker" },
            { 13502, "Ninja" },
            { 13902, "Pierret" },
            { 14102, "Phantom Thief" },
            { 14702, "Vampire" },
            { 15302, "Epikion Priest" },
            { 15502, "Rakshasa" },
            { 16202, "Death Knight" },
            { 16302, "Lich" },
            { 16902, "Samurai" },
            { 17302, "Kung Fu Girl" },
            { 18002, "Brownie Magician" },
            { 18102, "Kobold Bomber" },
            { 18302, "Sky Dancer" },
            { 18802, "Barbaric King" },
            { 19402, "Pirate Captain" },
            { 19602, "Mermaid" },
            { 19802, "Magic Knight" },
            { 19902, "Assassin" },
            { 20002, "Neostone Fighter" },
            { 20102, "Neostone Agent" },
            { 20402, "Anubis" },
            { 20602, "Horus" },
            { 20702, "Jack-o'-lantern" },
            { 21302, "Dice Magician" },
            { 21402, "Harp Magician" },
            { 13802, "Valkyrja" },
            { 14402, "Dragon" },
            { 14502, "Phoenix" },
            { 14602, "Chimera" },
            { 15702, "Oracle" },
            { 16102, "Occult Girl" },
            { 16602, "Dragon Knight" },
            { 16802, "Monkey King" },
            { 17002, "Archangel" },
            { 17402, "Beast Monk" },
            { 17902, "Hell Lady" },
            { 18602, "Pioneer" },
            { 18902, "Polar Queen" },
            { 19202, "Ifrit" },
            { 19702, "Sea Emperor" },
            { 20502, "Desert Queen" },
            { 21102, "Fairy King" },
            { 21202, "Panda Warrior" },
            { 21502, "Unicorn" },
            { 1000112, "Homunculus (Attack)" },
            // FEUER ERWECKT
            { 14212, "Red Angelmon" },
            { 18212, "Red King Angelmon" },
            { 12812, "Lamor" },
            { 10212, "Cogma" },
            { 10312, "Tatu" },
            { 10412, "Tantra" },
            { 10612, "Sieq" },
            { 10712, "Ursha" },
            { 10812, "Bremis" },
            { 10912, "Cahule" },
            { 12112, "Colleen" },
            { 13212, "Lala" },
            { 10112, "Iselia" },
            { 10512, "Lucasha" },
            { 11012, "Raoq" },
            { 11112, "Krakdon" },
            { 11312, "Fao" },
            { 11412, "Kugo" },
            { 11512, "Spectra" },
            { 11712, "Tagaros" },
            { 12012, "Kahli" },
            { 13712, "Kungen" },
            { 14012, "Garoche" },
            { 14812, "Geoffrey" },
            { 14912, "Ceres" },
            { 15012, "Mei" },
            { 15212, "Kai'en" },
            { 15412, "Cassandra" },
            { 15612, "Randy" },
            { 15812, "Fairo" },
            { 15912, "Rebecca" },
            { 16012, "Sath" },
            { 16512, "Iron" },
            { 17212, "Xiao Chun" },
            { 17712, "Burentau" },
            { 17812, "Igmanodon" },
            { 18412, "Gunpyeong" },
            { 18512, "Nangrim" },
            { 18712, "Naki" },
            { 19012, "Granite" },
            { 19312, "Anne" },
            { 19512, "Ignicus" },
            { 20212, "Sin" },
            { 20312, "Sonora" },
            { 20812, "Bulldozer" },
            { 20912, "Adrian" },
            { 21012, "Racuni" },
            { 11212, "Shihwa" },
            { 11612, "Atenai" },
            { 11812, "Baretta" },
            { 11912, "Fria" },
            { 13312, "Akia" },
            { 13412, "Jojo" },
            { 13512, "Garo" },
            { 13912, "Clara" },
            { 14112, "Jean" },
            { 14712, "Verdehile" },
            { 15312, "Chloe" },
            { 15512, "Hwa" },
            { 16212, "Arnold" },
            { 16312, "Antares" },
            { 16912, "Jun" },
            { 17312, "Hong Hua" },
            { 18012, "Draco" },
            { 18112, "Zibrolta" },
            { 18312, "Hwahee" },
            { 18812, "Surtr" },
            { 19412, "Carrack" },
            { 19612, "Platy" },
            { 19812, "Astar" },
            { 19912, "Lexy" },
            { 20012, "Trevor" },
            { 20112, "Lisa" },
            { 20412, "Khmun" },
            { 20612, "Duamutef" },
            { 20712, "Smokey" },
            { 21312, "Ludo" },
            { 21412, "Harmonia" },
            { 13812, "Vanessa" },
            { 14412, "Zaiross" },
            { 14512, "Perna" },
            { 14612, "Rakan" },
            { 15712, "Juno" },
            { 16112, "Rica" },
            { 16612, "Laika" },
            { 16812, "Mei Hou Wang" },
            { 17012, "Velajuel" },
            { 17412, "Kumar" },
            { 17912, "Raki" },
            { 18612, "Chiwu" },
            { 18912, "Brandia" },
            { 19212, "Tesarion" },
            { 19712, "Okeanos" },
            { 20512, "Sekhmet" },
            { 21112, "Daphnis" },
            { 21212, "Xiong Fei" },
            { 21512, "Helena" },
            { 21612, "Helena (Human)" },

            // WASSER SILVER
            { 12201, "Slime" },
            { 12301, "Forest Keeper" },
            { 12401, "Mushroom" },
            { 12701, "Ghost" },
            { 12901, "Mimick" },
            { 13001, "Horned Frog" },
            { 13101, "Sandman" },
            { 12501, "Maned Boar" },
            { 12601, "Monster Flower" },
            { 13601, "Surprise Box" },
            { 16401, "Skull Soldier" },
            { 17501, "Mischievous Bat" },
            { 17601, "Battle Scorpion" },

            // WASSER UNERWECKT
            { 12801, "Low Elemental" },
            { 14201, "Angelmon" },
            { 18201, "King Angelmon" },
            { 10201, "Imp" },
            { 10301, "Pixie" },
            { 10401, "Yeti" },
            { 10601, "Hellhound" },
            { 10801, "Elemental" },
            { 10901, "Garuda" },
            { 11101, "Salamander" },
            { 12101, "Harpu" },
            { 13201, "Howl" },
            { 14801, "Viking" },
            { 15201, "Vagabond" },
            { 10101, "Fairy" },
            { 10501, "Harpy" },
            { 10701, "Warbear" },
            { 11001, "Inugami" },
            { 11301, "Serpent" },
            { 11401, "Golem" },
            { 11501, "Griffon" },
            { 11701, "Inferno" },
            { 12001, "High Elemental" },
            { 13701, "Bearman" },
            { 14001, "Werewolf" },
            { 14901, "Amazon" },
            { 15001, "Martial Cat" },
            { 15301, "Epikion Priest" },
            { 15401, "Magical Archer" },
            { 15601, "Bounty Hunter" },
            { 15801, "Imp Champion" },
            { 15901, "Mystic Witch" },
            { 16001, "Grim Reaper" },
            { 16501, "Living Armor" },
            { 17201, "Drunken Master" },
            { 17701, "Minotauros" },
            { 17801, "Lizardman" },
            { 18501, "Beast Hunter" },
            { 18701, "Penguin Knight" },
            { 19001, "Battle Mammoth" },
            { 19301, "Cow Girl" },
            { 19501, "Charger Shark" },
            { 20201, "Martial Artist" },
            { 20301, "Mummy" },
            { 20801, "Frankenstein" },
            { 20901, "Elven Ranger" },
            { 21001, "Harg" },
            { 11201, "Nine-tailed Fox" },
            { 11601, "Undine" },
            { 11801, "Sylph" },
            { 11901, "Sylphid" },
            { 13301, "Succubus" },
            { 13401, "Joker" },
            { 13501, "Ninja" },
            { 13901, "Pierret" },
            { 14101, "Phantom Thief" },
            { 14701, "Vampire" },
            { 15501, "Rakshasa" },
            { 16201, "Death Knight" },
            { 16301, "Lich" },
            { 16901, "Samurai" },
            { 17301, "Kung Fu Girl" },
            { 18001, "Brownie Magician" },
            { 18101, "Kobold Bomber" },
            { 18301, "Sky Dancer" },
            { 18401, "Taoist" },
            { 18801, "Barbaric King" },
            { 19401, "Pirate Captain" },
            { 19601, "Mermaid" },
            { 19801, "Magic Knight" },
            { 19901, "Assassin" },
            { 20001, "Neostone Fighter" },
            { 20101, "Neostone Agent" },
            { 20401, "Anubis" },
            { 20601, "Horus" },
            { 20701, "Jack-o'-lantern" },
            { 21301, "Dice Magician" },
            { 21401, "Harp Magician" },
            { 13801, "Valkyrja" },
            { 14401, "Dragon" },
            { 14501, "Phoenix" },
            { 14601, "Chimera" },
            { 15701, "Oracle" },
            { 16101, "Occult Girl" },
            { 16601, "Dragon Knight" },
            { 16801, "Monkey King" },
            { 17001, "Archangel" },
            { 17401, "Beast Monk" },
            { 17901, "Hell Lady" },
            { 18601, "Pioneer" },
            { 18901, "Polar Queen" },
            { 19201, "Ifrit" },
            { 19701, "Sea Emperor" },
            { 20501, "Desert Queen" },
            { 21101, "Fairy King" },
            { 21201, "Panda Warrior" },
            { 21501, "Unicorn" },
            { 1000111, "Homunculus (Attack)" },
            
            // WASSER ERWECKT
            { 14211, "Blue Angelmon" },
            { 18211, "Blue King Angelmon" },
            { 12811, "Tigresse" },
            { 10211, "Fynn" },
            { 10311, "Kacey" },
            { 10411, "Kunda" },
            { 10611, "Tarq" },
            { 10811, "Daharenos" },
            { 10911, "Konamiya" },
            { 11111, "Kaimann" },
            { 12111, "Sisroo" },
            { 13211, "Lulu" },
            { 14811, "Huga" },
            { 15211, "Allen" },
            { 10111, "Elucia" },
            { 10511, "Ramira" },
            { 10711, "Dagora" },
            { 11011, "Icaru" },
            { 11311, "Shailoq" },
            { 11411, "Kuhn" },
            { 11511, "Kahn" },
            { 11711, "Purian" },
            { 12011, "Ellena" },
            { 13711, "Gruda" },
            { 14011, "Vigor" },
            { 14911, "Ellin" },
            { 15011, "Mina" },
            { 15311, "Rina" },
            { 15411, "Sharron" },
            { 15611, "Wayne" },
            { 15811, "Yaku" },
            { 15911, "Megan" },
            { 16011, "Hemos" },
            { 16511, "Nickel" },
            { 17211, "Mao" },
            { 17711, "Urtau" },
            { 17811, "Kernodon" },
            { 18511, "Gangchun" },
            { 18711, "Toma" },
            { 19011, "Talc" },
            { 19311, "Sera" },
            { 19511, "Aqcus" },
            { 20211, "Luan" },
            { 20311, "Nubia" },
            { 20811, "Tractor" },
            { 20911, "Eluin" },
            { 21011, "Remy" },
            { 11211, "Soha" },
            { 11611, "Mikene" },
            { 11811, "Tyron" },
            { 11911, "Lumirecia" },
            { 13311, "Izaria" },
            { 13411, "Sian" },
            { 13511, "Susano" },
            { 13911, "Julie" },
            { 14111, "Luer" },
            { 14711, "Liesel" },
            { 15511, "Su" },
            { 16211, "Fedora" },
            { 16311, "Rigel" },
            { 16911, "Kaz" },
            { 17311, "Xiao Lin" },
            { 18011, "Orion" },
            { 18111, "Malaka" },
            { 18311, "Mihyang" },
            { 18411, "Gildong" },
            { 18811, "Aegir" },
            { 19411, "Galleon" },
            { 19611, "Tetra" },
            { 19811, "Lapis" },
            { 19911, "Stella" },
            { 20011, "Ryan" },
            { 20111, "Emma" },
            { 20411, "Avaris" },
            { 20611, "Qebehsenuef" },
            { 20711, "Chilling" },
            { 21311, "Reno" },
            { 21411, "Sonnet" },
            { 13811, "Camilla" },
            { 14411, "Verad" },
            { 14511, "Sigmarus" },
            { 14611, "Taor" },
            { 15711, "Praha" },
            { 16111, "Anavel" },
            { 16611, "Chow" },
            { 16811, "Shi Hou" },
            { 17011, "Ariel" },
            { 17411, "Chandra" },
            { 17911, "Beth" },
            { 18611, "Woosa" },
            { 18911, "Alicia" },
            { 19211, "Theomars" },
            { 19711, "Poseidon" },
            { 20511, "Bastet" },
            { 21111, "Psamathe" },
            { 21211, "Mo Long" },
            { 21511, "Amelia" },
            { 21611, "Amelia (Human)" },
            
            // WIND SILVER
            { 12203, "Slime" },
            { 12303, "Forest Keeper" },
            { 12403, "Mushroom" },
            { 12703, "Ghost" },
            { 12903, "Mimick" },
            { 13003, "Horned Frog" },
            { 13103, "Sandman" },
            { 12503, "Maned Boar" },
            { 12603, "Monster Flower" },
            { 13603, "Surprise Box" },
            { 16403, "Skull Soldier" },
            { 17503, "Mischievous Bat" },
            { 17603, "Battle Scorpion" },
            
            // WIND UNERWECKT
            { 12803, "Low Elemental" },
            { 14203, "Angelmon" },
            { 18203, "King Angelmon" },
            { 10103, "Fairy" },
            { 10203, "Imp" },
            { 10303, "Pixie" },
            { 10403, "Yeti" },
            { 10603, "Hellhound" },
            { 10703, "Warbear" },
            { 10803, "Elemental" },
            { 10903, "Garuda" },
            { 11103, "Salamander" },
            { 12103, "Harpu" },
            { 13203, "Howl" },
            { 14803, "Viking" },
            { 15203, "Vagabond" },
            { 10503, "Harpy" },
            { 11003, "Inugami" },
            { 11303, "Serpent" },
            { 11403, "Golem" },
            { 11503, "Griffon" },
            { 11703, "Inferno" },
            { 12003, "High Elemental" },
            { 13703, "Bearman" },
            { 14003, "Werewolf" },
            { 14903, "Amazon" },
            { 15003, "Martial Cat" },
            { 15303, "Epikion Priest" },
            { 15403, "Magical Archer" },
            { 15603, "Bounty Hunter" },
            { 15803, "Imp Champion" },
            { 15903, "Mystic Witch" },
            { 16003, "Grim Reaper" },
            { 16503, "Living Armor" },
            { 17203, "Drunken Master" },
            { 17703, "Minotauros" },
            { 17803, "Lizardman" },
            { 18503, "Beast Hunter" },
            { 18703, "Penguin Knight" },
            { 19003, "Battle Mammoth" },
            { 19303, "Cow Girl" },
            { 19503, "Charger Shark" },
            { 20203, "Martial Artist" },
            { 20303, "Mummy" },
            { 20803, "Frankenstein" },
            { 20903, "Elven Ranger" },
            { 11203, "Nine-tailed Fox" },
            { 11603, "Undine" },
            { 11803, "Sylph" },
            { 11903, "Sylphid" },
            { 13303, "Succubus" },
            { 13403, "Joker" },
            { 13503, "Ninja" },
            { 13903, "Pierret" },
            { 14103, "Phantom Thief" },
            { 14703, "Vampire" },
            { 15503, "Rakshasa" },
            { 16203, "Death Knight" },
            { 16303, "Lich" },
            { 16903, "Samurai" },
            { 17303, "Kung Fu Girl" },
            { 18003, "Brownie Magician" },
            { 18103, "Kobold Bomber" },
            { 18303, "Sky Dancer" },
            { 18403, "Taoist" },
            { 18803, "Barbaric King" },
            { 19403, "Pirate Captain" },
            { 19603, "Mermaid" },
            { 19803, "Magic Knight" },
            { 19903, "Assassin" },
            { 20003, "Neostone Fighter" },
            { 20103, "Neostone Agent" },
            { 20403, "Anubis" },
            { 20603, "Horus" },
            { 20703, "Jack-o'-lantern" },
            { 21003, "Harg" },
            { 21303, "Dice Magician" },
            { 21403, "Harp Magician" },
            { 13803, "Valkyrja" },
            { 14403, "Dragon" },
            { 14503, "Phoenix" },
            { 14603, "Chimera" },
            { 15703, "Oracle" },
            { 16103, "Occult Girl" },
            { 16603, "Dragon Knight" },
            { 16803, "Monkey King" },
            { 17003, "Archangel" },
            { 17403, "Beast Monk" },
            { 17903, "Hell Lady" },
            { 18603, "Pioneer" },
            { 18903, "Polar Queen" },
            { 19203, "Ifrit" },
            { 19703, "Sea Emperor" },
            { 20503, "Desert Queen" },
            { 21103, "Fairy King" },
            { 21203, "Panda Warrior" },
            { 21503, "Unicorn" },
            { 1000113, "Homunculus (Attack)" },
            
            // WIND ERWECKT
            { 14213, "Gold Angelmon" },
            { 18213, "Gold King Angelmon" },
            { 12813, "Samour" },
            { 10113, "Aeilene" },
            { 10213, "Ralph" },
            { 10313, "Shannon" },
            { 10413, "Rakaja" },
            { 10613, "Gamir" },
            { 10713, "Ramagos" },
            { 10813, "Taharus" },
            { 10913, "Lindermen" },
            { 11113, "Lukan" },
            { 12113, "Seal" },
            { 13213, "Chichi" },
            { 14813, "Walter" },
            { 15213, "Roid" },
            { 10513, "Prilea" },
            { 11013, "Ramahan" },
            { 11313, "Ermeda" },
            { 11413, "Ragion" },
            { 11513, "Bernard" },
            { 11713, "Anduril" },
            { 12013, "Moria" },
            { 13713, "Dagorr" },
            { 14013, "Shakan" },
            { 14913, "Hina" },
            { 15013, "Naomi" },
            { 15313, "Michelle" },
            { 15413, "Ardella" },
            { 15613, "Roger" },
            { 15813, "Pigma" },
            { 15913, "Silia" },
            { 16013, "Hiva" },
            { 16513, "Copper" },
            { 17213, "Huan" },
            { 17713, "Eintau" },
            { 17813, "Velfinodon" },
            { 18513, "Suri" },
            { 18713, "Mav" },
            { 19013, "Olivine" },
            { 19313, "Hannah" },
            { 19513, "Zephicus" },
            { 20213, "Lo" },
            { 20313, "Namib" },
            { 20813, "Crane" },
            { 20913, "Erwin" },
            { 11213, "Arang" },
            { 11613, "Delphoi" },
            { 11813, "Shimitae" },
            { 11913, "Acasis" },
            { 13313, "Selena" },
            { 13413, "Lushen" },
            { 13513, "Orochi" },
            { 13913, "Sophia" },
            { 14113, "Julien" },
            { 14713, "Argen" },
            { 15513, "Yen" },
            { 16213, "Briand" },
            { 16313, "Fuco" },
            { 16913, "Kaito" },
            { 17313, "Ling Ling" },
            { 18013, "Aquila" },
            { 18113, "Taurus" },
            { 18313, "Chasun" },
            { 18413, "Woochi" },
            { 18813, "Hraesvelg" },
            { 19413, "Barque" },
            { 19613, "Cichlid" },
            { 19813, "Lupinus" },
            { 19913, "Tanya" },
            { 20013, "Logan" },
            { 20113, "Olivia" },
            { 20413, "Iunu" },
            { 20613, "Imesety" },
            { 20713, "Windy" },
            { 21013, "Raviti" },
            { 21313, "Morris" },
            { 21413, "Triana" },
            { 13813, "Katarina" },
            { 14413, "Jamire" },
            { 14513, "Teshar" },
            { 14613, "Lagmaron" },
            { 15713, "Seara" },
            { 16113, "Charlotte" },
            { 16613, "Leo" },
            { 16813, "Xing Zhe" },
            { 17013, "Eladriel" },
            { 17413, "Ritesh" },
            { 17913, "Ethna" },
            { 18613, "Pungbaek" },
            { 18913, "Tiana" },
            { 19213, "Akhamamir" },
            { 19713, "Triton" },
            { 20513, "Hathor" },
            { 21113, "Ganymede" },
            { 21213, "Feng Yan" },
            { 21513, "Diana" },
            { 21613, "Diana (Human)" },
            
            // Licht silver
            { 13604, "Surprise Box" },
            
            // Licht unerweckt
            { 14204, "Angelmon" },
            { 18204, "King Angelmon" },
            { 12804, "Low Elemental" },
            { 10204, "Imp" },
            { 10304, "Pixie" },
            { 10404, "Yeti" },
            { 10604, "Hellhound" },
            { 11104, "Salamander" },
            { 13204, "Howl" },
            { 14804, "Viking" },
            { 10104, "Fairy" },
            { 10504, "Harpy" },
            { 10704, "Warbear" },
            { 10804, "Elemental" },
            { 10904, "Garuda" },
            { 11004, "Inugami" },
            { 11304, "Serpent" },
            { 11404, "Golem" },
            { 11504, "Griffon" },
            { 11704, "Inferno" },
            { 12004, "High Elemental" },
            { 12104, "Harpu" },
            { 13704, "Bearman" },
            { 14004, "Werewolf" },
            { 14904, "Amazon" },
            { 15004, "Martial Cat" },
            { 15204, "Vagabond" },
            { 15604, "Bounty Hunter" },
            { 15804, "Imp Champion" },
            { 15904, "Mystic Witch" },
            { 16004, "Grim Reaper" },
            { 16504, "Living Armor" },
            { 16704, "Magical Archer (Fami)" },
            { 17204, "Drunken Master" },
            { 17704, "Minotauros" },
            { 17804, "Lizardman" },
            { 18504, "Beast Hunter" },
            { 18704, "Penguin Knight" },
            { 19004, "Battle Mammoth" },
            { 19104, "Fairy Queen (Fran)" },
            { 19504, "Charger Shark" },
            { 20204, "Martial Artist" },
            { 20304, "Mummy" },
            { 20804, "Frankenstein" },
            { 20904, "Elven Ranger" },
            { 11204, "Nine-tailed Fox" },
            { 11604, "Undine" },
            { 11804, "Sylph" },
            { 11904, "Sylphid" },
            { 13304, "Succubus" },
            { 13404, "Joker" },
            { 13504, "Ninja" },
            { 13904, "Pierret" },
            { 14104, "Phantom Thief" },
            { 15304, "Epikion Priest" },
            { 15404, "Magical Archer" },
            { 15504, "Rakshasa" },
            { 16204, "Death Knight" },
            { 16304, "Lich" },
            { 16904, "Samurai" },
            { 17304, "Kung Fu Girl" },
            { 18004, "Brownie Magician" },
            { 18104, "Kobold Bomber" },
            { 18404, "Taoist" },
            { 18804, "Barbaric King" },
            { 19404, "Pirate Captain" },
            { 19604, "Mermaid" },
            { 19804, "Magic Knight" },
            { 19904, "Assassin" },
            { 20004, "Neostone Fighter" },
            { 20104, "Neostone Agent" },
            { 20404, "Anubis" },
            { 20704, "Jack-o'-lantern" },
            { 21004, "Harg" },
            { 21304, "Dice Magician" },
            { 13804, "Valkyrja" },
            { 14404, "Dragon" },
            { 14504, "Phoenix" },
            { 14604, "Chimera" },
            { 14704, "Vampire" },
            { 15704, "Oracle" },
            { 16104, "Occult Girl" },
            { 16604, "Dragon Knight" },
            { 16804, "Monkey King" },
            { 17004, "Archangel" },
            { 17404, "Beast Monk" },
            { 17904, "Hell Lady" },
            { 18304, "Sky Dancer" },
            { 18604, "Pioneer" },
            { 18904, "Polar Queen" },
            { 19704, "Sea Emperor" },
            { 20504, "Desert Queen" },
            { 19204, "Ifrit" },
            { 20604, "Horus" },
            { 21104, "Fairy King" },
            { 21204, "Panda Warrior" },
            { 21404, "Harp Magician" },
            { 21504, "Unicorn" },
            
            // Licht erweckt
            { 14214, "White Angelmon" },
            { 14314, "Rainbowmon" },
            { 18214, "White King Angelmon" },
            { 12814, "Varis" },
            { 10214, "Taru" },
            { 10314, "Cheryl" },
            { 10414, "Arkajan" },
            { 10614, "Shamar" },
            { 11114, "Sharman" },
            { 13214, "Shushu" },
            { 14814, "Jansson" },
            { 10114, "Neal" },
            { 10514, "Kabilla" },
            { 10714, "Lusha" },
            { 10814, "Priz" },
            { 10914, "Teon" },
            { 11014, "Belladeon" },
            { 11314, "Elpuria" },
            { 11414, "Groggo" },
            { 11514, "Shamann" },
            { 11714, "Eludain" },
            { 12014, "Shren" },
            { 12114, "Sia" },
            { 13714, "Ahman" },
            { 14014, "Eshir" },
            { 14914, "Lyn" },
            { 15014, "Xiao Ling" },
            { 15214, "Darion" },
            { 15614, "Walkers" },
            { 15814, "Shaffron" },
            { 15914, "Linda" },
            { 16014, "Prom" },
            { 16514, "Silver" },
            { 16714, "Fami" },
            { 17214, "Tien Qin" },
            { 17714, "Grotau" },
            { 17814, "Glinodon" },
            { 18514, "Baekdu" },
            { 18714, "Dona" },
            { 19014, "Marble" },
            { 19114, "Fran" },
            { 19514, "Rumicus" },
            { 20214, "Hiro" },
            { 20314, "Sahara" },
            { 20814, "Driller" },
            { 20914, "Lucien" },
            { 11214, "Chamie" },
            { 11614, "Icasha" },
            { 11814, "Eredas" },
            { 11914, "Mihael" },
            { 13314, "Aria" },
            { 13414, "Figaro" },
            { 13514, "Gin" },
            { 13914, "Eva" },
            { 14114, "Louis" },
            { 15314, "Iona" },
            { 15414, "Chris" },
            { 15514, "Pang" },
            { 16214, "Conrad" },
            { 16314, "Halphas" },
            { 16914, "Tosi" },
            { 17314, "Liu Mei" },
            { 18014, "Gemini" },
            { 18114, "Dover" },
            { 18414, "Hwadam" },
            { 18814, "Mimirr" },
            { 19414, "Brig" },
            { 19614, "Molly" },
            { 20514, "Isis" },
            { 19914, "Natalie" },
            { 20014, "Lucas" },
            { 20114, "Illianna" },
            { 20414, "Amarna" },
            { 20714, "Misty" },
            { 21014, "Dova" },
            { 21314, "Tablo" },
            { 13814, "Akroma" },
            { 14414, "Zerath" },
            { 14514, "Eludia" },
            { 14614, "Shan" },
            { 14714, "Julianne" },
            { 15714, "Laima" },
            { 16114, "Lora" },
            { 16614, "Jager" },
            { 16814, "Qitian Dasheng" },
            { 17014, "Artamiel" },
            { 17414, "Shazam" },
            { 17914, "Asima" },
            { 18314, "Yeonhong" },
            { 18614, "Nigong" },
            { 18914, "Elenoa" },
            { 19714, "Pontos" },
            { 19814, "Iris" },
            { 19214, "Elsharion" },
            { 20614, "Wedjat" },
            { 21114, "Oberon" },
            { 21214, "Tian Lang" },
            { 21414, "Celia" },
            { 21514, "Eleanor" },
            { 21614, "Eleanor (Human)" },
            
            // Dunkel silver
            { 12705, "Ghost" },
            { 12905, "Mimick" },
            { 13005, "Horned Frog" },
            { 13105, "Sandman" },
            { 15105, "Devilmon" },
            { 12605, "Monster Flower" },
            { 13605, "Surprise Box" },
            
            // Dunkel unerweckt
            { 12805, "Low Elemental" },
            { 14205, "Angelmon" },
            { 18205, "King Angelmon" },
            { 10105, "Fairy" },
            { 10205, "Imp" },
            { 10305, "Pixie" },
            { 10705, "Warbear" },
            { 10905, "Garuda" },
            { 11105, "Salamander" },
            { 13205, "Howl" },
            { 10405, "Yeti" },
            { 10505, "Harpy" },
            { 10605, "Hellhound" },
            { 10805, "Elemental" },
            { 11005, "Inugami" },
            { 11305, "Serpent" },
            { 11405, "Golem" },
            { 11505, "Griffon" },
            { 11705, "Inferno" },
            { 12005, "High Elemental" },
            { 12105, "Harpu" },
            { 13705, "Bearman" },
            { 14005, "Werewolf" },
            { 14805, "Viking" },
            { 14905, "Amazon" },
            { 15005, "Martial Cat" },
            { 15205, "Vagabond" },
            { 15305, "Epikion Priest" },
            { 15605, "Bounty Hunter" },
            { 15805, "Imp Champion" },
            { 15905, "Mystic Witch" },
            { 16005, "Grim Reaper" },
            { 16505, "Living Armor" },
            { 17205, "Drunken Master" },
            { 17705, "Minotauros" },
            { 17805, "Lizardman" },
            { 18405, "Taoist" },
            { 18505, "Beast Hunter" },
            { 18705, "Penguin Knight" },
            { 19005, "Battle Mammoth" },
            { 19305, "Cow Girl" },
            { 19505, "Charger Shark" },
            { 20205, "Martial Artist" },
            { 20305, "Mummy" },
            { 20805, "Frankenstein" },
            { 21005, "Harg" },
            { 11205, "Nine-tailed Fox" },
            { 11605, "Undine" },
            { 11805, "Sylph" },
            { 11905, "Sylphid" },
            { 13305, "Succubus" },
            { 13405, "Joker" },
            { 13905, "Pierret" },
            { 14105, "Phantom Thief" },
            { 15405, "Magical Archer" },
            { 15505, "Rakshasa" },
            { 16205, "Death Knight" },
            { 16305, "Lich" },
            { 16905, "Samurai" },
            { 17305, "Kung Fu Girl" },
            { 18005, "Brownie Magician" },
            { 18105, "Kobold Bomber" },
            { 18805, "Barbaric King" },
            { 19405, "Pirate Captain" },
            { 19605, "Mermaid" },
            { 19805, "Magic Knight" },
            { 19905, "Assassin" },
            { 20005, "Neostone Fighter" },
            { 20405, "Anubis" },
            { 20705, "Jack-o'-lantern" },
            { 20905, "Elven Ranger" },
            { 21305, "Dice Magician" },
            { 13505, "Ninja" },
            { 13805, "Valkyrja" },
            { 14405, "Dragon" },
            { 14505, "Phoenix" },
            { 14605, "Chimera" },
            { 14705, "Vampire" },
            { 15705, "Oracle" },
            { 16105, "Occult Girl" },
            { 16605, "Dragon Knight" },
            { 16805, "Monkey King" },
            { 17005, "Archangel" },
            { 17405, "Beast Monk" },
            { 17905, "Hell Lady" },
            { 18305, "Sky Dancer" },
            { 18605, "Pioneer" },
            { 18905, "Polar Queen" },
            { 19205, "Ifrit" },
            { 19705, "Sea Emperor" },
            { 20105, "Neostone Agent" },
            { 20605, "Horus" },
            { 20505, "Desert Queen" },
            { 21105, "Fairy King" },
            { 21205, "Panda Warrior" },
            { 21405, "Harp Magician" },
            { 21505, "Unicorn" },
            
            // Dunkel erweckt
            { 14215, "Dark Angelmon" },
            { 18215, "Dark King Angelmon" },
            { 12815, "Havana" },
            { 10115, "Sorin" },
            { 10215, "Garok" },
            { 10315, "Camaryn" },
            { 10715, "Gorgo" },
            { 10915, "Rizak" },
            { 11115, "Decamaron" },
            { 13215, "Chacha" },
            { 10415, "Kumae" },
            { 10515, "Hellea" },
            { 10615, "Shumar" },
            { 10815, "Camules" },
            { 11015, "Kro" },
            { 11315, "Mantura" },
            { 11415, "Maggi" },
            { 11515, "Varus" },
            { 11715, "Drogan" },
            { 12015, "Jumaline" },
            { 12115, "Seren" },
            { 13715, "Haken" },
            { 14015, "Jultan" },
            { 14815, "Janssen" },
            { 14915, "Mara" },
            { 15015, "Miho" },
            { 15215, "Jubelle" },
            { 15315, "Rasheed" },
            { 15615, "Jamie" },
            { 15815, "Loque" },
            { 15915, "Gina" },
            { 16015, "Thrain" },
            { 16515, "Zinc" },
            { 17215, "Wei Shin" },
            { 17715, "Kamatau" },
            { 17815, "Devinodon" },
            { 18415, "Woonhak" },
            { 18515, "Hannam" },
            { 18715, "Kuna" },
            { 19015, "Basalt" },
            { 19315, "Cassie" },
            { 19515, "Calicus" },
            { 20215, "Jackie" },
            { 20315, "Karakum" },
            { 20815, "Crawler" },
            { 21015, "Kroa" },
            { 11215, "Kamiya" },
            { 11615, "Tilasha" },
            { 11815, "Aschubel" },
            { 11915, "Icares" },
            { 13315, "Isael" },
            { 13415, "Liebli" },
            { 13915, "Luna" },
            { 14115, "Guillaume" },
            { 15415, "Bethony" },
            { 15515, "Ran" },
            { 16215, "Dias" },
            { 16315, "Grego" },
            { 16915, "Sige" },
            { 17315, "Fei" },
            { 18015, "Korona" },
            { 18115, "Bering" },
            { 18815, "Hrungnir" },
            { 19415, "Frigate" },
            { 19615, "Betta" },
            { 19815, "Lanett" },
            { 19915, "Isabelle" },
            { 20015, "Karl" },
            { 20615, "Amduat" },
            { 20715, "Dusky" },
            { 20915, "Isillen" },
            { 21315, "Monte" },
            { 13515, "Han" },
            { 13815, "Trinity" },
            { 14415, "Grogen" },
            { 14515, "Jaara" },
            { 14615, "Zeratu" },
            { 14715, "Cadiz" },
            { 15715, "Giana" },
            { 16115, "Nicki" },
            { 16615, "Ragdoll" },
            { 16815, "Son Zhang Lao" },
            { 17015, "Fermion" },
            { 17415, "Rahul" },
            { 17915, "Craka" },
            { 18315, "Wolyung" },
            { 18615, "Woonsa" },
            { 18915, "Lydia" },
            { 19215, "Veromos" },
            { 19715, "Manannan" },
            { 20115, "Sylvia" },
            { 20415, "Thebae" },
            { 20515, "Nephthys" },
            { 21115, "Nyx" },
            { 21215, "Mi Ying" },
            { 21415, "Vivachel" },
            { 21515, "Alexandra" },
            { 21615, "Alexandra (Human)" }

        };
        public int unit_master_id { get; set; }
        public string Name
        {
            get
            {
                if (MonsterNames.ContainsKey(unit_master_id))
                    return MonsterNames[unit_master_id];
                else
                    return "Unknown";
            }
        }
        [JsonProperty("attribute")]
        public int AttributeId { get; set; }
        public string Attribute
        {
            get
            {
                switch (AttributeId)
                {
                    case 1: return "Water";
                    case 2: return "Fire";
                    case 3: return "Wind";
                    case 4: return "Light";
                    case 5: return "Dark";
                    default: return "Unknown";
                }
            }
        }
        [JsonProperty(propertyName: "create_time")]
        public DateTime DateSummoned { get; set; }
        [JsonProperty("unit_level")]
        public int Level { get; set; }
        [JsonProperty("unit_id")]
        public string Id { get; set; }
        [JsonProperty("class")]
        public int Stars { get; set; }
        [JsonProperty("experience")]
        public int CurrentExperience { get; set; }
        [JsonProperty("con")]
        public int BaseHp { get; set; }
        [JsonProperty("atk")]
        public int BaseAtk { get; set; }
        [JsonProperty("def")]
        public int BaseDef { get; set; }
        [JsonProperty("spd")]
        public int BaseSpd { get; set; }
        [JsonProperty("critical_rate")]
        public int BaseCR { get; set; }
        [JsonProperty("critical_damage")]
        public int BaseCD { get; set; }
        [JsonProperty("resist")]
        public int BaseRes { get; set; }
        [JsonProperty("accuracy")]
        public int BaseAcc { get; set; }


        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }
        
        
        //public int exp_gain_rate { get; set; }
        //public int exp_gained { get; set; }
        //public int building_id { get; set; }

        //public int island_id { get; set; }
        //public int pos_x { get; set; }
        //public int pos_y { get; set; }
        //public bool homunculus { get; set; }
        //public string homunculus_name { get; set; }
        //public int costume_master_id { get; set; } // transmog
        //public List<object> trans_items { get; set; }
        //public List<List<int>> skills { get; set; } // erstmal uninteressant lel
        //public int source { get; set; } wtf was soll das sein?
    }

    public class Rune
    {
        /// <summary>
        /// 1 => Rune nicht benutzt,
        /// 2 => Rune an Mob mit der Id => occupied_id
        /// </summary>
        [JsonProperty("occupied_type")]
        public int Occupied { get; set; }

        /// <summary>
        /// Id des Mobs, welches die Rune angelegt hat, sonst 0
        /// </summary>
        [JsonProperty("occupied_id")]
        public string OccupiedBy { get; set; }

        /// <summary>
        /// Sternegrad der Rune
        /// </summary>
        [JsonProperty("class")]
        public int Stars { get; set; }

        /// <summary>
        /// Verkaufswert
        /// </summary>
        [JsonProperty("sell_value")]
        public long Retail { get; set; }

        /// <summary>
        /// Mainstat
        /// </summary>
        [JsonProperty("pri_eff")]
        public List<int> Mainstat { get; set; }

        /// <summary>
        /// Prefix Stat / Fixer Substat
        /// </summary>
        [JsonProperty("prefix_eff")]
        public List<int> PrefixStat { get; set; }

        /// <summary>
        /// Liste der Substats .. Grade abhängig, 0-4 Listen, jeweils Key + Value
        /// </summary>
        [JsonProperty("sec_eff")]
        public List<List<int>> SubStats { get; set; }

        /// <summary>
        /// Slot, auf dem die Rune sich befindet
        /// </summary>
        [JsonProperty("slot_no")]
        public int Slot{ get; set; }

        /// <summary>
        ///  1: Normal - White, 2: Magic - Green, 3: Rare - Blue, 4: Hero - Purple, 5: Legendary - Orange
        /// </summary>
        [JsonProperty("rank")]
        public int Grade { get; set; }

        /// <summary>
        /// Aktueller + - Wert
        /// </summary>
        [JsonProperty("upgrade_curr")]
        public int CurrentUpgrade { get; set; }

        /// <summary>
        /// Uniq ID der Rune
        /// </summary>
        [JsonProperty("rune_id")]
        public string Id { get; set; }

        /// <summary>
        /// idk. 
        /// </summary>
        public string base_value { get; set; }
        
        /// <summary>
        /// Set Id - 1: Energy, 3: Swift
        /// </summary>
        [JsonProperty("set_id")]
        public int SetId { get; set; }

        /// <summary>
        /// IDK, bisher immer 0
        /// </summary>
        public int extra { get; set; }
        // upgrade_limit: (int) Kann man wohl getrost ignorieren, da immer 15
        // wizard_id :      ebenfalls unnötig hier.. muss man ja nicht überall haben - oder?
    }

    //#region ALLES ANDERE

    //#region Extra Klassen

    //public class ArenaShutdownInfo
    //{
    //    public int remained_start { get; set; }
    //    public int remained_end { get; set; }
    //}
    //public class DailyRewardInfo
    //{
    //    public int is_checked { get; set; }
    //    public int check_count { get; set; }
    //    // beides eigentlich Datum (yyyy-MM-dd)
    //    public string prev_last_check { get; set; }
    //    public string month { get; set; }
    //}
    //// siehe fails
    //public class DailyRewardUnitUpgradeInfo
    //{
    //    public int reward_exist { get; set; }
    //}
    //public class FriendDelInterval
    //{
    //    public int next_remained { get; set; }
    //    public int del_limit { get; set; }
    //    public int del_count { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class OppParticipationInfo
    //{
    //    public int league_type { get; set; }
    //    public int match_lose { get; set; }
    //    public int member_count { get; set; }
    //    public int energy { get; set; }
    //    public int match_score { get; set; }
    //    public int energy_max { get; set; }
    //    public int energy_regen_remained { get; set; }
    //    public int guild_id { get; set; }
    //    public int participated { get; set; }
    //    public int match_win { get; set; }
    //}
    //public class PvpInfo
    //{
    //    public int win_streak_update_remained { get; set; }
    //    public int rating_id { get; set; }
    //    public int arena_lose { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int is_new { get; set; }
    //    public int arena_win { get; set; }
    //    public int win_streak { get; set; }
    //    public int attack_score { get; set; }
    //    public int prev_rating_id { get; set; }
    //    public int rating_remained { get; set; }
    //}
    //public class RaidDeck
    //{
    //    /// <summary>
    //    /// SCHÄTZE, die Mobs die beim Raid benutzt werden (8 Werte, von links nach rechts, erst obere, dann untere Reihe
    //    /// </summary>
    //    public List<long> unit_id_list { get; set; }
    //    /// <summary>
    //    /// Null basierter Index, von welcher Position der Leaderskill benutzt wird
    //    /// </summary>
    //    public int leader_index { get; set; }
    //}
    //// gehört zur ShopInfo, der Rest ist aber bei den fails
    //public class IntervalList
    //{
    //    public int item_id { get; set; }
    //    public int remained_time { get; set; }
    //    public long wizard_id { get; set; }
    //    public int purchase_count { get; set; }
    //}
    //public class SummonSpecialInfo
    //{
    //    /// <summary>
    //    /// *_remained enthält wahrscheinlich eine Zeitspanne
    //    /// </summary>
    //    public int next_remained { get; set; }
    //    public int third_remained { get; set; }
    //    public int fourth_remained { get; set; }
    //    /// <summary>
    //    /// this,next,third & fourth enthalten die Ids der Mobs
    //    /// </summary>
    //    public List<int> third { get; set; }
    //    public List<int> @this { get; set; }
    //    public List<int> next { get; set; }
    //    public List<int> fourth { get; set; }
    //}
    //public class WishList
    //{
    //    public List<WishItem> item_list { get; set; }
    //    public int wish_sequence { get; set; }
    //    public int login_sequence { get; set; }
    //    public int next_update { get; set; }
    //    public int trial_remained { get; set; }
    //}
    //public class WishItem
    //{
    //    public int wish_id { get; set; }
    //    public int item_master_type { get; set; }
    //    public int amount { get; set; }
    //    public int item_master_id { get; set; }
    //}
    //#region WizardInfo
    //public class WizardInfo
    //{
    //    public int arena_energy_next_gain { get; set; }
    //    /// <summary>
    //    /// Level 1-50
    //    /// </summary>
    //    public int wizard_level { get; set; }
    //    /// <summary>
    //    /// Energy für den Riss
    //    /// </summary>
    //    public int darkportal_energy { get; set; }
    //    public UnitDepositorySlots unit_depository_slots { get; set; }
    //    public double energy_per_min { get; set; }
    //    public int costume_point { get; set; }
    //    public int social_point_max { get; set; }
    //    public int next_energy_gain { get; set; }
    //    /// <summary>
    //    /// Maximale Monsteranzahl (Standard: Max: 100)
    //    /// </summary>
    //    public UnitSlots unit_slots { get; set; }
    //    public int wizard_energy { get; set; }
    //    /// <summary>
    //    /// Letzter Login, Datum Format: yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string wizard_last_login { get; set; }
    //    public int mail_box_event { get; set; }
    //    public int arena_energy { get; set; }
    //    public int social_point_current { get; set; }
    //    public int arena_energy_max { get; set; }
    //    public long wizard_id { get; set; }
    //    public int honor_point { get; set; }
    //    public string wizard_name { get; set; }
    //    public int darkportal_energy_max { get; set; }
    //    /// <summary>
    //    /// Rep ? sollte wohl immer 1 sein bzw true
    //    /// </summary>
    //    public int rep_assigned { get; set; }
    //    public long rep_unit_id { get; set; }
    //    public long wizard_mana { get; set; }
    //    public int pvp_event { get; set; }
    //    public int energy_max { get; set; }
    //    public int experience { get; set; }
    //    public int honor_medal { get; set; }
    //    public int wizard_crystal { get; set; }
    //    public int guild_point { get; set; }
    //    public int costume_point_max { get; set; }
    //}
    //public class UnitDepositorySlots
    //{
    //    public Upgrade upgrade { get; set; }
    //    /// <summary>
    //    /// Wieviele Slots im Lager
    //    /// </summary>
    //    public int number { get; set; }
    //}
    //public class Upgrade
    //{
    //    /// <summary>
    //    /// Kosten für ein Lagerupgrade (Mana)
    //    /// </summary>
    //    public int mana { get; set; }
    //    /// <summary>
    //    /// Wieviele Slots im Lager nach Update
    //    /// </summary>
    //    public int number { get; set; }
    //    /// <summary>
    //    /// Kosten für ein Lagerupgrade (Kristalle)
    //    /// </summary>
    //    public int crystal { get; set; }
    //}
    //public class UnitSlots
    //{
    //    /// <summary>
    //    /// Maximal 100
    //    /// </summary>
    //    public int number { get; set; }
    //}
    //#endregion WizardInfo
    //public class GuildwarMatchInfo
    //{
    //    public int member_count_current { get; set; }
    //    public int league_type { get; set; }
    //    public int win_wait_remained { get; set; }
    //    public long match_id { get; set; }
    //    public int opp_guild_id { get; set; }
    //    public int def_num { get; set; }
    //    public int atk_num { get; set; }
    //    public int guild_rating_id { get; set; }
    //    /// <summary>
    //    /// Zeitstempel des gks? yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string create_time { get; set; }
    //    public int status { get; set; }
    //    public int opp_guild_hp_win_cond { get; set; }
    //    public int guild_id { get; set; }
    //    public int opp_guild_hp_current { get; set; }
    //    public int end_remained { get; set; }
    //    public int opp_guild_hp_max { get; set; }
    //}
    //public class GuildwarParticipationInfo
    //{
    //    public int league_type { get; set; }
    //    public int match_lose { get; set; }
    //    public int member_count { get; set; }
    //    public int energy { get; set; }
    //    public int match_score { get; set; }
    //    public int energy_max { get; set; }
    //    public int energy_regen_remained { get; set; }
    //    public int guild_id { get; set; }
    //    public int participated { get; set; }
    //    public int match_win { get; set; }
    //}
    //public class GuildwarRankingInfo
    //{
    //    public int rating_id { get; set; }
    //    public int league_type { get; set; }
    //    public int match_score { get; set; }
    //    public int total_guild_count { get; set; }
    //    public int rank { get; set; }
    //}
    //public class GuildwarRankingStat
    //{
    //    public GuildwarRankingInformation current { get; set; }
    //    public GuildwarRankingInformation prev { get; set; }
    //    public GuildwarRankingInformation best { get; set; }
    //}
    //public class GuildwarRankingInformation
    //{
    //    public int league_type { get; set; }
    //    public double ranking_rate { get; set; }
    //    public int participation_id { get; set; }
    //    public double defense_win_ratio { get; set; }
    //    public double attack_win_ratio { get; set; }
    //    public int rating_id { get; set; }
    //    public int attack_lose_count { get; set; }
    //    public int defense_lose_count { get; set; }
    //    public int match_score { get; set; }
    //    public int rank { get; set; }
    //    public int total_guild_count { get; set; }
    //    public int defense_win_count { get; set; }
    //    public int attack_win_count { get; set; }
    //}
    //public class GuildwarReserve
    //{
    //    public int status { get; set; }
    //    public int league_type { get; set; }
    //    public int guild_id { get; set; }
    //    /// <summary>
    //    /// Datum yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string last_update { get; set; }
    //}
    //public class GuildwarStatus
    //{
    //    public int status { get; set; }
    //    public int reset_remained { get; set; }
    //    public int match_remained { get; set; }
    //    public int prepare_remained { get; set; }
    //}
    //public class WorldbossRanking
    //{
    //    public int rating_id { get; set; }
    //    public int ranking { get; set; }
    //    public int ranking_rate { get; set; }
    //    public int? is_reward { get; set; }
    //    public long accumulate_damage { get; set; }
    //}
    //public class WorldbossStatus
    //{
    //    public int status { get; set; }
    //    public string close_time { get; set; }
    //    public int base_hp { get; set; }
    //    /// <summary>
    //    /// Datum yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string open_time { get; set; }
    //    public int daily_battle_init_remained_time { get; set; }
    //    public int open_remained_time { get; set; }
    //    /// <summary>
    //    /// Datum yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string battle_start_time { get; set; }
    //    /// <summary>
    //    /// Datum yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string battle_end_time { get; set; }
    //    public int worldboss_id { get; set; }
    //    public int dead_remained_time { get; set; }
    //    public double hp_rate { get; set; }
    //    public int close_remained_time { get; set; }
    //    public int refresh_term { get; set; }
    //    /// <summary>
    //    /// Mal schauen, Evtl Elemente?
    //    /// </summary>
    //    public int region_id { get; set; }
    //}
    //public class MentoringInfo
    //{
    //    public int slot_del_cnt { get; set; }
    //    public int reward_cnt { get; set; }
    //    public int attend { get; set; }
    //    public int remain_complete { get; set; }
    //    public long wizard_id { get; set; }
    //    public int slot_status { get; set; }
    //    public int next_del_time { get; set; }
    //    public int slot_cnt { get; set; }
    //}
    //public class InviteRewardIfo
    //{
    //    public int social_point_invites_max { get; set; }
    //    public int rewarded4 { get; set; }
    //    public int rewarded3 { get; set; }
    //    public int rewarded2 { get; set; }
    //    public int rewarded1 { get; set; }
    //    public int total_invites { get; set; }
    //    public int invites_init_remained { get; set; }
    //    public int social_point_invites { get; set; }
    //}
    //public class InviteBuddy
    //{
    //    public int invite_media_id { get; set; }
    //    public int inviter_uid { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class InviteAccount
    //{
    //    /// <summary>
    //    /// f755969001119038
    //    /// </summary>
    //    public string fbapp_id { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class BuildingList
    //{
    //    public int pos_x { get; set; }
    //    public int pos_y { get; set; }
    //    public long wizard_id { get; set; }
    //    public double gain_per_hour { get; set; }
    //    public int island_id { get; set; }
    //    public int building_master_id { get; set; }
    //    public int building_id { get; set; }
    //    /// <summary>
    //    /// Maximalwert bei den Kristall-/Mana- "Farmen"
    //    /// </summary>
    //    public int? harvest_max { get; set; }
    //    /// <summary>
    //    /// vorhandener Loot bei den Kristall-/Mana- "Farmen"
    //    /// </summary>
    //    public int? harvest_available { get; set; }
    //    /// <summary>
    //    /// Wohl eher bei den Kristall- "Farmen" wann der nächste Kristall ankommt
    //    /// </summary>
    //    public int? next_harvest { get; set; }
    //}
    //public class DecoList
    //{
    //    public int pos_x { get; set; }
    //    public int pos_y { get; set; }
    //    public long deco_id { get; set; }
    //    public int level { get; set; }
    //    public long wizard_id { get; set; }
    //    public int island_id { get; set; }
    //    /// <summary>
    //    /// Wahrscheinlich die ID des Gebäudes (Türme aus Arena/Gilde?)
    //    /// </summary>
    //    public int master_id { get; set; }
    //}
    ///// <summary>
    ///// Beschreibt die Arenaverteidigung
    ///// </summary>
    //public class DefenseUnitList
    //{
    //    /// <summary>
    //    /// Position des Mobs (Index:1)
    //    /// </summary>
    //    public int pos_id { get; set; }
    //    /// <summary>
    //    /// UniqueID des Mobs
    //    /// </summary>
    //    public long unit_id { get; set; }
    //}
    //public class Friend
    //{
    //    public int rep_unit_level { get; set; }
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int rating_id { get; set; }
    //    public int rep_unit_master_id { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int next_assist_time { get; set; }
    //    public string wizard_name { get; set; }
    //    public int rep_unit_class { get; set; }
    //    public long channel_uid { get; set; }
    //    public int next_gift_time { get; set; }
    //    public long rep_unit_id { get; set; }
    //}
    //public class GuildwarRewardList
    //{
    //    public int rating_id { get; set; }
    //    /// <summary>
    //    /// Noch verstehen 9, 8, 4stellig
    //    /// </summary>
    //    public List<List<int>> reward { get; set; }
    //}
    //public class GuildwarMember
    //{
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int grade { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int rating_id { get; set; }
    //    public string wizard_name { get; set; }
    //    public long channel_uid { get; set; }
    //    public int guild_id { get; set; }
    //}
    //public class Helper
    //{
    //    public int rep_unit_level { get; set; }
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int rating_id { get; set; }
    //    public int rep_unit_master_id { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int next_assist_time { get; set; }
    //    public string wizard_name { get; set; }
    //    public int rep_unit_class { get; set; }
    //    public long channel_uid { get; set; }
    //    public int next_gift_time { get; set; }
    //    public string rep_unit_id { get; set; }
    //}
    //public class InventoryInfo
    //{
    //    public int item_master_type { get; set; }
    //    public int item_quantity { get; set; }
    //    public int item_master_id { get; set; }
    //    public long wizard_id { get; set; }
    //}

    ///// <summary>
    ///// Belohnungen für das Einladen von Freunden
    ///// </summary>
    //public class InviteCounterList
    //{
    //    public int count { get; set; }
    //    /// <summary>
    //    ///  verstehen
    //    /// </summary>
    //    public List<int> reward { get; set; }
    //    public long wizard_id { get; set; }
    //    public int objective_id { get; set; }
    //    public int? limit_count { get; set; }
    //}
    //public class MyAttackList
    //{
    //    public int guild_point_var { get; set; }
    //    public int energy { get; set; }
    //    public int guild_id { get; set; }
    //    public long match_id { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class MenteeSlotList
    //{
    //    /// <summary>
    //    /// Datum yyyy-mm-dd hh:mm:ss
    //    /// </summary>
    //    public string date_add { get; set; }
    //    public int reward_status { get; set; }
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int remain_complete { get; set; }
    //    public long wizard_id { get; set; }
    //    public string wizard_name { get; set; }
    //    public int slot_status { get; set; }
    //    public string channel_uid { get; set; }
    //    public int next_reward_time { get; set; }
    //}
    ///// <summary>
    ///// Eventuell das Geschenk über Ellia
    ///// </summary>
    //public class MobRandomGiftList
    //{
    //    public int next_open_remained { get; set; }
    //    public int mob_id { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class MobCostumeEquipList
    //{
    //    public int costume_id { get; set; }
    //    public int mob_id { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class MobCostumePartList
    //{
    //    public int part_id { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //public class MobList
    //{
    //    public int pos_x { get; set; }
    //    public int pos_y { get; set; }
    //    public int level { get; set; }
    //    public int mob_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int island_id { get; set; }
    //    /// <summary>
    //    /// 1002 wird Ellia sein, WAS ZUM FICK IST 1004?!
    //    /// </summary>
    //    public int master_id { get; set; }
    //}
    //public class MyAtkdefList
    //{
    //    public long def_wizard_id { get; set; }
    //    public string match_id { get; set; }
    //    public long atk_wizard_id { get; set; }
    //}
    //public class OppGuildMemberList
    //{
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int grade { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int rating_id { get; set; }
    //    public string wizard_name { get; set; }
    //    public string channel_uid { get; set; }
    //    public int guild_id { get; set; }
    //}
    //public class ObstacleList
    //{
    //    public int pos_x { get; set; }
    //    public int pos_y { get; set; }
    //    public string obstacle_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int island_id { get; set; }
    //    /// <summary>
    //    /// ID baum ?
    //    /// </summary>
    //    public int master_id { get; set; }
    //}
    //public class OppDefenseList
    //{
    //    public int guild_point_var { get; set; }
    //    public long match_id { get; set; }
    //    public int guild_point_bonus { get; set; }
    //    public long wizard_id { get; set; }
    //    public int hp_current { get; set; }
    //    public int rank { get; set; }
    //    public int guild_id { get; set; }
    //    public int last_arena_score { get; set; }
    //    public int last_rating_id { get; set; }
    //    public int hp_max { get; set; }
    //}
    //public class PeriodItemList
    //{
    //    public int remained_time { get; set; }
    //    /// <summary>
    //    /// 2 / 4 ? 15 / 30 Tage evtl.
    //    /// </summary>
    //    public int period_type { get; set; }
    //}
    //public class PvpRewardList
    //{
    //    public int rating_id { get; set; }
    //    public int crystals { get; set; }
    //    public int unit_master_id { get; set; }
    //    public int unit_class { get; set; }
    //}
    //public class QuestActive
    //{
    //    /// <summary>
    //    /// wahrsch. bool, wenn true dann zu den rewarded dingern
    //    /// </summary>
    //    public int is_completed { get; set; }
    //    /// <summary>
    //    /// verstehen lel
    //    /// </summary>
    //    public List<List<int>> conditions { get; set; }
    //    public int quest_id { get; set; }
    //}
    ///// <summary>
    ///// Schleif dinger?
    ///// </summary>
    //public class RuneCraftItemList
    //{
    //    public int sell_value { get; set; }
    //    public long craft_type_id { get; set; }
    //    public long craft_item_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int craft_type { get; set; }
    //}
    ///// <summary>
    ///// evtl. Raid?
    ///// </summary>
    //public class RaidInfo
    //{
    //    public int available_stage_id { get; set; }
    //    public int raid_id { get; set; }
    //}
    ///// <summary>
    ///// VERSTEHEN
    ///// </summary>

    //public class ScenarioList
    //{
    //    public int difficulty { get; set; }
    //    public List<StageList> stage_list { get; set; }
    //    public int cleared { get; set; }
    //    public int region_id { get; set; }
    //}
    //public class StageList
    //{
    //    public int stage_no { get; set; }
    //    public int cleared { get; set; }
    //}





    //#endregion Extra Klassen

    //#region fails

    //#region DailyRewardList
    //public class DailyRewardList
    //{
    //    // in der RewardList dürften sich maximal days_max Einträge befinden
    //    public RewardList reward_list { get; set; }
    //    public int days_max { get; set; }
    //}
    //public class RewardList
    //{
    //    public List<__invalid_type__24> __invalid_name__24 { get; set; }
    //    public List<__invalid_type__25> __invalid_name__25 { get; set; }
    //    public List<__invalid_type__26> __invalid_name__26 { get; set; }
    //    public List<__invalid_type__27> __invalid_name__27 { get; set; }
    //    public List<__invalid_type__20> __invalid_name__20 { get; set; }
    //    public List<__invalid_type__21> __invalid_name__21 { get; set; }
    //    public List<__invalid_type__22> __invalid_name__22 { get; set; }
    //    public List<__invalid_type__23> __invalid_name__23 { get; set; }
    //    public List<__invalid_type__28> __invalid_name__28 { get; set; }
    //    public List<__invalid_type__29> __invalid_name__29 { get; set; }
    //    public List<__invalid_type__1> __invalid_name__1 { get; set; }
    //    public List<__invalid_type__3> __invalid_name__3 { get; set; }
    //    public List<__invalid_type__2> __invalid_name__2 { get; set; }
    //    public List<__invalid_type__5> __invalid_name__5 { get; set; }
    //    public List<__invalid_type__4> __invalid_name__4 { get; set; }
    //    public List<__invalid_type__7> __invalid_name__7 { get; set; }
    //    public List<__invalid_type__6> __invalid_name__6 { get; set; }
    //    public List<__invalid_type__9> __invalid_name__9 { get; set; }
    //    public List<__invalid_type__8> __invalid_name__8 { get; set; }
    //    public List<__invalid_type__11> __invalid_name__11 { get; set; }
    //    public List<__invalid_type__10> __invalid_name__10 { get; set; }
    //    public List<__invalid_type__13> __invalid_name__13 { get; set; }
    //    public List<__invalid_type__12> __invalid_name__12 { get; set; }
    //    public List<__invalid_type__15> __invalid_name__15 { get; set; }
    //    public List<__invalid_type__14> __invalid_name__14 { get; set; }
    //    public List<__invalid_type__17> __invalid_name__17 { get; set; }
    //    public List<__invalid_type__16> __invalid_name__16 { get; set; }
    //    public List<__invalid_type__19> __invalid_name__19 { get; set; }
    //    public List<__invalid_type__18> __invalid_name__18 { get; set; }
    //    public List<__invalid_type__31> __invalid_name__31 { get; set; }
    //    public List<__invalid_type__30> __invalid_name__30 { get; set; }
    //}
    //#endregion DailyRewardList

    //#region ShopInfo
    //public class ShopInfo
    //{
    //    // UNBEKANNTER TYP
    //    public List<object> triggered_list { get; set; }
    //    public List<ItemList> item_list { get; set; }
    //    public TriggerPurchasedList trigger_purchased_list { get; set; }
    //    public List<EventItemList> event_item_list { get; set; }
    //    public List<IntervalList> interval_list { get; set; }
    //}
    //public class ItemList
    //{
    //    public int enable { get; set; }
    //    // UNBEKANNTER TYP
    //    public List<List<object>> items { get; set; }
    //    public int buy_type { get; set; }
    //    public List<int> buy_cost { get; set; }
    //    public int notify { get; set; }
    //    public int item_id { get; set; }
    //    public int action_item_id { get; set; }
    //}
    //public class TriggerPurchasedList
    //{
    //    public __invalid_type__1100135 __invalid_name__1100135 { get; set; }
    //    public __invalid_type__1100114 __invalid_name__1100114 { get; set; }
    //}
    //public class EventItemList
    //{
    //    public int enable { get; set; }
    //    public List<List<object>> items { get; set; }
    //    public int buy_type { get; set; }
    //    public List<int> buy_cost { get; set; }
    //    public int notify { get; set; }
    //    public int item_id { get; set; }
    //    public int action_item_id { get; set; }
    //    public string date_begin { get; set; }
    //    public int? remained_time { get; set; }
    //    public string date_end { get; set; }
    //    public int? purchase_count_left { get; set; }
    //    public int? purchase_limit { get; set; }
    //}
    //#endregion ShopInfo

    //#region TransItemList
    //public class TransItemList
    //{
    //    public __invalid_type__100102365 __invalid_name__100102365 { get; set; }
    //    public __invalid_type__100112931 __invalid_name__100112931 { get; set; }
    //    public __invalid_type__100102249 __invalid_name__100102249 { get; set; }
    //}
    //public class __invalid_type__100102365
    //{
    //    public int source { get; set; }
    //    public int item_master_id { get; set; }
    //    public int trans_item_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int occupied_id { get; set; }
    //}
    //public class __invalid_type__100112931
    //{
    //    public int source { get; set; }
    //    public int item_master_id { get; set; }
    //    public int trans_item_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int occupied_id { get; set; }
    //}
    //public class __invalid_type__100102249
    //{
    //    public int source { get; set; }
    //    public int item_master_id { get; set; }
    //    public int trans_item_id { get; set; }
    //    public long wizard_id { get; set; }
    //    public int occupied_id { get; set; }
    //}
    //#endregion TransItemList

    //#region Guild
    //// alles nur wegen  popup_msgs
    //public class Guild
    //{
    //    public GuildInfo guild_info { get; set; }
    //    public List<GuildSkill> guild_skills { get; set; }
    //    public List<GuildMember> guild_members { get; set; }
    //    /// <summary>
    //    /// Kosten, um eine Gilde zu erstellen (default: 300000)
    //    /// </summary>
    //    public int price { get; set; }
    //    // NOCH UNBEKANNT
    //    public List<object> popup_msgs { get; set; }
    //    public int dc_rate { get; set; }
    //}
    //public class GuildInfo
    //{
    //    public string comment { get; set; }
    //    public string notice { get; set; }
    //    public string master_wizard_name { get; set; }
    //    public string name { get; set; }
    //    public int level { get; set; }
    //    public int master_wizard_level { get; set; }
    //    /// <summary>
    //    /// expire zeitstempel
    //    /// </summary>
    //    public GuildTimeData cache_expire_time { get; set; }
    //    public int experience { get; set; }
    //    public int member_now { get; set; }
    //    /// <summary>
    //    /// erstellung zeitstempel
    //    /// </summary>
    //    public GuildTimeData create_time { get; set; }
    //    public long master_wizard_id { get; set; }
    //    public int guild_id { get; set; }
    //    public int member_max { get; set; }
    //}
    //public class GuildTimeData
    //{
    //    /// <summary>
    //    /// Erstelldatum der Gilde Format: yyyy-MM-dd hh:mm:ss
    //    /// </summary>
    //    public string date { get; set; }
    //    /// <summary>
    //    /// Id der Timezone
    //    /// </summary>
    //    public int timezone_type { get; set; }
    //    /// <summary>
    //    /// Evtl. immer Asia/Seoul
    //    /// </summary>
    //    public string timezone { get; set; }
    //}
    //public class GuildSkill
    //{
    //    public int skill_type { get; set; }
    //    public int rid { get; set; }
    //    public int guild_id { get; set; }
    //    public int total_guild_point { get; set; }
    //    public int skill_level { get; set; }
    //}
    //public class GuildMember
    //{
    //    public int last_login_time { get; set; }
    //    public int wizard_level { get; set; }
    //    public int grade { get; set; }
    //    public int arena_score { get; set; }
    //    public long wizard_id { get; set; }
    //    public int rating_id { get; set; }
    //    public string wizard_name { get; set; }
    //    public long channel_uid { get; set; }
    //    public int guild_id { get; set; }
    //}
    //// wtf
    //public class GuildMemberDefenseList
    //{
    //    public List<List<long>> unit_list { get; set; }
    //    public long wizard_id { get; set; }
    //}
    //#endregion Guild

    //#region ShopBonusEvent

    //public class ShopBonusEvent
    //{
    //    public string date_begin { get; set; }
    //    public int bonus_event_id { get; set; }
    //    public int remained_time { get; set; }
    //    public List<Item> items { get; set; }
    //    public string date_end { get; set; }
    //    public string enabled { get; set; }
    //    public int purchase_count_left { get; set; }
    //    public int purchase_count_max { get; set; }
    //    public string app_version { get; set; }
    //    public int id { get; set; }
    //    public string market { get; set; }
    //    public int purchase_count { get; set; }
    //}
    //public class Item
    //{
    //    public int item_id { get; set; }
    //    public List<List<int>> reward { get; set; }
    //    /// <summary>
    //    /// ggf. int liste
    //    /// </summary>
    //    public List<object> reward_additional { get; set; }
    //    public int bonus_event_id { get; set; }
    //}
    //#endregion ShopBonusEvent

    //#endregion fails




    //public class CacheExpireTime
    //{
    //    public string date { get; set; }
    //    public int timezone_type { get; set; }
    //    public string timezone { get; set; }
    //}

    //public class CreateTime
    //{
    //    public string date { get; set; }
    //    public int timezone_type { get; set; }
    //    public string timezone { get; set; }
    //}

    //public class OppGuildInfo
    //{
    //    public string comment { get; set; }
    //    public string notice { get; set; }
    //    public string master_wizard_name { get; set; }
    //    public string name { get; set; }
    //    public int level { get; set; }
    //    public int master_wizard_level { get; set; }
    //    public CacheExpireTime cache_expire_time { get; set; }
    //    public int experience { get; set; }
    //    public int member_now { get; set; }
    //    public CreateTime create_time { get; set; }
    //    public int master_wizard_id { get; set; }
    //    public int guild_id { get; set; }
    //    public int member_max { get; set; }
    //}

    //#endregion ALLES ANDERE

}
