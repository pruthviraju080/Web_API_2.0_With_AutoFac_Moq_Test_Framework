using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Web_Services.Api.Models;

namespace Web_Service.API.Models
{  
    [JsonObject("customerModel")]
    public class CustomerModel
    {
        public CustomerModel()
        {
            Orders = new HashSet<OrderEntityModel>();
            CustomerDemographics = new HashSet<CustomerDemographicModel>();
        }

        [JsonProperty("customerID")]
        [Required]
        public string CustomerID { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("orders")]
        public virtual ICollection<OrderEntityModel> Orders { get; set; }

        [JsonProperty("customerDemographics")]
        public virtual ICollection<CustomerDemographicModel> CustomerDemographics { get; set; }
    }
}
