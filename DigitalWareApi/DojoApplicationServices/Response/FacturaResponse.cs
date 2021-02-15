using DigitalWareServices.Models;
using System.Collections.Generic;

namespace DigitalWareServices.Response
{
    public sealed class FacturasResponse : BaseGatewayResponse
    {
        public List<FacturaModel> Factura { get; set; }

        public FacturasResponse(List<FacturaModel> facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Factura = facturaModel;
        }
    }

    public sealed class FacturaResponse : BaseGatewayResponse
    {
        public FacturaModel Factura { get; set; }

        public FacturaResponse(FacturaModel facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Factura = facturaModel;
        }
    }

    public sealed class FacturaProductosResponse : BaseGatewayResponse
    {
        public List<FacturaProductoModel> FacturaProducto { get; set; }

        public FacturaProductosResponse(List<FacturaProductoModel> facturaProductoModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            FacturaProducto = facturaProductoModel;
        }
    }

    public sealed class FacturaProductoResponse : BaseGatewayResponse
    {
        public FacturaProductoModel FacturaProducto { get; set; }

        public FacturaProductoResponse(FacturaProductoModel facturaProductoModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            FacturaProducto = facturaProductoModel;
        }
    }
}
