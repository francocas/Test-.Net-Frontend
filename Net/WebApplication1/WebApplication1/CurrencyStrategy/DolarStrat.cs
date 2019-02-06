using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebApplication1.CurrencyStrategy
{
    public class DolarStrat : ICurrencyServiceStrat
    {
        public HttpResponseMessage Cotizacion(HttpRequestMessage request)
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetAsync("http://www.bancoprovincia.com.ar/Principal/Dolar").Result;
            }

        }
    }
}