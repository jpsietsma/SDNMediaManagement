using Newtonsoft.Json;
using SDNetAPI.Models;
using SDNMediaModels.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SDNetAPI.Controllers
{
    [RoutePrefix("api/Login")]
    public class MobileLoginController : ApiController
    {
        MobileLoginEntities db = new MobileLoginEntities();  

        [HttpPost]
        [Route("Register")]
        // POST: api/Login  
        public HttpResponseMessage Xamarin_reg(string username, string password)
        {
            MobileLogin login = new MobileLogin();
            login.UserName = username;
            login.Password = password;
            db.MobileLogins.Add(login);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Accepted, "Successfully Created");
        }

        [HttpGet]
        [Route("LogIn")]
        // GET: api/Login/5  
        public HttpResponseMessage Xamarin_login(string username, string password)
        {
            var user = db.MobileLogins.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            if (user == null)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Please Enter valid UserName and Password");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Accepted, "Success");
            }
        }
        
    }
}
