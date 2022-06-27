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
    public partial class frmConsultasDeVentasPorFechas : Form
    {
        DComprobante oComprobante = new DComprobante();
        DetalleComprobante Detalle = new DetalleComprobante();
        NDetalleComprobante oDetalle = new NDetalleComprobante();
        private List<DetalleComprobante> lista = new List<DetalleComprobante>();
       
        public frmConsultasDeVentasPorFechas()
        {
            InitializeComponent();
            mostrarLupa();
            actualizarDataGridViewMantenimientoDeComprobantes();

        }
        private void mostrarLupa()
         {

            dataGridViewComprobante.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.lupa,
                Name = "lupa",
                HeaderText = "Comprobante"
            });
        }
        public void mostrarDetalle()
        {
            this.dataGridViewDetalle.Visible = true;
            this.dataGridViewDetalle.DataSource = oDetalle.obtenerDatosEnList(int.Parse(this.txtIdVenta.Text));

        }

        private void CalcularTotal()
        {
            int NroFilas = dataGridViewDetalle.Rows.Count;
            Detalle.setSubTotal_1(0);
            decimal subtotalDelDataGridView = 0;
            for (int i = 0; i < NroFilas; i = i + 1)
            {
                subtotalDelDataGridView = Decimal.Parse(dataGridViewDetalle.Rows[i].Cells[7].Value + "");
                Detalle.setSubTotal_1(subtotalDelDataGridView);


            }

            int count = dataGridViewDetalle.Rows.Count;
            Detalle.igv = 0;
            for (int i = 0; i < count; i++)
            {
                decimal CantidadDeIgvDataGridView = dataGridViewDetalle.Rows[i].Cells[6].Value != null ?
                Decimal.Parse(dataGridViewDetalle.Rows[i].Cells[6].Value + "") : 0;
                Detalle.setIgv();
                Detalle.setTotal();
            }

            lblSubTotal.Text = Detalle.Subtotal + "";
            lblIgv.Text = Detalle.igv + "";
            lblTotal.Text = Detalle.Total + "";


        }

        public void actualizarDataGridViewMantenimientoDeComprobantes()
        {
            limpiarDataGridViewComprobante();
            NComprobante oNComprobantes = new NComprobante();
            List<Comprobante> oListComprobantes = oNComprobantes.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListComprobantes.Count; posicion = posicion + 1)
            {
                if (oListComprobantes[posicion].idComprobante != 0)
                {
                    dataGridViewComprobante.Rows.Add(
                        oListComprobantes[posicion].idComprobante,
                        oListComprobantes[posicion].fecha,
                        oListComprobantes[posicion].idempleado,
                        oListComprobantes[posicion].serie,
                        oListComprobantes[posicion].numeroDocumento,
                        oListComprobantes[posicion].tipoDocumento,
                        oListComprobantes[posicion].idcliente,
                        oListComprobantes[posicion].Cliente,
                        oListComprobantes[posicion],

                        oListComprobantes[posicion].total


                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewComprobante.Rows.Count) + " Comprobantes";

            }

        }

     

        private void limpiarDataGridViewComprobante()
        {
            dataGridViewComprobante.Rows.Clear();

        }

        private void dataGridViewComprobante_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdVenta.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[0].Value);
            this.dtpFecha.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[1].Value);
            this.txtSerie.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[3].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[4].Value);
            this.lblTipo.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[5].Value);
            this.txtDni.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[6].Value);
            this.txtCliente.Text = Convert.ToString(this.dataGridViewComprobante.CurrentRow.Cells[7].Value);
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
            this.dataGridViewDetalle.Columns[8].Visible = false;


            tabControlComprobante.SelectedIndex = 1;
        }

        private void dataGridViewComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {

                this.textBoxId.Text = dataGridViewComprobante.CurrentRow.Cells[0].Value.ToString();
                Reportes.frmReporteComprobante frm = new Reportes.frmReporteComprobante();
                frm.Idventa = int.Parse(textBoxId.Text);
                frm.ShowDialog();
            }
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            if (this.dtpFInicio.Value == this.dtpFFin.Value)
            {
                MessageBox.Show("Usted no ha Seleccionado la fecha hasta donde buscar... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtpFFin.Focus();
            }
            else
            {
                Reportes.frmReporteComprobanteGeneral frm = new Reportes.frmReporteComprobanteGeneral();
                frm.Texto = Convert.ToString(dtpFInicio.Value);
                frm.Texto2 = Convert.ToString(dtpFFin.Value);
                frm.ShowDialog();
            }

        }


    }
}
