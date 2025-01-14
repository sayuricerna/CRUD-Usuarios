using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    public class dto_personal
    {
        //Personal IdPersonal Cedula Nombre Cargo decimal:Sueldo IdPais Detalle
        public int IdPersonal { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        public int IdPais { get; set; }
        public string Detalle { get; set; } = null;

    }
}
