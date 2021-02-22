using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWare.Core.DTOs
{
    public class FacturaProductoDto
    {
        public int Id { get; set; }
        public int? FacturaId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }
        public double? ValorTotal { get; set; }
    }
}
