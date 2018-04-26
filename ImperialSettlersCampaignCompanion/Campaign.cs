using ImperialSettlersCampaignCompanion.Data;
using ImperialSettlersCampaignCompanion.Data.Factions;
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

        public string Name { get; set; }
        public int Chapter { get; set; } = 1;

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
    }
}
