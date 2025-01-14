using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    //se cambio internal class dto_pais a public por el metodo leer de cls_pais
    public class dto_pais
    {
        //Paises IdPais Detalle
        public int IdPais { get; set; }
        public string Detalle { get; set; }
    }
}
