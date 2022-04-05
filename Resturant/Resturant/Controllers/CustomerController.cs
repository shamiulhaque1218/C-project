using BEL;
using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Resturant.Controllers
{
    
    public class CustomerController : ApiController
    {
        //[CustomAuth]
        [Route("api/customers")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerService.Get());
        }
        [Route("api/customers/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerService.Get(id));
        }
        [Route("api/customers/create")]
        [HttpPost]
        public HttpResponseMessage Create(CustomerModel customer)
        {
            CustomerService.Create(customer);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/customers/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(CustomerModel customer)
        {
            CustomerService.Edit(customer);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/customers/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            CustomerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
