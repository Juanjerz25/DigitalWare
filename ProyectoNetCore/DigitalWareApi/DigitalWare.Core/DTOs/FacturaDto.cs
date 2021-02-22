using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWare.Core.DTOs
{
    public class FacturaDto
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public double? ValorTotal { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
