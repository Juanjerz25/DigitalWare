using System;

namespace DigitalWareServices.Models
{
    public class FacturaModel
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public double? ValorTotal { get; set; }
        public DateTime? Fecha { get; set; }

        //Propiedades Complementarias
        public string ClienteNombre { get; set; }
    }
}
