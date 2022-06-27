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

namespace CapaPresentacion
{
    public partial class frmVideo : Form
    {
       
        public frmVideo()
        {
            InitializeComponent();
            
        }
        
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
            wmpVideo.Ctlcontrols.stop();
        }

        int Lx, Ly;

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1032, 544);
            //this.Location = new Point(Lx, Ly);
            this.Location = new Point(190, 70);
            buttonMaximizar.Visible = true;
            buttonRestaurar.Visible = false;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            buttonMaximizar.Visible = false;
            buttonRestaurar.Visible = true;
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1032, 544);
            this.Location = new Point(190, 70);
        }

    }
}
