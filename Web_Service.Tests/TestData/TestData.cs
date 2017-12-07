using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Service.Appliation.Entities;
using Web_Service.API.Models;
using Web_Service.Data.DatabaseModels;

namespace Web_Service.Tests.TestData
{
    public static class TestData
    {
        public static CustomerEntity GetCustomerEntity()
        {
            var customer = new CustomerEntity
            {
                CustomerID = "ALSE",
                CompanyName = "Frontier",
                Address = "5678 Hutch",
                City = "Dallas",
                ContactName = "Locas",
                ContactTitle = "Location",
                Country = "USA",
                Fax = "657899543",
                Phone = "7865443276",
                PostalCode = "75432"
            };

            return customer;
        }

        public static CustomerModel GetCustomerModel()
        {
            var customer = new CustomerModel
            {
                CustomerID = "ALSE",
                CompanyName = "Frontier",
                Address = "5678 Hutch",
                City = "Dallas",
                ContactName = "Locas",
                ContactTitle = "Location",
                Country = "USA",
                Fax = "657899543",
                Phone = "7865443276",
                PostalCode = "75432"
            };

            return customer;
        }
    }
}
