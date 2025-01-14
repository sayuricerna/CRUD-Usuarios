using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Logica
{
    internal class cls_asistencia
    {
        private Datos.conexion cn = new Datos.conexion();
        public bool insertar(Datos.dto_asistencia dto_Asistencia)
        {
            var cls_personal = new cls_personal();
            var existencia = cls_personal.duplicadoCedula(dto_Asistencia.Cedula);
            if (!existencia)
            {
                MessageBox.Show("No existe el usuario en la base de datos");
                return false;
            }
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "insert into Asistencia(idPersonal, cedula) values(@idPersonal, @cedula)";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@idPersonal", dto_Asistencia.IdPersonal);
                    comando.Parameters.AddWithValue("@cedula", dto_Asistencia.Cedula);
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
