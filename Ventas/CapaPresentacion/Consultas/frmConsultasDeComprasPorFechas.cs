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

namespace CapaPresentacion.Consultas
{
    public partial class frmConsultasDeComprasPorFechas : Form
    {
        DIngresos oIngresos = new DIngresos();
        DetalleIngresos Detalle = new DetalleIngresos();
        NDetalleIngresos oDetalle = new NDetalleIngresos();
        private List<DetalleIngresos> lista = new List<DetalleIngresos>();
         
        public frmConsultasDeComprasPorFechas()
        {
            InitializeComponent();
            actualizarDataGridViewMantenimientoDeIngresos();

        }

        public void mostrarDetalle()
        {
            this.dataGridViewDetalle.Visible = true;
            this.dataGridViewDetalle.DataSource = oDetalle.obtenerDatosEnList(int.Parse(this.txtCodigo.Text));
           
        }

        private void CalcularTotal()
        {
            int NroFilas = dataGridViewDetalle.Rows.Count;
            Detalle.setSubTotal_1(0);
            decimal subtotalDelDataGridView = 0;
            for (int i = 0; i < NroFilas; i = i + 1)
            {
                subtotalDelDataGridView = Decimal.Parse(dataGridViewDetalle.Rows[i].Cells[9].Value + "");
                Detalle.setSubTotal_1(subtotalDelDataGridView);
                

            }

            int count = dataGridViewDetalle.Rows.Count;
            Detalle.igv = 0;
            for (int i = 0; i < count; i++)
            {
                decimal CantidadDeIgvDataGridView = dataGridViewDetalle.Rows[i].Cells[7].Value != null ?
                Decimal.Parse(dataGridViewDetalle.Rows[i].Cells[7].Value + "") : 0;
                Detalle.setIgv();
                Detalle.setTotal();
            }
           
            lblSubTotal.Text = Detalle.Subtotal + "";
            lblIgv.Text = Detalle.igv + "";
            lblTotal.Text = Detalle.Total + "";
      

        }

        public void actualizarDataGridViewMantenimientoDeIngresos()
        {
            limpiarDataGridViewIngresos();
            NIngresos oNIngresos = new NIngresos();
            List<Ingresos> oListIngresos = oNIngresos.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListIngresos.Count; posicion = posicion + 1)
            {
                if (oListIngresos[posicion].idingreso != 0)
                {
                    dataGridViewIngresos.Rows.Add(
                        oListIngresos[posicion].idingreso,
                        oListIngresos[posicion].fechaingreso,
                        oListIngresos[posicion].dniempleado,
                        oListIngresos[posicion].serie,
                        oListIngresos[posicion].numerodocumento,
                        oListIngresos[posicion].tipodocumento,
                        oListIngresos[posicion].idproveedor,
                        oListIngresos[posicion].proveedor,
                        oListIngresos[posicion].estado,
                        oListIngresos[posicion].total);
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewIngresos.Rows.Count) + " Ingresos";

            }

        }

        private void limpiarDataGridViewIngresos()
        {
            dataGridViewIngresos.Rows.Clear();

        }

        private void dataGridViewIngresos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (Convert.ToString(e.Value) == "EFECTUADO")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToString(e.Value) == "ANULADO")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridViewIngresos_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[0].Value);
            this.dtpFecha.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[1].Value);
            this.txtSerie.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[3].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[4].Value);
            this.lblTipo.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[5].Value);
            this.txtIdProveedor.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[6].Value);
            this.txtProveedor.Text = Convert.ToString(this.dataGridViewIngresos.CurrentRow.Cells[7].Value);
            if (this.lblTipo.Text == "Factura")
            {
                this.rbnFactura.Checked = true;
            }
            else
            {
                this.rbnBoleta.Checked = true;
            }

            mostrarDetalle();
            CalcularTotal();
            this.dataGridViewDetalle.Visible = true;
            this.labelSubTotal.Visible = true;
            this.labelSubTotal.Text = "SubTotal: S/. ";
            this.labelIgv.Text = "Total Igv: S/. ";
            this.labelTotalPagado.Text = "Total: S/. ";


            this.lblSubTotal.Visible = true;
            this.dataGridViewDetalle.Columns[10].Visible = false;
            this.dataGridViewDetalle.Columns[1].Visible = false;
            this.dataGridViewDetalle.Columns[3].Visible = false;
            tabControlIngresos.SelectedIndex = 1;
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            if (this.dtpInicio.Value == this.dtpFin.Value)
            {
                MessageBox.Show("Usted no ha Seleccionado la fecha hasta donde buscar... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtpFin.Focus();
            }
            else
            {
                Reportes.frmReporteConsultasFechaIngreso frm = new Reportes.frmReporteConsultasFechaIngreso();
                frm.Texto = Convert.ToString(dtpInicio.Value);
                frm.Texto2 = Convert.ToString(dtpFin.Value);
                frm.ShowDialog();
            }
        }
    }
}
