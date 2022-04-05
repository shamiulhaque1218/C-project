using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Final.Controllers
{
    
    public class ManagerController : ApiController
    {
        [Route("api/managers")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ManagersService.Get());
        }
        [Route("api/managers/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, ManagersService.Get(id));
        }
        [Route("api/managers/create")]
        [HttpPost]
        public HttpResponseMessage Create(ManagerModel manager)
        {
            ManagersService.Create(manager);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/managers/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(ManagerModel manager)
        {
            ManagersService.Edit(manager);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/managers/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ManagersService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
