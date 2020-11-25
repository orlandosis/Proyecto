using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Empleados
    {
       
            public int id { get; set; }
            public string Codigo { get; set; }
            public string Nombre{ get; set; }

            public string Apellido { get; set; }
            public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contaseña { get; set; }


    }
}
