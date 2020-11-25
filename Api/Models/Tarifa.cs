using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Tarifa
    {
        public int id { get; set; }
        public string Tipo_Tarifa { get; set; }
        public Double Precio { get; set; }

    }
}
