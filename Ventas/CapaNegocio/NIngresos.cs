using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NIngresos
    {
       public Boolean registrarIngresos(Ingresos oDetalleIngresos)
       {
           DIngresos oDDetalleIngresos = new DIngresos();
           return oDDetalleIngresos.registrarIngresos(oDetalleIngresos);
       }

       public List<Ingresos> obtenerDatosEnList()
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.obtenerDatosEnLista();
       }

       public List<Ingresos> obtenerDatosEnListaXEstado()
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.obtenerDatosEnListaXTurno();
       }

       public Boolean modificarEstadoIngreso(int busqueda, Ingresos oIngresos)
       {
           DIngresos oDEmpleado = new DIngresos();
           return oDEmpleado.modificarEstadoIngreso(busqueda, oIngresos);
       }

       public Ingresos consultarIdIngresos(int busqueda)
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIdIngreso(busqueda);
       }

       public Ingresos consultarIngresos()
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIngresos();
       }

       public Ingresos consultarIngresosPorDocumento(String busca)
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIngresosxDocumento(busca);
       }

       public Ingresos consultarIngresosPorEmpleado(String busca)
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIngresosxEmpleados(busca);
       }


       public Ingresos consultarIngresosPorEstado(String busca)
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIngresosxEstado(busca);
       }

       public Ingresos consultarIngresosPorProveedor(String busca)
       {
           DIngresos oDIngresos = new DIngresos();
           return oDIngresos.consultarIngresosxProveeedotr(busca);
       }
    }
}
