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
    public partial class frmReporteEmpleado : Form
    {
        public frmReporteEmpleado()
        {
            InitializeComponent();
            cargarComboBoxTipo();
            comboBoxTipo.Text = " Seleccione una Opcion";
        }
        private void cargarComboBoxTipo()
        {
            NTipoDeUsuario oNTipoDeUsuario = new NTipoDeUsuario();
            List<tipoDeUsuario> oListTipoDeUsuario = oNTipoDeUsuario.obtenerDatosEnList();
            for (int i = 0; i < oListTipoDeUsuario.Count; i++)
            {
                comboBoxTipo.Items.Add(oListTipoDeUsuario[i]);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.VerReporteEmpleado(this.dsPrincipal.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.VerReporteEmpleado(this.dsPrincipal.Empleado);
            this.reportViewer1.RefreshReport();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.comboBoxTipo.Text = " Seleccione una Opcion";
            this.textBoxMostrar.Clear();
            this.empleadoTableAdapter.VerReporteEmpleado(this.dsPrincipal.Empleado);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeUsuario oTipoDeUsuario = new tipoDeUsuario();
            oTipoDeUsuario = (tipoDeUsuario)comboBoxTipo.SelectedItem;
            textBoxMostrar.Text = oTipoDeUsuario.nombreDeTipoDeUsuario;
            NTipoDeUsuario oNTipoDeUsuario = new NTipoDeUsuario();
            String buscar = this.textBoxMostrar.Text;
            oTipoDeUsuario = oNTipoDeUsuario.BuscarTipoDeUsuarioxNombre(buscar);
            if (oTipoDeUsuario != null)
            {
                this.empleadoTableAdapter.VerTipoDeEmpleados(this.dsPrincipal.Empleado, comboBoxTipo.Text);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
