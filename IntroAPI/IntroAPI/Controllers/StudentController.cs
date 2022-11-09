using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            var data = new { Id = 1, Name = "Tanvir" };
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post() { 
            return Request.CreateResponse(HttpStatusCode.OK,"this is post");   
        }
        public HttpResponseMessage Delete() {
            return Request.CreateResponse(HttpStatusCode.OK, "this is delte");
        }
    }
}
