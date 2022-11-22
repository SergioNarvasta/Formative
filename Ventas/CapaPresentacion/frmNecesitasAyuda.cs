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
    public partial class frmNecesitasAyuda : Form
    {
        
        public frmNecesitasAyuda()
        {
            InitializeComponent();
            
            label6SinRaya.MouseHover += new System.EventHandler(this.pasa_encimaMouse);
            label6SinRaya.MouseLeave += this.quita_encimaMouse;

            label7SinRaya.MouseHover += new System.EventHandler(this.pasar_encimaMouse);
            label7SinRaya.MouseLeave += this.quitar_encimaMouse;

            label1SinRaya.MouseHover += new System.EventHandler(this.pasar_encimaMouse1);
            label1SinRaya.MouseLeave += this.quitar_encimaMouse1;
        }
        private void abrirFromEnPanel(object fromHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = fromHijo as Form;
            fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            fh.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }
        private void abrirLogo()
        {
            abrirFromEnPanel(new frmNecesitasAyuda());
        }
        private void mostrarLogoAlCerrar(object sender, FormClosedEventArgs e)
        {
            abrirLogo();
        }

        private void frmNecesitasAyuda_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(791, 538);
            
        }

        private void pasa_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Ayuda.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label6SinRaya.ForeColor = Color.Orange;
            this.label6SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline, GraphicsUnit.Point);
            
            
        }
        private void quita_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Blanco.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label6SinRaya.ForeColor = Color.DarkGray;
            this.label6SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point);

            
        }

        private void pasar_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Video.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label7SinRaya.ForeColor = Color.Orange;
            this.label7SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Blanco.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label7SinRaya.ForeColor = Color.DarkGray;
            this.label7SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point);


        }

        private void pasar_encimaMouse1(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Informacion.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label1SinRaya.ForeColor = Color.Orange;
            this.label1SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encimaMouse1(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Blanco.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label1SinRaya.ForeColor = Color.DarkGray;
            this.label1SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point);


        }


        private void label6SinRaya_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro abrir el Manual de Usuario del Programa?",
                   "MANUAL DE USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\server\\Desktop\\ProyectosDSI\\Sistemas_de_Control_de_Ventas_y_Stock\\CapaPresentacion\\bin\\Debug\\imagen\\Manual.pdf");

            }
        }

        private void label1SinRaya_Click(object sender, EventArgs e)
        {
            label6SinRaya.Visible = false;
            label7SinRaya.Visible = false;
            label1SinRaya.Visible = false;
            label5.Visible = false;
            pictureBoxImagen.Visible = false;

            frmInformacion fm = new frmInformacion();
            fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            
            fm.Show();
            fm.Location = new Point(650, 140);
            fm.Size = new Size(253, 412);
            
            fm.labelWeb.Location = new Point(6, 346);
            fm.labelReservado.Location = new Point(30, 380);
        }

        private void label7SinRaya_Click(object sender, EventArgs e)
        {
            
            frmVideo fm = new frmVideo();

            fm.ShowDialog();
        }

    }
}
