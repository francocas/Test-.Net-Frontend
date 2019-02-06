using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelos;
using WebApplication1.Controllers;
using System.Web.Http.Results;
using System.Net;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http;

namespace ApiTest
{
    [TestClass]
    public class TestUsersController
    {
        [TestMethod]
        public void GetAllUsers_ShouldReturnAllUsers()
        {
            var testUsers = this.GetAllUsers();
            var controller = new UsersController();
            var result = controller.GetAll() as List<Users>;

            Assert.AreEqual(testUsers.Count, result.Count);
        }

        [TestMethod]
        public void GetUserById_ShouldReturnCorrectUser()
        {
            var testUsers = this.GetAllUsers();
            var lastId = testUsers[testUsers.Count - 1].id;
            var controller = new UsersController();
            var result = controller.GetUser(lastId);

            Assert.IsNotNull(result);
            Assert.AreEqual(testUsers[testUsers.Count-1].email, result.email);
        }

        [TestMethod]
        public void GetUserById_ShouldNotFindUser()
        {
            var testUsers = this.GetAllUsers();
            var controller = new UsersController();
            var result = controller.GetUser(654);
            

        }

        [TestMethod]
        public void DeleteUserById_ShouldReturnNotFound()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.Delete(654);

            Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
        }

        [TestMethod]
        public void DeleteUserById_ShouldReturnTrue()
        {
            var testUsers = this.GetAllUsers();
            var lastId = testUsers[testUsers.Count - 1].id;
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.Delete(lastId);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void UpdateUserById_ShouldReturnNotFound()
        {
            var testUser = this.GetAllUsers()[0];
            testUser.id = 123;
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.UpdateUser(testUser);

            Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
        }

        [TestMethod]
        public void UpdateUserById_ShouldReturnTrue()
        {
            var testUsers = this.GetAllUsers();
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.UpdateUser(testUsers[testUsers.Count-1]);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void Insert_ShouldReturnTrue()
        {
            var testUsers = this.GetAllUsers();
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.InsertUser(testUsers[testUsers.Count - 1]);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        public List<Users> GetAllUsers()
        {
            return UsersDAL.GetAll();
        }
    }
}
