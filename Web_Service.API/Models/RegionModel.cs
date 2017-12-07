using System.Collections.Generic;

namespace Web_Services.Api.Models
{

    public class RegionModel
    {
        public RegionModel()
        {
            Territories = new HashSet<TerritoryModel>();
        }

        public int RegionID { get; set; }

        public string RegionDescription { get; set; }

        public virtual ICollection<TerritoryModel> Territories { get; set; }
    }
}
