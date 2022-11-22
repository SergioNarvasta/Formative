using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Clientes
    {
       public int Dni { get; set; }
       public String Apellidos { get; set; }
      public String Nombres { get; set; }
      public String Direccion { get; set; }
      public String Celular { get; set; }
      public String idSucursal { get; set; }
      

      public Clientes()
      {
          Dni = 0;
          Apellidos = "";
          Nombres = "";
          Direccion = "";
          Celular = "";
          idSucursal = "";
      }
      public int getDni()
      {
          return this.Dni;
      }
      public void setDni(int dni)
      {
          this.Dni = dni;
      }
      public String getApellidos()
      {
          return this.Apellidos;
      }
      public void setApellidos(String apellidos)
      {
          this.Apellidos = apellidos;
      }
      public String getNombres()
      {
          return this.Nombres;
      }
      public void setNombres(String nombres)
      {
          this.Nombres = nombres;
      }
      public String getDireccion()
      {
          return this.Direccion;
      }
      public void setDireccion(String direccion)
      {
          this.Direccion = direccion;
      }
      public String getCelular()
      {
          return this.Celular;
      }
      public void setCelular(String celular)
      {
          this.Celular = celular;
      }
      public String getIdSucursal()
      {
          return this.idSucursal;
      }
      public void setIdSucursal(String idsucursal)
      {
          this.idSucursal = idsucursal;
      }

      
      public override String ToString()
      {
          return this.Apellidos + " " + Nombres;
      }
    }
}
