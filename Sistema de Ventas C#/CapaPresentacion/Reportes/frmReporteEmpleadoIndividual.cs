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
    public partial class frmReporteEmpleadoIndividual : Form
    {
        private int _Dni;

        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public frmReporteEmpleadoIndividual()
        {
            InitializeComponent();
        }
        
        private void frmReporteEmpleadoIndividual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spreporte_factura' Puede moverla o quitarla según sea necesario.
            try
            {
                this.reporteEmpleadoPorDniTableAdapter.Fill(this.dsPrincipal.reporteEmpleadoPorDni, Dni);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }


            this.reportViewer1.RefreshReport();
        }


    }
}
