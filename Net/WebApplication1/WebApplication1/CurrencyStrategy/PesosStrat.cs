using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebApplication1.CurrencyStrategy
{
    public class PesosStrat : ICurrencyServiceStrat
    {
        public HttpResponseMessage Cotizacion(HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Unauthorized, "No está autorizado");
        }
    }
}