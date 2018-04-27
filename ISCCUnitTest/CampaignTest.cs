using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImperialSettlersCampaignCompanion;
using ImperialSettlersCampaignCompanion.i18n;
using ImperialSettlersCampaignCompanion.Data;
using ImperialSettlersCampaignCompanion.Data.Provinces;

namespace ISCCUnitTest
{
    /// <summary>
    /// Description résumée pour CampaignTest
    /// </summary>
    [TestClass]
    public class CampaignTest
    {
        Database db = Database.Instance;

        [TestMethod]
        public void TestJsonWithProvinces()
        {
            Campaign campaign = new Campaign("Romans (F - Barbarians)", db.GetFaction(1), db.GetFaction(2));
            Assert.AreEqual(1, campaign.ProdStone);
            
            Province province = db.GetProvince(1);
            campaign.Acquire(province);
            Assert.AreEqual(2, campaign.ProdStone);

            campaign.ToJSonFile();

            campaign = Campaign.FromJSonFile("Romans (F - Barbarians).isc");
            Assert.AreEqual(2, campaign.ProdStone);
            Assert.AreEqual(Strings.MISTYMOUNTAINS_NAME, campaign.Provinces[0].Name);

            campaign.LoseControl(province);
            Assert.AreEqual(1, campaign.ProdStone);

            campaign.ToJSonFile();

            campaign = Campaign.FromJSonFile("Romans (F - Barbarians).isc");
            Assert.AreEqual(1, campaign.ProdStone);
        }
    }
}
