using DigitalWareServices.Models;
using System.Collections.Generic;

namespace DigitalWareServices.Response
{
    public sealed class ClientesResponse : BaseGatewayResponse
    {
        public List<ClienteModel> Cliente { get; set; }

        public ClientesResponse(List<ClienteModel> facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Cliente = facturaModel;
        }
    }

    public sealed class ClienteResponse : BaseGatewayResponse
    {
        public ClienteModel Cliente { get; set; }

        public ClienteResponse(ClienteModel facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Cliente = facturaModel;
        }
    }
}
