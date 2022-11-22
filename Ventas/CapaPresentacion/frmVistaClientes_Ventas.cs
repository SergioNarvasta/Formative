using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmListarCliente : Form
    {
        public static int cambioEstadoVista = 0;
        public frmListarCliente()
        {
            InitializeComponent();
            textBoxBuscarxApellidos.Enabled = false;
            textBoxBuscarxDni.Enabled = false;
            radioButtonDni.Checked = false;
            radioButtonApellidoPaterno.Checked = false;
            textBoxBuscarxDni.Enabled = false;
            actualizarDataGridViewCliente();
        }

        public void actualizarDataGridViewCliente()
        {
            NClientes oNClientes = new NClientes();
            List<Clientes> oListClientes = oNClientes.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
            {
                if (oListClientes[posicion].getDni() != 0)
                {
                    dataGridViewCliente.Rows.Add(
                        oListClientes[posicion].getDni(),
                        oListClientes[posicion].getApellidos(),
                        oListClientes[posicion].getNombres(),
                        oListClientes[posicion].getDireccion(),
                        oListClientes[posicion].getCelular(),
                        oListClientes[posicion]);
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

            }


        }
        public void actualizarDataGridViewCliente_1()
        {
            int buscar = int.Parse(textBoxBuscarxDni.Text);
            NClientes oNClientes = new NClientes();
            List<Clientes> oListClientes = oNClientes.obtenerDatosEnListaDeClientesxDni(buscar);
            for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
            {
                if (oListClientes[posicion].getDni() != 0)
                {
                    dataGridViewCliente.Rows.Add(
                        oListClientes[posicion].getDni(),
                        oListClientes[posicion].getApellidos(),
                        oListClientes[posicion].getNombres(),
                        oListClientes[posicion].getDireccion(),
                        oListClientes[posicion].getCelular(),
                        oListClientes[posicion]);
                }

            }


        }
        public void actualizarDataGridViewCliente_2()
        {
            String buscar = textBoxBuscarxApellidos.Text;
            NClientes oNClientes = new NClientes();
            List<Clientes> oListClientes = oNClientes.obtenerDatosEnListaDeClientesxApellidos(buscar);
            for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
            {
                if (oListClientes[posicion].getDni() != 0)
                {
                    dataGridViewCliente.Rows.Add(
                        oListClientes[posicion].getDni(),
                        oListClientes[posicion].getApellidos(),
                        oListClientes[posicion].getNombres(),
                        oListClientes[posicion].getDireccion(),
                        oListClientes[posicion].getCelular(),
                        oListClientes[posicion]);
                }

            }


        }
        private void limpiarDataGridViewCliente()
        {
            dataGridViewCliente.Rows.Clear();

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonDni_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxApellidos.Visible = false;
            this.textBoxBuscarxDni.Visible = true;
            this.textBoxBuscarxDni.Enabled = true;
            this.textBoxBuscarxDni.Clear();
            this.textBoxBuscarxDni.Focus();

            this.labelTotal.Location = new Point(646, 296);
            this.limpiarDataGridViewCliente();
            this.actualizarDataGridViewCliente();

        }

        private void radioButtonApellidoPaterno_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxDni.Visible = false;
            this.textBoxBuscarxApellidos.Visible = true;
            this.textBoxBuscarxApellidos.Enabled = true;
            this.textBoxBuscarxApellidos.Clear();
            this.textBoxBuscarxApellidos.Focus();

            this.labelTotal.Location = new Point(646, 296);
            this.limpiarDataGridViewCliente();
            this.actualizarDataGridViewCliente();
        }

        private void dataGridViewCliente_DoubleClick_1(object sender, EventArgs e)
        {
            
            frmMantenimientoDeComprobantes fm = Owner as frmMantenimientoDeComprobantes;
            fm.txtDocIdentidad.Text = dataGridViewCliente.CurrentRow.Cells[0].Value.ToString();
            fm.txtDatos.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells[1].Value + ", " + dataGridViewCliente.CurrentRow.Cells[2].Value);
            this.Hide();
        }

        private void textBoxBuscarxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxDni.TextLength) > 0)
                {

                    NClientes oNClientess = new NClientes();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonDni.Checked == true)
                    {
                        Clientes oClientess = new Clientes();
                        int buscarXDni = int.Parse(textBoxBuscarxDni.Text);
                        oClientess = oNClientess.BuscarDniClientes(buscarXDni);
                        if (oClientess == null)
                        {
                            MessageBox.Show("EL Dni del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxDni.Clear();
                            textBoxBuscarxDni.Focus();
                        }
                        else if (oClientess != null)
                        {
                            limpiarDataGridViewCliente();
                            actualizarDataGridViewCliente_1();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(444, 326);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese el Dni del Clientes a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxDni.Focus();
                    actualizarDataGridViewCliente();
                    labelTotal.Location = new Point(646, 326);
                }

            }
        }

        private void textBoxBuscarxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxApellidos.TextLength) > 0)
                {

                    NClientes oNClientes = new NClientes();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonApellidoPaterno.Checked == true)
                    {
                        Clientes oClientes = new Clientes();
                        String buscarXApellido = textBoxBuscarxApellidos.Text;
                        oClientes = oNClientes.BuscarApellidosClientes(buscarXApellido);
                        if (oClientes == null)
                        {
                            MessageBox.Show("Los Apellidos del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxApellidos.Clear();
                            textBoxBuscarxApellidos.Focus();
                        }
                        else if (oClientes != null)
                        {
                            limpiarDataGridViewCliente();
                            actualizarDataGridViewCliente_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(444, 396);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese los Apellidos del Clientes a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxApellidos.Focus();
                    actualizarDataGridViewCliente();
                    labelTotal.Location = new Point(646, 326);
                }
            }
        }

        private void textBoxBuscarxApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxApellidos.Clear();
            this.labelTotal.Location = new Point(646, 396);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
       
        }

        private void textBoxBuscarxDni_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxApellidos.Clear();
            this.labelTotal.Location = new Point(646, 396);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
       
        }
    }
}
