using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NTipoDePago
    {
       public List<TipoDePago> obtenerDatosEnList()
       {
           DTipoDePago oDTipoDePagol = new DTipoDePago();
           return oDTipoDePagol.obtenerDatosEnLista();
       }
    }
}
