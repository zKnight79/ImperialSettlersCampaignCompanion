using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Factions
{
    class Egyptians : Faction
    {
        public override int Id
        {
            get
            {
                return EGYPTIAN_ID;
            }
        }

        public override string Name
        {
            get
            {
                return i18n.Strings.EGYPTIAN_NAME;
            }
        }

        public override int ProdWorker
        {
            get
            {
                return 3;
            }
        }

        public override int ProdGold
        {
            get
            {
                return 1;
            }
        }
    }
}
