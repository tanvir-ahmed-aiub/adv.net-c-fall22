using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BDonate.Controllers
{
    public class GroupController : ApiController
    {
        [HttpGet]
        [Route("api/groups")]
        public HttpResponseMessage Get() { 
            var data = GroupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }
        [HttpGet]
        [Route("api/groups/{id}")]
        public HttpResponseMessage Get(int id) {
            var data = GroupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/groups/add")]
        [HttpPost]
        public HttpResponseMessage Add(GroupDTO obj) {
            var data = GroupService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
