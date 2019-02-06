using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.CurrencyStrategy
{
    interface ICurrencyServiceStrat
    {
        HttpResponseMessage Cotizacion(HttpRequestMessage request);
    }
}
