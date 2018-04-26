using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Factions
{
    public abstract class Faction
    {
        protected const int ROMAN_ID = 1;
        protected const int BARBARIAN_ID = 2;
        protected const int EGYPTIAN_ID = 3;
        protected const int JAPANESE_ID = 4;

        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual int ProdWorker { get; } = 0;
        public virtual int ProdWood { get; } = 0;
        public virtual int ProdStone { get; } = 0;
        public virtual int ProdFood { get; } = 0;
        public virtual int ProdGold { get; } = 0;
        public virtual int ProdWeapon { get; } = 1;
        public virtual int ProdShield { get; } = 1;
    }
}
