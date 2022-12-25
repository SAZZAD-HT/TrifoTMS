using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Trif0TMS.Controllers
{
    [EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {

        [Route("api/Login")]
        [HttpPost]
        public HttpResponseMessage LoG(LoginDTO login)
        {
            try
            {
                if (login == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Email & Password is not provided");
                }
                if (ModelState.IsValid)
                {
                    var data = AuthService.Authenticate(login.Email, login.Password);

                    if (data != null)
                    {         
                        return Request.CreateResponse(HttpStatusCode.Accepted, data);
                    }
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Email or password is invalid");
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Logout/{token}")]
        public HttpResponseMessage Logout(string token)
        {
            if(token==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Token is not provided");
            }
            var data=AuthService.logout(token);
            if(data!=null)
            {
                return Request.CreateResponse(HttpStatusCode.Accepted, data);
            }
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "Token is invalid");
        }
    }
}
