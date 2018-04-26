using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Factions
{
    class Japaneses : Faction
    {
        public override int Id
        {
            get
            {
                return JAPANESE_ID;
            }
        }

        public override string Name
        {
            get
            {
                return i18n.Strings.JAPANESE_NAME;
            }
        }

        public override int ProdWorker
        {
            get
            {
                return 4;
            }
        }

        public override int ProdWood
        {
            get
            {
                return 1;
            }
        }
    }
}
