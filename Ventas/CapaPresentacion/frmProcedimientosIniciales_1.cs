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
    public partial class frmProcedimientosIniciales_1 : Form
    {
       
        public frmProcedimientosIniciales_1()
        {
            InitializeComponent();
            label3SinRaya.MouseHover += new System.EventHandler(this.pas_encima);
            label3SinRaya.MouseLeave += this.quitar_encima;

            label7SinRaya.MouseHover += new System.EventHandler(this.pasa_encimaMouse);
            label7SinRaya.MouseLeave += this.quita_encimaMouse;


            
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
           abrirFromEnPanel(new frmProcedimientosIniciales_1());
       }
        private void mostrarLogoAlCerrar(object sender, FormClosedEventArgs e)
       {
           abrirLogo();
       }

        private void label1_Click(object sender, EventArgs e)
        {
            //frmMantenimientoDeProducto p = frmMantenimientoDeProducto.GetInstancia();
            frmMantenimientoDeProducto p = new frmMantenimientoDeProducto();
            p.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            p.Show();
        }

        
        private void pas_encima(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\NuevaVenta.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label3SinRaya.ForeColor = Color.Orange;
            this.label3SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline, GraphicsUnit.Point);
            
            
        }
        private void quitar_encima(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Blanco.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label3SinRaya.ForeColor = Color.DarkGray;
            this.label3SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point);

         
        }

        private void pasa_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Cliente.png");
            pictureBoxImagen.BackgroundImage = imagen;

            this.label7SinRaya.ForeColor = Color.Orange;
            this.label7SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline, GraphicsUnit.Point);

        }
        private void quita_encimaMouse(object obj, EventArgs evt)
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\Blanco.png");
            pictureBoxImagen.BackgroundImage = imagen;
            this.label7SinRaya.ForeColor = Color.DarkGray;
            this.label7SinRaya.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point);



        }

      
        private void label7SinRaya_Click(object sender, EventArgs e)
        {
           
            label3SinRaya.Visible = false;
            label7SinRaya.Visible = false;
            label5.Visible = false;
            pictureBoxImagen.Visible = false;

            frmMantenimientoDeCliente fm = new frmMantenimientoDeCliente();
            fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            //abrirFromEnPanel(fm);
            
            fm.Show();



        }

        private void label3SinRaya_Click(object sender, EventArgs e)
        {
            this.label3SinRaya.Visible = false;
            this.label7SinRaya.Visible = false;
            this.label5.Visible = false;
            this.pictureBoxImagen.Visible = false;
            frmMantenimientoDeComprobantes v = new frmMantenimientoDeComprobantes();
            v.labelNombre.Text = this.labelDni.Text;
            v.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            v.Show();
            v.Location = new Point(485, 100);
        }
    }
}
