using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Presentacion
    {
        public int idPresentacion { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
       

       public Presentacion()
       {
           idPresentacion = 0;
           nombre = "";
           descripcion = "";
           
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
       public String getDescripcion()
       {
           return this.descripcion;
       }
       public void setDescripcion(String des)
       {
           this.descripcion = des;
       }
       public override String ToString()
       {
           return this.nombre;
       }
    }
}
