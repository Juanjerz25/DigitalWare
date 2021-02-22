using System;
using System.Collections.Generic;

namespace DigitalWare.Core.Entities
{
    public partial class FacturaProducto
    {
        public int Id { get; set; }
        public int? FacturaId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }
        public double? ValorTotal { get; set; }

        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
