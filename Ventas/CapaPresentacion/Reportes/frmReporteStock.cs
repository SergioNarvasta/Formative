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
    public partial class frmReporteStock : Form
    {
        public frmReporteStock()
        {
            InitializeComponent();
        }

        private void frmReporteStock_Load(object sender, EventArgs e)
        {
           this.mostrarStockProductosTableAdapter.Fill(this.dsPrincipal.mostrarStockProductos);
           this.reportViewer1.RefreshReport();
        }
    }
}
