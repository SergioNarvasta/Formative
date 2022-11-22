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
    public partial class frmReporteComprobante : Form
    {
        private int idComprobante;

        public int Idventa
        {
            get { return idComprobante; }
            set { idComprobante = value; }
        }
        public frmReporteComprobante()
        {
            InitializeComponent();
        }

        private void frmReporteComprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.reporteComprobante' Puede moverla o quitarla según sea necesario.
            this.reporteComprobanteTableAdapter.Fill(this.dsPrincipal.reporteComprobante,idComprobante);

            this.reportViewer1.RefreshReport();
            
        }

       
    }
}
