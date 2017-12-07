using System.Collections.Generic;
using Web_Service.API.Models;

namespace Web_Services.Api.Models
{

    public class CustomerDemographicModel
    {
        public CustomerDemographicModel()
        {
            Customers = new HashSet<CustomerModel>();
        }

        public string CustomerTypeID { get; set; }

        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerModel> Customers { get; set; }
    }
}
