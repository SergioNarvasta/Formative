using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NPresentacion
    {
       public List<Presentacion> obtenerDatosEnList()
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.obtenerDatosEnLista();
       }


       public Boolean registrarPresentacion(Presentacion oPresentacion)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.registrarPresentacion(oPresentacion);
       }

       
       public List<Presentacion> obtenerDatosEnListaDePresentacion(String buscar)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.obtenerDatosEnListaDePresentacionxNombre(buscar);
       }
       

       public Boolean editarPresentacion(int buscar, Presentacion oPresentacion)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.modificarPresentacion(buscar, oPresentacion);
       }

       public Boolean eliminarPresentacion(int buscar)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.eliminarPresentacion(buscar);
       }

       public Presentacion BuscarPresentacion(int busqueda)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.consultarPresentacionxCodigo(busqueda);
       }

       public Presentacion BuscarPresentacionxNombre(String busqueda)
       {
           DPresentacion oDPresentacion = new DPresentacion();
           return oDPresentacion.consultarPresentacionxNombres(busqueda);
       }

       
    }
}
