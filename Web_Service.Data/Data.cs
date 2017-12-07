using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Web_Service.Data.Contexts;
using Web_Service.Data.DatabaseModels;
using Web_Service.Data.Requests;

namespace Web_Service.Data
{
    public class Data: IData
    {
        private readonly NorthWindContext _northWindContext;

        public Data(NorthWindContext northWindContext)
        {
            _northWindContext = northWindContext;
        }

        //Customers from Database
        public async Task<List<Customer>> Customers()
        {
           return await _northWindContext.Customers.ToListAsync();
        }

        //Get Customer By Id
        public async Task<Customer> CustomerById(string id)
        {
            return await _northWindContext.Customers.FirstOrDefaultAsync(x => x.CustomerID == id);
        }

        public async Task AddNewCustomer(CreateCustomer newCustomer)
        {
            var customer = new Customer
            {
                CustomerID = newCustomer.CustomerID,
                CompanyName = newCustomer.CompanyName,
                ContactName = newCustomer.ContactName,
                ContactTitle = newCustomer.ContactTitle,
                Address = newCustomer.Address,
                City = newCustomer.City,
                Region = newCustomer.Region,
                PostalCode = newCustomer.PostalCode,
                Country = newCustomer.Country,
                Phone = newCustomer.Phone,
                Fax = newCustomer.Fax
            };

            _northWindContext.Customers.Add(customer);
            await _northWindContext.SaveChangesAsync();
        }

        public async Task UpdateCustomerRecord(string customerId, UpdateCustomerRequest updateCustomerRequestEntity)
        {
            var customer = await _northWindContext.Customers.FirstOrDefaultAsync(x => x.CustomerID == customerId);

            customer.CompanyName = updateCustomerRequestEntity.CompanyName;
            customer.ContactName = updateCustomerRequestEntity.ContactName;
            customer.ContactTitle = updateCustomerRequestEntity.ContactTitle;
            customer.Address = updateCustomerRequestEntity.Address;
            customer.City = updateCustomerRequestEntity.City;
            customer.Region = updateCustomerRequestEntity.Region;
            customer.Country = updateCustomerRequestEntity.Country;
            customer.Fax = updateCustomerRequestEntity.Fax;
            customer.Phone = updateCustomerRequestEntity.Phone;
            customer.PostalCode = updateCustomerRequestEntity.PostalCode;

            //Saving Changes
            await _northWindContext.SaveChangesAsync();

        }

        public async Task DeleteCustomer(string customerId)
        {
            var customer = await _northWindContext.Customers.FirstOrDefaultAsync(x => x.CustomerID == customerId);

            _northWindContext.Customers.Remove(customer);
            await _northWindContext.SaveChangesAsync();
        }
    }
}
