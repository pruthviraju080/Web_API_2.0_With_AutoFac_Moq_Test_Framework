using System.Collections.Generic;

namespace Web_Services.Api.Models
{
    public class ShipperModel
    {

        public ShipperModel()
        {
            Orders = new HashSet<OrderEntityModel>();
        }

        public int ShipperID { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<OrderEntityModel> Orders { get; set; }
    }
}
