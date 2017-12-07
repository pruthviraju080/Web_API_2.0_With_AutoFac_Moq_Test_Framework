using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{

    public class TerritoryEntity
    {
        public TerritoryEntity()
        {
            Employees = new HashSet<EmployeeEntity>();
        }

        public string TerritoryID { get; set; }

        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }

        public virtual RegionEntity RegionEntity { get; set; }

        public virtual ICollection<EmployeeEntity> Employees { get; set; }
    }
}
