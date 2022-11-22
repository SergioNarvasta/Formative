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
   public  class DTipoDePago
   {
       SqlConnection oSqlConnection;
       SqlDataReader oSqlDataReader;

       public List<TipoDePago> obtenerDatosEnLista()
       {
           List<TipoDePago> oListDTipoDePago = new List<TipoDePago>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("mostrarFormaPago", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               TipoDePago oTipoDePago;

               while (oSqlDataReader.Read())
               {
                   oTipoDePago = new TipoDePago();
                   oTipoDePago.idFormaPago = (int)oSqlDataReader["IdFormaDePago"];
                   oTipoDePago.nombreFormaPago = (String)oSqlDataReader["nombre"];
              
                   oListDTipoDePago.Add(oTipoDePago);
               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDTipoDePago;
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
