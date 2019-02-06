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
        public void InsertUser([FromBody]Users user)
        {
            UsersBl usersBl = new UsersBl();
            usersBl.AddUser(user);
        }

        [HttpPut]
        [ActionName("UpdateUser")]
        public void UpdateUser([FromBody]Users user)
        {
            UsersBl usersBl = new UsersBl();
            usersBl.UpdateUser(user);
        }


        [ActionName("DeleteUserById")]
        public void Delete(int id)
        {
            UsersBl usersBl = new UsersBl();
            usersBl.DeleteUserById(id);
        }
    }
}
