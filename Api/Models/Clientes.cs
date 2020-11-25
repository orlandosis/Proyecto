using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Clientes
    {
        //j
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo{ get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Tipo_Medidor { get; set; }
        public string Observaciones{ get; set; }
        public string Ubicacion_Geografica { get; set; }
        public string Alerta { get; set; }
        public string Codigo_Contador { get; set; }

    }
}
