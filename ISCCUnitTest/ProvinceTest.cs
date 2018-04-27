using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImperialSettlersCampaignCompanion.Data.Provinces;
using ImperialSettlersCampaignCompanion.Data;

namespace ISCCUnitTest
{
    [TestClass]
    public class ProvinceTest
    {
        [TestMethod]
        public void TestProvinceEquals()
        {
            Province p1 = Database.Instance.GetProvince(1);
            Province p2 = Database.Instance.GetProvince(1);
            Province p3 = Database.Instance.GetProvince(1);
            Assert.AreSame(p1, p2);
            Assert.AreSame(p1, p3);
            Assert.AreSame(p2, p3);
        }
    }
}
