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
    public partial class frmReporteProveedor : Form
    {
        public frmReporteProveedor()
        {
            InitializeComponent();
            this.cargarComboBoxRazon();
            this.comboBoxRazon.Text = "Seleccione una Opcion";
            this.inicio();
        }

        private void cargarComboBoxRazon()
        {
            NProveedor oNProveedor = new NProveedor();
            List<Proveedor> oListProveedor = oNProveedor.obtenerDatosEnList();
            for (int i = 0; i < oListProveedor.Count; i++)
            {
                comboBoxRazon.Items.Add(oListProveedor[i]);

            }
        }
        private void inicio()
        {
            this.groupBox1.Size = new Size(240, 129);
            this.radioButtonRazon.Location = new Point(15, 34);
            this.radioButtonSector.Location = new Point(15, 59);
            this.radioButtonTodos.Location = new Point(15, 84);
            this.radioButtonRazon.Checked = false;
            this.radioButtonSector.Checked = false;
          
        }
        private void frmReporteProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.verProveedor(this.dsPrincipal.Proveedor);
            this.reportViewer1.RefreshReport();
        }

        private void radioButtonRazon_Click(object sender, EventArgs e)
        {
            this.groupBox1.Size = new Size(240, 147);

            this.comboBoxRazon.Visible = true;
            this.radioButtonSector.Location = new Point(15, 84);
            this.radioButtonTodos.Location = new Point(15, 109);
            this.radioButtonRazon.Checked = true;
            this.radioButtonSector.Checked = false;
            this.radioButtonTodos.Checked = false;
            this.textBoxSector.Visible = false;
            this.buttonBuscar.Visible = false;
        }

        private void radioButtonSector_Click(object sender, EventArgs e)
        {
            this.groupBox1.Size = new Size(240, 147);

            this.comboBoxRazon.Visible = false;
            this.radioButtonSector.Location = new Point(15, 59);
            this.textBoxSector.Location = new Point(30, 84);
            this.buttonBuscar.Location = new Point(214, 83);
            this.textBoxSector.Visible = true;
            this.textBoxSector.Focus();
            this.buttonBuscar.Visible = true;
            this.radioButtonTodos.Location = new Point(15, 110);
            this.radioButtonRazon.Checked = false;
            this.radioButtonSector.Checked = true;
            this.radioButtonTodos.Checked = false;
        }

        private void radioButtonTodos_Click(object sender, EventArgs e)
        {
            this.comboBoxRazon.Visible = false;
            this.comboBoxRazon.Text = "Seleccione una Opcion";
            this.textBoxSector.Visible = false;
            this.textBoxSector.Clear();
            this.buttonBuscar.Visible = false;

            this. inicio();

            this.proveedorTableAdapter.verProveedor(this.dsPrincipal.Proveedor);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxRazon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor = (Proveedor)comboBoxRazon.SelectedItem;
            textBoxBuscar.Text = oProveedor.razonsocial;
            NProveedor oNProveedor = new NProveedor();
            String buscar = this.textBoxBuscar.Text;
            oProveedor = oNProveedor.BuscarRazonSocialProveedor(buscar);
            if (oProveedor != null)
            {
                this.proveedorTableAdapter.verProveedorPorRazonSocial(this.dsPrincipal.Proveedor, textBoxBuscar.Text);
                this.reportViewer1.RefreshReport();

            }
           
        }

        private void textBoxSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if (textBoxSector.TextLength > 0)
                {
                    NProveedor oNProveedor = new NProveedor();
                    String buscar = textBoxSector.Text;
                    Proveedor oProveedor = oNProveedor.BuscarSectorComercialProveedor(buscar);
                    if (oProveedor != null)
                    {
                        this.proveedorTableAdapter.VerProveedorPorSectorComercial(this.dsPrincipal.Proveedor, textBoxSector.Text);
                        this.reportViewer1.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("La SECTOR COMERCIAL no existe...!!!",
                            "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxSector.Text = "";
                        textBoxSector.Focus();
                        this.proveedorTableAdapter.verProveedor(this.dsPrincipal.Proveedor);
                        this.reportViewer1.RefreshReport();
                    }

                }
                else
                {
                    MessageBox.Show("Usted no a escrito ningun SECTOR COMERCIAL a Buscar",
                       "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBoxSector.Focus();
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxSector.TextLength > 0)
                {
                    NProveedor oNProveedor = new NProveedor();
                    String buscar = textBoxSector.Text;
                    Proveedor oProveedor = oNProveedor.BuscarSectorComercialProveedor(buscar);
                    if (oProveedor != null)
                    {
                        this.proveedorTableAdapter.VerProveedorPorSectorComercial(this.dsPrincipal.Proveedor, textBoxSector.Text);
                        this.reportViewer1.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("La SECTOR COMERCIAL no existe...!!!",
                            "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxSector.Text = "";
                        textBoxSector.Focus();
                        this.proveedorTableAdapter.verProveedor(this.dsPrincipal.Proveedor);
                        this.reportViewer1.RefreshReport();
                    }

                }
                else
                {
                    MessageBox.Show("Usted no a escrito ningun SECTOR COMERCIAL a Buscar",
                       "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBoxSector.Focus();
                }
        }
    }
}
