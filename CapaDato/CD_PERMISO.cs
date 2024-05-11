using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CD_PERMISO
    {
        public List<Permisos> Listar(int idusuario)
        {
            List<permisos> lista = new List<permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select ID_us,fecha_us,password_us,nom_us,correo_us, numero_us from Usuarios";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IDUsuario = Convert.ToInt32(dr["ID_us"]),
                                fecha = dr["fecha_us"].ToString(),
                                password = dr["password_us"].ToString(),
                                Nombre = dr["nom_us"].ToString(),
                                correo = dr["correo_us"].ToString(),
                                numero = dr["numero_us"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }



    }
}
