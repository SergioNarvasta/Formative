using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NTipoDeUsuario
    {
       public tipoDeUsuario consultarRegistro(int busqueda)
        {
            DTipoDeUsuario oDTipoDeUsuario = new DTipoDeUsuario();
            return oDTipoDeUsuario.buscarRegistro(busqueda);
        }
        public List<tipoDeUsuario> obtenerDatosEnList()
        {
            DTipoDeUsuario oDTipoDeUsuario = new DTipoDeUsuario();
            return oDTipoDeUsuario.obtenerDatosEnList();
        }

        public tipoDeUsuario BuscarTipoDeUsuarioxNombre(String busqueda)
        {
            DTipoDeUsuario oDtipoDeUsuario = new DTipoDeUsuario();
            return oDtipoDeUsuario.consultartipoDeUsuarioxNombres(busqueda);
        }

    }
}
