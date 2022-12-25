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
    public class ApplicantController : ApiController
    {
        [HttpPost]
        [Route("api/applicant/add")]
        public HttpResponseMessage Register(AdminApplicantDTO adminapplicant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = AdminApplicantService.Add(adminapplicant);
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
        [Route("api/applicant/list")]
        public HttpResponseMessage GetAllApplicants()
        {
            try
            {
                var data = AdminApplicantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/applicant/{id}")]
        public HttpResponseMessage GetSingleApplicant(int id)
        {
            try
            {
                var data = AdminApplicantService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/applicant/delete/{id}")]
        public HttpResponseMessage DeleteApplicant(int id)
        {
            try
            {
                var data = AdminApplicantService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/applicant/update")]
        public HttpResponseMessage UpdateApplicant(AdminApplicantDTO adminapplicant)
        {
            try
            {
                var data = AdminApplicantService.Update(adminapplicant);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/allapplicant/count")]
        public HttpResponseMessage AllApplicantsCount()
        {
            try
            {
                var data = AdminApplicantService.Get().Count;
                List<int> numberList = new List<int>() { data };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/applicant/{email}")]
        public HttpResponseMessage GetSingleApplicantByEmail(string eamil)
        {
            try
            {
                var data = AdminApplicantService.GetChecker(eamil);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}