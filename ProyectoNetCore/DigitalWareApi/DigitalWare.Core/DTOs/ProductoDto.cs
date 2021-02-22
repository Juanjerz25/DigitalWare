using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWare.Core.DTOs
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double? Costo { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? Cantidad { get; set; }
    }
}
