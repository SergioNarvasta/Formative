using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public  class tipoDeUsuario
    {
       public int tipoDeUsuario_id { get; set; }
       public String nombreDeTipoDeUsuario { get; set; }

        public int getTipoDeUsuario_id()
        {
            return this.tipoDeUsuario_id;
        }
        public void setTipoDeUsuario_id(int tipoDeUsuario_id)
        {
            this.tipoDeUsuario_id = tipoDeUsuario_id;
        }
        public String getNombreDeTipoDeUsuario()
        {
            return this.nombreDeTipoDeUsuario;
        }
        public void setNombreDeTipoDeUsuarios(String nombreDeTipoDeUsuario)
        {
            this.nombreDeTipoDeUsuario = nombreDeTipoDeUsuario;
        }
        public override string ToString()
        {
            return this.nombreDeTipoDeUsuario;
        }
    }
}
