using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEmpleado
    {
        public Empleado consultarRegistroNick(String busqueda)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.consultarRegistroNick(busqueda);
        }

        public Empleado consultarContraseña(String busqueda)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.recuperarContraseña(busqueda);
        }
        public List<Empleado> obtenerDatosEnList()
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.obtenerDatosEnLista();
        }

        public List<Empleado> obtenerDatosEnListaDeEmpleados(int buscar)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.obtenerDatosEnListaDeEmpleados(buscar);
        }

        public Boolean registrarEmpleado(Empleado oEmpleado)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.registrarEmpleado(oEmpleado);
        }

        public Boolean modificarContraseña(int busqueda, Empleado oEmpleado)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.modificarContraseña(busqueda,oEmpleado);
        }

        public Empleado consultarDniEmpleado(int busqueda)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.consultarDni(busqueda);
        }

        public Empleado BuscarDniEmpleado(int busqueda)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.consultarUsuario(busqueda);
        }

        public Boolean editarEmpleado(int buscar, Empleado oEmpleado)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.modificarEmpleado(buscar,oEmpleado);
        }

        public Boolean eliminarEmpleado(int buscar)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.eliminarEmpleado(buscar);
        }

        public Empleado BuscarEmpleadoxTipos(String busqueda)
        {
            DEmpleado oDEmpleado = new DEmpleado();
            return oDEmpleado.BuscarEmpleadoxTipo(busqueda);
        }
    }
}
