using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Datos;

namespace _01_Mi_Primera_Vez.Logica
{
    internal class cls_usuario
    {
        private readonly conexion cn = new conexion();
        //Usuario IdUsuario NombreUsuario Contrasenia CreateAt ModifiedAt

        //insertar CREATE
        public string Insertar(dto_usuario Usuario)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena1 = "INSERT INTO Usuario (NombreUsuario, Contrasenia) values('" +
                    Usuario.NombreUsuario + "','" +
                    Usuario.Contrasenia + "')";
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


        //listar READ
        public List<dto_usuario> todos()
        {
            var listausuario = new List<dto_usuario>();
            using (var conexion = cn.obtenerConexion())
            {//IsUsuario, NombreUsuario, Contasenia, CreateAt, ModifiedAt
                string cadena = "SELECT * FROM Usuario";
                using (var comando = new SqlCommand(cadena, conexion)) 
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader()) 
                    {
                        while (lector.Read())
                        {
                            var usuario = new dto_usuario 
                            {
                                //Usuario IdUsuario NombreUsuario Contrasenia  CreateAt ModifiedAt
                                IdUsuario = (int)lector["IdUsuario"],
                                NombreUsuario = lector["NombreUsuario"].ToString(),
                                Contrasenia = lector["Contrasenia"].ToString(),
                                CreateAt = (DateTime)lector["CreateAt"],
                                ModifiedAt = (DateTime)lector["ModifiedAt"],
                            };
                            listausuario.Add(usuario);
                        }
                    }
                }
            }

            return listausuario;
        }


        //actualizar UPDATE
        public string actualizar(dto_usuario usuario)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "update Usuario set " +
                    $"NombreUsuario='{usuario.NombreUsuario}', Contrasenia='{usuario.Contrasenia}'," +
                    $"ModifiedAt=GETDATE() where IdUsuario={usuario.IdUsuario}";

                //$"ModifiedAt='{usuario.ModifiedAt.ToString("yyyy-MM-dd HH:mm:ss")}' where IdUsuario={usuario.IdUsuario}";

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
        //Eliminar DELETE
        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"delete from usuario where IdUsuario={id}";
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

        //buscar 
        public dto_usuario buscarPorId(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "select * from usuario where IdUsuario=" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        var usuario = new dto_usuario
                        {
                            IdUsuario = (int)lector["IdUsuario"],
                            NombreUsuario = lector["NombreUsuario"].ToString(),
                            Contrasenia = lector["Contrasenia"].ToString(),
                            ModifiedAt = (DateTime)lector["ModifiedAt"],
                            CreateAt = (DateTime)lector["CreateAt"],
                        };
                        return usuario;
                    }
                }
            }
        }
        public List<dto_usuario> buscador(string texto)
        {
            List<dto_usuario> listausuario = new List<dto_usuario>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Usuario" +
                    $"where NombreUsuario like '%{texto}%'";
                using (var comando = new SqlCommand(cadena, conexion)) 
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new dto_usuario
                            {
                                IdUsuario = (int)lector["IdUsuario"],
                                NombreUsuario = lector["NombreUsuario"].ToString(),
                                Contrasenia = lector["Contrasenia"].ToString(),
                                CreateAt = (DateTime)lector["CreateAt"],
                                ModifiedAt = (DateTime)lector["ModifiedAt"],
                            };
                            listausuario.Add(usuario);
                        }
                    }
                }
            }

            return listausuario;

        }


    }
}
