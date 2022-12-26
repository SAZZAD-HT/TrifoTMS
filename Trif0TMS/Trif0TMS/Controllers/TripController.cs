using BLL.Services;
using System;
using Trif0TMS.AuthFilter;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.DTOs;

namespace Trif0TMS.Controllers
{
    [EnableCors("*", "*", "*")]
    [Logged]
    public class TripController : ApiController
    {
        [HttpPost]
        [Route("api/Trip/add")]
        public HttpResponseMessage Register(TripDTO trip)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = TripService.Add(trip);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/Trip/list")]
        public HttpResponseMessage GetTripList()
        {
            try
            {
                var data = TripService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/Trip/{id}")]
        public HttpResponseMessage GetSingleTrip(int id)
        {
            try
            {
                var data = TripService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/Trip/delete/{id}")]
        public HttpResponseMessage DeleteTrip(int id)
        {
            try
            {
                var data = TripService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Trip/update")]
        public HttpResponseMessage UpdateTrip(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Update(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/allTrip/list/count")]
        public HttpResponseMessage AllAdminsCount()
        {
            try
            {
                var data3 = TripService.Get().Count;
                List<int> numberList = new List<int>() { data3 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}