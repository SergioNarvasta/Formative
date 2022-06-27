using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Venta
   {
       public int IdVenta { get; set; }
       public int Cantidad { get; set; }
       public String Descripcion { get; set; }
       public Decimal PrecioVenta { get; set; }
       public int IdProducto { get; set; }
       public Decimal Igv { get; set; }
       public Decimal SubTotal { get; set; }


       public Venta() {
           Cantidad = 0;
           Descripcion = "";
           PrecioVenta = 0;
           IdVenta = 0;
           IdProducto = 0;
           Igv = 0;
           SubTotal = 0;
       }
       public Venta(int objIdVenta,int objCantidad,String objDescripcion,Decimal objPVenta,
           int objIdProducto, Decimal objIgv, Decimal objSubTotal){
           IdVenta = objIdVenta;
           Cantidad =objCantidad;
           Descripcion = objDescripcion;
           PrecioVenta = objPVenta;
           IdProducto = objIdProducto;
           Igv = objIgv;
           SubTotal = objSubTotal;
       }
    }

}
