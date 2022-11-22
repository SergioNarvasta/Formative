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

namespace CapaPresentacion
{
    public partial class frmVistaProveedor_Ingresos : Form
    {
        Proveedor oProveedor = new Proveedor();
        DProveedor oDProveedor = new DProveedor();
        private int accion = DAccion.NO_ACCION;
        
        public frmVistaProveedor_Ingresos()
        {
            InitializeComponent();

           this.comboBoxBuscar.Text = "Seleccione una Opcion";
            
            actualizarDataGridViewProveedor();
        }

        public void actualizarDataGridViewProveedor()
        {
            limpiarDataGridViewProveedor();
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";

            }


        }
        public void actualizarDataGridViewProveedor_1()
        {
            string buscar = textBoxBuscarxRazonSocial.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxRazonSocial(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }

        public void actualizarDataGridViewProveedor_2()
        {
            string buscar = textBoxBuscar.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxBoleta(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }
        public void actualizarDataGridViewProveedor_3()
        {
            string buscar = textBoxBuscar.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxFactura(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }


        private void limpiarDataGridViewProveedor()
        {
            dataGridViewProveedor.Rows.Clear();

        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Boleta")
            {
                this.textBoxBuscar.Text = Convert.ToString(this.comboBoxBuscar.SelectedItem);
                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Clear();

                NProveedor oNProveedor = new NProveedor();
                String buscar = this.textBoxBuscar.Text;
                Proveedor oProveedor = oNProveedor.BuscarBoletaProveedor(buscar);
                if (oProveedor != null)
                {
                    limpiarDataGridViewProveedor();
                    this.actualizarDataGridViewProveedor_2();
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores encontrados";

                }


            }
            else if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Factura")
            {
                this.textBoxBuscar.Text = Convert.ToString(this.comboBoxBuscar.SelectedItem);

                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Clear();

                NProveedor oNProveedor = new NProveedor();
                String buscar = this.textBoxBuscar.Text;
                Proveedor oProveedor = oNProveedor.BuscarFacturaProveedor(buscar);
                if (oProveedor != null)
                {
                    limpiarDataGridViewProveedor();
                    this.actualizarDataGridViewProveedor_3();
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores encontrados";

                }

            }
            else if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Razon Social")
            {
                this.textBoxBuscar.Clear();
                this.label7.Location = new Point(53, 31);
                this.comboBoxBuscar.Location = new Point(137, 28);
                this.textBoxBuscarxRazonSocial.Visible = true;
                this.buttonBuscarxRazon.Visible = true;
                this.textBoxBuscarxRazonSocial.Location = new Point(357, 28);
                this.buttonBuscarxRazon.Location = new Point(647, 29);
                this.textBoxBuscarxRazonSocial.Focus();
                this.actualizarDataGridViewProveedor();

            }

        }

        private void frmVistaProveedor_Ingresos_Load(object sender, EventArgs e)
        {
            this.label7.Location = new Point(190, 30);
            this.comboBoxBuscar.Location = new Point(274, 27);
            labelTotal.Location = new Point(470, 296);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";
        }

        private void dataGridViewProveedor_DoubleClick(object sender, EventArgs e)
        {
            frmMantenimientoDeIngresos fm = Owner as frmMantenimientoDeIngresos;
            fm.txtIdProveedor.Text = dataGridViewProveedor.CurrentRow.Cells[0].Value.ToString();
            fm.txtProveedor.Text = Convert.ToString(dataGridViewProveedor.CurrentRow.Cells[1].Value + " - " + Convert.ToString(dataGridViewProveedor.CurrentRow.Cells[3].Value));
            this.Hide();
        }

        private void textBoxBuscarxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxRazonSocial.TextLength) > 0)
                {
                    Proveedor oProveedors = new Proveedor();
                    NProveedor oNProveedors = new NProveedor();

                    string busqueda = textBoxBuscarxRazonSocial.Text;
                    oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                    if (oProveedors == null)
                    {

                        MessageBox.Show("La Razon Social del Proveedor que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxRazonSocial.Clear();
                        textBoxBuscarxRazonSocial.Focus();
                    }
                    else if (oProveedors != null)
                    {
                        limpiarDataGridViewProveedor();
                        actualizarDataGridViewProveedor_1();
                        labelTotal.Location = new Point(470, 296);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors encontrados";

                    }

                }
                else
                {
                    MessageBox.Show("Ingrese la Razon Social del PROVEEDOR a buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxRazonSocial.Focus();
                    actualizarDataGridViewProveedor();
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                }
               
            }
        }

        private void buttonBuscarxRazon_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxRazonSocial.TextLength) > 0)
            {
                Proveedor oProveedors = new Proveedor();
                NProveedor oNProveedors = new NProveedor();

                string busqueda = textBoxBuscarxRazonSocial.Text;
                oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                if (oProveedors == null)
                {

                    MessageBox.Show("La Razon Social del Proveedor que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxRazonSocial.Clear();
                    textBoxBuscarxRazonSocial.Focus();
                }
                else if (oProveedors != null)
                {
                    limpiarDataGridViewProveedor();
                    actualizarDataGridViewProveedor_1();
                    labelTotal.Location = new Point(470, 296);
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors encontrados";

                }

            }
            else
            {
                MessageBox.Show("Ingrese la Razon Social del PROVEEDOR a buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxRazonSocial.Focus();
                actualizarDataGridViewProveedor();
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

            }
               
        }

        private void textBoxBuscarxRazonSocial_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxRazonSocial.Clear();
        }

    }
}
