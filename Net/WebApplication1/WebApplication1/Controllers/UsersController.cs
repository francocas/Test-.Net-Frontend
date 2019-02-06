using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;
using Modelos;
using BL;
namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {


        [ResponseType(typeof(IEnumerable<Users>))]
        public IEnumerable<Users> GetAll()
        {
            UsersBl usersBl = new UsersBl();
            return usersBl.GetAllUsers();
        }

        [ResponseType(typeof(Users))]
        [HttpGet]
        [ActionName("GetUserById")]
        public Users GetUser(int id)
        {
            UsersBl usersBl = new UsersBl();
            return usersBl.GetUserById(id);
        }
        
        [HttpPost]
        [ActionName("InsertUser")]
        public HttpResponseMessage InsertUser([FromBody]Users user)
        {
            UsersBl usersBl = new UsersBl();
            if (!usersBl.AddUser(user))
            {
                var message = string.Format("Product with id = {0} not found", user.id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPut]
        [ActionName("UpdateUser")]
        public HttpResponseMessage UpdateUser([FromBody]Users user)
        {
            UsersBl usersBl = new UsersBl();
            if(!usersBl.UpdateUser(user))
            {
                var message = string.Format("Product with id = {0} not found", user.id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }


        [ActionName("DeleteUserById")]
        public HttpResponseMessage Delete(int id)
        {
            UsersBl usersBl = new UsersBl();
            if(!usersBl.DeleteUserById(id))
            {
                var message = string.Format("Product with id = {0} not found", id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}
