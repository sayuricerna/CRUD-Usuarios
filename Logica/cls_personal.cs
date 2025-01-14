using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.Data;
using System.Data.SqlClient;
using _01_Mi_Primera_Vez.Datos;
using System.Globalization;
namespace _01_Mi_Primera_Vez.Logica
{
    public class cls_personal
    {
        private readonly conexion cn = new conexion();
        public string Insertar(dto_personal Personal)
        {
            using (var conexion = cn.obtenerConexion())
            {
                //Personal IdPersonal Cedula Nombre Cargo decimal:Sueldo IdPais Detalle
                string cadena1 = "INSERT INTO Personal (Cedula, Nombre, Cargo, Sueldo, IdPais) values('" +
                    Personal.Cedula + "','" +
                    Personal.Nombre + "','" +
                    Personal.Cargo + "'," +
                    Personal.Sueldo + "," +
                    Personal.IdPais + ")";
                using (var comando = new SqlCommand(cadena1, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }
        public List<dto_personal> todos()
        {
            var listapersonal = new List<dto_personal>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT IdPersonal, Cedula, Nombre, Cargo, Sueldo, Paises.IdPais, Paises.Detalle " +
                                "FROM Personal INNER JOIN Paises ON Paises.IdPais = Personal.IdPais";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var personal = new dto_personal
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                Cedula = lector["Cedula"].ToString(),
                                Nombre = lector["Nombre"].ToString(),
                                Cargo = lector["Cargo"].ToString(),
                                Sueldo = Convert.ToDecimal(lector["Sueldo"]),
                                IdPais = (int)lector["IdPais"],
                                Detalle = lector["Detalle"].ToString()
                            };
                            listapersonal.Add(personal);
                        }
                    }
                }
            }

            return listapersonal;
        }
        public dto_personal uno(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "select * from personal where IdPersonal=" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        var personal = new dto_personal
                        {
                            IdPersonal = (int)lector["IdPersonal"],
                            Cedula = lector["cedula"].ToString(),
                            Nombre = lector["nombre"].ToString(),
                            Cargo = lector["cargo"].ToString(),
                            Sueldo = (decimal)lector["sueldo"],
                            IdPais = (int)lector["idPais"],
                        };
                        return personal;
                    }
                }
            }
        }
        public dto_personal uno(string cedula)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"select * from personal where cedula='{cedula}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var personal = new dto_personal
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                Cedula = lector["cedula"].ToString(),
                                Nombre = lector["nombre"].ToString(),
                                Cargo = lector["cargo"].ToString(),
                                Sueldo = (decimal)lector["sueldo"],
                                IdPais = (int)lector["idPais"],
                            };
                            return personal;
                        }
                        else
                        {
                            return new dto_personal();
                        }
                    }
                }
            }
        }
        public string actualizar(dto_personal personal)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "update Personal set " +
                    $"cargo='{personal.Cargo}', cedula='{personal.Cedula}'," +
                    $"idPais={personal.IdPais},nombre='{personal.Nombre}'," +
                    $"sueldo={personal.Sueldo} where IdPersonal={personal.IdPersonal}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }
        public bool duplicadoCedula(string cedula)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"select count(*) as repetidos from personal where cedula='{cedula}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        if ((int)lector["repetidos"] > 0)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                }
            }
        }
        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"delete from personal where IdPersonal={id}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
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
        public List<dto_personal> buscador(string texto)
        {
            List<dto_personal> listapersonal = new List<dto_personal>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT IdPersonal, Cedula, Nombre, Cargo, Sueldo, Paises.IdPais, Paises.Detalle " +
                    "FROM Personal inner join Paises on Paises.IdPais = Personal.IdPais " +
                    $"where Nombre like '%{texto}%'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var personal = new dto_personal
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                Cedula = lector["Cedula"].ToString(),
                                Nombre = lector["Nombre"].ToString(),
                                Cargo = lector["Cargo"].ToString(),
                                Sueldo = (decimal)lector["Sueldo"],
                                Detalle = lector["Detalle"].ToString()
                            };
                            listapersonal.Add(personal);
                        }
                    }
                }
            }
            return listapersonal;
        }  
    }
}
