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
    public partial class frmReportePresentacion : Form
    {
        public frmReportePresentacion()
        {
            InitializeComponent();
            this.cargarComboBoxPresentacion();
            this.comboBoxPresentacion.Text = "Seleccione una Opcion";
            
        }
        private void cargarComboBoxPresentacion()
        {
            NPresentacion oNPresentacion = new NPresentacion();
            List<Presentacion> oListPresentacion = oNPresentacion.obtenerDatosEnList();
            for (int i = 0; i < oListPresentacion.Count; i++)
            {
                comboBoxPresentacion.Items.Add(oListPresentacion[i]);

            }
        }
        private void frmReportePresentacion_Load(object sender, EventArgs e)
        {
            this.presentacionTableAdapter.VerReportePresentacion(this.dsPrincipal.Presentacion);
            this.reportViewer1.RefreshReport();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.comboBoxPresentacion.Text = "Seleccione una Opcion";
            this.presentacionTableAdapter.VerReportePresentacion(this.dsPrincipal.Presentacion);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presentacion oPresentacion = new Presentacion();
            oPresentacion = (Presentacion)comboBoxPresentacion.SelectedItem;
            textBoxPresentacion.Text = oPresentacion.nombre;
            NPresentacion oNPresentacion = new NPresentacion();
            String buscar = this.textBoxPresentacion.Text;
            oPresentacion = oNPresentacion.BuscarPresentacionxNombre(buscar);
            if (oPresentacion != null)
            {
                this.presentacionTableAdapter.VerReportePresentacionPorNombres(this.dsPrincipal.Presentacion, textBoxPresentacion.Text);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
