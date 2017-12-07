using System;
using System.Collections.Generic;


namespace Web_Service.Appliation.Entities
{

    public class CustomerDemographicEntity
    {
        public CustomerDemographicEntity()
        {
            Customers = new HashSet<CustomerEntity>();
        }

        public string CustomerTypeID { get; set; }

        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerEntity> Customers { get; set; }
    }
}
