using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public  class Ingresos
    {
      public int idingreso { get; set; }
      public int dniempleado { get; set; }
      public int idproveedor { get; set; }
      public DateTime fechaingreso { get; set; }
      public String serie { get; set; }
      public String numerodocumento { get; set; }
      public String tipodocumento { get; set; }
      public Decimal igv { get; set; }
      public String estado { get; set; }
      public String direccion { get; set; }
      public String empelado { get; set; }
      //campo calculado
      public Decimal total { get; set; }
      public String proveedor { get; set; }
      public Ingresos()
      {
          idingreso = 0;
          dniempleado = 0;
          idproveedor = 0;
          serie = "";
          numerodocumento = "";
          tipodocumento = "";
          igv = 0;
          estado = "";
          proveedor = "";
          direccion = "";
          empelado = "";
      }

      public int getIdIngreso()
      { return this.idingreso; }
      public void setIdIngreso(int id)
      { this.idingreso = id; }

      public int getEmpleado()
      { return this.dniempleado; }
      public void setEmpleado(int dni)
      { this.dniempleado = dni; }

      public int getProveedor()
      { return this.idproveedor; }
      public void setProveedor(int id)
      { this.idproveedor = id; }

      public DateTime getFecha()
      { return this.fechaingreso; }
      public void setIdIngreso(DateTime fecha)
      { this.fechaingreso = fecha; }

      public String getSerie()
      { return this.serie; }
      public void setSerie(String series)
      { this.serie = series; }

      public String getNumero()
      { return this.numerodocumento; }
      public void setNumero(String num)
      { this.numerodocumento = num; }

      public String getTipo()
      { return this.tipodocumento; }
      public void setTipo(String tipo)
      { this.tipodocumento = tipo; }

      public Decimal getIgv()
      { return this.igv; }
      public void setIgv(Decimal impuesto)
      { this.igv = impuesto; }

      public String getEstado()
      { return this.estado; }
      public void setEstado(String stado)
      { this.estado = stado; }

      public String getNombreProveedor()
      { return this.proveedor; }
      public void setNombreProveedor(String prov)
      { this.proveedor = prov; }

      public override string ToString()
      {
          return estado;
      }
    }
}
