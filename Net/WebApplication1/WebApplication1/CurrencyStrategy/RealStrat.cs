using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication1.CurrencyStrategy
{
    public class RealStrat : ICurrencyServiceStrat
    {
        public HttpResponseMessage Cotizacion(HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Unauthorized, "No está autorizado");
        }
    }
}
