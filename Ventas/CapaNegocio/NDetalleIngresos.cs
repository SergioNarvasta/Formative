using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NDetalleIngresos
    {
       public Boolean registrarDetalleIngresos(DetalleIngresos oDetalleIngresos)
       {
        
           DDetalleIngresos oDDetalleIngresos = new DDetalleIngresos();
           return oDDetalleIngresos.registrarDetalleIngresos(oDetalleIngresos);
       }

       public List<DetalleIngresos> obtenerDatosEnList(int busca)
       {
           DDetalleIngresos oDDetalle = new DDetalleIngresos();
           return oDDetalle.obtenerDatosEnLista(busca);
       }
    }
}
