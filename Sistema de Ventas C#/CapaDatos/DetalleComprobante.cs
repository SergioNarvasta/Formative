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
   public class DetalleComprobante
    {
       public int idDetalle { get;set;}
       public String descripcion { get; set; }
       public int idproducto { get; set; }
       public int idcomprobante { get; set; }
       public int cantidad { get;set;}
       public Decimal precioVenta { get; set; }
       public Decimal igv { get; set; }
       //campo calculado 
       public Decimal Subtotal { get; set; }
       public Decimal Total { get; set; }
        public DetalleComprobante() {
           cantidad = 0;
           descripcion = "";
           precioVenta = 0;
           idcomprobante = 0;
           idproducto = 0;
           igv = 0;
           Subtotal = 0;
       }
        public DetalleComprobante(int objIdVenta, int objCantidad, String objDescripcion, Decimal objPVenta,
           int objIdProducto, Decimal objIgv, Decimal objSubTotal){
           idcomprobante = objIdVenta;
           cantidad =objCantidad;
           descripcion = objDescripcion;
           precioVenta = objPVenta;
           idproducto = objIdProducto;
           igv = objIgv;
           Subtotal = objSubTotal;
       }


        public void setSubTotal()
        {
            Subtotal = (cantidad * Convert.ToDecimal(precioVenta));
        }

        public void setSubTotal_1(Decimal subtotal)
        {
            if (subtotal == 0)
            {
                this.Subtotal = 0;
            }
            else
            {
                this.Subtotal = Math.Round(this.Subtotal + subtotal, 2);
            }
        }

        public void setIgv()
        {
            this.igv = Math.Round(Convert.ToDecimal(Subtotal) * Convert.ToDecimal(0.18), 2);
        }

        public void setTotal()
        {
            this.Total = Math.Round(Subtotal + igv, 2);
        }
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        public Boolean registrarDetalleComprobante()
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registraDetalleComprobante", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idproducto", idproducto));
                oSqlCommand.Parameters.Add(new SqlParameter("@idcomprobante", idcomprobante));
                oSqlCommand.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                oSqlCommand.Parameters.Add(new SqlParameter("@preciounitario", precioVenta));
                oSqlCommand.Parameters.Add(new SqlParameter("@igv", igv));
                oSqlCommand.Parameters.Add(new SqlParameter("@subtotal", Subtotal));
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

    }
}
