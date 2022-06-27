using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NHorario
    {
        public Boolean registrarHorario(Horario oHorario)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.registrarHorarios(oHorario);
        }

        public List<Horario> obtenerDatosEnList()
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.obtenerDatosEnLista();
        }

        public List<Horario> obtenerDatosEnListPorTurnos()
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.obtenerDatosEnListaXTurno();
        }

        
        public List<Horario> obtenerDatosEnListaDeHorarioxEmpleado(String buscando)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioPorEmpleado(buscando);
        }
        public List<Horario> obtenerDatosEnListaDeHorarioxTurno(String buscando)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioPorTurno(buscando);
        }
        public List<Horario> obtenerDatosEnListaDeHorarioxCargo(String buscando)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioPorCargo(buscando);
        }

        public Boolean editarHorario(int buscar, Horario oHorario)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.modificarHorarios(buscar, oHorario);
        }

        public Boolean eliminarHorario(int buscar)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.eliminarHorarios(buscar);
        }

        public Horario BuscarEmpleadoHorario(String busqueda)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioxEmpleado(busqueda);
        }
        public Horario BuscarTurnoHorario(String busqueda)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioxTurno(busqueda);
        }
        public Horario BuscarCargoHorario(String busqueda)
        {
            DHorario oDHorario = new DHorario();
            return oDHorario.consultarHorarioxCargo(busqueda);
        }
    }
}
