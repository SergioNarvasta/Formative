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
  public  class DSucursal
    {
        SqlConnection oSqlConnection;
        SqlDataReader oSqlDataReader;

        public List<Sucursal> obtenerDatosEnLista()
        {
            List<Sucursal> oListDSucursal = new List<Sucursal>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("listarSucursal", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Sucursal oSucursal;

                while (oSqlDataReader.Read())
                {
                    oSucursal = new Sucursal();
                    oSucursal.idSucursal = (String)oSqlDataReader["idSucursal"];
                    oSucursal.nombre = (String)oSqlDataReader["nombre"];
                    oSucursal.idUbigeo = (int)oSqlDataReader["idUbigeo"];
                    oSucursal.direccion = (String)oSqlDataReader["direccion"];
                    oSucursal.imagen = (byte[])oSqlDataReader["imagen"];
                    oSucursal.telefono = (int)oSqlDataReader["telefono"];
                    oListDSucursal.Add(oSucursal);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDSucursal;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
    }
}
