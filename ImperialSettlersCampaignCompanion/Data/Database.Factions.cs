using ImperialSettlersCampaignCompanion.Data.Factions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data
{
    partial class Database
    {
        public Faction[] Factions { get; private set; }

        private void SetFactions()
        {
            this.Factions = new Faction[] {
                new Romans(),
                new Barbarians(),
                new Egyptians(),
                new Japaneses()
            };
        }

        public Faction GetFaction(int id)
        {
            return (
                from f in Factions
                where f.Id == id
                select f
            ).SingleOrDefault();
        }
    }
}
