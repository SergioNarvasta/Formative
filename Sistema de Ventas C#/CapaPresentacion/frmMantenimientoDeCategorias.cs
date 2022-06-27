using CapaDatos;
using CapaNegocio;
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
    public partial class frmMantenimientoDeCategorias : Form
    {
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;

        public frmMantenimientoDeCategorias()
        {
            InitializeComponent();

            textBoxCodigo.Enabled = false;
            textBoxBuscar.Enabled = false;
            habilitarCajasDeTexto(false);
            habilitarControles(true, false, false, false, false,false);
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
            textBoxBuscar.Text = "";
            radioButtonCodigo.Checked = false;
            radioButtonNombre.Checked = false;

        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxNombre.Enabled = editable;

        }
        private void habilitarControles(Boolean cNuevo, Boolean cGuardar, Boolean cEditar,
            Boolean cEliminar, Boolean cCancelar,Boolean cImprimir)
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
            String buscar = textBoxNombre.Text;
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
            int buscar = int.Parse(textBoxCodigo.Text);
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

        private void buttonGuardar_Click(object sender, EventArgs e)
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
                                habilitarControles(true, false, false, false, true,false);
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

                        habilitarControles(false, false, true, true, true,false);
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
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto(true);
            limpiarCajasDeTexto();
            textBoxNombre.Focus();
            habilitarControles(true, true, false, false, true,false);
            actualizarDataGridViewMantenimientoDeCategorias();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
            {
                textBoxNombre.Focus();
                accion = DAccion.ACCION_MODIFICAR;
                habilitarControles(false, true, false, false, true,true);
                habilitarCajasDeTexto(true);
                textBoxCodigo.Enabled = false;
                textBoxNombre.Focus();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un registro ...!!!");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMantenimientoDeCategoria.RowCount >= 1)
            {
                int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
                if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
                {
                    if (MessageBox.Show("Esta Seguro de ELIMINAR la Categoria Seleccionada?",
                    "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NCategorias oNCategorias = new NCategorias();
                        Categorias oCategorias = new Categorias();
                        int buscar = int.Parse(textBoxCodigo.Text);
                        oCategorias = oNCategorias.BuscarCategorias(buscar);
                        if (oCategorias != null)
                        {
                            oCategorias = getObjetoCategoria();
                            if (oNCategorias.eliminarCategorias(buscar))
                            {
                                MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                    "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //accion = DAccion.NO_ACCION;
                                habilitarCajasDeTexto(false);
                                limpiarCajasDeTexto();
                                actualizarDataGridViewMantenimientoDeCategorias();
                                buttonBuscar1.Visible = true;
                                //textBoxBuscar.Visible = false;
                                textBoxCodigo.Enabled = false;
                                dataGridViewMantenimientoDeCategoria.Enabled = true;
                                habilitarControles(true, false, false, false, false,false);
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

        private void dataGridViewMantenimientoDeCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeCategoria.CurrentRow.Index;
            if (filaSeleccionada != -1)
            {

                Categorias oCategoriaSeleccionado = (Categorias)dataGridViewMantenimientoDeCategoria.Rows[filaSeleccionada].Cells[1].Value;
                setObjetoCategorias(oCategoriaSeleccionado);
                Categorias oCliente = new Categorias();


                textBoxCodigo.Enabled = false;
                habilitarCajasDeTexto(false);
                habilitarControles(false, false, true, true, true,true);

            }

        }

        private void buttonBuscar1_MouseClick(object sender, MouseEventArgs e)
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

                        habilitarControles(false, false, true, true, true,true);
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            buttonNuevo.Focus();
            habilitarCajasDeTexto(false);


            limpiarCajasDeTexto();
            dataGridViewMantenimientoDeCategoria.Visible = true;
            actualizarDataGridViewMantenimientoDeCategorias();
            habilitarControles(true, false, false, false, false,false);
            textBoxBuscar.Enabled = false;
        }

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscar.TextLength) > 0)
                {
                    NCategorias oNCategorias = new NCategorias();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonNombre.Checked == true)
                    {
                        Categorias oCategorias = new Categorias();
                        String buscar = (textBoxBuscar.Text);
                        oCategorias = oNCategorias.BuscarCategoriasxNombre(buscar);
                        if (oCategorias == null)
                        {
                            MessageBox.Show("El Nombre de la Categoria que esta Buscando no EXISTE... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscar.Clear();
                            textBoxBuscar.Focus();
                        }
                        else if (oCategorias != null)
                        {
                            setObjetoCategorias(oCategorias);
                            limpiarDataGridViewMantenimientoDeCategorias();
                            actualizarDataGridViewMantenimientoDeCategorias_1();
                            labelTotal.Visible = true;
                            this.labelTotal.Location = new Point(518, 279);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias encontrados";
                            habilitarControles(false, false, true, true, true,true);
                        }
                    }
                    if (radioButtonCodigo.Checked == true)
                    {
                        Categorias oCategorias = new Categorias();
                        int buscar = int.Parse(textBoxBuscar.Text);
                        oCategorias = oNCategorias.BuscarCategorias(buscar);
                        if (oCategorias == null)
                        {
                            MessageBox.Show("El Codigo de la Categoria que esta Buscando no EXISTE... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscar.Clear();
                            textBoxBuscar.Focus();
                        }
                        else if (oCategorias != null)
                        {
                            setObjetoCategorias(oCategorias);
                            limpiarDataGridViewMantenimientoDeCategorias();
                            actualizarDataGridViewMantenimientoDeCategorias_2();
                            labelTotal.Visible = true;
                            this.labelTotal.Location = new Point(518, 279);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias encontrados";
                            habilitarControles(false, false, true, true, true,true);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo o Nombre de la Categoria a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscar.Focus();
                    limpiarCajasDeTexto();
                    limpiarDataGridViewMantenimientoDeCategorias();
                    actualizarDataGridViewMantenimientoDeCategorias();
                    this.labelTotal.Location = new Point(614, 279);
                }
                buttonCancelar.Enabled = true;
            }
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxBuscar.Enabled = true;
            textBoxBuscar.Focus();
            buttonCancelar.Enabled = true;
            labelTotal.Visible = true;
            textBoxBuscar.Clear();
            limpiarDataGridViewMantenimientoDeCategorias();
            actualizarDataGridViewMantenimientoDeCategorias();
            //labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";


        }

        private void radioButtonNombre_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxBuscar.Enabled = true;
            textBoxBuscar.Focus();
            buttonCancelar.Enabled = true;
            labelTotal.Visible = true;
            textBoxBuscar.Clear();
            limpiarDataGridViewMantenimientoDeCategorias();
            actualizarDataGridViewMantenimientoDeCategorias();
            //labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias";

        }

        private void textBoxBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBuscar.Clear();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                                    habilitarControles(true, false, false, false, true,false);
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

                            habilitarControles(false, false, true, true, true,true);
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

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscar.TextLength) > 0)
            {
                NCategorias oNCategorias = new NCategorias();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonNombre.Checked == true)
                {
                    Categorias oCategorias = new Categorias();
                    String buscar = (textBoxBuscar.Text);
                    oCategorias = oNCategorias.BuscarCategoriasxNombre(buscar);
                    if (oCategorias == null)
                    {
                        MessageBox.Show("El Nombre de la Categoria que esta Buscando no EXISTE... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscar.Clear();
                        textBoxBuscar.Focus();
                    }
                    else if (oCategorias != null)
                    {
                        setObjetoCategorias(oCategorias);
                        limpiarDataGridViewMantenimientoDeCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_1();
                        labelTotal.Visible = true;
                        this.labelTotal.Location = new Point(518, 279);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias encontrados";
                    }
                }
                if (radioButtonCodigo.Checked == true)
                {
                    Categorias oCategorias = new Categorias();
                    int buscar = int.Parse(textBoxBuscar.Text);
                    oCategorias = oNCategorias.BuscarCategorias(buscar);
                    if (oCategorias == null)
                    {
                        MessageBox.Show("El Codigo de la Categoria que esta Buscando no EXISTE... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscar.Clear();
                        textBoxBuscar.Focus();
                    }
                    else if (oCategorias != null)
                    {
                        setObjetoCategorias(oCategorias);
                        limpiarDataGridViewMantenimientoDeCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_2();
                        labelTotal.Visible = true;
                        this.labelTotal.Location = new Point(518, 279);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeCategoria.Rows.Count) + " Categorias encontrados";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Codigo o Nombre de la Categoria a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscar.Focus();
                limpiarDataGridViewMantenimientoDeCategorias();
                actualizarDataGridViewMantenimientoDeCategorias();
                
            }
            buttonCancelar.Enabled = true;
        }

    }
}
