using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class NProveedor
    {
        public Boolean registrarProveedor(Proveedor oProveedor)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.registrarProveedor(oProveedor);
        }

        public List<Proveedor> obtenerDatosEnList()
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.obtenerDatosEnLista();
        }
        public List<Proveedor> obtenerDatosEnListaDeProveedorxRazonSocial(String buscando)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorPorRazonSocial(buscando);
        }
        public List<Proveedor> obtenerDatosEnListaDeProveedorxSetor(String buscando)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProvedorPorSectorComercial(buscando);
        }
        public List<Proveedor> obtenerDatosEnListaDeProveedorxBoleta(String buscando)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProvedorPorBoleta(buscando);
        }
        public List<Proveedor> obtenerDatosEnListaDeProveedorxFactura(String buscando)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProvedorPorFactura(buscando);
        }

        public Boolean editarProveedor(int buscar, Proveedor oProveedor)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.modificarProveedor(buscar, oProveedor);
        }

        public Boolean eliminarProveedor(int buscar)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.eliminarProveedor(buscar);
        }

        public Proveedor BuscarRazonSocialProveedor(String busqueda)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorxRazonSocial(busqueda);
        }
        public Proveedor BuscarSectorComercialProveedor(String busqueda)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorxSectorComercial(busqueda);
        }
        public Proveedor BuscarBoletaProveedor(String busqueda)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorxBoleta(busqueda);
        }
        public Proveedor BuscarFacturaProveedor(String busqueda)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorxFactura(busqueda);
        }

        public Proveedor BuscarIdProveedor(int busqueda)
        {
            DProveedor oDProveedor = new DProveedor();
            return oDProveedor.consultarProveedorxId(busqueda);
        }
    }
}
