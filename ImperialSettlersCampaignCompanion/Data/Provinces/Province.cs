using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Provinces
{
    public abstract class Province
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public abstract string TraitDescription { get; }
        public virtual int ControlCost { get; set; } = 0;
        public virtual Unkeep Unkeep { get; } = Unkeep.None;
        public virtual bool NeedToPayResources { get; set; } = false;

        public virtual void ApplyAcquire(Campaign campaign) { }
        public virtual void ApplyLoseControl(Campaign campaign)
        {
            campaign.Provinces.ForEach(province =>
            {
                province.ControlCost += 2;
            });
        }
        public virtual void ApplyResourcesPaid(Campaign campaign) { }
    }
}
