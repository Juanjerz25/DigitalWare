
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

        [HttpPost]
        public HttpResponseMessage CrearFactura([FromBody] FacturaModel request)
        {
            var response = FacturaServices.CrearFactura(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EditarFactura([FromBody] FacturaModel request)
        {
            var response = FacturaServices.EditarFactura(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EliminarFactura([FromBody] FacturaModel request)
        {
            var response = FacturaServices.EliminarFactura(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearFacturaProducto([FromBody] FacturaModel request)
        {
            var response = FacturaServices.CrearFacturaProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EditarFacturaProducto([FromBody] FacturaModel request)
        {
            var response = FacturaServices.EditarFacturaProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EliminarFacturaProducto([FromBody] FacturaModel request)
        {
            var response = FacturaServices.EliminarFacturaProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }



    }
}
