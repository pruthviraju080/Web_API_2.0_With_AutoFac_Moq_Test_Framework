using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{
    public class ShipperEntity
    {

        public ShipperEntity()
        {
            Orders = new HashSet<OrderEntity>();
        }

        public int ShipperID { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<OrderEntity> Orders { get; set; }
    }
}
