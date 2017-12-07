using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Service.Data.DatabaseModels;
using Web_Service.Data.Requests;

namespace Web_Service.Data
{
    public interface IData
    {
        Task<List<Customer>> Customers();

        Task<Customer> CustomerById(string id);

        Task AddNewCustomer(CreateCustomer customer);

        Task UpdateCustomerRecord(string customerId, UpdateCustomerRequest updateCustomerRequestEntity);

        Task DeleteCustomer(string customerId);

    }
}
