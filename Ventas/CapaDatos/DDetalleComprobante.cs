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
  public  class DDetalleComprobante
  {
      SqlConnection oSqlConnection = new SqlConnection();
      SqlDataReader oSqlDataReader;
      public Boolean registrarDetalleComprobante(DetalleComprobante oDetalleComprobante)
      {
          try
          {

              oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("registraDetalleComprobante", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@idproducto", oDetalleComprobante.idproducto));
              oSqlCommand.Parameters.Add(new SqlParameter("@idcomprobante", oDetalleComprobante.idcomprobante));
              oSqlCommand.Parameters.Add(new SqlParameter("@cantidad", oDetalleComprobante.cantidad));
              oSqlCommand.Parameters.Add(new SqlParameter("@preciounitario", oDetalleComprobante.precioVenta));
              oSqlCommand.Parameters.Add(new SqlParameter("@igv", oDetalleComprobante.igv));
              oSqlCommand.Parameters.Add(new SqlParameter("@subtotal",oDetalleComprobante.Subtotal));
             oSqlCommand.ExecuteNonQuery();
              oSqlConnection.Close();
              return true;
          }
          catch (System.Exception ex)
          {
              oSqlConnection.Close();
              MessageBox.Show("Error...!!!" + ex.Message);
              return false;
          }
      }
      
      
      public List<DetalleComprobante> obtenerDatosEnLista(int buscar)
      {
          List<DetalleComprobante> oListDComprobante = new List<DetalleComprobante>();
          try
          {
              oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("mostrarDetalleComprobante", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@idComprobante", buscar));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              DetalleComprobante oComprobante;

              while (oSqlDataReader.Read())
              {
                  oComprobante = new DetalleComprobante();

                  oComprobante.idDetalle = (int)oSqlDataReader["idDetalleComprobante"];
                  oComprobante.idproducto = (int)oSqlDataReader["idProducto"];
                  oComprobante.descripcion = (String)oSqlDataReader["Nombre"];
                  oComprobante.idcomprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.cantidad = (int)oSqlDataReader["Cantidad"];
                  oComprobante.precioVenta = (Decimal)oSqlDataReader["precioUnitario"];
                  oComprobante.igv = (Decimal)oSqlDataReader["igv"];
                  oComprobante.Subtotal = (Decimal)oSqlDataReader["subTotal"];
                 

                  oListDComprobante.Add(oComprobante);
              }
              oSqlDataReader.Close();
              oSqlConnection.Close();
              return oListDComprobante;
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
