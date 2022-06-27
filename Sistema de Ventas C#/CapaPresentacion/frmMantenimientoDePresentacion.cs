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
    public partial class frmMantenimientoDePresentacion : Form
    {
        DPresentacion oPresentacion = new DPresentacion();
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;
        public frmMantenimientoDePresentacion()
        {
            InitializeComponent();
            
            textBoxBuscarxNombre.Enabled = false;
            buttonBuscarxNombre.Visible = false;
            habilitarCajasDeTexto(false);
            habilitarControles(true, false, false, false, false, true);
            actualizarDataGridViewMantenimientoDePresentacion();
            accion = DAccion.ACCION_INSERTAR;
        }
        //private void mostraImagen()
        //{

        //    dataGridViewMantenimientoDePresentacion.Columns.Add(new DataGridViewImageColumn()
        //    {
        //        Image = Properties.Resources.eliminar,
        //        Name = "eliminar",
        //        HeaderText = "Eliminar"
        //    });
        //}
        public Presentacion getObjetoPresentacion()
        {
            Presentacion oDPresentacion = new Presentacion();
            oDPresentacion.setNombre(textBoxNombre.Text);
            oDPresentacion.setDescripcion(richTextBoxDscripcion.Text);

            return oDPresentacion;
        }

        public Presentacion getObjetoPresentacion_1()
        {
            Presentacion oDPresentacion = new Presentacion();
            oDPresentacion.setIdPresentacion(int.Parse(textBoxCodigo.Text));
            oDPresentacion.setNombre(textBoxNombre.Text);
            oDPresentacion.setDescripcion(richTextBoxDscripcion.Text);


            return oDPresentacion;
        }

        public void setObjetoPresentacion(Presentacion oDPresentacion)
        {
            textBoxCodigo.Text = oDPresentacion.getIdPresentacion() + "";
            textBoxNombre.Text = oDPresentacion.getNombre() + "";
            richTextBoxDscripcion.Text = oDPresentacion.getDescripcion() + "";

        }

        private void limpiarCajasDeTexto()
        {

            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            richTextBoxDscripcion.Text = "";
            
        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            richTextBoxDscripcion.Enabled = editable;

        }
        private void habilitarControles(Boolean cNuevo, Boolean cGuardar, Boolean cEditar,
            Boolean cEliminar, Boolean cCancelar, Boolean cImprimir)
        {

            buttonNuevo.Enabled = cNuevo;
            buttonGuardar.Enabled = cGuardar;
            buttonEditar.Enabled = cEditar;
            buttonEliminar.Enabled = cEliminar;
            buttonCancelar.Enabled = cCancelar;
            buttonImprimir.Enabled = cImprimir;

        }

        public void actualizarDataGridViewMantenimientoDePresentacion()
        {
            limpiarDataGridViewMantenimientoDePresentacion();
            NPresentacion oNPresentacion = new NPresentacion();
            List<Presentacion> oListPresentacion = oNPresentacion.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListPresentacion.Count; posicion = posicion + 1)
            {
                if (oListPresentacion[posicion].idPresentacion != 0)
                {
                    dataGridViewMantenimientoDePresentacion.Rows.Add(
                        oListPresentacion[posicion].idPresentacion,
                        oListPresentacion[posicion],
                        oListPresentacion[posicion].descripcion

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

            }

        }

        public void actualizarDataGridViewMantenimientoDePresentacion_1()
        {
            String buscar = textBoxBuscarxNombre.Text;
            limpiarDataGridViewMantenimientoDePresentacion();
            NPresentacion oNPresentacion = new NPresentacion();
            List<Presentacion> oListPresentacion = oNPresentacion.obtenerDatosEnListaDePresentacion(buscar);
            for (int posicion = 0; posicion < oListPresentacion.Count; posicion = posicion + 1)
            {
                if (oListPresentacion[posicion].idPresentacion != 0)
                {
                    dataGridViewMantenimientoDePresentacion.Rows.Add(
                        oListPresentacion[posicion].idPresentacion,
                        oListPresentacion[posicion],
                        oListPresentacion[posicion].descripcion
                         );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

            }

        }

        
        private void limpiarDataGridViewMantenimientoDePresentacion()
        {
            dataGridViewMantenimientoDePresentacion.Rows.Clear();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlPresentacion.SelectedIndex = 1;
            limpiarCajasDeTexto();
            textBoxNombre.Enabled = true;
            textBoxNombre.Focus();
            habilitarControles(true, false, false, false, true, true);
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlPresentacion.SelectedIndex = 1;
            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxNombre.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Nombre de la Presentacion",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombre.Focus();
                }
                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NPresentacion oNPresentacion = new NPresentacion();
                        if (oNPresentacion.registrarPresentacion(getObjetoPresentacion()))
                        {
                            habilitarControles(true, false, false, false, true, true);
                            buttonNuevo.Focus();
                            actualizarDataGridViewMantenimientoDePresentacion();
                            habilitarCajasDeTexto(false);
                            textBoxNombre.Enabled = false;
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
                    NPresentacion oNPresentacion = new NPresentacion();
                    Presentacion oPresentacion = new Presentacion();
                    if (oNPresentacion.editarPresentacion(int.Parse(textBoxCodigo.Text), getObjetoPresentacion_1()))
                    {
                        MessageBox.Show("CATEGORIA Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewMantenimientoDePresentacion();
                        limpiarCajasDeTexto();
                        tabControlPresentacion.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, true);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar la PRESENTACION ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewMantenimientoDePresentacion_DoubleClick(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDePresentacion.CurrentRow.Index;
            if (filaSeleccionada != -1)
            {

                Presentacion oPresentacionSeleccionado = (Presentacion)dataGridViewMantenimientoDePresentacion.Rows[filaSeleccionada].Cells[1].Value;
                setObjetoPresentacion(oPresentacionSeleccionado);
                Presentacion oPresentacion = new Presentacion();

                buttonGuardar.Enabled = false;
                buttonEditar.Enabled = true;
                buttonEliminar.Enabled = true;
                textBoxCodigo.Enabled = false;
                textBoxNombre.Enabled = false;
                habilitarCajasDeTexto(false);
                habilitarControles(false, false, true, true, true, true);

            }

            this.tabControlPresentacion.SelectedIndex = 1;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDePresentacion.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
            {
                
                accion = DAccion.ACCION_MODIFICAR;
                
                habilitarControles(false, true, false, false, true, true);
                habilitarCajasDeTexto(true);
                textBoxNombre.Enabled = true;
                textBoxNombre.Focus();
                textBoxCodigo.Enabled = false;
                pictureBoxLupa.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un registro ...!!!");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (tabControlPresentacion.SelectedIndex == 0)
            {
                
                foreach (DataGridViewRow fila in dataGridViewMantenimientoDePresentacion.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[3].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los registros Seleccionados?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oPresentacion.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);

                            actualizarDataGridViewMantenimientoDePresentacion();
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Productos";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }


             }

            if (tabControlPresentacion.SelectedIndex == 1)
            {


                tabControlPresentacion.SelectedIndex = 1;
                if (dataGridViewMantenimientoDePresentacion.RowCount >= 1)
                {

                    int filaSeleccionada = dataGridViewMantenimientoDePresentacion.CurrentRow.Index;
                    if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los datos de la PRESENTACION?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NPresentacion oNPresentacion = new NPresentacion();
                            Presentacion oPresentacion = new Presentacion();
                            int buscar = int.Parse(textBoxCodigo.Text);
                            oPresentacion = oNPresentacion.BuscarPresentacion(buscar);
                            if (oPresentacion != null)
                            {
                                oPresentacion = getObjetoPresentacion();
                                oPresentacion.setIdPresentacion(buscar);
                                if (oNPresentacion.eliminarPresentacion(buscar))
                                {
                                    MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    buttonNuevo.Focus();
                                    textBoxCodigo.Enabled = false;
                                    habilitarCajasDeTexto(false);
                                    limpiarCajasDeTexto();
                                    habilitarControles(false, false, false, false, true, true);

                                    tabControlPresentacion.SelectedIndex = 0;
                                    actualizarDataGridViewMantenimientoDePresentacion();
                                    pictureBoxLupa.Visible = true;
                                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (tabControlPresentacion.SelectedIndex == 0)
            {
                textBoxBuscarxNombre.Enabled = false;
                textBoxBuscarxNombre.Clear();
                buttonBuscarxNombre.Visible = false;
                radioButtonNombre.Checked = false;
                actualizarDataGridViewMantenimientoDePresentacion();
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();

            }
            if (tabControlPresentacion.SelectedIndex == 1)
            {
                limpiarCajasDeTexto();
                textBoxNombre.Enabled = false;
                habilitarCajasDeTexto(false);

                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();
            }
            
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            
                tabControlPresentacion.SelectedIndex = 1;
                if ((textBoxNombre.TextLength) > 0)
                {
                    Presentacion oPresentacion = new Presentacion();
                    NPresentacion oNPresentacion = new NPresentacion();

                    string busqueda = textBoxNombre.Text;
                    oPresentacion = oNPresentacion.BuscarPresentacionxNombre(busqueda);


                    if (oPresentacion == null)
                    {

                        textBoxNombre.Enabled = false;
                        habilitarCajasDeTexto(true);
                        richTextBoxDscripcion.Focus();
                        habilitarControles(false, true, false, false, true, false);
                    }
                    else if (oPresentacion != null)
                    {
                        MessageBox.Show("PRESENTACION encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoPresentacion(oPresentacion);
                        textBoxNombre.Enabled = false;
                        
                        habilitarControles(false, false, true, true, true, false);
                        buttonCancelar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Presentacion Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNombre.Clear();

                        textBoxNombre.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre de la PRESENTACION... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

                }
            }
            
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                tabControlPresentacion.SelectedIndex = 1;
                if ((textBoxNombre.TextLength) > 0)
                {
                    Presentacion oPresentacion = new Presentacion();
                    NPresentacion oNPresentacion = new NPresentacion();

                    string busqueda = textBoxNombre.Text;
                    oPresentacion = oNPresentacion.BuscarPresentacionxNombre(busqueda);


                    if (oPresentacion == null)
                    {

                        textBoxNombre.Enabled = false;
                        habilitarCajasDeTexto(true);
                        richTextBoxDscripcion.Focus();
                        habilitarControles(false, true, false, false, true, false);
                    }
                    else if (oPresentacion != null)
                    {
                        MessageBox.Show("PRESENTACION encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoPresentacion(oPresentacion);
                        textBoxNombre.Enabled = false;
                        
                        habilitarControles(false, false, true, true, true, false);
                        buttonCancelar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Presentacion Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNombre.Clear();

                        textBoxNombre.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el NOmbre de la PRESENTACION... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";

                }
            }
        }

        private void frmMantenimientoDePresentacion_Load(object sender, EventArgs e)
        {
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion";
            habilitarControles(true, false, false, false, false, true);
      
        }

        private void tabControlPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPresentacion.SelectedIndex == 0)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                textBoxCodigo.Enabled = false;
                habilitarControles(true, false, false, false, true, true);
                buttonNuevo.Focus();

            }
            if (tabControlPresentacion.SelectedIndex == 1)
            {
                this.buttonNuevo.Enabled = true;
                this.buttonCancelar.Enabled = true;
                this.habilitarCajasDeTexto(false);
                this.textBoxCodigo.Enabled = false;
                this.buttonNuevo.Focus();
                this.dataGridViewMantenimientoDePresentacion.Visible = true;
                this.labelTotal.Location = new Point(646, 296);
                this.labelTotal.Visible = true;
                this.actualizarDataGridViewMantenimientoDePresentacion();
                this.radioButtonNombre.Checked = false;
                this.textBoxBuscarxNombre.Enabled = false;
                this.buttonBuscarxNombre.Visible = false;
                this.textBoxBuscarxNombre.Clear();

            }
        }

        private void radioButtonNombre_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxNombre.Visible = true;
            this.buttonBuscarxNombre.Visible = true;
            this.textBoxBuscarxNombre.Enabled = true;
            this.textBoxBuscarxNombre.Clear();
            this.textBoxBuscarxNombre.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxNombre.Visible = true;

            this.labelTotal.Location = new Point(452, 297);
            actualizarDataGridViewMantenimientoDePresentacion();
        }

        private void textBoxBuscarxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxNombre.TextLength) > 0)
                {
                    tabControlPresentacion.SelectedIndex = 0;

                    NPresentacion oNPresentacion = new NPresentacion();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonNombre.Checked == true)
                    {
                        Presentacion oPresentacion = new Presentacion();
                        String buscarXNombre = textBoxBuscarxNombre.Text;
                        oPresentacion = oNPresentacion.BuscarPresentacionxNombre(buscarXNombre);
                        if (oPresentacion == null)
                        {
                            MessageBox.Show("EL Nombre de la PRESENTACION que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxNombre.Clear();
                            textBoxBuscarxNombre.Focus();
                        }
                        else if (oPresentacion != null)
                        {
                            limpiarDataGridViewMantenimientoDePresentacion();
                            actualizarDataGridViewMantenimientoDePresentacion_1();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(354, 297);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre de la Presentacion a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxNombre.Focus();
                    actualizarDataGridViewMantenimientoDePresentacion();
                    labelTotal.Location = new Point(452, 297);
                }
                buttonCancelar.Enabled = true;
            }
        }

        private void buttonBuscarxNombre_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxNombre.TextLength) > 0)
            {
                tabControlPresentacion.SelectedIndex = 0;

                NPresentacion oNPresentacion = new NPresentacion();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonNombre.Checked == true)
                {
                    Presentacion oPresentacion = new Presentacion();
                    String buscarXNombre = textBoxBuscarxNombre.Text;
                    oPresentacion = oNPresentacion.BuscarPresentacionxNombre(buscarXNombre);
                    if (oPresentacion == null)
                    {
                        MessageBox.Show("EL Nombre de la PRESENTACION que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxNombre.Clear();
                        textBoxBuscarxNombre.Focus();
                    }
                    else if (oPresentacion != null)
                    {
                        limpiarDataGridViewMantenimientoDePresentacion();
                        actualizarDataGridViewMantenimientoDePresentacion_1();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(354, 297);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacion encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese el Nombre de la Presentacion a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxNombre.Focus();
                actualizarDataGridViewMantenimientoDePresentacion();
                labelTotal.Location = new Point(452, 297);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxNombre.Clear();
            this.labelTotal.Location = new Point(452, 297);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDePresentacion.Rows.Count) + " Presentacions";

        }


        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            frmReportePresentacion fm = new frmReportePresentacion();
            fm.ShowDialog();
        }

        private void dataGridViewMantenimientoDePresentacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewMantenimientoDePresentacion.Rows[e.RowIndex].Cells[3];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataGridViewMantenimientoDePresentacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                this.buttonEliminar.Enabled = true;
            }
            else
            {
                this.buttonEliminar.Enabled = false;

            }
        }

        private void richTextBoxDscripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
        }



    }
}
