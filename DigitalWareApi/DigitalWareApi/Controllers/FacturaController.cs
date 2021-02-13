
using DigitalWareServices.Models;
using DigitalWareServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DigitalWareApi.Controllers
{
    [Route("api/Factura/{action}", Name = "Factura")]
    public class FacturaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ObtenerFacturas()
        {
            var response = FacturaServices.ObtenerFacturas();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage ObtenerFacturaProductos([FromBody] FacturaModel request)
        {
            var response = FacturaServices.ObtenerFacturaProductos(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }



    }
}
