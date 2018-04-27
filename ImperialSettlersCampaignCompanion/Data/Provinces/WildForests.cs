using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data.Provinces
{
    class WildForests : Province
    {
        public override int Id { get; } = 2;

        public override string Name { get; } = i18n.Strings.WILDFORESTS_NAME;

        public override string TraitDescription { get; } = i18n.Strings.WILDFORESTS_TRAIT;

        public override int ControlCost { get; set; } = 5;

        public override void ApplyAcquire(Campaign campaign)
        {
            campaign.StartBonuses.Add(i18n.Strings.WILDFORESTS_STARTBONUS);
        }
    }
}
