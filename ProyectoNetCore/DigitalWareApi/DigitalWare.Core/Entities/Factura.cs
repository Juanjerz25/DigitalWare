using System;
using System.Collections.Generic;

namespace DigitalWare.Core.Entities
{
    public partial class Factura
    {
        public Factura()
        {
            FacturaProducto = new HashSet<FacturaProducto>();
        }

        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public double? ValorTotal { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<FacturaProducto> FacturaProducto { get; set; }
    }
}
