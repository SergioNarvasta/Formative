using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;
using CapaDatos;
using System.Drawing.Drawing2D;


namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {

        public static int estado = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Empleado oDEmpleado = new Empleado();
        private int accion = DAccion.NO_ACCION;
        public frmLogin()
        {
            InitializeComponent();
            Mensajes();
            pictureBox1.Visible = false;
            timerFecha_Hora.Enabled = true;
              
        }
        private void Mensajes()
        {
            ttMensaje2.SetToolTip(this.txtNick, "Digite su Usuario");
            ttMensaje2.SetToolTip(this.txtPassword, "Digite su Contraseña");
            ttMensaje2.SetToolTip(this.pbxSalir, "Para salir del Programa");
            ttMensaje2.SetToolTip(this.pbxEntrar, "Para ir al Menu Principal");
            ttMensaje2.SetToolTip(this.pictureBox1,"Mostrar");
            
        }

        private void pbxEntrar_Click(object sender, EventArgs e)
        {
            NEmpleado oNEmpleado = new NEmpleado();
            String busqueda = txtNick.Text;
            Empleado oDEmpleado = oNEmpleado.consultarRegistroNick(busqueda);
            if (txtNick.TextLength > 0 && txtPassword.TextLength > 0)
            {
                player.SoundLocation = @"Bienvenido.wav";
                player.Play();
                label1.Text = "Bienvenido " + " " + txtNick.Text;
                if (oDEmpleado == null)
                {
                    player.SoundLocation = @"Usuario Incorrecto.wav";
                    player.Play();
                    
                    label1.Text = "El Nombre Del Usuario Que a Digitado No Es El Correcto :(";
                    
                }
                else if (oDEmpleado.getHabilitar() == "1")
                {
                    if (oDEmpleado.getPassword() == txtPassword.Text)
                    {
                        DEmpleado oDEmpleado1 = new DEmpleado();
                        estado = 1; 
                        Dispose();
                        new frmSistemaDeMenu(oDEmpleado).ShowDialog();
                        txtPassword.Clear();
                       
                    }
                    else
                    {
                        player.SoundLocation = @"Contraseña.wav";
                        player.Play();
                        label1.Text = "la contraseña ingresada es incorrecto, intentelo nuevamente:(";
                        txtPassword.Clear();
                        pictureBox1.Visible = false;
                        if (txtPassword.PasswordChar == '*')
                        {
                            txtPassword.PasswordChar = '\0';
                            pictureBox1.Image = pictureBox1.BackgroundImage;

                            this.ttMensaje2.SetToolTip(this.pictureBox1, "Ocultar");

                        }
                        else
                        {
                            txtPassword.PasswordChar = '*';
                            pictureBox1.Image = pictureBox1.InitialImage;

                            this.ttMensaje2.SetToolTip(this.pictureBox1, "Mostrar");
                        }
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Su Cuenta no esta disponible en estos momentos por favor consultar al administrador", 
                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                player.SoundLocation = @"UserPass.wav";
                player.Play();
                label1.Text = "Por favor Ingrese el Usuario y su Respectiva Contraseña :(";
           }
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Usted desea Salir del Programa?",
                "CONFIRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                estado = 2;
                Dispose();

            }
            
            
        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {
            Empleado oEmpleado = new Empleado();
            this.Visible = false;
            new frmRecuperacionDeContraseña(oEmpleado).ShowDialog();
            
        }

        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            Sucursal oSucursal = new Sucursal();
            tipoDeUsuario oTipoDeUsuario = new tipoDeUsuario();
            NEmpleado oNEmpleado = new NEmpleado();
            String busqueda = txtNick.Text;
            Empleado oDEmpleado = oNEmpleado.consultarRegistroNick(busqueda);
            if (e.Clicks == 1)
            {
                if (txtNick.TextLength > 0)
                {
                    if (oDEmpleado != null)
                    {
                        MemoryStream stream = new MemoryStream(oDEmpleado.getFoto());
                        pictureBoxFoto.Image = Image.FromStream(stream);
                        

                        txtPassword.Focus();
                        label1.Text = "";

                        int busq = oDEmpleado.getTipoDeUsuario();
                        NTipoDeUsuario nTipo = new NTipoDeUsuario();
                        tipoDeUsuario oTipo = nTipo.consultarRegistro(busq);
                        label2.Text = oDEmpleado.getNombre() + " " + oDEmpleado.getApellidoPaterno() + " " + oDEmpleado.getApellidoMaterno() + 
                            "\n" + oTipo.getNombreDeTipoDeUsuario();
                        //labelDni.Text = Convert.ToString(oDEmpleado.getUsuario_id());
                        //labelTipoDeUsuario.Text = Convert.ToString(oTipo.getTipoDeUsuario_id());
                        ////labelApPaterno.Text = oDEmpleado.getApellidoPaterno();
                        ////labelApMaterno.Text = oDEmpleado.getApellidoMaterno();
                        ////labelNombres.Text = oDEmpleado.getNombre();
                        ////labelSucursal.Text = oDEmpleado.getIdSucursal();
                        //labelFechas.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " : " + DateTime.Now.Second;

                    }
                    else
                    {
                        label1.Text = "El Nombre Del Usuario Que a Digitado No Existe :(";
                        txtNick.Focus();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    label1.Text = "";

                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
             if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                pictureBox1.Image = pictureBox1.BackgroundImage;
                this.ttMensaje2.SetToolTip(this.pictureBox1, "Ocultar");
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBox1.Image = pictureBox1.InitialImage;
                this.ttMensaje2.SetToolTip(this.pictureBox1, "Mostrar");
            }
            txtPassword.Focus();
        }

        private void timerFecha_Hora_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToShortTimeString() + " : " + DateTime.Now.Second;
            this.labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        

      
    }
}
