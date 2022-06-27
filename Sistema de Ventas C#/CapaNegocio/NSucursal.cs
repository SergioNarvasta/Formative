using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class NSucursal
    {
        public List<Sucursal> obtenerDatosEnList()
        {
            DSucursal oDSucursal = new DSucursal();
            return oDSucursal.obtenerDatosEnLista();
        }
    }
}
