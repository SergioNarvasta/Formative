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
    public partial class frmReporteCategorias : Form
    {
        public frmReporteCategorias()
        {
            InitializeComponent();
            cargarComboBoxCategorias();
            this.comboBoxCategorias.Text = "Seleccione una Opcion";
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
        private void frmReporteCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.VerReporteCategorias(this.dsPrincipal.Categoria);

            this.reportViewer1.RefreshReport();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.comboBoxCategorias.Text = "Seleccione una Opcion";
            this.categoriaTableAdapter.VerReporteCategorias(this.dsPrincipal.Categoria);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias oCategorias = new Categorias();
            oCategorias = (Categorias)comboBoxCategorias.SelectedItem;
            textBoxCategoria.Text = oCategorias.nombre;
            NCategorias oNCategorias = new NCategorias();
            String buscar = this.textBoxCategoria.Text;
            oCategorias = oNCategorias.BuscarCategoriasxNombre(buscar);
            if (oCategorias != null)
            {
                this.categoriaTableAdapter.VerReporteCategoriasPorNombres(this.dsPrincipal.Categoria, textBoxCategoria.Text);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
