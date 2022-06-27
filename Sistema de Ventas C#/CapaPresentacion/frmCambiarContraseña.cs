using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCambiarContraseña : Form
    {
        public static int cambioDeEstado = 0;
        public frmCambiarContraseña(Empleado oDEmpleado)
        {
            InitializeComponent();
            labelNombre.Enabled = false;
            textBoxDni.Text ="Numero de D.N.I. mas ENTER";
            pictureBox.Visible = false;
            pictureBox1.Visible = false;
            this.mensaje.SetToolTip(this.pictureBox, "Mostrar");
            this.mensaje.SetToolTip(this.pictureBox1, "Mostrar");
            
            
        }
        public static Boolean ValidadorNumerico(char e)
        {
            String ValidarCaracteres = "0123456789\b";
            Boolean existe = ValidarCaracteres.Contains(e);
            if (existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public Empleado getObjetoEmpleado()
        {
            Empleado oEmpleado = new Empleado();
            oEmpleado.usuario_id = int.Parse(textBoxDni.Text);
            oEmpleado.password = textBoxPassword.Text;
            return oEmpleado;
        }
        
        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
            
            string cadena = textBoxPassword.Text;
            string cadena1 = textBoxPassword1.Text;
            if(cadena!=cadena1)
            {
                MessageBox.Show("Las CONTRASEÑAS no son iguales", "ADVERTENCIA...!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword1.Clear();
                textBoxPassword.Focus();
                
                pictureBox1.Visible = false;
                if (textBoxPassword.PasswordChar == '*')
                {
                    textBoxPassword.PasswordChar = '\0';
                    pictureBox.Image = pictureBox.BackgroundImage;
                    pictureBox.Visible = true;
                    this.mensaje.SetToolTip(this.pictureBox, "Ocultar");
                    
                }
                else
                {
                    textBoxPassword.PasswordChar = '*';
                    pictureBox.Image = pictureBox.InitialImage;
                    pictureBox.Visible = true;
                    this.mensaje.SetToolTip(this.pictureBox, "Mostrar");
                }
                textBoxPassword.Focus();
                
            }
            else if (cadena.Equals(""))
            {
                MessageBox.Show("El campos Nueva Clave esta vacia...", "ADVERTENCIA...!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword1.Clear();
                textBoxPassword.Focus();
                pictureBox.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                if(e.KeyChar == '\r')
                {
                    if (textBoxDni.TextLength > 0)
                    {
                        NEmpleado oNEmpleado = new NEmpleado();
                        int buscar = int.Parse(textBoxDni.Text);
                        Empleado oEmpleado = oNEmpleado.consultarDniEmpleado(buscar);
                        if (oNEmpleado.modificarContraseña(int.Parse(textBoxDni.Text), getObjetoEmpleado()))
                        {
                            if (oEmpleado != null)
                            {
                                MessageBox.Show("Opercion Exitosa...",
                                    "INFORMACION...!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                textBoxPassword.Clear();
                                textBoxPassword1.Clear();
                                textBoxDni.Clear();
                                textBoxPassword.Focus();
                                pictureBox.Visible = false;
                                pictureBox1.Visible = false;
                            }
                            else 
                            {
                                MessageBox.Show("El D.N.I no existe...!!!",
                                    "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBoxDni.Text = "";
                                pictureBox.Visible = false;
                                pictureBox1.Visible = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar la CONTRASEÑA",
                                "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Dispose();
                            pictureBox.Visible = false;
                            pictureBox1.Visible = false;
                        }
                    }
                    else 
                    {
                        MessageBox.Show("La caja de texto esta vacia",
                            "ADVERTENCIA...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        textBoxDni.Focus();
                    }
                    
                }
            }
        }

        private void pictureBoxSalir_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Close();
            
        }

        private void textBoxDni_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDni.Clear();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox.Visible = true;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBoxPassword.PasswordChar=='*')
            {
                textBoxPassword.PasswordChar = '\0';
                pictureBox.Image = pictureBox.BackgroundImage;
                this.mensaje.SetToolTip(this.pictureBox, "Ocultar");
            }
            else
            {
                textBoxPassword.PasswordChar='*';
                pictureBox.Image = pictureBox.InitialImage;
                this.mensaje.SetToolTip(this.pictureBox, "Mostrar");
            }
            textBoxPassword.Focus();
        }

        private void textBoxPassword1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword1.PasswordChar == '*')
            {
                textBoxPassword1.PasswordChar = '\0';
                pictureBox1.Image = pictureBox1.BackgroundImage;
                this.mensaje.SetToolTip(this.pictureBox1, "Ocultar");
            }
            else
            {
                textBoxPassword1.PasswordChar = '*';
                pictureBox1.Image = pictureBox1.InitialImage;
                this.mensaje.SetToolTip(this.pictureBox1, "Mostrar");
            }
            textBoxPassword1.Focus();
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            this.Location = new Point(380, 10);
            this.textBoxPassword.Focus();
        }

       

    }
}
