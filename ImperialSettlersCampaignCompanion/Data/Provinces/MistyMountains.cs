using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Provinces
{
    class MistyMountains : Province
    {
        public override int Id { get; } = 1;
        public override string Name { get; } = i18n.Strings.MISTYMOUNTAINS_NAME;
        public override string TraitDescription { get; } = i18n.Strings.MISTYMOUNTAINS_TRAIT;
        public override Unkeep Unkeep { get; } = Unkeep.Wood;

        public override void ApplyAcquire(Campaign campaign)
        {
            campaign.ProdBonusStone++;
        }
        public override void ApplyLoseControl(Campaign campaign)
        {
            base.ApplyLoseControl(campaign);
            campaign.ProdBonusStone--;
        }
    }
}
