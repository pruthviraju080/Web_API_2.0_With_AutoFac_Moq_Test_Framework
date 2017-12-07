using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{  

    public class CustomerEntity
    {
        public CustomerEntity()
        {
            Orders = new HashSet<OrderEntity>();
            CustomerDemographics = new HashSet<CustomerDemographicEntity>();
        }

        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public virtual ICollection<OrderEntity> Orders { get; set; }

        public virtual ICollection<CustomerDemographicEntity> CustomerDemographics { get; set; }
    }
}
