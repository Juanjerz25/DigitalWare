using System;
using System.Collections.Generic;

namespace DigitalWare.Core.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
