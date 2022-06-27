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
    public partial class frmInformacion : Form
    {
        public static int cambioEstado = 0;
        public frmInformacion()
        {
            InitializeComponent();
            labeNombre.MouseHover += new System.EventHandler(this.pas_encima);
            labeNombre.MouseLeave += this.quitar_encima;

            lblNombre.MouseHover += new System.EventHandler(this.pas_encima_1);
            lblNombre.MouseLeave += this.quitar_encima_1;

            lblRu.MouseHover += new System.EventHandler(this.pas_encima_2);
            lblRu.MouseLeave += this.quitar_encima_2;
        }

        private void labeNombre_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Salvador Roger");
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            this.Location = new Point(465, 70);
        }

        private void pas_encima(object obj, EventArgs evt)
        {
            this.labeNombre.ForeColor = Color.Blue;
            this.labeNombre.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encima(object obj, EventArgs evt)
        {
            this.labeNombre.ForeColor = Color.DarkGray;
            this.labeNombre.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);


        }


        private void lblNombre_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Carlos Mendoza Inga");

        }

        private void pas_encima_1(object obj, EventArgs evt)
        {
            this.lblNombre.ForeColor = Color.Blue;
            this.lblNombre.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encima_1(object obj, EventArgs evt)
        {
            this.lblNombre.ForeColor = Color.DarkGray;
            this.lblNombre.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);


        }

        private void pas_encima_2(object obj, EventArgs evt)
        {
            this.lblRu.ForeColor = Color.Blue;
            this.lblRu.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encima_2(object obj, EventArgs evt)
        {
            this.lblRu.ForeColor = Color.DarkGray;
            this.lblRu.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);


        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Gerardo Rufino Rafael");

        }
    }
}
