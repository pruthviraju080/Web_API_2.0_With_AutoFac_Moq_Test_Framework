using System;
using System.Collections.Generic;
using Web_Service.API.Models;

namespace Web_Services.Api.Models
{

    public class OrderEntityModel
    {
       
        public OrderEntityModel()
        {
            Order_Details = new HashSet<Order_DetailModel>();
        }

        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }
        
        public decimal? Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        public virtual CustomerModel CustomerModel { get; set; }

        public virtual EmployeeModel EmployeeModel { get; set; }

        public virtual ICollection<Order_DetailModel> Order_Details { get; set; }

        public virtual ShipperModel ShipperModel { get; set; }
    }
}
