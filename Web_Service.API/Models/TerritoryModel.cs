using System.Collections.Generic;

namespace Web_Services.Api.Models
{

    public class TerritoryModel
    {
        public TerritoryModel()
        {
            Employees = new HashSet<EmployeeModel>();
        }

        public string TerritoryID { get; set; }

        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }

        public virtual RegionModel RegionModel { get; set; }

        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}
