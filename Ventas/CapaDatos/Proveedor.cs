using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public  class Proveedor
    {
      public int idprovedor;
      public String razonsocial;
      public String sectorcomercial;
      public String tipododocumento;
      public String numerodocumento;
      public String direccion;
      public String telefono;
      public String email;
      public String url;

      public Proveedor()
      {
          idprovedor = 0;
          razonsocial = "";
          sectorcomercial = "";
          tipododocumento = "";
          numerodocumento = "";
          direccion = "";
          telefono = "";
          email = "";
          url = "";
      }

      public int getIdproveedor()
      { return this.idprovedor;}
      public void setIdproveedor(int id)
      { this.idprovedor = id; }

      public String getRazon()
      { return this.razonsocial;}
      public void setRazon(String razon)
      { this.razonsocial = razon; }

      public String getSector()
      { return this.sectorcomercial; }
      public void setSector(String sector)
      { this.sectorcomercial = sector; }

      public String getTipo()
      { return this.tipododocumento; }
      public void setTipo(String tipo)
      { this.tipododocumento = tipo; }

      public String getNumero()
      { return this.numerodocumento; }
      public void setNumero(String numero)
      { this.numerodocumento = numero; }

      public String getDireccion()
      { return this.direccion; }
      public void setDireccion(String dire)
      { this.direccion = dire; }

      public String getTelefono()
      { return this.telefono; }
      public void setTelefono(String fono)
      { this.telefono = fono; }

      public String getEmail()
      { return this.email; }
      public void setEmail(String correo)
      { this.email = correo; }

      public String getUrl()
      { return this.url; }
      public void setUrl(String web)
      { this.url = web; }

      public override string ToString()
      {
          return razonsocial;
      }
    }
}
