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
    public partial class frmReporteHorario : Form
    {
        public frmReporteHorario()
        {
            InitializeComponent();
            this.comboBoxEmpleado.Text = "Seleccione un Empleado";
            this.comboBoxTurno.Text = "Seleccione un Turno";
            this.comboBoxCargo.Text = "Seleccione un Cargo";
            
            cargarComboBoxEmpleado();
            cargarComboBoxTurno();
            cargarComboBoxCargo();
           
        }
        private void cargarComboBoxEmpleado()
        {
            NEmpleado oNEmpleado = new NEmpleado();
            List<Empleado> oListEmpleado = oNEmpleado.obtenerDatosEnList();
            for (int i = 0; i < oListEmpleado.Count; i++)
            {
                comboBoxEmpleado.Items.Add(oListEmpleado[i]);

            }
        }

        private void cargarComboBoxTurno()
        {
            NHorario oNHorario = new NHorario();
            List<Horario> oListHorario = oNHorario.obtenerDatosEnListPorTurnos();
            for (int i = 0; i < oListHorario.Count; i++)
            {
                comboBoxTurno.Items.Add(oListHorario[i]);

            }
        }

        private void cargarComboBoxCargo()
        {
            NTipoDeUsuario oNTipoDeUsuario = new NTipoDeUsuario();
            List<tipoDeUsuario> oListTipoDeUsuario = oNTipoDeUsuario.obtenerDatosEnList();
            for (int i = 0; i < oListTipoDeUsuario.Count; i++)
            {
                comboBoxCargo.Items.Add(oListTipoDeUsuario[i]);

            }
        }
        private void frmReporteHorario_Load(object sender, EventArgs e)
        {
           this.horarioTableAdapter.VerHorario(this.dsPrincipal.Horario);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTurno.Text = "Seleccione un Turno";
            comboBoxCargo.Text = "Seleccione un Cargo";
            Empleado oEmpleado = new Empleado();
            oEmpleado = (Empleado)comboBoxEmpleado.SelectedItem;
            textBoxBuscar.Text = oEmpleado.apellidoPaterno + " " + oEmpleado.apellidoMaterno + " " + oEmpleado.nombres;
            NHorario oNHorario = new NHorario();
            String buscar = this.textBoxBuscar.Text;
            Horario oHorario = oNHorario.BuscarEmpleadoHorario(buscar);
            if (oHorario != null)
            {
                this.horarioTableAdapter.VerHorarioDeEmpleado(this.dsPrincipal.Horario, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
        }

        private void comboBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmpleado.Text = "Seleccione un Empleado";
            comboBoxCargo.Text = "Seleccione un Cargo";

            Horario oHorario= new Horario();
            oHorario = (Horario)comboBoxTurno.SelectedItem;
            textBoxBuscar.Text = oHorario.Turno;

            NHorario oNHorario = new NHorario();
            String buscar = this.textBoxBuscar.Text;
            oHorario = oNHorario.BuscarTurnoHorario(buscar);
            if (oHorario != null)
            {
                this.horarioTableAdapter.VerHorarioPorTurno(this.dsPrincipal.Horario, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
       
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.comboBoxEmpleado.Text = "Seleccione un Empleado";
            this.comboBoxTurno.Text = "Seleccione un Turno";
            this.comboBoxCargo.Text = "Seleccione un Cargo";
            
            this.horarioTableAdapter.VerHorario(this.dsPrincipal.Horario);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTurno.Text = "Seleccione un Turno";
            comboBoxEmpleado.Text = "Seleccione un Empleado";
            tipoDeUsuario oTipoDeUsuario = new tipoDeUsuario();
            oTipoDeUsuario = (tipoDeUsuario)comboBoxCargo.SelectedItem;
            textBoxBuscar.Text = oTipoDeUsuario.nombreDeTipoDeUsuario;

            NHorario oNHorario = new NHorario();
            String buscar = this.textBoxBuscar.Text;
            Horario oHorario = oNHorario.BuscarCargoHorario(buscar);
            if (oHorario != null)
            {
                this.horarioTableAdapter.VerHorarioPorCargo(this.dsPrincipal.Horario, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
           
        }
    }
}
