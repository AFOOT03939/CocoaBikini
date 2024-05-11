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
            List<Permisos> lista = new List<Permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.ID_rol, p.nom_perm from Permisos p");
                    query.AppendLine("inner join Rol r on r.ID_rol = p.ID_rol");
                    query.AppendLine("inner join Usuarios u on u.ID_rol = r.ID_rol");
                    query.AppendLine("where u.ID_us = @idusuario");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                oRol = new Rol() { IDrol = Convert.ToInt32(dr["ID_rol"]) },
                                nombre = dr["nom_perm"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Permisos>();
                }
            }
            return lista;
        }
    }
}
