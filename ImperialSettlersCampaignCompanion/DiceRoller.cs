using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion
{
    public static class DiceRoller
    {
        private static Random Rnd { get; }

        static DiceRoller()
        {
            Rnd = new Random();
        }

        public static int Roll(int sideCount)
        {
            return Rnd.Next(sideCount) + 1;
        }
    }
}
