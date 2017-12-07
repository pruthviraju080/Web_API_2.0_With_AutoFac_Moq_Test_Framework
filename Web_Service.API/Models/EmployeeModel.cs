using System;
using System.Collections.Generic;

namespace Web_Services.Api.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees1 = new HashSet<EmployeeModel>();
            Orders = new HashSet<OrderEntityModel>();
            Territories = new HashSet<TerritoryModel>();
        }

        public int EmployeeID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public string Extension { get; set; }

        public byte[] Photo { get; set; }

        public string Notes { get; set; }

        public int? ReportsTo { get; set; }

        public string PhotoPath { get; set; }

        public virtual ICollection<EmployeeModel> Employees1 { get; set; }

        public virtual EmployeeModel Employee1 { get; set; }

        public virtual ICollection<OrderEntityModel> Orders { get; set; }

        public virtual ICollection<TerritoryModel> Territories { get; set; }
    }
}
