using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Antlr.Runtime;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Web_Service.Appliation;
using Web_Service.Appliation.Entities;
using Web_Service.Appliation.RequestEntities;
using Web_Service.API.Models;
using Web_Service.API.Requests;
using Web_Services.Api.Models;

namespace Web_Service.API.Controllers
{

    /// <summary>
    /// Customer Contoller
    /// </summary>
    public class CutomersController : ApiController
    {
        private readonly IApplication _app;

        /// <summary>
        /// Contructor with Dependency Injection, Register the Dependecies through Atofac
        /// </summary>
        /// <param name="app"></param>
        public CutomersController(IApplication app)
        {
            _app = app;
        }
        
        /// <summary>
        /// This Method Retrieves the Customers list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/customers")]
        [ResponseType(typeof(List<CustomerModel>))]
        public async Task<HttpResponseMessage> GetCustomers()
        {
            var customers = await _app.GetCustomers();
            return Request.CreateResponse(HttpStatusCode.OK,Mapper.Map<List<CustomerModel>>(customers));
        }

        /// <summary>
        /// This Method retrieves the Customer Information
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/customer/{customerId}")]
        [ResponseType(typeof(CustomerModel))]
        public async Task<HttpResponseMessage> GetCustomer(string customerId)
        {
            var customer = await _app.GetCustomerById(customerId.Trim());
            
            //Returns Bad Request if the cusotmer is null, Or else returns customer object.
            return (customer == null) ? 
                Request.CreateResponse(HttpStatusCode.NotFound) 
                : Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<CustomerModel>(customer));

        }

        /// <summary>
        /// This Method creates a new Customer Record
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
       [HttpPost]
       [Route("api/cutomer")]
       public async Task<HttpResponseMessage> CreateCustomer([FromBody]CreateCustomerRequest customer)
        {
            var cus = await _app.GetCustomerById(customer.CustomerID);
            if(cus != null) return Request.CreateResponse(HttpStatusCode.BadRequest, "Record already existed.");

            await _app.CreateNewCustomer(Mapper.Map<CreateCustomerRequestEntity>(customer));
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

    
        /// <summary>
        /// This Method Update Customer Record
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="updateRequest"></param>
        [HttpPatch]
        [Route("api/{customerId}/customer")]
        [ResponseType(typeof(string))]
        public async Task<HttpResponseMessage> UpdateCustomerRecord(string customerId, [FromBody]UpdateCustomerRequestModel updateRequest)
        {
            var cus = await _app.GetCustomerById(customerId);
            if (cus == null) return Request.CreateResponse(HttpStatusCode.BadRequest, "Update Can't perform, Record not existed.");

            await _app.UpdateCustomer(customerId, Mapper.Map<UpdateCustomerRequestEntity>(updateRequest));
            return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        [HttpDelete]
        [Route("api/{customerId}")]
        [ResponseType(typeof(string))]
        public async Task<HttpResponseMessage> Delete(string customerId)
        {
            var cus = await _app.GetCustomerById(customerId);
            if (cus == null) return Request.CreateResponse(HttpStatusCode.BadRequest, "Update Can't perform, Record not existed.");

            await _app.DeleteCustomerRecord(customerId);
            return Request.CreateResponse(HttpStatusCode.OK, "Successfully Deleted.");
        }
    }
}
