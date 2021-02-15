using System;

namespace DigitalWareServices.Models
{
    public class FacturaProductoModel
    {
        public int Id { get; set; }
        public int? FacturaId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }
        public double? ValorTotal { get; set; }

        //Complementarias
        public string ProductoNombre { get; set; }
    }
}
