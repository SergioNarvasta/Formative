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

namespace CapaPresentacion
{
    public partial class frmMantenimientoDeIngresos : Form
    {
        DIngresos oIngresos = new DIngresos();
        DetalleIngresos Detalle = new DetalleIngresos();
        NDetalleIngresos oDetalle = new NDetalleIngresos();
        private List<DetalleIngresos> lista = new List<DetalleIngresos>();
         public frmMantenimientoDeIngresos()
        {
            InitializeComponent();
            labelAnular.MouseHover += new System.EventHandler(this.pasar_encimaMouse1);
            labelAnular.MouseLeave += this.quitar_encimaMouse1;
            actualizarDataGridViewMantenimientoDeIngresos();
             
        }

        private void GenerarIdIngresos()
        {
            DIngresos oIngresos = new DIngresos();
            txtCodigo.Text = oIngresos.GenerarIdIngresos();
        }
        private void GenerarSeriedeDocumento()
        {
            DIngresos oIngresos = new DIngresos();

            txtSerie.Text = oIngresos.GenerarSerieDocumento();
        }
        private void GenerarNumeroIngresos()
        {
            DIngresos oIngresos = new DIngresos();

            if (rbnBoleta.Checked == true)
                txtCorrelativo.Text = oIngresos.NumeroIngresos("Boleta");
            else
                txtCorrelativo.Text = oIngresos.NumeroIngresos("Factura");
        }

        private void llenarGrillas()
        {
            Decimal sumaSubtotal = 0;
            Decimal sumaIgv = 0;
            Decimal sumatotal = 0;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lista[i].idIngreso;
                dataGridView1.Rows[i].Cells[1].Value = lista[i].stock_inicial;
                dataGridView1.Rows[i].Cells[2].Value = lista[i].descripcion;
                dataGridView1.Rows[i].Cells[3].Value = lista[i].precioCompra;
                dataGridView1.Rows[i].Cells[4].Value = lista[i].Subtotal;
                dataGridView1.Rows[i].Cells[5].Value = lista[i].idproducto;
                dataGridView1.Rows[i].Cells[6].Value = lista[i].igv;
                dataGridView1.Rows[i].Cells[7].Value = lista[i].fechaProduccion;
                dataGridView1.Rows[i].Cells[8].Value = lista[i].fechaVencimiento;
                
                sumaSubtotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                sumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[lista.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
            dataGridView1.Rows[lista.Count + 1].Cells[4].Value = sumaSubtotal;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[lista.Count + 2].Cells[3].Value = "      I.G.V.        %";
            dataGridView1.Rows[lista.Count + 2].Cells[4].Value = sumaIgv;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[lista.Count + 3].Cells[3].Value = "     TOTAL     S/.";
            sumatotal += sumaSubtotal + sumaIgv;
            dataGridView1.Rows[lista.Count + 3].Cells[4].Value = sumatotal;
            dataGridView1.ClearSelection();
        }

        public Ingresos leerObjetoIngresos()
        {
            Ingresos oIngresos = new Ingresos();
            decimal Total = 0;
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                string TipoDocumento = "";
                TipoDocumento = rbnBoleta.Checked == true ? "Boleta" : "Factura";
                oIngresos.dniempleado = int.Parse(labelNombre.Text);
                oIngresos.idproveedor = int.Parse(txtIdProveedor.Text);
                oIngresos.fechaingreso = Convert.ToDateTime(dtpFecha.Value);
                oIngresos.serie = txtSerie.Text;
                oIngresos.numerodocumento = txtCorrelativo.Text;
                oIngresos.tipodocumento = TipoDocumento;
                oIngresos.estado = labelEstado.Text;
                oIngresos.total = Convert.ToDecimal(Total);
            }

            return oIngresos;
        }

        private void habilitarCajasDeTexto(Boolean editable)
        {
            txtCodigo.Enabled = editable;
            txtIdProveedor.Enabled = editable;
            txtProveedor.Enabled = editable;
            rbnBoleta.Enabled = editable;
            rbnFactura.Enabled = editable;
            txtSerie.Enabled = editable;
            txtCorrelativo.Enabled = editable;
            txtIgv.Enabled = editable;
            dtpFecha.Enabled = editable;
            txtIdProducto.Enabled = editable;
            txtProducto.Enabled = editable;
            txtPrecioCompra.Enabled = editable;
            txtStock.Enabled = editable;
            dtpProduccion.Enabled = editable;
            dtpVencimiento.Enabled = editable;

        }

        public void mostrarDetalle()
        {
            this.dataGridView1.Visible = false;
            this.dataGridViewDetalle.Visible = true;
            this.dataGridViewDetalle.DataSource = oDetalle.obtenerDatosEnList(int.Parse(this.txtCodigo.Text));
            this.btnCancelar.Enabled=true;
         }


        private void GuardarDetalleIngresos(
            Int32 objIdIngreso, Int32 objIdProducto ,
            Int32 objStock, Decimal objPCompra,
            DateTime objFProduccion, 
            DateTime objFVencimiento, Decimal objIgv, Decimal objSubTotal )
        {
            Detalle.idIngreso = objIdIngreso;
            Detalle.idproducto = objIdProducto;
            Detalle.stock_inicial = objStock;
            Detalle.precioCompra = objPCompra;
            Detalle.fechaProduccion = objFProduccion;
            Detalle.fechaVencimiento = objFVencimiento;
            Detalle.igv = objIgv;
            Detalle.Subtotal = objSubTotal;
            Detalle.registrarDetalleIngresos();
            GenerarIdIngresos();
            GenerarNumeroIngresos();

        }

        private void limpiarCajasDeTexto()
        {

            txtIdProveedor.Text = "";
            txtProveedor.Text = "";
            rbnBoleta.Checked = false;
            rbnFactura.Checked = false;
            txtCorrelativo.Clear();
            dtpFecha.Value = DateTime.Now;
            this.dataGridView1.Rows.Clear();


        }
        private void limpiar()
        {

            txtIdProducto.Clear();
            txtProducto.Clear();
            txtPrecioCompra.Clear();
            txtStock.Text = "";
            dtpProduccion.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;


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
        private void frmMantenimientoDeIngresos_Load(object sender, EventArgs e)
        {
            this.labelEstado.Text = "EFECTUADO";
            this.txtIgv.Text = "18";
            GenerarIdIngresos();
            GenerarSeriedeDocumento();

        }

        private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "Factura";

            }

            else
            {
                lblTipo.Text = "Boleta";


            }
            GenerarNumeroIngresos();
        }

        private void rbnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            GenerarNumeroIngresos();
            lblTipo.Text = "Boleta";
        }
       
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            tabControlIngresos.SelectedIndex = 1;
            DetalleIngresos DI = new DetalleIngresos();
            Decimal porcentaje = 0;
            Decimal subTotal = 0;
            if (this.txtIdProducto.Text.Trim() != "")
            {
                if (this.txtProducto.Text.Trim() != "")
                {
                    if (this.txtStock.Text.Trim() != "")
                    {
                        if (Convert.ToInt32(txtStock.Text) >= 0)
                        {
                            if (this.dtpProduccion.Value != this.dtpVencimiento.Value)
                            {
                                if (this.txtIgv.Text.Trim() != "")
                                {
                                    DI.idproducto = Convert.ToInt32(txtIdProducto.Text);
                                    DI.idIngreso = Convert.ToInt32(txtCodigo.Text);
                                    DI.descripcion = txtProducto.Text;
                                    DI.stock_inicial = Convert.ToInt32(txtStock.Text);
                                    DI.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                                    porcentaje = (Convert.ToDecimal(txtIgv.Text) / 100) + 1;
                                    subTotal = ((Convert.ToDecimal(txtPrecioCompra.Text) * Convert.ToInt32(txtStock.Text)) / porcentaje);
                                    DI.igv = Math.Round(Convert.ToDecimal(subTotal) * (Convert.ToDecimal(txtIgv.Text) / (100)), 2);
                                    DI.Subtotal = Math.Round(subTotal, 2);
                                    DI.fechaProduccion = Convert.ToDateTime(dtpProduccion.Value);
                                    DI.fechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value);
                                    lista.Add(DI);
                                    llenarGrillas();
                                    btnGuardar.Enabled = true;
                                    btnCancelar.Enabled = true;
                                    btnAsignar.Enabled = false;
                                    btnQuitar.Enabled = true;
                                    limpiar();

                                }
                                else
                                {
                                    MessageBox.Show("Por Favor Ingrese I.G.V.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtIgv.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor seleccione Una Fecha de Vencimiento.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                dtpVencimiento.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La Cantidad Ingresada no es Valida", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStock.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Ingrese la Cantidad a Comprar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStock.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Por Favor Busque el Producto a Comprar.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnBuscarProductos.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Busque el Producto a Comprar.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                btnBuscarProductos.Focus();
            }

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            tabControlIngresos.SelectedIndex = 1;
            frmVistaProveedor_Ingresos fm = new frmVistaProveedor_Ingresos();
            AddOwnedForm(fm);
            fm.ShowDialog();
            this.dtpFecha.Enabled = true;
            this.btnBuscarProductos.Enabled = true;
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            tabControlIngresos.SelectedIndex = 1;
            frmVistaProductos_Ingresos fm = new frmVistaProductos_Ingresos();
            AddOwnedForm(fm);
            fm.ShowDialog();
            this.txtStock.Enabled = true;
            this.txtStock.Focus();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            tabControlIngresos.SelectedIndex = 1;
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        lista.RemoveAt(dataGridView1.CurrentRow.Index);
                        llenarGrillas();
                        MessageBox.Show("Producto Eliminado de la Lista Ok.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningun Elemento en la Lista.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Item a Eliminar de la Lista.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No Existe Ningun Elemento en la Lista", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tabControlIngresos.SelectedIndex = 1;
            if (dataGridView1.Rows.Count > 0)
            {
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                {
                    NIngresos oNIngresos = new NIngresos();
                    oNIngresos.registrarIngresos(leerObjetoIngresos());

                }
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Decimal SumaIgv = 0; Decimal SumaSubtotal = 0;
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) != "")
                        {
                            SumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                            SumaSubtotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                            GuardarDetalleIngresos(
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                                Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value),
                                Convert.ToDateTime(dataGridView1.Rows[i].Cells[7].Value),
                                Convert.ToDateTime(dataGridView1.Rows[i].Cells[8].Value),
                                SumaIgv,
                                SumaSubtotal);

                        }
                    }
                    actualizarDataGridViewMantenimientoDeIngresos();


                    if (MessageBox.Show("La Compra fue realizada con EXITO!!!, ¿Desea Usted Imprimir la " + this.lblTipo.Text + "?",
                   "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //frmReporteIngresos fm = new frmReporteIngresos();
                        //fm.Idventa = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                        //fm.ShowDialog();
                        limpiarCajasDeTexto();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewIngresos.Columns[10].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataGridViewIngresos.Rows[e.RowIndex].Cells[10];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

            
           
        }

        private void dataGridViewIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                this.labelAnular.Visible = true;
                this.labelAnular.Text = "Click Aqui...";
            }
            else 
            {
                this.labelAnular.Visible = true;
                this.labelAnular.Text = "";

            }
           
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);

        }

        private void dtpVencimiento_ValueChanged(object sender, EventArgs e)
        {
            btnAsignar.Enabled = true;
        }

        private void labelAnular_MouseClick(object sender, MouseEventArgs e)
        {
            tabControlIngresos.SelectedIndex = 0;
            if (tabControlIngresos.SelectedIndex == 0)
            {

                foreach (DataGridViewRow fila in dataGridViewIngresos.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[10].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de AULAR las compras Seleccionados?",
                     "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oIngresos.Modificar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);
                            actualizarDataGridViewMantenimientoDeIngresos();

                        }
                    }
                }


            }

            
        }

        private void dataGridViewIngresos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (Convert.ToString(e.Value)=="EFECTUADO" )
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


        private void pasar_encimaMouse1(object obj, EventArgs evt)
        {
            this.labelAnular.ForeColor = Color.Red;
            this.labelAnular.Text = "Anular Compras";
            this.labelAnular.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point);


        }
        private void quitar_encimaMouse1(object obj, EventArgs evt)
        {
            this.labelAnular.ForeColor = Color.Green;
            this.labelAnular.Text = "Click Aqui...";
            this.labelAnular.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);


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
            this.labelIgv.Visible = true;
            this.labelTotalPagado.Visible = true;
            this.labelSubTotal.Text = "SubTotal: S/. ";
            this.labelIgv.Text = "Total Igv: S/. ";
            this.labelTotalPagado.Text = "Total: S/. ";


            this.lblSubTotal.Visible = true;
            this.lblIgv.Visible = true;
            this.lblTotal.Visible = true;
            this.dataGridViewDetalle.Columns[10].Visible = false;
            this.dataGridViewDetalle.Columns[1].Visible = false;
            this.dataGridViewDetalle.Columns[3].Visible = false;
            tabControlIngresos.SelectedIndex = 1;
        }

        private void dataGridViewDetalle_DoubleClick(object sender, EventArgs e)
        {


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarCajasDeTexto();
            GenerarIdIngresos();
            this.rbnBoleta.Enabled = true;
            this.rbnFactura.Enabled = true;
            this.dtpVencimiento.Enabled = false;
            this.dataGridViewDetalle.Visible = false;
            this.btnAsignar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.labelSubTotal.Visible = false;
            this.lblSubTotal.Visible = false;
            this.labelIgv.Visible = false;
            this.lblIgv.Visible = false;
            this.labelTotalPagado.Visible = false;
            this.lblTotal.Visible = false;
            this.dataGridView1.Visible = true;

                
        }

        private void rbnBoleta_Click(object sender, EventArgs e)
        {
            this.btnBuscarProveedor.Enabled = true;
        }

        private void rbnFactura_Click(object sender, EventArgs e)
        {
            this.btnBuscarProveedor.Enabled = true;
        }

        private void txtStock_MouseClick(object sender, MouseEventArgs e)
        {
            this.dtpProduccion.Enabled = true;
            this.btnAsignar.Enabled = false;
        }

        private void dtpProduccion_ValueChanged(object sender, EventArgs e)
        {
            this.dtpVencimiento.Enabled = true;
        }

        private void tabControlIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlIngresos.SelectedIndex == 0)
            {
                this.limpiar();
                this.limpiarCajasDeTexto();
                this.txtCodigo.Clear();
                this.btnAsignar.Enabled = false;
                this.dtpVencimiento.Enabled = false;
                this.dataGridViewDetalle.Visible = false;
                this.labelSubTotal.Visible = false;
                this.lblSubTotal.Visible = false;
                this.labelIgv.Visible = false;
                this.lblIgv.Visible = false;
                this.labelTotalPagado.Visible = false;
                this.lblTotal.Visible = false;
                this.dataGridView1.Visible = true;
            }
            if (tabControlIngresos.SelectedIndex == 1)
            {
                this.habilitarCajasDeTexto(true);
                this.btnCancelar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCajasDeTexto();
            limpiar();
            this.dtpVencimiento.Enabled = false;
            this.txtCodigo.Clear();
            this.txtSerie.Clear();
            this.txtIgv.Clear();
            this.btnAsignar.Enabled = false;
            this.rbnBoleta.Enabled = false;
            this.rbnFactura.Enabled = false;
            this.btnCancelar.Enabled = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReporteGeneralIngresos fm = new frmReporteGeneralIngresos();
            fm.ShowDialog();
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.rbnBoleta.Checked = true;
            this.rbnFactura.Checked = true;
        }
    }
}
