using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Service.Appliation.Entities;
using Web_Service.Data;
using AutoMapper;
using Web_Service.Appliation.RequestEntities;
using Web_Service.Data.DatabaseModels;
using Web_Service.Data.Requests;

namespace Web_Service.Appliation
{
    public class Application : IApplication
    {
        private readonly Data.Data _data;

        public Application(Data.Data data)
        {
            _data = data;
        }

        public async Task<List<CustomerEntity>> GetCustomers()
        {
            var customers = await _data.Customers();

            //Mapping Customer to CustomerEntity 
            return Mapper.Map<List<CustomerEntity>>(customers);
        }

        public async Task<CustomerEntity> GetCustomerById(string id)
        {
            var customer = await _data.CustomerById(id);
            return Mapper.Map<CustomerEntity>(customer);
        }

        public async Task CreateNewCustomer(CreateCustomerRequestEntity customerEntity)
        {
            var customer = Mapper.Map<CreateCustomer>(customerEntity);
            await _data.AddNewCustomer(customer);
        }

        public async Task UpdateCustomer(string customerId, UpdateCustomerRequestEntity updateCustomerRequestEntity)
        {
            var customer = Mapper.Map<UpdateCustomerRequest>(updateCustomerRequestEntity);
            await _data.UpdateCustomerRecord(customerId, customer);
        }

        public async Task DeleteCustomerRecord(string customerId)
        {
            await _data.DeleteCustomer(customerId);
        }
    }
}
