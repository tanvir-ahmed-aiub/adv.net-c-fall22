using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/dept/all")]
        [HttpGet]
        public HttpResponseMessage AllDept()
        {
            return Request.CreateResponse(HttpStatusCode.OK,"dept get called");
        }
        [Route("api/dept/maxstudent")]
        [HttpGet]
        public HttpResponseMessage MaxStu()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "max student dept");
        }

        [Route("api/dept/create")]
        [HttpPost]
        public HttpResponseMessage CreateDept()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "dept post called");
        }
    }
}
