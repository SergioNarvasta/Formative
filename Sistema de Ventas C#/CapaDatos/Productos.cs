using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Productos
    {
       public int idProducto { get; set; }
       public int idCategoria { get; set; }
       public int idPresentacion { get; set; }
       public String nombre { get; set; }
       public String marca { get; set; }
       
       public Decimal precioCompra { get; set; }
       public Decimal precioVenta { get; set; }
       public int stock { get; set; }
       public Byte[] imagen { get; set; }
       public String categoria { get; set; }
       public String presentacion { get; set; }

       public int idDetalle { get; set; }
       public DateTime fecha { get; set; }
       public int idcomprobante { get; set; }
       public int cantidad { get; set; }
       public int stock_actual { get; set; }

       public Productos()
       {
           idProducto = 0;
           idCategoria = 0;
           idPresentacion = 0;
           nombre = "";
           marca = "";
           precioCompra = 0;
           precioVenta = 0;
           stock = 0;
           categoria = "";
           presentacion = "";
           idcomprobante = 0;
           cantidad = 0;
           stock_actual = 0;
       }

       public int getIdProducto()
       {
           return this.idProducto;
       }
       public void setIdProducto(int idP)
       {
           this.idProducto = idP;
       }
       public int getIdCategoria()
       {
           return this.idCategoria;
       }
       public void setIdCategoria(int idC)
       {
           this.idCategoria = idC;
       }
       public int getIdPresentacion()
       {
           return this.idPresentacion;
       }
       public void setIdPresentacion(int idPr)
       {
           this.idPresentacion = idPr;
       }
       public String getNombre()
       {
           return this.nombre;
       }
       public void setNombre(String nom)
       {
           this.nombre = nom;
       }
       public String getMarca()
       {
           return this.marca;
       }
       public void setMarca(String mar)
       {
           this.marca = mar;
       }
       
       public Decimal getPrecioVenta()
       {
           return this.precioVenta;
       }
       public void setPrecioVenta(Decimal pv)
       {
           this.precioVenta = pv;
       }
       public Decimal getPrecioCompra()
       {
           return this.precioCompra;
       }
       public void setPrecioCompra(Decimal pc)
       {
           this.precioCompra = pc;
       }
       public int getStock()
       {
           return this.stock;
       }
       public void setStock(int st)
       {
           this.stock = st;
       }
       public Byte[] getImagen()
       {
           return this.imagen;
       }
       public void setImagen(Byte[] im)
       {
           this.imagen = im;
       }
       public String getCategoria()
       {
           return this.categoria;
       }
       public void setCategoria(String cate)
       {
           this.categoria = cate;
       }
       public String getPresentacion()
       {
           return this.presentacion;
       }
       public void setPresentacion(String prese)
       {
           this.presentacion = prese;
       }
       public override String ToString()
       {
           return this.nombre;
       }
    }
}
