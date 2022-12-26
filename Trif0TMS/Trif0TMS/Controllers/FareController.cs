using BLL.DTOs;
using BLL.Services;
using System;
using Trif0TMS.AuthFilter;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Trif0TMS.Controllers
{
    [EnableCors("*", "*", "*")]
    [Logged]
    public class FareController : ApiController
    {
        [Route("api/Fare")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = FareService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //[Route("api/Fare/add")]
        //[HttpPost]
        //public HttpResponseMessage Add(StartEnd Admin)
        //{
        //    try
        //    {
        //        var data = FareServices.Add(Admin);
        //        if (data != null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, data);
        //        }
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }
        //}

        //[Route("api/Admin/{id}")]
        //[HttpGet]
        //public HttpResponseMessage Get(int id)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, FareServices.Get(id));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }
        //}
    }
}