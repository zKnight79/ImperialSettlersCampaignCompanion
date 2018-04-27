using ImperialSettlersCampaignCompanion.Data;
using ImperialSettlersCampaignCompanion.Data.Factions;
using ImperialSettlersCampaignCompanion.Data.Provinces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ImperialSettlersCampaignCompanion
{
    public class Campaign
    {
        private const string FILE_EXTENSION = ".isc";

        #region Global Campaign Informations
        public string Name { get; set; }
        public int Chapter { get; set; } = 1;

        public int VictoryPoints { get; set; } = 0;

        [JsonIgnore]
        public Faction PlayerFaction { get; private set; }
        [JsonIgnore]
        public Faction ForeignFaction { get; private set; }

        public int PlayerFactionId
        {
            get
            {
                return PlayerFaction.Id;
            }
            set
            {
                PlayerFaction = Database.Instance.GetFaction(value);
            }
        }
        public int ForeignFactionId
        {
            get
            {
                return ForeignFaction.Id;
            }
            set
            {
                ForeignFaction = Database.Instance.GetFaction(value);
            }
        }
        #endregion

        [JsonIgnore]
        public List<Province> Provinces { get; } = new List<Province>();

        public Tuple<int, int, bool>[] ProvinceAcquired
        {
            get
            {
                List<Tuple<int, int, bool>> list = new List<Tuple<int, int, bool>>();

                Provinces.ForEach(province =>
                {
                    list.Add(new Tuple<int, int, bool>(province.Id, province.ControlCost, province.NeedToPayResources));
                });

                return list.ToArray();
            }
            set
            {
                List<Tuple<int, int, bool>> list = value.ToList();
                list.ForEach(tuple =>
                {
                    Province province = Database.Instance.GetProvince(tuple.Item1);
                    province.ControlCost = tuple.Item2;
                    province.NeedToPayResources = tuple.Item3;
                    Provinces.Add(province);
                });
            }
        }

        public Campaign() { }

        public Campaign(string name, Faction playerFaction, Faction foreignFaction)
        {
            Name = name;
            PlayerFaction = playerFaction;
            ForeignFaction = foreignFaction;
        }

        public void ToJSonFile()
        {
            File.WriteAllText(GetValidFileName(Name), JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static bool Exists(string name)
        {
            return File.Exists(GetValidFileName(name));
        }

        private static string GetValidFileName(string baseName)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));

            return r.Replace(baseName, "") + FILE_EXTENSION;
        }

        public static Campaign FromJSonFile(string filePath)
        {
            return JsonConvert.DeserializeObject<Campaign>(File.ReadAllText(filePath));
        }

        public static Campaign[] GetSavedCampaigns()
        {
            List<Campaign> campaigns = new List<Campaign>();

            IEnumerable<string> files = Directory.EnumerateFiles(".", "*" + FILE_EXTENSION, SearchOption.TopDirectoryOnly);
            files.ToList().ForEach(file =>
            {
                campaigns.Add(FromJSonFile(file));
            });

            return campaigns.ToArray();
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} ({2})", Name, PlayerFaction.Name, ForeignFaction.Name);
        }

        #region Computed Production
        [JsonIgnore]
        public int ProdWorker
        {
            get
            {
                return PlayerFaction.ProdWorker;
            }
        }
        [JsonIgnore]
        public int ProdWeapon
        {
            get
            {
                return PlayerFaction.ProdWeapon;
            }
        }
        [JsonIgnore]
        public int ProdWood
        {
            get
            {
                return PlayerFaction.ProdWood;
            }
        }
        [JsonIgnore]
        public int ProdStone
        {
            get
            {
                return PlayerFaction.ProdStone
                    + this.ProdBonusStone;
            }
        }
        [JsonIgnore]
        public int ProdFood
        {
            get
            {
                return PlayerFaction.ProdFood;
            }
        }
        [JsonIgnore]
        public int ProdGold
        {
            get
            {
                return PlayerFaction.ProdGold;
            }
        }
        [JsonIgnore]
        public int ProdCardAny
        {
            get
            {
                return 0;
            }
        }
        [JsonIgnore]
        public int ProdCardFaction
        {
            get
            {
                return 0;
            }
        }
        [JsonIgnore]
        public int ProdCardCommon
        {
            get
            {
                return 0;
            }
        }
        #endregion

        public void Acquire(Province province)
        {
            Provinces.Add(province);
            province.ApplyAcquire(this);
        }
        public void LoseControl(Province province)
        {
            if (Provinces.Remove(province))
            {
                province.ApplyLoseControl(this);
            }
        }

        #region Bonus Production
        public int ProdBonusStone { get; set; }
        #endregion

        #region Bonus Start
        public List<string> StartBonuses { get; } = new List<string>();
        #endregion
    }
}
