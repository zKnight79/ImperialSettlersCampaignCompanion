using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Factions
{
    class Barbarians : Faction
    {
        public override int Id
        {
            get
            {
                return BARBARIAN_ID;
            }
        }

        public override string Name
        {
            get
            {
                return i18n.Strings.BARBARIAN_NAME;
            }
        }

        public override int ProdWorker
        {
            get
            {
                return 5;
            }
        }
    }
}
