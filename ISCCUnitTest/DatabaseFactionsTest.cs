using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImperialSettlersCampaignCompanion.Data;
using ImperialSettlersCampaignCompanion.Data.Factions;
using ImperialSettlersCampaignCompanion.i18n;

namespace ISCCUnitTest
{
    [TestClass]
    public class DatabaseFactionsTest
    {
        Database db = Database.Instance;

        [TestMethod]
        public void TestThereShouldBe4Factions()
        {
            Assert.AreEqual(4, db.Factions.Length);
        }

        [TestMethod]
        public void TestFaction1IsRomans()
        {
            int id = 1;
            Faction f = db.GetFaction(id);
            Assert.IsNotNull(f);
            Assert.AreEqual(id, f.Id);
            Assert.AreEqual(Strings.ROMAN_NAME, f.Name);
            Assert.AreEqual(2, f.ProdWorker);
        }

        [TestMethod]
        public void TestFaction2IsBarbarians()
        {
            int id = 2;
            Faction f = db.GetFaction(id);
            Assert.IsNotNull(f);
            Assert.AreEqual(id, f.Id);
            Assert.AreEqual(Strings.BARBARIAN_NAME, f.Name);
            Assert.AreEqual(5, f.ProdWorker);
        }

        [TestMethod]
        public void TestFaction3IsEgyptians()
        {
            int id = 3;
            Faction f = db.GetFaction(id);
            Assert.IsNotNull(f);
            Assert.AreEqual(id, f.Id);
            Assert.AreEqual(Strings.EGYPTIAN_NAME, f.Name);
            Assert.AreEqual(3, f.ProdWorker);
        }

        [TestMethod]
        public void TestFaction4IsJapaneses()
        {
            int id = 4;
            Faction f = db.GetFaction(id);
            Assert.IsNotNull(f);
            Assert.AreEqual(id, f.Id);
            Assert.AreEqual(Strings.JAPANESE_NAME, f.Name);
            Assert.AreEqual(4, f.ProdWorker);
        }
    }
}
