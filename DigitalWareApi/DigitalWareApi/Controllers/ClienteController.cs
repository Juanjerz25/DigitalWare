
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
    [Route("api/Cliente/{action}", Name = "Cliente")]
    public class ClienteController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ObtenerClientes()
        {
            var response = ClienteServices.ObtenerClientes();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearCliente([FromBody] ClienteModel request)
        {
            var response = ClienteServices.CrearCliente(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EditarCliente([FromBody] ClienteModel request)
        {
            var response = ClienteServices.EditarCliente(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage EliminarCliente([FromBody] ClienteModel request)
        {
            var response = ClienteServices.EliminarCliente(request);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

    }
}
