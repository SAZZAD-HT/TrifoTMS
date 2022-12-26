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
    public class AdminController : ApiController
    {
        [HttpPost]
        [Route("api/admin/add")]
        public HttpResponseMessage Register(AdminDTO admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = AdminService.Add(admin);
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
        [Route("api/admin/list")]
        public HttpResponseMessage GetAllAdmins()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage GetSingleAdmin(int id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/admin/delete/{id}")]
        public HttpResponseMessage DeleteAdmin(int id)
        {
            try
            {
                var data = AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/admin/update")]
        public HttpResponseMessage UpdateAdmin(AdminDTO admin)
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
        [Route("api/alladmin/list/count")]
        public HttpResponseMessage AllAdminsCount()
        {
            try
            {
                var data3=AdminService.Get().Count;
                List<int> numberList = new List<int>() { data3 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/admin/get/{email}")]
        public HttpResponseMessage GetSingleAdminByEmail(string eamil)
        {
            try
            {
                var data = AdminService.GetChecker(eamil);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
