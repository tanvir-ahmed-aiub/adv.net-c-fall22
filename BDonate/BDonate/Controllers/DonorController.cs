using BDonate.AuthFilter;
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BDonate.Controllers
{
    [EnableCors("*","*","*")]
    public class DonorController : ApiController
    {
        //[Logged]
        [HttpGet]
        [Route("api/donors")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = DonorService.Get().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        [HttpGet]
        [Route("api/donors/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = DonorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/donors/add")]
        [HttpPost]
        public HttpResponseMessage Add(DonorDTO obj)
        {
            var data = DonorService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
