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
   public class DDetalleIngresos
    {
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        public Boolean registrarDetalleIngresos(DetalleIngresos oDetalleIngresos)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registraDetalleIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idingreso", oDetalleIngresos.idIngreso));
                oSqlCommand.Parameters.Add(new SqlParameter("@idproducto",oDetalleIngresos. idproducto));
                oSqlCommand.Parameters.Add(new SqlParameter("@stock_actual", oDetalleIngresos.stock_inicial));
                oSqlCommand.Parameters.Add(new SqlParameter("@PCompra", oDetalleIngresos.precioCompra));
                oSqlCommand.Parameters.Add(new SqlParameter("@fProduccion", oDetalleIngresos.fechaProduccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@fVencimiento", oDetalleIngresos.fechaVencimiento));
                oSqlCommand.Parameters.Add(new SqlParameter("@igv", oDetalleIngresos.igv));
                oSqlCommand.Parameters.Add(new SqlParameter("@subtotal", oDetalleIngresos.Subtotal));
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


        public List<DetalleIngresos> obtenerDatosEnLista(int buscar)
        {
            List<DetalleIngresos> oListDIngresos = new List<DetalleIngresos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarDetalleIngreso", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idIngreso", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                DetalleIngresos oIngresos;

                while (oSqlDataReader.Read())
                {
                    oIngresos = new DetalleIngresos();

                    oIngresos.idDetalle=(int)oSqlDataReader["idDetalleIngreso"];
                    oIngresos.idIngreso = (int)oSqlDataReader["idIngreso"];
                    oIngresos.stock_inicial=(int)oSqlDataReader["stock_inicial"];
                    oIngresos.descripcion = (String)oSqlDataReader["Nombre"];
                    oIngresos.precioCompra=(Decimal)oSqlDataReader["precioCompra"];
                    oIngresos.Subtotal=(Decimal)oSqlDataReader["subTotal"];
                    oIngresos.idproducto=(int)oSqlDataReader["IdProducto"];
                    oIngresos.igv=(Decimal)oSqlDataReader["igv"];
                    oIngresos.fechaProduccion=(DateTime)oSqlDataReader["fecha_produccion"];
                    oIngresos.fechaVencimiento=(DateTime)oSqlDataReader["fecha_vencimiento"];
                    

                    oListDIngresos.Add(oIngresos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDIngresos;
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
