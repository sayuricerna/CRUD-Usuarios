using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    //Asistencia IdAsistencia IdPersonal Cedula FechaRegistro
    internal class dto_asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdPersonal { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
