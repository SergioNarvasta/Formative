using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DTipoDeUsuario
    {
        SqlConnection oSqlConnection;
        SqlDataReader oSqlDataReader;
        
        public List<tipoDeUsuario> obtenerDatosEnList()
        {
            tipoDeUsuario oDTipoDeUsuario;
            List<tipoDeUsuario> oListDTipoDeUsuario = new List<tipoDeUsuario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                String sentencia = "Select * from tipoDeUsuario";
                SqlCommand oSqlCommand = new SqlCommand(sentencia, oSqlConnection);
                oSqlDataReader = oSqlCommand.ExecuteReader();
                while (oSqlDataReader.Read())
                {
                    oDTipoDeUsuario = new tipoDeUsuario();
                    oDTipoDeUsuario.setTipoDeUsuario_id((int)oSqlDataReader["tipoDeUsuario_id"]);
                    oDTipoDeUsuario.setNombreDeTipoDeUsuarios((String)oSqlDataReader["nombreDeTipoDeUsuario"]);
                    oListDTipoDeUsuario.Add(oDTipoDeUsuario);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDTipoDeUsuario;
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error ...!!!" + e);
                return null;
            }
        }

        public tipoDeUsuario buscarRegistro(int busqueda)
        {
            try
            {
                tipoDeUsuario oTipoDeUsuario;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("consultarTipoDeUsuario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@tipoDeUsuario_id", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oTipoDeUsuario = new tipoDeUsuario();
                    oTipoDeUsuario.tipoDeUsuario_id = (int)oSqlDataReader["tipoDeUsuario_id"];

                    oTipoDeUsuario.nombreDeTipoDeUsuario = ((String)oSqlDataReader["nombreDeTipoDeUsuario"]);
                   
                    oSqlDataReader.Close();

                    return oTipoDeUsuario;

                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error....!!!" + ex.Message);
                return null;
            }
        }

        public tipoDeUsuario consultartipoDeUsuarioxNombres(String busqueda)
        {
            try
            {
                tipoDeUsuario oDtipoDeUsuario;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarTipoDeUsuarioPorNombre", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@tipoDeUsuario", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDtipoDeUsuario = new tipoDeUsuario();
                    oDtipoDeUsuario.tipoDeUsuario_id = ((int)oSqlDataReader["tipoDeUsuario_id"]);
                    oDtipoDeUsuario.nombreDeTipoDeUsuario = ((String)oSqlDataReader["nombreDeTipoDeUsuario"]);
                    oSqlDataReader.Close();
                    return oDtipoDeUsuario;


                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error....!!!" + ex.Message);
                return null;
            }
        }

    }
}
