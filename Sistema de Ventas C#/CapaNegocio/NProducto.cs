using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class NProducto
    {
        public Boolean registrarProductos(Productos oProductos)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.registrarProductos(oProductos);
        }

        public List<Productos> obtenerDatosEnList()
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnLista();
        }
        public List<Productos> obtenerDatosEnListaDeProductosxNombre(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosxNombre(buscar);
        }
        public List<Productos> obtenerDatosEnListaDeProductosxMarca(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosxMarca(buscar);
        }

        public List<Productos> obtenerDatosEnListProductosIngresos()
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaProductosIngresos();
        }
        public List<Productos> obtenerDatosEnListaDeProductosxNombreIngresos(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosxNombreIngresos(buscar);
        }
        public List<Productos> obtenerDatosEnListaDeProductosxMarcaIngresos(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosxMarcaIngresos(buscar);
        }

      
      
        public Boolean editarProductos(int buscar, Productos oProductos)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.modificarProductos(buscar, oProductos);
        }
        public Boolean eliminarProductos(int buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.eliminarProductos(buscar);
        }

        public Productos BuscarProductoxNombre(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxNombre(busqueda);
        }
        public Productos BuscarProductoxMarca(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxMarca(busqueda);
        }
        public Productos BuscarProductoxId(int busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxId(busqueda);
        }

        public Productos BuscarProductoxNombreIngresos(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxNombreIngresos(busqueda);
        }
        public Productos BuscarProductoxMarcaIngresos(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxMarcaIngresos(busqueda);
        }
       

        public Productos BuscarProductoxCategoria(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosxCategorias(busqueda);
        }


        public List<Productos> obtenerDatosEnListaProductosComprobantes()
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaProductosComprobante();
        }
        public List<Productos> obtenerDatosEnListaDeProductosComprobantesPorNombre(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosComprobantesxNombre(buscar);
        }
        public List<Productos> obtenerDatosEnListaDeProductosComprobantesPorMarca(String buscar)
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaDeProductosComprobantesxMarca(buscar);
        }

        public Productos BuscarProductoComprobantesPorNombre(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosComprobantesxNombre(busqueda);
        }
        public Productos BuscarProductoComprobantesPorMarca(String busqueda)
        {
            DProducto oDProducto = new DProducto();
            return oDProducto.BuscarProductosComprobantesxMarca(busqueda);
        }

        public List<Productos> obtenerDatosEnListDeStockProductos()
        {
            DProducto oDProductos = new DProducto();
            return oDProductos.obtenerDatosEnListaStock();
        }
       
    }
}
