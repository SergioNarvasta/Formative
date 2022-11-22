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
   public class DetalleIngresos
    {
        public int idDetalle { get;set;}
       public int idIngreso { get; set; }
       public String descripcion { get; set; }
       public int idproducto { get; set; }
       public int stock_inicial { get; set; }
       public DateTime fechaProduccion { get;set;}
       public DateTime fechaVencimiento { get; set; }
       public Decimal igv { get; set; }
       public Decimal precioCompra { get; set; }
       //campo calculado 
       public Decimal Subtotal { get; set; }
       public Decimal Total { get; set; }

        public DetalleIngresos() {
           descripcion = "";
           stock_inicial = 0;
           idIngreso = 0;
           idproducto = 0;
           igv = 0;
           Subtotal = 0;
           precioCompra = 0;
           
       }
        public DetalleIngresos(int objIdIngreso, String objDescripcion,
            int objProducto,
           int objStock,DateTime ObjProduccion,
            DateTime ObjVencimiento, Decimal objIgv,
            Decimal objSubTotal, Decimal objPrecio)
        {
           idIngreso = objIdIngreso;
           descripcion = objDescripcion;
           idproducto = objProducto;
           stock_inicial = objStock;
           fechaProduccion = ObjProduccion;
           fechaVencimiento = ObjVencimiento;
           igv = objIgv;
           Subtotal = objSubTotal;
           precioCompra = objPrecio;
       }


        public void setSubTotal()
        {
            Subtotal = (stock_inicial * Convert.ToDecimal(precioCompra));
        }
        public void setSubTotal_1(Decimal subtotal)
        {
            if (subtotal == 0)
            {
                this.Subtotal = 0;
            }
            else 
            {
                this.Subtotal = Math.Round(this.Subtotal + subtotal,2);
            }
        }
        
        public void setIgv()
        {
            this.igv = Math.Round(Convert.ToDecimal(Subtotal)*Convert.ToDecimal(0.18),2);
        }

        public void setTotal()
        {
            this.Total = Math.Round(Subtotal+igv,2);
        }
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        public Boolean registrarDetalleIngresos()
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registraDetalleIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idingreso", idIngreso));
                oSqlCommand.Parameters.Add(new SqlParameter("@idproducto", idproducto));
                oSqlCommand.Parameters.Add(new SqlParameter("@stock_actual", stock_inicial));
                oSqlCommand.Parameters.Add(new SqlParameter("@PCompra", precioCompra));
                oSqlCommand.Parameters.Add(new SqlParameter("@fProduccion", fechaProduccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@fVencimiento", fechaVencimiento));
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
