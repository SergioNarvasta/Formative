using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public  class TipoDePago
    {
      public int idFormaPago { get; set; }
      public String nombreFormaPago { get; set; }

      public TipoDePago()
      {
          idFormaPago = 0;
          nombreFormaPago = "";
      }
      
      public int getIdForma()
      {
          return this.idFormaPago;
      }
      public void setIdForma(int forma)
      {
          this.idFormaPago = forma;
      }

      public String getNombreForma()
      {
          return this.nombreFormaPago;
      }
      public void setNombreForma(String nombre)
      {
          this.nombreFormaPago = nombre;
      }

      public override String ToString()
      {
          return this.nombreFormaPago;
      }
    }

   
}
