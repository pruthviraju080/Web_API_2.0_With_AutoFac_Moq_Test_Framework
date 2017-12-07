using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Service.Appliation.Entities;
using Web_Service.Appliation.RequestEntities;

namespace Web_Service.Appliation
{
    public interface IApplication
    {
        Task<List<CustomerEntity>> GetCustomers();

        Task<CustomerEntity> GetCustomerById(string id);

        Task CreateNewCustomer(CreateCustomerRequestEntity customer);

        Task UpdateCustomer(string customerId,UpdateCustomerRequestEntity updateCustomerRequestEntity);

        Task DeleteCustomerRecord(string customerId);
    }
}
