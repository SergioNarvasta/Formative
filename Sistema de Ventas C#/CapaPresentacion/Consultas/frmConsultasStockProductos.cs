using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Consultas
{
    public partial class frmConsultasStockProductos : Form
    {
        public frmConsultasStockProductos()
        {
            InitializeComponent();
            actualizarDataGridViewMantenimientoDeProductos();
        }


        public void actualizarDataGridViewMantenimientoDeProductos()
        {
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListDeStockProductos();
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idProducto != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].cantidad,
                        oListProductos[posicion].stock_actual

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }

        private void limpiarDataGridViewMantenimientoDeProductos()
        {
            dataGridViewMantenimientoDeProducto.Rows.Clear();

        }
        private void dataGridViewMantenimientoDeProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (Convert.ToInt32(e.Value) >= 11)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void frmConsultasStockProductos_Load(object sender, EventArgs e)
        {
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteStock fm = new frmReporteStock();
            fm.ShowDialog();
        }
    }
}
