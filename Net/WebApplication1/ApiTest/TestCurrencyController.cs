using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Hosting;
using WebApplication1.Controllers;

namespace ApiTest
{
    [TestClass]
    public class TestCurrencyController
    {
        [TestMethod]
        public void Get_ShouldReturnUnauthorized()
        {
            var controller = new CotizacionController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var result = controller.Get("Real");

            Assert.AreEqual(HttpStatusCode.Unauthorized, result.StatusCode);
        }

        [TestMethod]
        public void Get_ShouldReturnCurrency()
        {
            
            var controller = new CotizacionController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            var testCurrency = this.Cotizacion(controller.Request);
            var result = controller.Get("Dolar");

            
            Assert.AreEqual(testCurrency.StatusCode, result.StatusCode);
        }

        public HttpResponseMessage Cotizacion(HttpRequestMessage request)
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetAsync("http://www.bancoprovincia.com.ar/Principal/Dolar").Result;
            }

        }
    }
}
