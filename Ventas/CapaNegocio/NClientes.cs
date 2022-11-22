using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NClientes
    {
       public Boolean registrarClientes(Clientes oClientes)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.registrarClientes(oClientes);
       }

       public List<Clientes> obtenerDatosEnList()
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.obtenerDatosEnLista();
       }
       public List<Clientes> obtenerDatosEnListaDeClientesxDni(int buscando)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.consultarClientePorDni(buscando);
       }
       public List<Clientes> obtenerDatosEnListaDeClientesxApellidos(String buscando)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.consultarClientePorApellidos(buscando);
       }

       public Boolean editarClientes(int buscar, Clientes oClientes)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.modificarClientes(buscar, oClientes);
       }

       public Boolean eliminarClientes(int buscar)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.eliminarClientes(buscar);
       }

       public Clientes BuscarDniClientes(int busqueda)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.consultarClientexDni(busqueda);
       }
       public Clientes BuscarApellidosClientes(String busqueda)
       {
           DClientes oDClientes = new DClientes();
           return oDClientes.consultarClientexApellidos(busqueda);
       }

       
       
    }
}
