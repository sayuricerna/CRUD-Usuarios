using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//necesito importar esta lib para hacer la conexion
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
namespace _01_Mi_Primera_Vez.Datos
{
    public class conexion
    {
        private readonly string varconexion = "Server=localhost\\SQLEXPRESS;Database=Asistencias;Trusted_Connection=True";
        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(varconexion);
        }
    }
}
