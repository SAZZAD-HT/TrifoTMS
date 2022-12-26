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
    public class PoliceController : ApiController
    {
        [HttpPost]
        [Route("api/police/add")]
        public HttpResponseMessage Register(PoliceDTO p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = PoliceService.Add(p);
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
        [Route("api/police/list")]
        public HttpResponseMessage GetAllPolice()
        {
            try
            {
                var data = PoliceService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/police/{id}")]
        public HttpResponseMessage GetSinglePolice(int id)
        {
            try
            {
                var data = PoliceService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/police/delete/{id}")]
        public HttpResponseMessage DeletePolice(int id)
        {
            try
            {
                var data = PoliceService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/police/update")]
        public HttpResponseMessage UpdatePolice(PoliceDTO policeDTO)
        {
            try
            {
                var data = PoliceService.Update(policeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/police/{uname}")]
        public HttpResponseMessage GetSinglepoliceByuname(string uname)
        {
            try
            {
                var data = PoliceService.GetChecker(uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/police/Case/Add")]
        public HttpResponseMessage ADD(CaseDTO c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = CaseService.Add(c);
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
        [Route("api/police/Caselist")]
        public HttpResponseMessage GetAllCase()
        {
            try
            {
                var data = CaseService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/case/{id}")]
        public HttpResponseMessage GetSingleCase(int id)
        {
            try
            {
                var data = CaseService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/case/remove/{id}")]
        public HttpResponseMessage DeleteCase(int id)
        {
            try
            {
                var data = CaseService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/case/update")]
        public HttpResponseMessage UpdateCase(CaseDTO caseDTO)
        {
            try
            {
                var data = CaseService.Update(caseDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/police/{id}/case")]
        public HttpResponseMessage GetwithCase(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PoliceService.Getwithcase(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}