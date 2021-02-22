using System;
using System.Collections.Generic;

namespace DigitalWare.Core.Entities
{
    public partial class Producto
    {
        public Producto()
        {
            FacturaProducto = new HashSet<FacturaProducto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double? Costo { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? Cantidad { get; set; }

        public virtual ICollection<FacturaProducto> FacturaProducto { get; set; }
    }
}
