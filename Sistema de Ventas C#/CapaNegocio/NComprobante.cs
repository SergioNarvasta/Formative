using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NComprobante
    {


          public Boolean registrarComprobante(Comprobante oDetalleComprobante)
           {
               DComprobante oDDetalleComprobante = new DComprobante();
               return oDDetalleComprobante.registrarComprobante(oDetalleComprobante);
           }

          public List<Comprobante> obtenerDatosEnList()
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.obtenerDatosEnLista();
          }
          public List<Comprobante> obtenerDatosEnListaDeComprobantexApellidos(String buscando)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantePorApellidos(buscando);
          }


          public Comprobante BuscarApellidosComprobante(String busqueda)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantexApellidos(busqueda);
          }
          public Comprobante BuscarBoletaComprobante(String busqueda)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantexDocumento(busqueda);
          }

          public Comprobante BuscarClienteComprobante(String busqueda)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantexCliente(busqueda);
          }

          public Comprobante BuscarEmpleadoComprobante(String busqueda)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantexEmpleado(busqueda);
          }

          public Comprobante BuscarPagoComprobante(String busqueda)
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobantexPago(busqueda);
          }

          public Comprobante BuscarBoletaComprobante()
          {
              DComprobante oDComprobante = new DComprobante();
              return oDComprobante.consultarComprobante();
          }
          
          
    }
}
