using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NDetalleComprobante
    {
       public Boolean registrarDetalleComprobante(DetalleComprobante oDetalleComprobante)
       {
        
           DDetalleComprobante oDDetalleComprobante = new DDetalleComprobante();
           return oDDetalleComprobante.registrarDetalleComprobante(oDetalleComprobante);
       }

       public List<DetalleComprobante> obtenerDatosEnList(int busca)
       {
           DDetalleComprobante oDDetalle = new DDetalleComprobante();
           return oDDetalle.obtenerDatosEnLista(busca);
       }
    }
}
