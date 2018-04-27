using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Provinces
{
    public enum Unkeep
    {
        None,
        Worker,
        Wood,
        Stone,
        Food
    }

    static class UnkeepMethods
    {
        public static Bitmap GetBitmap(this Unkeep unkeep)
        {
            switch(unkeep)
            {
                case Unkeep.Worker:
                    return Pictures.Worker;
                case Unkeep.Wood:
                    return Pictures.Wood;
                case Unkeep.Stone:
                    return Pictures.Stone;
                case Unkeep.Food:
                    return Pictures.Food;
                default:
                    return null;
            }
        }
    }
}
