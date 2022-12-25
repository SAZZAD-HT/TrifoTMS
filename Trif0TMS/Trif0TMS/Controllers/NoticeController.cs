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
    public class NoticeController : ApiController
    {
        [HttpPost]
        [Route("api/notice/create")]
        public HttpResponseMessage Register(NoticeDTO noticeDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = NoticeService.Add(noticeDTO);
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
        [Route("api/notice/list")]
        public HttpResponseMessage GetAllNotices()
        {
            try
            {
                var data = NoticeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/notice/{id}")]
        public HttpResponseMessage GetSingleNotice(int id)
        {
            try
            {
                var data = NoticeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/notice/delete/{id}")]
        public HttpResponseMessage DeleteNotice(int id)
        {
            try
            {
                var data = NoticeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/notice/update")]
        public HttpResponseMessage UpdateNotice(NoticeDTO noticeDTO)
        {
            try
            {
                var data = NoticeService.Update(noticeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}