using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Factions
{
    class Romans : Faction
    {
        public override int Id
        {
            get
            {
                return ROMAN_ID;
            }
        }

        public override string Name
        {
            get
            {
                return i18n.Strings.ROMAN_NAME;
            }
        }

        public override int ProdWorker
        {
            get
            {
                return 2;
            }
        }

        public override int ProdWood
        {
            get
            {
                return 1;
            }
        }

        public override int ProdStone
        {
            get
            {
                return 1;
            }
        }
    }
}
