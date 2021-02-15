
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
    [Route("api/Producto/{action}", Name = "Producto")]
    public class ProductoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ObtenerProductos()
        {
            var response = ProductoServices.ObtenerProductos();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearProducto([FromBody] ProductoModel request)
        {
            var response = ProductoServices.CrearProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EditarProducto([FromBody] ProductoModel request)
        {
            var response = ProductoServices.EditarProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EliminarProducto([FromBody] ProductoModel request)
        {
            var response = ProductoServices.EliminarProducto(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

    }
}
