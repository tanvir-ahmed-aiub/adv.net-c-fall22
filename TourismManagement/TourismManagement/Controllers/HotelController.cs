using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TourismManagement.Auth;

namespace TourismManagement.Controllers
{
    [EnableCors("*","*","*")]
    public class HotelController : ApiController
    {
        [Logged]
        [Route("api/hotels")]
        public HttpResponseMessage Get() {
            try
            {
                var data = HotelService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data); 
            }
            catch (Exception ex) { 
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);  
            }
        }
        [Route("api/hotels/add")]
        [HttpPost]
        public HttpResponseMessage Add(HotelDTO hotel)
        {
            try
            {
                var data = HotelService.Add(hotel);
                if(data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { }); 
            }
            catch (Exception ex) {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        
    }
}
