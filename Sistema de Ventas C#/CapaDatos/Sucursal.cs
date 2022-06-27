using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Sucursal
    {
       public String idSucursal { get; set; }
       public String nombre { get; set; }
       public int idUbigeo { get; set; }
       public String direccion { get; set; }
       public Byte[] imagen { get; set; }
       public int telefono { get; set; }

       public Sucursal()
       {
           idSucursal = "";
           nombre = "";
           idUbigeo = 0;
           direccion = "";
           telefono = 0;
       }
      public String getidSucursal()
      {
          return this.idSucursal;
      }
      public void setidSucursal(String idSucursal)
      {
          this.idSucursal = idSucursal;
      }

      public String getNombre()
      {
          return this.nombre;
      }
      public void setNombre(String nombre)
      {
          this.nombre = nombre;
      }
      public int getididUbigeo()
      {
          return this.idUbigeo;
      }
      public void setidUbigeo(int idUbigeo)
      {
          this.idUbigeo=idUbigeo;
      }
      public String getDireccion()
      {
          return this.direccion;
      }
      public void setDireccion(String direccion)
      {
          this.direccion = direccion;
      }
      public byte[] getImagen()
      {
          return this.imagen;
      }
      public void setImagen(byte[] imagen)
      {
          this.imagen = imagen;
      }
      public int getTelefono()
      {
          return this.telefono;
      }
      public void setTelefono(int telefono)
      {
          this.telefono = telefono;
      }

      public override String ToString()
      {
          return this.nombre;
      }
    }
}
