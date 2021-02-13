using System;

namespace DigitalWareServices.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double? Costo { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? Cantidad { get; set; }
    }
}
