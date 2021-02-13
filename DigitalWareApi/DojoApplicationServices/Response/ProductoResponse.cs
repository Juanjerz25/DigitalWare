using DigitalWareServices.Models;
using System.Collections.Generic;

namespace DigitalWareServices.Response
{
    public sealed class ProductosResponse : BaseGatewayResponse
    {
        public List<ProductoModel> Producto { get; set; }

        public ProductosResponse(List<ProductoModel> facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Producto = facturaModel;
        }
    }

    public sealed class ProductoResponse : BaseGatewayResponse
    {
        public ProductoModel Producto { get; set; }

        public ProductoResponse(ProductoModel facturaModel, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Producto = facturaModel;
        }
    }
}
