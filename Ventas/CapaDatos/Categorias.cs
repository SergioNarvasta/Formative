using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Categorias
    {
       public int idCategoria { get; set; }
       public String nombre { get; set; }
       

       public Categorias()
       {
           
           idCategoria = 0;
           nombre = "";
          
       }

      
       public int getIdCategoria()
       {
           return this.idCategoria;
       }
       public void setIdCategoria(int idC)
       {
           this.idCategoria = idC;
       }
       
       public String getNombre()
       {
           return this.nombre;
       }
       public void setNombre(String nom)
       {
           this.nombre = nom;
       }
       
       public override String ToString()
       {
           return this.nombre;
       }
    }
}
