using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NCategorias
    {
        public Boolean registrarCategorias(Categorias oCategorias)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.registrarCategorias(oCategorias);
        }

        public List<Categorias> obtenerDatosEnList()
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.obtenerDatosEnLista();
        }
        public List<Categorias> obtenerDatosEnListaDeCategorias(String buscar)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.obtenerDatosEnListaDeCategoriasxNombre(buscar);
        }
        public List<Categorias> obtenerDatosEnListaDeCategoriasxCodigo(int buscar)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.obtenerDatosEnListaDeCategoriasxCodigo(buscar);
        }


        public Boolean editarCategorias(int buscar, Categorias oCategorias)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.modificarCategorias(buscar, oCategorias);
        }

        public Boolean eliminarCategorias(int buscar)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.eliminarCategorias(buscar);
        }

        public Categorias BuscarCategorias(int busqueda)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.consultarCategoriasxCodigo(busqueda);
        }

        public Categorias BuscarCategoriasxNombre(String busqueda)
        {
            DCategorias oDCategorias = new DCategorias();
            return oDCategorias.consultarCategoriasxNombres(busqueda);
        }

        
        
    }
    
}
