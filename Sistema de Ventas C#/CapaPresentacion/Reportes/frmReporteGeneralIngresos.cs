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
    public partial class frmReporteGeneralIngresos : Form
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
        public frmReporteGeneralIngresos()
        {
            InitializeComponent();
            this.comboBoxEmpleados.Text = "Seleccione una opcion";
            this.comboBoxProveedor.Text = "Seleccione una opcion";
            this.comboBoxEstado.Text = "Seleccione una opcion";
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.checkBoxTodos.Checked = false;

            cargarComboBoxEmpleado();
            cargarComboBoxProveedor();
            cargarComboBoxEstado();
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

        private void cargarComboBoxProveedor()
        {
            NProveedor oNProveedor = new NProveedor();
            List<Proveedor> oListEmpleado = oNProveedor.obtenerDatosEnList();
            for (int i = 0; i < oListEmpleado.Count; i++)
            {
                comboBoxProveedor.Items.Add(oListEmpleado[i]);

            }
        }

        private void cargarComboBoxEstado()
        {
            NIngresos oNProveedor = new NIngresos();
            List<Ingresos> oListEmpleado = oNProveedor.obtenerDatosEnListaXEstado();
            for (int i = 0; i < oListEmpleado.Count; i++)
            {
                comboBoxEstado.Items.Add(oListEmpleado[i]);

            }
        }
        private void frmReporteGeneralIngresos_Load(object sender, EventArgs e)
        {
            this.ingresoTableAdapter.verCompras(this.dsPrincipal.Ingreso);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProveedor.Text = "Seleccione una Opcion";
            comboBoxEstado.Text = "Seleccione una Opcion";
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.checkBoxTodos.Checked = false;
            Empleado oEmpleado = new Empleado();
            oEmpleado = (Empleado)comboBoxEmpleados.SelectedItem;
            textBoxBuscar.Text = oEmpleado.apellidoPaterno + " " + oEmpleado.apellidoMaterno + " " + oEmpleado.nombres;
            NIngresos oNIngresos = new NIngresos();
            String buscar = this.textBoxBuscar.Text;
            Ingresos oIngresos = oNIngresos.consultarIngresosPorEmpleado(buscar);
            if (oIngresos != null)
            {
                this.ingresoTableAdapter.verComprasPorEmpleados(this.dsPrincipal.Ingreso,this.textBoxBuscar.Text);

                this.reportViewer1.RefreshReport();

            }
        }
        

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmpleados.Text = "Seleccione una Opcion";
            comboBoxEstado.Text = "Seleccione una Opcion";
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.checkBoxTodos.Checked = false;
            Proveedor oEmpleado = new Proveedor();
            oEmpleado = (Proveedor)comboBoxProveedor.SelectedItem;
            textBoxBuscar.Text = oEmpleado.razonsocial;
            NIngresos oNIngresos = new NIngresos();
            String buscar = this.textBoxBuscar.Text;
            Ingresos oIngresos = oNIngresos.consultarIngresosPorProveedor(buscar);
            if (oIngresos != null)
            {
                this.ingresoTableAdapter.verComprasPorProvedor(this.dsPrincipal.Ingreso, this.textBoxBuscar.Text);

                this.reportViewer1.RefreshReport();

            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmpleados.Text = "Seleccione una Opcion";
            comboBoxProveedor.Text = "Seleccione una Opcion";
            this.checkBoxTodos.Checked = false;
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            Ingresos oEmpleado = new Ingresos();
            oEmpleado = (Ingresos)comboBoxEstado.SelectedItem;
            textBoxBuscar.Text = oEmpleado.estado;
            NIngresos oNIngresos = new NIngresos();
            String buscar = this.textBoxBuscar.Text;
            Ingresos oIngresos = oNIngresos.consultarIngresosPorEstado(buscar);
            if (oIngresos != null)
            {
                this.ingresoTableAdapter.verComprasPorEstado(this.dsPrincipal.Ingreso, this.textBoxBuscar.Text);

                this.reportViewer1.RefreshReport();

            }
        }

        
        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            if (this.dtpFechaInicio.Value == this.dtpFechaFin.Value)
            {
                MessageBox.Show("Usted no ha Seleccionado la fecha hasta donde buscar... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtpFechaFin.Focus();
            }
            else
            {
                this.comboBoxEstado.Text = "Seleccione una opcion";
                this.comboBoxEmpleados.Text = "Seleccione una opcion";
                this.comboBoxProveedor.Text = "Seleccione una opcion";
                this.checkBoxTodos.Checked = false;
                this.radioButtonBoleta.Checked = false;
                this.radioButtonFactura.Checked = false;
              
                Texto = Convert.ToString(dtpFechaInicio.Value);
                Texto2 = Convert.ToString(dtpFechaFin.Value);
                this.ingresoTableAdapter.verComprasPorFechas(this.dsPrincipal.Ingreso,Convert.ToDateTime(Texto),Convert.ToDateTime(Texto2));

                this.reportViewer1.RefreshReport();

            }
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxEstado.Text = "Seleccione una opcion";
            this.comboBoxEmpleados.Text = "Seleccione una opcion";
            this.comboBoxProveedor.Text = "Seleccione una opcion";
            this.radioButtonBoleta.Checked = false;
            this.radioButtonFactura.Checked = false;
            this.ingresoTableAdapter.verCompras(this.dsPrincipal.Ingreso);
            this.reportViewer1.RefreshReport();
        }

        private void radioButtonBoleta_Click(object sender, EventArgs e)
        {
            this.comboBoxEstado.Text = "Seleccione una opcion";
            this.comboBoxEmpleados.Text = "Seleccione una opcion";
            this.comboBoxProveedor.Text = "Seleccione una opcion";
            this.checkBoxTodos.Checked = false;
            this.textBoxBuscar.Text = "Boleta";
            NIngresos oNComprobante = new NIngresos();
            String buscar = this.textBoxBuscar.Text;
            Ingresos oComprobante = oNComprobante.consultarIngresosPorDocumento(buscar);
            if (oComprobante != null)
            {
                this.dtpFechaInicio.Value = Convert.ToDateTime(DateTime.Now.ToString());
                this.dtpFechaFin.Value = Convert.ToDateTime(DateTime.Now.ToString());
            
                this.ingresoTableAdapter.verComprasPorDocumentos(this.dsPrincipal.Ingreso, this.textBoxBuscar.Text);

                this.reportViewer1.RefreshReport();
            }
        }

        private void radioButtonFactura_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxEstado.Text = "Seleccione una opcion";
            this.comboBoxEmpleados.Text = "Seleccione una opcion";
            this.comboBoxProveedor.Text = "Seleccione una opcion";
            this.checkBoxTodos.Checked = false;
            this.textBoxBuscar.Text = "Factura";
            NIngresos oNComprobante = new NIngresos();
            String buscar = this.textBoxBuscar.Text;
            Ingresos oComprobante = oNComprobante.consultarIngresosPorDocumento(buscar);
            if (oComprobante != null)
            {

                this.ingresoTableAdapter.verComprasPorDocumentos(this.dsPrincipal.Ingreso, this.textBoxBuscar.Text);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
