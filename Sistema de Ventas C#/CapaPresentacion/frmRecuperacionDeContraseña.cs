using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.IO;


namespace CapaPresentacion
{
    public partial class frmRecuperacionDeContraseña : Form
    {
        public static int cambioDeEstado = 0;
        public frmRecuperacionDeContraseña(Empleado oEmpleado)
        {
            InitializeComponent();
            textBoxEmail.Text = "Digite su Correo Electronico y pulse enter";
            textBoxContraseña.Enabled = false;
            textBoxContraseña.Text = "Contraseña";
            labelApellidoPaterno.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cambioDeEstado = 0; Dispose();
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            NEmpleado oNEmpleado= new NEmpleado();
            String busqueda = textBoxEmail.Text;
            Empleado oEmpleado = oNEmpleado.consultarContraseña(busqueda);
            if (e.KeyChar == '\r')
            {

                if (textBoxEmail.TextLength > 0)
                {
                    if (oEmpleado != null)
                    {
                        MemoryStream stream = new MemoryStream(oEmpleado.getFoto());
                        pictureBox1.Image = Image.FromStream(stream);
                        textBoxContraseña.Text = oEmpleado.getPassword();
                        labelApellidoPaterno.Text = oEmpleado.getApellidoPaterno();
                        textBoxEmail.Text = oEmpleado.getEmail();
                        textBoxEmail.Focus();

                    }
                    else if(textBoxEmail.Text=="Digite su Correo Electronico y pulse enter")
                    {
                        MessageBox.Show("Usted no a digitado ningun email valido", " ERROR...",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.Text = "";
                        textBoxEmail.Focus();
                    }
                        
                    else
                    {
                        MessageBox.Show("El Email no existe...!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxEmail.Text = "";
                        pictureBox1.Image = pictureBox1.BackgroundImage;
                        labelApellidoPaterno.Text = "USUARIO";
                        
                        textBoxEmail.Focus();
                        textBoxContraseña.Text = "CONTRASEÑA";
                    }
                }
                else
                {
                    labelApellidoPaterno.Text = "";
                    MessageBox.Show("La caja de texto esta vacia", " ADVERTENCIA...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    textBoxEmail.Focus();
                    textBoxContraseña.Text = "CONTRASEÑA";
                }
            }
        }
        
        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = "C:\\Users\\server\\Desktop\\Sistemas_de_Control_de_Ventas_y_Stock\\";
            pictureBox1.ImageLocation = ruta +  "sinfoto.jpg";
            textBoxEmail.Text = "";
            labelApellidoPaterno.Text = "USUARIO";
            textBoxContraseña.Text = "CONTRASEÑA";
            textBoxEmail.Focus();
        }
    }
}

