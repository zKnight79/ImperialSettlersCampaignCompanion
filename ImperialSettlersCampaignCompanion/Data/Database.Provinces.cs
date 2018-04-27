using ImperialSettlersCampaignCompanion.Data.Provinces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperialSettlersCampaignCompanion.Data
{
    partial class Database
    {
        public Province[] Provinces { get; private set; }

        private void SetProvinces()
        {
            this.Provinces = new Province[] {
                new MistyMountains()
            };
        }

        public Province GetProvince(int id)
        {
            return (
                from p in Provinces
                where p.Id == id
                select p
            ).SingleOrDefault();
        }
    }
}
