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
    public partial class frmReporteGeneralDeComprobantes : Form
    {
        private String _Texto;
        private String _Texto2;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public String Texto2
        {
            get { return _Texto2; }
            set { _Texto2 = value; }
        }
        public frmReporteGeneralDeComprobantes()
        {
            InitializeComponent();
            this.radioButtonEmpleado.Checked = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.radioButtonPago.Checked = false;
            this.radioButtonFecha.Checked = false;
           // this.inicio();
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.cargarComboBoxEmpleado();
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.cargarComboBoxPago();

           
           
        }

        private void cargarComboBoxEmpleado()
        {
            NEmpleado oNEmpleado = new NEmpleado();
            List<Empleado> oListEmpleado = oNEmpleado.obtenerDatosEnList();
            for (int i = 0; i < oListEmpleado.Count; i++)
            {
                comboBoxEmpleados.Items.Add(oListEmpleado[i]);

            }
        }

        private void cargarComboBoxPago()
        {
            NTipoDePago oNTipoDePago = new NTipoDePago();
            List<TipoDePago> oListPago = oNTipoDePago.obtenerDatosEnList();
            for (int i = 0; i < oListPago.Count; i++)
            {
                comboBoxPago.Items.Add(oListPago[i]);

            }
        }
     

       
        private void frmReporteGeneralDeComprobantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Comprobante' Puede moverla o quitarla según sea necesario.
            this.comprobanteTableAdapter.verComprobante(this.dsPrincipal.Comprobante);
            this.reportViewer1.RefreshReport();
      
        }

        private void radioButtonEmpleado_Click(object sender, EventArgs e)
        {
            this.comboBoxEmpleados.Enabled = true;
            this.comboBoxEmpleados.Focus();
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.checkBoxTodos.Checked = false;
        }

        private void radioButtonBoleta_Click(object sender, EventArgs e)
        {
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonFactura.Checked= false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.checkBoxTodos.Checked = false;
            
                this.textBoxBuscar.Text = "Boleta";
                NComprobante oNComprobante = new NComprobante();
                String buscar = this.textBoxBuscar.Text;
                Comprobante oComprobante = oNComprobante.BuscarBoletaComprobante(buscar);
                if (oComprobante != null)
                {

                    this.comprobanteTableAdapter.verComprobantePorDocumentos(this.dsPrincipal.Comprobante, textBoxBuscar.Text);
                    this.reportViewer1.RefreshReport();
                }
            

        }

        private void radioButtonFactura_Click(object sender, EventArgs e)
        {
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.checkBoxTodos.Checked = false;
            this.textBoxBuscar.Text = "Factura";
            NComprobante oNComprobante = new NComprobante();
            String buscar = this.textBoxBuscar.Text;
            Comprobante oComprobante = oNComprobante.BuscarBoletaComprobante(buscar);
            if (oComprobante != null)
            {

                this.comprobanteTableAdapter.verComprobantePorDocumentos(this.dsPrincipal.Comprobante, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();
            }
           
        }

        private void radioButtonClientes_Click(object sender, EventArgs e)
        {
            
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonFactura.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.checkBoxTodos.Checked = false;
            this.textBoxNombres.Enabled = true;
            this.buttonBuscar.Enabled = true;
            this.textBoxNombres.Focus();
            this.label1.Enabled = true;
        }

        private void radioButtonPago_Click(object sender, EventArgs e)
        {
            this.comboBoxPago.Enabled = true;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.comboBoxPago.Focus();
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.checkBoxTodos.Checked = false;
            
        }

        private void radioButtonFecha_Click(object sender, EventArgs e)
        {
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
           
            this.label2.Enabled = true;
            this.dtpFechaInicio.Enabled = true;
            this.dtpFechaInicio.Focus();
            this.label3.Enabled = true;
            this.dtpFechaFin.Enabled = true;
            this.btnBuscarFechas.Enabled = true;
            this.checkBoxTodos.Checked = false;
        }

        private void checkBoxTodos_Click(object sender, EventArgs e)
        {
            this.radioButtonEmpleado.Checked = false;
            this.comboBoxEmpleados.Text = "Seleccione una Opcion";
            this.comboBoxEmpleados.Enabled = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonClientes.Checked = false;
            this.textBoxNombres.Enabled = false;
            this.buttonBuscar.Enabled = false;
            this.label1.Enabled = false;
            this.radioButtonPago.Checked = false;
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.Text = "Seleccione una Opcion";
            this.radioButtonFecha.Checked = false;
            this.label2.Enabled = false;
            this.dtpFechaInicio.Enabled = false;
            this.label3.Enabled = false;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.btnBuscarFechas.Enabled = false;

        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPago.Text = "Seleccione una Opcion";
            Empleado oEmpleado = new Empleado();
            oEmpleado = (Empleado)comboBoxEmpleados.SelectedItem;
            textBoxBuscar.Text = oEmpleado.apellidoPaterno + " " + oEmpleado.apellidoMaterno + " " + oEmpleado.nombres;
            NHorario oNHorario = new NHorario();
            String buscar = this.textBoxBuscar.Text;
            Horario oHorario = oNHorario.BuscarEmpleadoHorario(buscar);
            if (oHorario != null)
            {
                this.comprobanteTableAdapter.verComprobantePorEmpleado(this.dsPrincipal.Comprobante, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
            this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            
            this.comprobanteTableAdapter.verComprobante(this.dsPrincipal.Comprobante);
            this.reportViewer1.RefreshReport();

        }

        private void comboBoxPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPago.Text = "Seleccione una Opcion";
            TipoDePago oEmpleado = new TipoDePago();
            oEmpleado = (TipoDePago)comboBoxPago.SelectedItem;
            textBoxBuscar.Text = oEmpleado.nombreFormaPago;
            NComprobante oNComprobante = new NComprobante();
            String buscar = this.textBoxBuscar.Text;
            Comprobante oComprobante = oNComprobante.BuscarPagoComprobante(buscar);
            if (oComprobante != null)
            {
                this.comprobanteTableAdapter.verComprobantePorPago(this.dsPrincipal.Comprobante, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
        }

        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if (textBoxNombres.TextLength > 0)
                {
                    NComprobante oNProducto = new NComprobante();
                    String buscar = textBoxNombres.Text;
                    Comprobante oProductos = oNProducto.BuscarClienteComprobante(buscar);
                    if (oProductos != null)
                    {
                        this.comprobanteTableAdapter.verComprobantePorClientes(this.dsPrincipal.Comprobante, textBoxNombres.Text);
                        this.reportViewer1.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("El CLIENTE no existe...!!!",
                            "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxNombres.Text = "";
                        textBoxNombres.Focus();
                        this.comprobanteTableAdapter.verComprobante(this.dsPrincipal.Comprobante);
                        this.reportViewer1.RefreshReport();
                    }

                }
                else
                {
                    MessageBox.Show("Usted no a escrito ninguna CLIENTE a Buscar",
                       "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBoxNombres.Focus();
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxNombres.TextLength > 0)
            {
                NComprobante oNProducto = new NComprobante();
                String buscar = textBoxNombres.Text;
                Comprobante oProductos = oNProducto.BuscarClienteComprobante(buscar);
                if (oProductos != null)
                {
                    this.comprobanteTableAdapter.verComprobantePorClientes(this.dsPrincipal.Comprobante, textBoxNombres.Text);
                    this.reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("El CLIENTE no existe...!!!",
                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombres.Text = "";
                    textBoxNombres.Focus();
                    this.comprobanteTableAdapter.verComprobante(this.dsPrincipal.Comprobante);
                    this.reportViewer1.RefreshReport();
                }

            }
            else
            {
                MessageBox.Show("Usted no a escrito ninguna CLIENTE a Buscar",
                   "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                textBoxNombres.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dtpFechaInicio.Value == this.dtpFechaFin.Value)
            {
                MessageBox.Show("Usted no ha Seleccionado la fecha hasta donde buscar... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtpFechaFin.Focus();
            }
            else
            {
                Texto = Convert.ToString(dtpFechaInicio.Value);
                Texto2 = Convert.ToString(dtpFechaFin.Value);
                this.comprobanteTableAdapter.verComprobantePorFechas(this.dsPrincipal.Comprobante, Convert.ToDateTime(Texto),Convert.ToDateTime(Texto2));
                this.reportViewer1.RefreshReport();
                
            }

        }
    }
}
