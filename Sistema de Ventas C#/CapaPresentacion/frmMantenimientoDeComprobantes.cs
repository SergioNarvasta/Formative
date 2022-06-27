using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMantenimientoDeComprobantes : Form
    {
        DComprobante oComprobante = new DComprobante();
        DetalleComprobante Detalle = new DetalleComprobante();
        NDetalleComprobante oDetalle = new NDetalleComprobante();
        private List<DetalleComprobante> lista = new List<DetalleComprobante>();
       


        public frmMantenimientoDeComprobantes()
        {
            InitializeComponent();
            mostraImagen();
            this.comboBoxPago.Text = "Seleccione una Opcion"; 
            actualizarDataGridViewMantenimientoDeComprobantes();
            cargarComboBoxPago();
            dateTimePickerFecha.Enabled = true;
            this.buttonELiminarSeleccion.Enabled = false;
        }
        private void mostraImagen()
        {

            dataGridViewComprobante.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.lupa,
                Name = "lupa",
                HeaderText = "Detalle"
            });
        }
        private void GenerarIdVenta()
        {
            DComprobante oComprobante = new DComprobante();
            txtIdVenta.Text = oComprobante.GenerarIdVenta();
        }

        private void GenerarSeriedeDocumento()
        {
            DComprobante oComprobante = new DComprobante();

            lblSerie.Text = oComprobante.GenerarSerieDocumento();
        }

        private void GenerarNumeroComprobante()
        {
            DComprobante oComprobante = new DComprobante();

            if (rbnBoleta.Checked == true)
                lblNroCorrelativo.Text = oComprobante.NumeroComprobante("Boleta");
            else
                lblNroCorrelativo.Text = oComprobante.NumeroComprobante("Factura");
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
                dataGridView1.Rows[i].Cells[0].Value = lista[i].idcomprobante;
                dataGridView1.Rows[i].Cells[1].Value = lista[i].cantidad;
                dataGridView1.Rows[i].Cells[2].Value = lista[i].descripcion;
                dataGridView1.Rows[i].Cells[3].Value = lista[i].precioVenta;
                dataGridView1.Rows[i].Cells[4].Value = lista[i].Subtotal;
                dataGridView1.Rows[i].Cells[5].Value = lista[i].idproducto;
                dataGridView1.Rows[i].Cells[6].Value = lista[i].igv;
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
        public Comprobante leerObjetoComprobante()
        {
            Comprobante oComprobante = new Comprobante();
            decimal Total = 0;
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                string TipoDocumento = "";
                TipoDocumento = rbnBoleta.Checked == true ? "Boleta" : "Factura";
                oComprobante.idempleado = int.Parse(labelNombre.Text);
                oComprobante.idcliente = int.Parse(txtDocIdentidad.Text);
                oComprobante.serie = lblSerie.Text;
                oComprobante.numeroDocumento = lblNroCorrelativo.Text;
                oComprobante.tipoDocumento = TipoDocumento;
                oComprobante.fecha = Convert.ToDateTime(dateTimePickerFecha.Value);
                oComprobante.total = Convert.ToDecimal(Total);
                TipoDePago oSucursal = (TipoDePago)comboBoxPago.SelectedItem;
                oComprobante.setPago(oSucursal.idFormaPago);


            }

            return oComprobante;
        }

        private void GuardarDetalleComprobante(Int32 objIdProducto, Int32 objIdVenta,
            Int32 objCantidad, Decimal objPUnitario,
           Decimal objIgv, Decimal objSubTotal)
        {
            Detalle.idproducto = objIdProducto;
            Detalle.idcomprobante = objIdVenta;
            Detalle.cantidad = objCantidad;
            Detalle.precioVenta = objPUnitario;
            Detalle.igv = objIgv;
            Detalle.Subtotal = objSubTotal;
            Detalle.registrarDetalleComprobante();
            GenerarIdVenta();
            GenerarNumeroComprobante();

        }
        private void cargarComboBoxPago()
        {
            NTipoDePago oNTipoDePago = new NTipoDePago();
            List<TipoDePago> oListPago = oNTipoDePago.obtenerDatosEnList();
            for (int i = 0; i < oListPago.Count; i++)
            {
                comboBoxPago.Items.Add(oListPago[i]);

            }
        }
        private void limpiarCajasDeTexto()
        {

            txtDatos.Text = "";
            txtDocIdentidad.Text = "";
            comboBoxPago.Text = "Seleccione una Opcion";
            txtCantidad.Text = "";
            txtIdProducto.Text = "";
            //txtIdVenta.Text = "";
            txtIgv.Text = "";
            txtMarca.Text = "";
            txtNombre.Text = "";
            txtPVenta.Text = "";
            txtStock.Text = "";
            rbnBoleta.Checked = false;
            rbnFactura.Checked = false;
            this.dataGridView1.Rows.Clear();


        }

        private void limpiar()
        {

            txtCantidad.Text = "0";
            txtIdProducto.Clear();
            // txtIdVenta.Clear();

            txtMarca.Clear();
            txtNombre.Clear();
            txtPVenta.Text = "0";
            txtStock.Text = "0";


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
        public void actualizarDataGridViewMantenimientoDeComprobantes_2()
        {
            String buscar = textBoxBuscarxApellidos.Text;
            NComprobante oNComprobantes = new NComprobante();
            List<Comprobante> oListComprobantes = oNComprobantes.obtenerDatosEnListaDeComprobantexApellidos(buscar);
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

        private void dataGridViewComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewComprobante.Rows[e.RowIndex].Cells[10];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
       
        private void buttonELiminarSeleccion_Click(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 0;
            if (tabControlVentas.SelectedIndex == 0)
            {
                
                foreach (DataGridViewRow fila in dataGridViewComprobante.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[10].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los registros Seleccionados?",
                     "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oComprobante.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);
                            actualizarDataGridViewMantenimientoDeComprobantes();
                            this.labelTotal.Location = new Point(469, 490);
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewComprobante.Rows.Count) + " Comprobantes";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }


            }
        }

        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxApellidos.TextLength) > 0)
            {
                tabControlVentas.SelectedIndex = 0;

                NComprobante oNClientes = new NComprobante();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                Comprobante oComprobante = new Comprobante();
                String buscarXApellido = textBoxBuscarxApellidos.Text;
                oComprobante = oNClientes.BuscarApellidosComprobante(buscarXApellido);
                if (oComprobante == null)
                {
                    MessageBox.Show("El Clientes que esta Buscando no ha Realizado ninguna Compra ... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxApellidos.Clear();
                    textBoxBuscarxApellidos.Focus();
                }
                else if (oComprobante != null)
                {
                    limpiarDataGridViewComprobante();
                    actualizarDataGridViewMantenimientoDeComprobantes_2();
                    labelTotal.Visible = true;
                    labelTotal.Location = new Point(469, 490);
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewComprobante.Rows.Count) + " Clientes encontrados";
                }



            }
            else
            {
                MessageBox.Show("Ingrese los Apellidos del Clientes a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxApellidos.Focus();
                actualizarDataGridViewMantenimientoDeComprobantes();
                labelTotal.Location = new Point(469, 490);
            }

           
        }
       
        private void frmComprobante_Load(object sender, EventArgs e)
        {
            GenerarNumeroComprobante();
            GenerarSeriedeDocumento();
            GenerarIdVenta();
            this.txtIgv.Text = "18";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
            if (dataGridView1.Rows.Count > 0)
            {
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                {
                    NComprobante oNComprobante = new NComprobante();
                    oNComprobante.registrarComprobante(leerObjetoComprobante());

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
                            GuardarDetalleComprobante(
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                                Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value),
                                SumaIgv, SumaSubtotal);

                        }
                    }
                    actualizarDataGridViewMantenimientoDeComprobantes();
                   

                    if (MessageBox.Show("La venta fue realizada con EXITO!!!, ¿Desea Usted Imprimir la " + this.lblTipo.Text + "?",
                   "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmReporteComprobante fm = new frmReporteComprobante();
                        fm.Idventa = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                        fm.ShowDialog();
                        limpiarCajasDeTexto();
                        btnGuardar.Enabled = false;
                        btnAnular.Enabled = false;
                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
            frmListarCliente fm = new frmListarCliente();
            AddOwnedForm(fm);
            fm.ShowDialog();
        }

        private void buttonBuscar1_Click_1(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
            frmVistaProductos_Ventas fm = new frmVistaProductos_Ventas();
            AddOwnedForm(fm);
            fm.ShowDialog();
        }

        private void btnAgregarItem_Click_1(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
            DetalleComprobante V = new DetalleComprobante();
            Decimal porcentaje = 0;
            Decimal subTotal = 0;
            if (this.txtDocIdentidad.Text.Trim() != "")
            {
                if (txtNombre.Text.Trim() != "")
                {
                    if (txtCantidad.Text.Trim() != "")
                    {
                        if (Convert.ToInt32(txtCantidad.Text) >= 0)
                        {
                            if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text))
                            {
                                if (txtIgv.Text.Trim() != "")
                                {
                                    V.idproducto = Convert.ToInt32(txtIdProducto.Text);
                                    V.idcomprobante = Convert.ToInt32(txtIdVenta.Text);
                                    V.descripcion = txtNombre.Text + " - " + txtMarca.Text;
                                    V.cantidad = Convert.ToInt32(txtCantidad.Text);
                                    V.precioVenta = Convert.ToDecimal(txtPVenta.Text);
                                    porcentaje = (Convert.ToDecimal(txtIgv.Text) / 100) + 1;
                                    subTotal = ((Convert.ToDecimal(txtPVenta.Text) * Convert.ToInt32(txtCantidad.Text)) / porcentaje);
                                    V.igv = Math.Round(Convert.ToDecimal(subTotal) * (Convert.ToDecimal(txtIgv.Text) / (100)), 2);
                                    V.Subtotal = Math.Round(subTotal, 2);
                                    lista.Add(V);
                                    llenarGrillas();
                                    btnGuardar.Enabled = true;
                                    btnAnular.Enabled = true;
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
                                MessageBox.Show("Stock Insuficiente para Realizar la Venta.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cantidad Ingresada no Válida.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtCantidad.Clear();
                            txtCantidad.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Ingrese Cantidad a Vender.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtCantidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Busque el Producto a Vender.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            else
            {
                MessageBox.Show("Por Favor Busque el Cliente a Vender.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnQuitarItem_Click_1(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
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
        private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "FACTURA";
                
            }

            else
            {
                lblTipo.Text = "BOLETA DE VENTA";
                
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxApellidos.TextLength) > 0)
                {
                    tabControlVentas.SelectedIndex = 0;

                    NComprobante oNClientes = new NComprobante();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    Comprobante oComprobante = new Comprobante();
                        String buscarXApellido = textBoxBuscarxApellidos.Text;
                        oComprobante = oNClientes.BuscarApellidosComprobante(buscarXApellido);
                        if (oComprobante == null)
                        {
                            MessageBox.Show("El Clientes que esta Buscando no ha Realizado ninguna Compra ... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxApellidos.Clear();
                            textBoxBuscarxApellidos.Focus();
                        }
                        else if (oComprobante != null)
                        {
                            limpiarDataGridViewComprobante();
                            actualizarDataGridViewMantenimientoDeComprobantes_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(469, 490);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewComprobante.Rows.Count) + " Clientes encontrados";
                        }
                    


                }
                else
                {
                    MessageBox.Show("Ingrese los Apellidos del Clientes a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxApellidos.Focus();
                    actualizarDataGridViewMantenimientoDeComprobantes();
                    labelTotal.Location = new Point(469, 490);
                }
               
            }
        }

        private void textBoxBuscarxApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBuscarxApellidos.Clear();
        }

        private void dataGridViewComprobante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                this.buttonELiminarSeleccion.Enabled = true;
            }
            else
            {
                this.buttonELiminarSeleccion.Enabled = false;

            }

            if (e.ColumnIndex == 11)
            {

                this.textBoxId.Text = dataGridViewComprobante.CurrentRow.Cells[0].Value.ToString();
                Reportes.frmReporteComprobante frm = new Reportes.frmReporteComprobante();
                frm.Idventa = int.Parse(textBoxId.Text);
                frm.ShowDialog();
            }
        }
        
      
        private void rbnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            GenerarNumeroComprobante();
        }

        private void tabControlVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlVentas.SelectedIndex == 1)
            {
                GenerarIdVenta();
                this.txtIgv.Text = "18";
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txtCantidad.Clear();
            btnAgregarItem.Enabled = true;
            btnQuitarItem.Enabled = true;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            tabControlVentas.SelectedIndex = 1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReporteGeneralDeComprobantes fm = new frmReporteGeneralDeComprobantes();
            fm.ShowDialog();
        }

    }
}
