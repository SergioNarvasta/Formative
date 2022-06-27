using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReporteProductos : Form
    {
        public frmReporteProductos()
        {
            InitializeComponent();
            this.cargarComboBoxCategorias();
            this.comboBoxCategorias.Text = "Seleccione una opcion";
        }
        private void cargarComboBoxCategorias()
        {
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnList();
            for (int i = 0; i < oListCategorias.Count; i++)
            {
                comboBoxCategorias.Items.Add(oListCategorias[i]);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.verTodosLosProductos(this.dsPrincipal.Producto);
            this.reportViewer1.RefreshReport();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.comboBoxCategorias.Text = "Seleccione una Opcion";
            this.productoTableAdapter.verTodosLosProductos(this.dsPrincipal.Producto);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias oCategorias = new Categorias();
            oCategorias = (Categorias)comboBoxCategorias.SelectedItem;
            textBoxCategoria.Text = oCategorias.nombre;

            NProducto oNProductos = new NProducto();
            String buscar = this.textBoxCategoria.Text;
            Productos oProductos = oNProductos.BuscarProductoxCategoria(buscar);
            if (oProductos != null)
            {
                this.productoTableAdapter.verProductosParametrizados(this.dsPrincipal.Producto, textBoxCategoria.Text);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
