using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.CurrencyStrategy;

namespace WebApplication1.Controllers
{
    public class CotizacionController : ApiController
    {
        // GET: api/Cotizacion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cotizacion/5
        public HttpResponseMessage Get(string Currency)
        {
            HttpResponseMessage retorno = new HttpResponseMessage();
            ICurrencyServiceStrat currencyService;
            switch(Currency.ToLower())
            {
                case "dolar":
                    currencyService = new DolarStrat();
                    retorno = currencyService.Cotizacion(Request);
                    break;
                case "pesos":
                    currencyService = new PesosStrat();
                    retorno = currencyService.Cotizacion(Request);
                    break;
                case "real":
                    currencyService = new RealStrat();
                    retorno = currencyService.Cotizacion(Request);
                    break;
            }
            return retorno;
        }

        // POST: api/Cotizacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cotizacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cotizacion/5
        public void Delete(int id)
        {
        }
    }
}
