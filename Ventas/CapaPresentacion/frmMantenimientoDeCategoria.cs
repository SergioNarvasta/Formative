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
    public partial class frmMantenimientoDeCategoria : Form
    {
        DCategorias oCategoria = new DCategorias();
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;
        public frmMantenimientoDeCategoria()
        {
            InitializeComponent();
            
            textBoxBuscarxCodigo.Enabled = false;
            textBoxBuscarxNombre.Enabled = false;
            buttonBuscarxCodigo.Visible = false;
            buttonBuscarxNombre.Visible = false;
            habilitarCajasDeTexto(false);
            habilitarControles(true, false, false, false, false, true);
            actualizarDataGridViewMantenimientoDeCategorias();
            accion = DAccion.ACCION_INSERTAR;
        }

        
        public Categorias getObjetoCategoria()
        {
            Categorias oDCategorias = new Categorias();
            oDCategorias.setNombre(textBoxNombre.Text);

            return oDCategorias;
        }

        public Categorias getObjetoCategoria_1()
        {
            Categorias oDCategorias = new Categorias();
            oDCategorias.setIdCategoria(int.Parse(textBoxCodigo.Text));
            oDCategorias.setNombre(textBoxNombre.Text);

            return oDCategorias;
        }

        public void setObjetoCategorias(Categorias oDCategorias)
        {
            textBoxCodigo.Text = oDCategorias.getIdCategoria() + "";
            textBoxNombre.Text = oDCategorias.getNombre() + "";

        }

        private void limpiarCajasDeTexto()
        {

            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
           
        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxNombre.Enabled = editable;

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

        public void actualizarDataGridViewMantenimientoDeCategorias()
        {
            limpiarDataGridViewMantenimientoDeCategorias();
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListCategorias.Count; posicion = posicion + 1)
            {
                if (oListCategorias[posicion].idCategoria != 0)
                {
                    dataGridViewMantenimientoDeCategoria.Rows.Add(
                        oListCategorias[posicion].idCategoria,
                        oListCategorias[posicion]

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

            }

        }

        public void actualizarDataGridViewMantenimientoDeCategorias_1()
        {
            String buscar = textBoxBuscarxNombre.Text;
            limpiarDataGridViewMantenimientoDeCategorias();
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnListaDeCategorias(buscar);
            for (int posicion = 0; posicion < oListCategorias.Count; posicion = posicion + 1)
            {
                if (oListCategorias[posicion].idCategoria != 0)
                {
                    dataGridViewMantenimientoDeCategoria.Rows.Add(
                        oListCategorias[posicion].idCategoria,
                        oListCategorias[posicion]

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

            }

        }

        public void actualizarDataGridViewMantenimientoDeCategorias_2()
        {
            int buscar = int.Parse(textBoxBuscarxCodigo.Text);
            limpiarDataGridViewMantenimientoDeCategorias();
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnListaDeCategoriasxCodigo(buscar);
            for (int posicion = 0; posicion < oListCategorias.Count; posicion = posicion + 1)
            {
                if (oListCategorias[posicion].idCategoria != 0)
                {
                    dataGridViewMantenimientoDeCategoria.Rows.Add(
                        oListCategorias[posicion].idCategoria,
                        oListCategorias[posicion]

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

            }

        }

        private void limpiarDataGridViewMantenimientoDeCategorias()
        {
            dataGridViewMantenimientoDeCategoria.Rows.Clear();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlCategoria.SelectedIndex = 1;
            habilitarCajasDeTexto(true);
            limpiarCajasDeTexto();
            textBoxNombre.Enabled = true;
            textBoxNombre.Focus();
            habilitarControles(true, false, false, false, true, false);
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlCategoria.SelectedIndex = 1;
            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxNombre.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Nombre de la Categoria",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombre.Focus();
                }
                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NCategorias oNCategoria = new NCategorias();
                        if (oNCategoria.registrarCategorias(getObjetoCategoria()))
                        {
                            habilitarControles(true, false, false, false, true, false);
                            buttonNuevo.Focus();
                            actualizarDataGridViewMantenimientoDeCategorias();
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
                if(MessageBox.Show("Esta Seguro de guardar los datos?",
                       "Confirmar el Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    NCategorias oNCategoria = new NCategorias();
                    Categorias oCategoria = new Categorias();
                    if (oNCategoria.editarCategorias(int.Parse(textBoxCodigo.Text), getObjetoCategoria_1()))
                    {
                        MessageBox.Show("CATEGORIA Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewMantenimientoDeCategorias();
                        limpiarCajasDeTexto();
                        tabControlCategoria.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, false);
                    }
                    else 
                    {
                        MessageBox.Show("No se pudo Modificar la CATEGORIA ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
            {
                textBoxNombre.Focus();
                accion = DAccion.ACCION_MODIFICAR;
                habilitarControles(false, true, false, false, true, false);
                habilitarCajasDeTexto(true);
                
                textBoxCodigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un registro ...!!!");
            }
        }

        private void dataGridViewMantenimientoDeCategoria_DoubleClick(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
            if (filaSeleccionada != -1)
            {

                Categorias oCategoriaSeleccionado = (Categorias)dataGridViewMantenimientoDeCategoria.Rows[filaSeleccionada].Cells[1].Value;
                setObjetoCategorias(oCategoriaSeleccionado);
                Categorias oCategoria = new Categorias();

                buttonGuardar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
                textBoxCodigo.Enabled = false;
                habilitarCajasDeTexto(false);
                habilitarControles(false, false, true, true, true, true);

            }

            this.tabControlCategoria.SelectedIndex = 1;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (tabControlCategoria.SelectedIndex == 0)
            {
                labelTotal.ForeColor = Color.Red;
                foreach (DataGridViewRow fila in dataGridViewMantenimientoDeCategoria.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[2].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los Registros Seleccionados?",
                         "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oCategoria.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);

                            actualizarDataGridViewMantenimientoDeCategorias();
                            this.labelTotal.Location = new Point(647, 303);
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Productos";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }


            }
            if (tabControlCategoria.SelectedIndex == 1)
            {
                tabControlCategoria.SelectedIndex = 1;
                if (dataGridViewMantenimientoDeCategoria.RowCount >= 1)
                {

                    int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
                    if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los datos de la CATEGORIA?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NCategorias oNCategorias = new NCategorias();
                            Categorias oCategorias = new Categorias();
                            int buscar = int.Parse(textBoxCodigo.Text);
                            oCategorias = oNCategorias.BuscarCategorias(buscar);
                            if (oCategorias != null)
                            {
                                oCategorias = getObjetoCategoria();
                                oCategorias.setIdCategoria(buscar);
                                if (oNCategorias.eliminarCategorias(buscar))
                                {
                                    MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    buttonNuevo.Focus();
                                    textBoxCodigo.Enabled = false;
                                    habilitarCajasDeTexto(false);
                                    limpiarCajasDeTexto();
                                    habilitarControles(false, false, false, false, true, false);

                                    tabControlCategoria.SelectedIndex = 0;
                                    actualizarDataGridViewMantenimientoDeCategorias();
                                    pictureBoxLupa.Visible = true;
                                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

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
            if (tabControlCategoria.SelectedIndex == 0)
            {
                textBoxBuscarxCodigo.Enabled = false;
                textBoxBuscarxCodigo.Clear();
                buttonBuscarxCodigo.Visible = false;
                textBoxBuscarxNombre.Enabled = false;
                textBoxBuscarxNombre.Clear();
                buttonBuscarxNombre.Visible = false;
                radioButtonNombre.Checked = false;
                radioButtonCodigo.Checked = false;
                actualizarDataGridViewMantenimientoDeCategorias();
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();

            }
            if (tabControlCategoria.SelectedIndex == 1)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();
            }
            
        }

        private void pictureBoxLupa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                if ((textBoxNombre.TextLength) > 0)
                {
                    Categorias oCategorias = new Categorias();
                    NCategorias oNCategorias = new NCategorias();

                    String busqueda = textBoxNombre.Text;
                    oCategorias = oNCategorias.BuscarCategoriasxNombre(busqueda);


                    if (oCategorias == null)
                    {
                        MessageBox.Show("EL NOMBRE de la Categorias no esta registrado ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxNombre.Focus();
                        textBoxNombre.Clear();

                    }
                    else if (oCategorias != null)
                    {
                        MessageBox.Show("CATEGORIA encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoCategorias(oCategorias);
                        textBoxNombre.Enabled = false;
                        limpiarDataGridViewMantenimientoDeCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_1();

                        habilitarControles(false, false, true, true, true, true);
                        buttonCancelar.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Categorias Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNombre.Clear();
                        textBoxNombre.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";
                        this.labelTotal.Location = new Point(614, 279);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre de la CATEGORIA a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";


                    limpiarDataGridViewMantenimientoDeCategorias();
                    actualizarDataGridViewMantenimientoDeCategorias();
                    this.labelTotal.Location = new Point(614, 279);
                }
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                if ((textBoxNombre.TextLength) > 0)
                {

                    if (accion == DAccion.ACCION_INSERTAR)
                    {
                        Categorias oCategorias = new Categorias();
                        NCategorias oNCategorias = new NCategorias();

                        String busqueda = textBoxNombre.Text;
                        oCategorias = oNCategorias.BuscarCategoriasxNombre(busqueda);
                        if (oCategorias == null)
                        {
                            if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (oNCategorias.registrarCategorias(getObjetoCategoria()))
                                {
                                    habilitarControles(true, true, false, false, true, false);
                                    buttonNuevo.Focus();
                                    actualizarDataGridViewMantenimientoDeCategorias();
                                    habilitarCajasDeTexto(false);
                                    textBoxCodigo.Enabled = false;
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
                        else if (oCategorias != null)
                        {
                            MessageBox.Show("CATEGORIA encontrado ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            setObjetoCategorias(oCategorias);
                            textBoxNombre.Enabled = false;
                            limpiarDataGridViewMantenimientoDeCategorias();
                            actualizarDataGridViewMantenimientoDeCategorias_1();

                            habilitarControles(false, false, true, true, true, true);
                            buttonCancelar.Focus();
                            buttonCancelar.Enabled = true;
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

                        }

                    }

                    else if (accion == DAccion.ACCION_MODIFICAR)
                    {
                        if (MessageBox.Show("Esta Seguro de guardar los datos?",
                               "Confirmar el Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NCategorias oNCategorias = new NCategorias();
                            Categorias oCategorias = new Categorias();
                            if (oNCategorias.editarCategorias(int.Parse(textBoxCodigo.Text), getObjetoCategoria_1()))
                            {
                                MessageBox.Show("Categorias Modificado Exitosamente ... !!!",
                                 "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                actualizarDataGridViewMantenimientoDeCategorias();
                                limpiarCajasDeTexto();

                            }
                            else
                            {
                                MessageBox.Show("No se pudo Modificar la Categoria ... !!!",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("La caja de Texto esta vacia... !!!",
                           "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    limpiarDataGridViewMantenimientoDeCategorias();
                    actualizarDataGridViewMantenimientoDeCategorias();
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";
                }

            }
        }

        private void frmMantenimientoDeCategoria_Load(object sender, EventArgs e)
        {
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";
            habilitarControles(true, false, false, false, false, true);
      
        }

        private void tabControlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCategoria.SelectedIndex == 0)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                textBoxCodigo.Enabled = false;
                habilitarControles(true, false, false, false, true, true);
                buttonNuevo.Focus();

            }
            if (tabControlCategoria.SelectedIndex == 1)
            {
                this.buttonNuevo.Enabled = true;
                this.buttonCancelar.Enabled = true;
                this.habilitarCajasDeTexto(false);
                this.textBoxCodigo.Enabled = false;
                this.buttonNuevo.Focus();
                this.dataGridViewMantenimientoDeCategoria.Visible = true;
                this.labelTotal.Location = new Point(646, 296);
                this.labelTotal.Visible = true;
                this.actualizarDataGridViewMantenimientoDeCategorias();
                this.radioButtonCodigo.Checked = false;
                this.radioButtonNombre.Checked = false;
                this.textBoxBuscarxCodigo.Enabled = false;
                this.buttonBuscarxCodigo.Visible = false;
                this.textBoxBuscarxNombre.Enabled = false;
                this.buttonBuscarxNombre.Visible = false;
                this.textBoxBuscarxCodigo.Clear();
                this.textBoxBuscarxNombre.Clear();
                
            }
        }

        private void radioButtonCodigo_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxNombre.Visible = false;
            this.buttonBuscarxNombre.Visible = false;
            this.textBoxBuscarxCodigo.Visible = true;
            this.buttonBuscarxCodigo.Visible = true;
            this.textBoxBuscarxCodigo.Enabled = true;
            this.textBoxBuscarxCodigo.Clear();
            this.textBoxBuscarxCodigo.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxCodigo.Visible = true;

            this.labelTotal.Location = new Point(646, 259);
            actualizarDataGridViewMantenimientoDeCategorias();
        }

        private void textBoxBuscarxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxCodigo.TextLength) > 0)
                {
                    tabControlCategoria.SelectedIndex = 0;

                    NCategorias oNCategorias = new NCategorias();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonCodigo.Checked == true)
                    {
                        Categorias oCategorias = new Categorias();
                        int buscarXCodigo = int.Parse(textBoxBuscarxCodigo.Text);
                        oCategorias = oNCategorias.BuscarCategorias(buscarXCodigo);
                        if (oCategorias == null)
                        {
                            MessageBox.Show("EL Codigo de la CATEGORIA que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxCodigo.Clear();
                            textBoxBuscarxCodigo.Focus();
                        }
                        else if (oCategorias != null)
                        {
                            limpiarDataGridViewMantenimientoDeCategorias();
                            actualizarDataGridViewMantenimientoDeCategorias_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(544, 256);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categoria encontrados";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo del Categoria a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxCodigo.Focus();
                    actualizarDataGridViewMantenimientoDeCategorias();
                    labelTotal.Location = new Point(646, 259);
                }
                buttonCancelar.Enabled = true;
            }
        }

        private void buttonBuscarxCodigo_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxCodigo.TextLength) > 0)
            {
                tabControlCategoria.SelectedIndex = 0;

                NCategorias oNCategorias = new NCategorias();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonCodigo.Checked == true)
                {
                    Categorias oCategorias = new Categorias();
                    int buscarXCodigo = int.Parse(textBoxBuscarxCodigo.Text);
                    oCategorias = oNCategorias.BuscarCategorias(buscarXCodigo);
                    if (oCategorias == null)
                    {
                        MessageBox.Show("EL Codigo del Categorias que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxCodigo.Clear();
                        textBoxBuscarxCodigo.Focus();
                    }
                    else if (oCategorias != null)
                    {
                        limpiarDataGridViewMantenimientoDeCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_2();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(544, 256);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categoria encontrados";
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingrese el Codigo del Categoria a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxCodigo.Focus();
                actualizarDataGridViewMantenimientoDeCategorias();
                labelTotal.Location = new Point(646, 259);
            }
            buttonCancelar.Enabled = true;
        }

        private void radioButtonNombre_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxCodigo.Visible = false;
            this.buttonBuscarxCodigo.Visible = false;
            this.textBoxBuscarxNombre.Visible = true;
            this.buttonBuscarxNombre.Visible = true;
            this.textBoxBuscarxNombre.Enabled = true;
            this.textBoxBuscarxNombre.Clear();
            this.textBoxBuscarxNombre.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxNombre.Visible = true;

            this.labelTotal.Location = new Point(646, 259);
            actualizarDataGridViewMantenimientoDeCategorias();
        }

        private void textBoxBuscarxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxNombre.TextLength) > 0)
                {
                    tabControlCategoria.SelectedIndex = 0;

                    NCategorias oNClientes = new NCategorias();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonNombre.Checked == true)
                    {
                        Categorias oCategoria = new Categorias();
                        String buscarXNombre = textBoxBuscarxNombre.Text;
                        oCategoria = oNClientes.BuscarCategoriasxNombre(buscarXNombre);
                        if (oCategoria == null)
                        {
                            MessageBox.Show("EL Nombre de la CATEGORIA que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxNombre.Clear();
                            textBoxBuscarxNombre.Focus();
                        }
                        else if (oCategoria != null)
                        {
                            limpiarDataGridViewMantenimientoDeCategorias();
                            actualizarDataGridViewMantenimientoDeCategorias_1();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(544, 256);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Clientes encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre de la Categoria a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxNombre.Focus();
                    actualizarDataGridViewMantenimientoDeCategorias();
                    labelTotal.Location = new Point(646, 259);
                }
                buttonCancelar.Enabled = true;
            }
        }

        private void buttonBuscarxNombre_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxNombre.TextLength) > 0)
            {
                tabControlCategoria.SelectedIndex = 0;

                NCategorias oNClientes = new NCategorias();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonNombre.Checked == true)
                {
                    Categorias oCategoria = new Categorias();
                    String buscarXNombre = textBoxBuscarxNombre.Text;
                    oCategoria = oNClientes.BuscarCategoriasxNombre(buscarXNombre);
                    if (oCategoria == null)
                    {
                        MessageBox.Show("EL Nombre de la CATEGORIA que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxNombre.Clear();
                        textBoxBuscarxNombre.Focus();
                    }
                    else if (oCategoria != null)
                    {
                        limpiarDataGridViewMantenimientoDeCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_1();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(544, 256);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Clientes encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese el Nombre de la Categoria a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxNombre.Focus();
                actualizarDataGridViewMantenimientoDeCategorias();
                labelTotal.Location = new Point(646, 259);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxCodigo.Clear();
            this.labelTotal.Location = new Point(646, 259);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";
        
        }

        private void textBoxBuscarxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxNombre.Clear();
            this.labelTotal.Location = new Point(646, 259);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            frmReporteCategorias fm = new frmReporteCategorias();
            fm.ShowDialog();

        }

        private void dataGridViewMantenimientoDeCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewMantenimientoDeCategoria.Rows[e.RowIndex].Cells[2];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataGridViewMantenimientoDeCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                this.buttonEliminar.Enabled = true;
            }
            else 
            {
                this.buttonEliminar.Enabled = false;
            }

        }

       
    }
}
