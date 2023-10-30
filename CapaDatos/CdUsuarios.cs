using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CdUsuarios
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista= new List<Usuario>();

            try
            {
                using (SqlConnection oconexicon = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdUsuario,Nombre,Apellidos,Correo,Reestablecer,Activo from USUARIO";
                    SqlCommand cmd = new SqlCommand(query,oconexicon);
                    cmd.CommandType=System.Data.CommandType.Text;

                    oconexicon.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read()) { 
                        }
                    }
                    {

                    }
                }



            }
            catch (Exception)
            {

                throw;
            }



            return lista;
        }
    }
}
