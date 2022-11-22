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
    public partial class frmReporteClientes : Form
    {
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.VerReporteDeClientes(this.dsPrincipal.Cliente);

            this.reportViewer2.RefreshReport();
        }

        private void textBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if (textBoxCliente.TextLength > 0)
                {
                    NClientes oNClientes = new NClientes();
                    String buscar = textBoxCliente.Text;
                    Clientes oClientes = oNClientes.BuscarApellidosClientes(buscar);
                    if (oClientes != null)
                    {
                        this.clienteTableAdapter.VerReporteClientePorNombres(this.dsPrincipal.Cliente, textBoxCliente.Text);

                        this.reportViewer2.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("El Apellido o el Nombre del Cliente no existe...!!!",
                            "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxCliente.Text = "";
                        textBoxCliente.Focus();
                        this.clienteTableAdapter.VerReporteDeClientes(this.dsPrincipal.Cliente);
                        this.reportViewer2.RefreshReport();
                    }

                }
                else
                {
                    MessageBox.Show("Usted no a escrito ningun Apellido o Nombres a Buscar",
                       "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBoxCliente.Focus();

                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxCliente.TextLength > 0)
            {
                NClientes oNClientes = new NClientes();
                String buscar = textBoxCliente.Text;
                Clientes oClientes = oNClientes.BuscarApellidosClientes(buscar);
                if (oClientes != null)
                {
                    this.clienteTableAdapter.VerReporteClientePorNombres(this.dsPrincipal.Cliente, textBoxCliente.Text);

                    this.reportViewer2.RefreshReport();

                }
                else
                {
                    MessageBox.Show("El Apellido o el Nombre del Cliente no existe...!!!",
                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCliente.Text = "";
                    textBoxCliente.Focus();
                    this.clienteTableAdapter.VerReporteDeClientes(this.dsPrincipal.Cliente);
                    this.reportViewer2.RefreshReport();
                }

            }
            else
            {
                MessageBox.Show("Usted no a escrito ningun Apellido o Nombres a Buscar",
                   "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                textBoxCliente.Focus();

            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.VerReporteDeClientes(this.dsPrincipal.Cliente);
            this.reportViewer2.RefreshReport();

        }

       
    }
}
