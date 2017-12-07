using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{

    public class RegionEntity
    {
        public RegionEntity()
        {
            Territories = new HashSet<TerritoryEntity>();
        }

        public int RegionID { get; set; }

        public string RegionDescription { get; set; }

        public virtual ICollection<TerritoryEntity> Territories { get; set; }
    }
}
