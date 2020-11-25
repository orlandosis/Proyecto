using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class Factura
    {

        public int id { get; set; }
        public int Codigo_Factura { get; set; }
        public string No_Contador { get; set; }

        public string Mes_Factura { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public int Lectura_Acterior { get; set; }
        public int Lectura_Actual { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public int Total_Pago { get; set; }

    }
}
