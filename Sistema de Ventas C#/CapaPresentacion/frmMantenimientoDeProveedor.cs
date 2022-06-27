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
    public partial class frmMantenimientoDeProveedor : Form
    {
        Proveedor oProveedor = new Proveedor();
        DProveedor oDProveedor = new DProveedor();
        private int accion = DAccion.NO_ACCION;
        public frmMantenimientoDeProveedor()
        {
            InitializeComponent();
            this.comboBoxSectorComercial.Text = "Seleccione una Opcion";
            this.comboBoxBuscar.Text = "Seleccione una Opcion";
            this.radioButtonFactura.Checked = false;
            this.radioButtonBoleta.Checked = false;

            actualizarDataGridViewProveedor();
            accion = DAccion.ACCION_INSERTAR;
            habilitarControles(true, false, false, false, false, true);
           
            
        }

        public Proveedor getObjetoProveedor()
        {
            Proveedor oDProveedors = new Proveedor();

            //oDProveedors.setIdproveedor(int.Parse(textBoxIdProveedor.Text));
            string TipoDocumento = "";
            TipoDocumento = radioButtonBoleta.Checked == true ? "Boleta" : "Factura";
            oDProveedors.setRazon(textBoxRazonSocial.Text);
            oDProveedors.setDireccion((textBoxDireccion.Text));
            oDProveedors.setSector(comboBoxSectorComercial.Text);
            oDProveedors.setTipo(TipoDocumento);
            oDProveedors.setNumero(textBoxNumeroDocumento.Text);
            oDProveedors.setTelefono((textBoxCelular.Text));
            oDProveedors.setEmail(textBoxEmail.Text);
            oDProveedors.setUrl(textBoxUrl.Text);

            return oDProveedors;
        }
        public Proveedor getObjetoProveedor_1()
        {
            Proveedor oDProveedors = new Proveedor();
            string TipoDocumento = "";
            TipoDocumento = radioButtonBoleta.Checked == true ? "Boleta" : "Factura";
            
            oDProveedors.setIdproveedor(int.Parse(textBoxIdProveedor.Text));
            oDProveedors.setRazon(textBoxRazonSocial.Text);
            oDProveedors.setDireccion((textBoxDireccion.Text));
            oDProveedors.setSector(comboBoxSectorComercial.Text);
            oDProveedors.setTipo(TipoDocumento);
            oDProveedors.setNumero(textBoxNumeroDocumento.Text);
            oDProveedors.setTelefono((textBoxCelular.Text));
            oDProveedors.setEmail(textBoxEmail.Text);
            oDProveedors.setUrl(textBoxUrl.Text);

            return oDProveedors;
        }


        public void setObjetoProveedors(Proveedor oDProveedors)
        {
            textBoxIdProveedor.Text = oDProveedors.getIdproveedor() + "";
            textBoxRazonSocial.Text = oDProveedors.getRazon() + "";
            textBoxDireccion.Text = oDProveedors.getDireccion() + "";
            comboBoxSectorComercial.Text = oDProveedors.getSector() + "";
            lblTipo.Text = oDProveedors.getTipo() + "";
            textBoxNumeroDocumento.Text = oDProveedors.getNumero() + "";
            textBoxCelular.Text = oDProveedors.getTelefono() + "";
            textBoxEmail.Text = oDProveedors.getEmail() + "";
            textBoxUrl.Text = oDProveedors.getUrl() + "";
           }
       
        public void actualizarDataGridViewProveedor()
        {
            limpiarDataGridViewProveedor();
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";

            }


        }
        public void actualizarDataGridViewProveedor_1()
        {
            string buscar = textBoxBuscarxRazonSocial.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxRazonSocial(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }

        public void actualizarDataGridViewProveedor_2()
        {
            string buscar = textBoxBuscar.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxBoleta(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }
        public void actualizarDataGridViewProveedor_3()
        {
            string buscar = textBoxBuscar.Text;
            NProveedor oNProveedors = new NProveedor();
            List<Proveedor> oListProveedors = oNProveedors.obtenerDatosEnListaDeProveedorxFactura(buscar);
            for (int posicion = 0; posicion < oListProveedors.Count; posicion = posicion + 1)
            {
                if (oListProveedors[posicion].getIdproveedor() != 0)
                {
                    dataGridViewProveedor.Rows.Add(
                        oListProveedors[posicion].getIdproveedor(),
                        oListProveedors[posicion].getRazon(),
                        oListProveedors[posicion].getDireccion(),
                        oListProveedors[posicion].getSector(),
                        oListProveedors[posicion].getNumero(),
                        oListProveedors[posicion].getTipo(),
                        oListProveedors[posicion].getTelefono(),
                        oListProveedors[posicion].getEmail(),
                        oListProveedors[posicion].getUrl());
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";


            }


        }


        private void habilitarControles(Boolean cNuevo, Boolean cGuardar, Boolean cEditar,
          Boolean cEliminar, Boolean cCancelar, Boolean cImprimir)
        {

            buttonNuevo.Enabled = cNuevo;
            buttonGuardar.Enabled = cGuardar;
            buttonModificar.Enabled = cEditar;
            buttonEliminar.Enabled = cEliminar;
            buttonCancelar.Enabled = cCancelar;
            buttonImprimir.Enabled = cImprimir;

        }



        private void limpiarDataGridViewProveedor()
        {
            dataGridViewProveedor.Rows.Clear();

        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxRazonSocial.Enabled = editable;
            textBoxCelular.Enabled = editable;
            textBoxDireccion.Enabled = editable;
            textBoxEmail.Enabled = editable;
            lblTipo.Enabled = editable;
            comboBoxSectorComercial.Enabled = editable;
            textBoxUrl.Enabled = editable;

        }
        private void habilitarCajasDeTexto_1(Boolean editable)
        {
            //textBoxRazonSocial.Enabled = editable;
            textBoxCelular.Enabled = editable;
            textBoxDireccion.Enabled = editable;
            textBoxEmail.Enabled = editable;
            lblTipo.Enabled = editable;
            comboBoxSectorComercial.Enabled = editable;
            textBoxUrl.Enabled = editable;

        }

        
        private void limpiarCajasDeTexto()
        {

            textBoxIdProveedor.Text = "";
            textBoxRazonSocial.Text = "";
            textBoxDireccion.Text = "";
            comboBoxSectorComercial.Text = "Seleccione una Opcion";
            lblTipo.Text = "";
            textBoxNumeroDocumento.Clear();
            textBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxUrl.Text = "";
            radioButtonBoleta.Checked = false;
            radioButtonFactura.Checked = false;
            
          
        }


        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Boleta")
            {
                this.textBoxBuscar.Text = Convert.ToString(this.comboBoxBuscar.SelectedItem);
                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Clear();

                NProveedor oNProveedor = new NProveedor();
                String buscar = this.textBoxBuscar.Text;
                Proveedor oProveedor = oNProveedor.BuscarBoletaProveedor(buscar);
                if (oProveedor != null)
                {
                    limpiarDataGridViewProveedor();
                    this.actualizarDataGridViewProveedor_2();
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores encontrados";

                }


            }
            else if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Factura")
            {
                this.textBoxBuscar.Text = Convert.ToString(this.comboBoxBuscar.SelectedItem);

                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Clear();

                NProveedor oNProveedor = new NProveedor();
                String buscar = this.textBoxBuscar.Text;
                Proveedor oProveedor = oNProveedor.BuscarFacturaProveedor(buscar);
                if (oProveedor != null)
                {
                    limpiarDataGridViewProveedor();
                    this.actualizarDataGridViewProveedor_3();
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores encontrados";

                }

            }
            else if (Convert.ToString(this.comboBoxBuscar.SelectedItem) == "Razon Social")
            {
                this.textBoxBuscar.Clear();
                this.label7.Location = new Point(53, 31);
                this.comboBoxBuscar.Location = new Point(137, 28);
                this.textBoxBuscarxRazonSocial.Visible = true;
                this.buttonBuscarxRazon.Visible = true;
                this.textBoxBuscarxRazonSocial.Location = new Point(357, 28);
                this.buttonBuscarxRazon.Location = new Point(647, 29);
                this.textBoxBuscarxRazonSocial.Focus();
                this.actualizarDataGridViewProveedor();
                
            }

        }

        private void frmMantenimientoDeProveedor_Load(object sender, EventArgs e)
        {
            //GenerarNumeroProveedor();

            this.label7.Location = new Point(190, 30);
            this.comboBoxBuscar.Location = new Point(274, 27);
            this.habilitarCajasDeTexto_1(false);
            labelTotal.Location = new Point(470, 296);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";
            habilitarControles(true, false, false, false, true, true);
        }

        private void tabControlProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControlProveedor.SelectedIndex == 0)
            {
                this.comboBoxBuscar.Text = "Seleccione una Opcion";
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                this.textBoxBuscarxRazonSocial.Clear();
                this.limpiarCajasDeTexto();

                this.habilitarCajasDeTexto(false);
                this.textBoxIdProveedor.Enabled = false;
                this.habilitarControles(true, false, false, false, true, true);
                this.buttonNuevo.Focus();
            }
            if (this.tabControlProveedor.SelectedIndex == 1)
            {
                this.textBoxBuscar.Clear();
                this.labelMensaje.Visible = false;
                this.pictureBoxIcono.Visible = false;
                this.buttonNuevo.Enabled = true;
                this.buttonCancelar.Enabled = true;
                this.buttonNuevo.Focus();
                
            }
        }

        private void comboBoxDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Convert.ToString(this.comboBoxDocumento.SelectedItem) == "Boleta")
            //{
            
            //    this.textBoxNumeroDocumento.Text = oProveedor.NumeroProveedor("Boleta");
            //    this.textBoxCelular.Focus();
            //}
            //else if (Convert.ToString(this.comboBoxDocumento.SelectedItem) == "Factura")
            //{
            //    DProveedor oProveedor = new DProveedor();
            //    this.textBoxNumeroDocumento.Text = oProveedor.NumeroProveedor("Factura");
            //    this.textBoxCelular.Focus();
            //}
           
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string texto = textBoxEmail.Text;
            bool validar = texto.Contains("@gmail.com") || texto.Contains("@hotmail.com");
            if (validar == true)
            {
                this.pictureBoxIcono.Visible = false;
                this.labelMensaje.Visible = false;
                this.labelMensaje.Text = "";
                
            }
            else
            {
                this.pictureBoxIcono.Visible = true;
                this.labelMensaje.Visible = true;
                this.labelMensaje.Text = "El email debe ser example@gmail.com o \nexample@hotmail.com";
                textBoxEmail.Clear();
                textBoxEmail.Focus();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlProveedor.SelectedIndex = 1;

            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxRazonSocial.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Razon social del Proveedor",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRazonSocial.Focus();
                }
                else if (textBoxDireccion.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Direccion del Proveedor",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxDireccion.Focus();
                }
                else if (textBoxCelular.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Celular del Proveedor",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCelular.Focus();
                }
                else if (comboBoxSectorComercial.Text.Equals(""))
                {
                    MessageBox.Show("Falta seleccionar un Sector comercial...",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxSectorComercial.Focus();
                }
               
                else if (textBoxEmail.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Email del Proveedor",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEmail.Focus();
                }
                else if (textBoxUrl.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Pagina web del Proveedor",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxUrl.Focus();
                }

                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NProveedor oNProveedors = new NProveedor();
                        if (oNProveedors.registrarProveedor(getObjetoProveedor()))
                        {
                            habilitarControles(true, false, false, false, true, false);
                            buttonNuevo.Focus();
                            actualizarDataGridViewProveedor();
                            habilitarCajasDeTexto(false);
                            textBoxIdProveedor.Enabled = false;
                            limpiarCajasDeTexto();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el registro ... !!!");
                        }
                    }
                    else
                    {

                        accion = DAccion.NO_ACCION;

                    }
                }
            }
            else if (accion == DAccion.ACCION_MODIFICAR)
            {
                if (MessageBox.Show("Esta Seguro de guardar los datos?",
                       "Confirmar el Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NProveedor oNProveedors = new NProveedor();
                    Proveedor oProveedors = new Proveedor();
                    if (oNProveedors.editarProveedor(int.Parse(textBoxIdProveedor.Text), getObjetoProveedor_1()))
                    {
                        MessageBox.Show("Proveedor Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewProveedor();
                        limpiarCajasDeTexto();
                        tabControlProveedor.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, false);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el PROVEEDOR ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewProveedor_DoubleClick(object sender, EventArgs e)
        {
            this.textBoxIdProveedor.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[0].Value);
            this.textBoxRazonSocial.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[1].Value);
            this.textBoxDireccion.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[2].Value);
            this.comboBoxSectorComercial.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[3].Value);
            this.textBoxNumeroDocumento.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[4].Value);
            this.lblTipo.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[5].Value);
            this.textBoxCelular.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[6].Value);
            this.textBoxEmail.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[7].Value);
            this.textBoxUrl.Text = Convert.ToString(this.dataGridViewProveedor.CurrentRow.Cells[8].Value);

            if (this.lblTipo.Text == "Factura")
            {
                this.radioButtonFactura.Checked = true;
            }
            else 
            {
                this.radioButtonBoleta.Checked = true;
            }
            habilitarCajasDeTexto(false);
            habilitarControles(false, false, true, true, true, true);

            tabControlProveedor.SelectedIndex = 1;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewProveedor.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxIdProveedor.Text.Length) > 0)
            {
                textBoxRazonSocial.Focus();
                accion = DAccion.ACCION_MODIFICAR;
                habilitarControles(false, true, false, false, true, false);
                habilitarCajasDeTexto(true);
                textBoxIdProveedor.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un registro ...!!!");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (tabControlProveedor.SelectedIndex == 0)
            {

                foreach (DataGridViewRow fila in dataGridViewProveedor.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[9].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los registros Seleccionados?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oDProveedor.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);

                            actualizarDataGridViewProveedor();
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedores";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }


            }
            if (tabControlProveedor.SelectedIndex == 1)
            {

                tabControlProveedor.SelectedIndex = 1;
                if (dataGridViewProveedor.RowCount >= 1)
                {

                    int filaSeleccionada = dataGridViewProveedor.CurrentRow.Index;
                    if (filaSeleccionada != -1 && (textBoxIdProveedor.Text.Length) > 0)
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los datos del PROVEEDOR?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NProveedor oNProveedors = new NProveedor();
                            Proveedor oProveedors = new Proveedor();
                            int buscar = int.Parse(textBoxIdProveedor.Text);
                            oProveedors = oNProveedors.BuscarIdProveedor(buscar);
                            if (oProveedors != null)
                            {
                                oProveedors = getObjetoProveedor();
                                oProveedors.setIdproveedor(buscar);
                                if (oNProveedors.eliminarProveedor(buscar))
                                {
                                    MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    buttonNuevo.Focus();
                                    textBoxIdProveedor.Enabled = false;
                                    habilitarCajasDeTexto(false);
                                    limpiarCajasDeTexto();
                                    habilitarControles(false, false, false, false, true, false);

                                    tabControlProveedor.SelectedIndex = 0;
                                    actualizarDataGridViewProveedor();
                                    pictureBoxLupa.Visible = true;
                                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                                }
                                else
                                {
                                    MessageBox.Show("No se pudo ELIMINAR el registro...!!!",
                                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    accion = DAccion.NO_ACCION;

                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo ELIMINAR el registro...!!!",
                                       "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                accion = DAccion.NO_ACCION;

                            }
                        }
                        else
                        {
                            accion = DAccion.NO_ACCION;

                        }
                    }
                    else
                    {

                        MessageBox.Show("Se tiene que seleccionar un REGISTRO....!!!",
                                   "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        accion = DAccion.NO_ACCION;

                    }


                }
                else
                {
                    MessageBox.Show("No Existen REGISTROS....!!!",
                                   "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accion = DAccion.NO_ACCION;

                }
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlProveedor.SelectedIndex = 1;
            limpiarCajasDeTexto();
            textBoxIdProveedor.Enabled = false;
            textBoxRazonSocial.Enabled = true;
            textBoxRazonSocial.Focus();
            pictureBoxLupa.Visible = true;
            habilitarControles(true, false, false, false, true, false);
        
        }

        private void textBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                tabControlProveedor.SelectedIndex = 1;
                if ((textBoxRazonSocial.TextLength) > 0)
                {
                    Proveedor oProveedors = new Proveedor();
                    NProveedor oNProveedors = new NProveedor();

                   string busqueda = textBoxRazonSocial.Text;
                    oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                    if (oProveedors == null)
                    {

                        textBoxRazonSocial.Enabled = false;
                        habilitarCajasDeTexto(true);
                        radioButtonBoleta.Checked = false;
                        radioButtonFactura.Checked = false;
                        textBoxDireccion.Focus();
                        habilitarControles(false, true, false, false, true, false);
                    }
                    else if (oProveedors != null)
                    {
                        MessageBox.Show("PROVEEDOR encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoProveedors(oProveedors);
                        if (this.lblTipo.Text == "Factura")
                        {
                            this.radioButtonFactura.Checked = true;
                        }
                        else
                        {
                            this.radioButtonBoleta.Checked = true;
                        }
                        textBoxRazonSocial.Enabled = false;
                        habilitarControles(false, false, true, true, true, true);
                        buttonCancelar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Proveedor Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxRazonSocial.Clear();

                        textBoxRazonSocial.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la Razon Social del PROVEEDOR... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRazonSocial.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                }
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            tabControlProveedor.SelectedIndex = 1;
            if ((textBoxRazonSocial.TextLength) > 0)
            {
                Proveedor oProveedors = new Proveedor();
                NProveedor oNProveedors = new NProveedor();

                string busqueda = textBoxRazonSocial.Text;
                oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                if (oProveedors == null)
                {

                    textBoxRazonSocial.Enabled = false;
                    habilitarCajasDeTexto(true);
                    radioButtonBoleta.Checked = false;
                    radioButtonFactura.Checked = false;
                    textBoxDireccion.Focus();
                    habilitarControles(false, true, false, false, true, false);
                }
                else if (oProveedors != null)
                {
                    MessageBox.Show("PROVEEDOR encontrado ... !!!",
                      "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setObjetoProveedors(oProveedors);
                    if (this.lblTipo.Text == "Factura")
                    {
                        this.radioButtonFactura.Checked = true;
                    }
                    else
                    {
                        this.radioButtonBoleta.Checked = true;
                    }
                    textBoxRazonSocial.Enabled = false;
                    habilitarControles(false, false, true, true, true, true);
                    buttonCancelar.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar al Proveedor Solicitado",
                        "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxRazonSocial.Clear();

                    textBoxRazonSocial.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                }
            }
            else
            {
                MessageBox.Show("Ingrese la Razon Social del PROVEEDOR... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRazonSocial.Focus();
                buttonCancelar.Enabled = true;
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (tabControlProveedor.SelectedIndex == 0)
            {
                textBoxBuscar.Enabled = false;
                textBoxBuscar.Clear();
                this.comboBoxBuscar.Text = "Seleccione una Opcion";
                this.label7.Location = new Point(190, 30);
                this.comboBoxBuscar.Location = new Point(274, 27);
                this.textBoxBuscarxRazonSocial.Visible = false;
                this.buttonBuscarxRazon.Visible = false;
                
                textBoxBuscarxRazonSocial.Clear();
                actualizarDataGridViewProveedor();
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();

            }
            if (tabControlProveedor.SelectedIndex == 1)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();
            }
            
            
        }

        private void textBoxBuscarxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxRazonSocial.TextLength) > 0)
                {
                    tabControlProveedor.SelectedIndex = 0;

                    Proveedor oProveedors = new Proveedor();
                    NProveedor oNProveedors = new NProveedor();

                    string busqueda = textBoxBuscarxRazonSocial.Text;
                    oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                    if (oProveedors == null)
                    {

                        MessageBox.Show("La Razon Social del Proveedor que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxRazonSocial.Clear();
                        textBoxBuscarxRazonSocial.Focus();
                    }
                    else if (oProveedors != null)
                    {
                        limpiarDataGridViewProveedor();
                        actualizarDataGridViewProveedor_1();
                        labelTotal.Location = new Point(470, 296);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors encontrados";

                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese la Razon Social del PROVEEDOR a buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxRazonSocial.Focus();
                    actualizarDataGridViewProveedor();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

                }
                this.buttonCancelar.Enabled = true;
            }
        }

        private void buttonBuscarxRazon_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxRazonSocial.TextLength) > 0)
            {
                tabControlProveedor.SelectedIndex = 0;

                Proveedor oProveedors = new Proveedor();
                NProveedor oNProveedors = new NProveedor();

                string busqueda = textBoxBuscarxRazonSocial.Text;
                oProveedors = oNProveedors.BuscarRazonSocialProveedor(busqueda);


                if (oProveedors == null)
                {

                    MessageBox.Show("La Razon Social del Proveedor que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxRazonSocial.Clear();
                    textBoxBuscarxRazonSocial.Focus();
                }
                else if (oProveedors != null)
                {
                    limpiarDataGridViewProveedor();
                    actualizarDataGridViewProveedor_1();
                    labelTotal.Location = new Point(470, 296);
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors encontrados";

                }

            }
            else
            {
                MessageBox.Show("Ingrese la Razon Social del PROVEEDOR a buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxRazonSocial.Focus();

                actualizarDataGridViewProveedor();
                buttonCancelar.Enabled = true;
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewProveedor.Rows.Count) + " Proveedors";

            }
            this.buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxRazonSocial_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxRazonSocial.Clear();
        }

        private void dataGridViewProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewProveedor.Rows[e.RowIndex].Cells[9];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                this.buttonEliminar.Enabled = true;
            }
            else
            {
                this.buttonEliminar.Enabled = false;

            }
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);

        }

        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);

        }

        private void radioButtonFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFactura.Checked == true)
            {
                lblTipo.Text = "Factura";

            }

            else
            {
                lblTipo.Text = "Boleta";


            }
            GenerarNumeroProveedor();
        }
        private void GenerarNumeroProveedor()
        {
            DProveedor oProveedor = new DProveedor();

            if (radioButtonBoleta.Checked == true)
                textBoxNumeroDocumento.Text = oProveedor.NumeroComprobante("Boleta");
            else
                textBoxNumeroDocumento.Text = oProveedor.NumeroComprobante("Factura");
        }
        private void radioButtonBoleta_CheckedChanged(object sender, EventArgs e)
        {
            GenerarNumeroProveedor();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            frmReporteProveedor fm = new frmReporteProveedor();
            fm.ShowDialog();
        }


    }
}
