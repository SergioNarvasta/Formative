using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMantenimientoDeProducto : Form
    {
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;
       
        public frmMantenimientoDeProducto()
        {
            InitializeComponent();
            this.textBoxBuscarxNombre.Enabled = false;
            this.textBoxBuscarxMarca.Enabled = false;
            this.buttonBuscarxNombre.Visible = false;
            this.buttonBuscarxMarca.Visible = false;
            this.textBoxIdProducto.Visible = false;
            this.textBoxIdCategoria.Visible = false;
            this.textBoxNombreCate.Size = new Size(218, 20);
            this.textBoxNombreCate.Enabled = false;
            //this.comboBoxPresentacion.Text = "Seleccione una opcion";
           
            habilitarCajasDeTexto(false);
            habilitarControles(true, false, false, false, false, true);
            actualizarDataGridViewMantenimientoDeProductos();
            accion = DAccion.ACCION_INSERTAR;
        }

        internal static Form GetInstancia()
        {
            throw new NotImplementedException();
        }

        private void pictureBoxBuscarCategoria_Click(object sender, EventArgs e)
        {
            int cantida1 = int.Parse(textBoxPVenta.Text);
            int cantidad2 = int.Parse(textBoxPCompra.Text);
            int total = cantida1 - cantidad2;
            frmVistaCategoria_Productos fm = new frmVistaCategoria_Productos();
            AddOwnedForm(fm);
            fm.ShowDialog();
            this.textBoxStock.Text = Convert.ToString(total);
            this.comboBoxPresentacion.Focus();
        }
       

        public Productos getObjetoProductos()
        {
            Productos oDProductos = new Productos();
            //oDProductos.setIdProducto(int.Parse(textBoxIdProducto.Text));
            Presentacion oPresentacion = (Presentacion)comboBoxPresentacion.SelectedItem;
            oDProductos.setIdPresentacion(oPresentacion.getIdPresentacion());
            oDProductos.setIdCategoria(int.Parse(textBoxIdCategoria.Text));

            oDProductos.setNombre((textBoxNombre.Text));
            oDProductos.setMarca((textBoxMarca.Text));
            oDProductos.setStock(int.Parse(textBoxStock.Text));
            oDProductos.setPrecioVenta(Convert.ToDecimal(textBoxPVenta.Text));


            oDProductos.setPrecioCompra(Convert.ToDecimal(textBoxPCompra.Text));

            oDProductos.setCategoria((textBoxNombreCate.Text));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBoxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            oDProductos.setImagen(ms.ToArray());



            return oDProductos;
        }
        public Productos getObjetoProducto_1()
        {
            Productos oDProductos = new Productos();
            oDProductos.setIdProducto(int.Parse(textBoxIdProducto.Text));
            oDProductos.setIdCategoria(int.Parse(textBoxIdCategoria.Text));
            Presentacion oPresentacion = (Presentacion)comboBoxPresentacion.SelectedItem;
            oDProductos.setIdPresentacion(oPresentacion.getIdPresentacion());
            oDProductos.setNombre((textBoxNombre.Text));
            oDProductos.setMarca((textBoxMarca.Text));
            oDProductos.setPrecioCompra(Convert.ToDecimal(textBoxPCompra.Text));
            oDProductos.setPrecioVenta(Convert.ToDecimal(textBoxPVenta.Text));
            oDProductos.setStock(int.Parse(textBoxStock.Text));

            oDProductos.setCategoria((textBoxNombreCate.Text));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBoxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            oDProductos.setImagen(ms.ToArray());



            return oDProductos;
        }
        public void setObjetoProductos(Productos oDProductos)
        {
            textBoxIdProducto.Text = oDProductos.getIdProducto() + "";
            textBoxIdCategoria.Text = oDProductos.getIdCategoria() + "";
            comboBoxPresentacion.SelectedIndex = oDProductos.getIdPresentacion()-1;
            textBoxNombre.Text = oDProductos.getNombre() + "";
            textBoxMarca.Text = oDProductos.getMarca() + "";
            textBoxStock.Text = oDProductos.getStock() + "";
            textBoxPCompra.Text = oDProductos.getPrecioCompra() + "";
            textBoxPVenta.Text = oDProductos.getPrecioVenta() + "";
            textBoxNombreCate.Text = oDProductos.getCategoria() + "";
            MemoryStream stream = new MemoryStream(oDProductos.getImagen());
            pictureBoxImagen.Image = Image.FromStream(stream);


        }
        private void limpiarCajasDeTexto()
        {

            //textBoxIdProducto.Text = "";
            textBoxIdCategoria.Text = "";
            textBoxNombre.Text = "";
            textBoxMarca.Text = "";
            textBoxStock.Text = "";
            textBoxPVenta.Text = "";
            textBoxPCompra.Text = "";
            textBoxNombreCate.Text = "";
            pictureBoxImagen.Image = pictureBoxImagen.BackgroundImage;
            comboBoxPresentacion.Text = "Seleccione una opcion";

            
        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxMarca.Enabled = editable;
            textBoxStock.Enabled = editable;
            textBoxPVenta.Enabled = editable;
            textBoxPCompra.Enabled = editable;
            comboBoxPresentacion.Enabled = editable;

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

        public void actualizarDataGridViewMantenimientoDeProductos()
        {
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idProducto != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].idPresentacion,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].idCategoria,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].imagen

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }
        public void actualizarDataGridViewMantenimientoDeProductos_1()
        {
            limpiarDataGridViewMantenimientoDeProductos();
            String buscar = textBoxBuscarxNombre.Text;

            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosxNombre(buscar);
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idProducto != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                       oListProductos[posicion].idProducto,
                        oListProductos[posicion].idPresentacion,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].idCategoria,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].imagen

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }
        public void actualizarDataGridViewMantenimientoDeProductos_2()
        {
            String buscar = textBoxBuscarxMarca.Text;
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosxMarca(buscar);
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idProducto != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].idPresentacion,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].idCategoria,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].imagen

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }

        private void limpiarDataGridViewMantenimientoDeProductos()
        {
            dataGridViewMantenimientoDeProducto.Rows.Clear();

        }

        private void cargarComboBoxPresentacion()
        {
            NPresentacion oNPresentacion = new NPresentacion();
            List<Presentacion> oListSucursal = oNPresentacion.obtenerDatosEnList();
            for (int i = 0; i < oListSucursal.Count; i++)
            {
                comboBoxPresentacion.Items.Add(oListSucursal[i]);

            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 1;
            label7.Visible = false;
            textBoxIdProducto.Visible = false;
            textBoxNombre.Enabled = true;
            textBoxIdProducto.Text = "";
            limpiarCajasDeTexto();
            habilitarCajasDeTexto(false);
            textBoxNombre.Focus();
            pictureBoxBuscarCategoria.Enabled = false;

            habilitarControles(true, false, false, false, true, false);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 1;

            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxMarca.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Marca del Producto",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMarca.Focus();
                }
                else if (textBoxPCompra.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Precio de Compra del Producto",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPCompra.Focus();
                }
                else if (textBoxPVenta.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Precio de Venta del Producto",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPVenta.Focus();
                }
                else if (textBoxStock.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Stock del Producto",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxStock.Focus();
                }
                else if (textBoxNombreCate.Text.Equals(""))
                {
                    MessageBox.Show("Falta Seleccionar la Categoria del Producto",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombreCate.Focus();
                }
                else if (comboBoxPresentacion.Text.Equals("Seleccione una opcion"))
                {
                    MessageBox.Show("Falta Seleccionar la Presentacion del...",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxPresentacion.Focus();
                }
                else if (pictureBoxImagen.Image == pictureBoxImagen.BackgroundImage)
                {
                    MessageBox.Show("Falta Seleccionar la Imagen del Producto...",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBoxImagen.Focus();
                }

                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NProducto oNProductos = new NProducto();
                        if (oNProductos.registrarProductos(getObjetoProductos()))
                        {
                            habilitarControles(true, false, false, false, true, true);
                            buttonNuevo.Focus();
                            actualizarDataGridViewMantenimientoDeProductos();
                            habilitarCajasDeTexto(false);
                            textBoxIdProducto.Enabled = false;
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
                    NProducto oNProductos = new NProducto();
                    Productos oProductos = new Productos();
                    if (oNProductos.editarProductos(int.Parse(textBoxIdProducto.Text), getObjetoProducto_1()))
                    {
                        MessageBox.Show("Productos Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewMantenimientoDeProductos();
                        limpiarCajasDeTexto();
                        tabControlProducto.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, true);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el PRODUCTO ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            String nombreDeFoto;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.InitialDirectory = "d:\\";
            oOpenFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            oOpenFileDialog.Title = "Seleccione la imagen . . .";
            oOpenFileDialog.FilterIndex = 3;
            oOpenFileDialog.FileName = "";
            oOpenFileDialog.RestoreDirectory = true;

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                nombreDeFoto = oOpenFileDialog.FileName;
                pictureBoxImagen.Image = Image.FromFile(nombreDeFoto);


            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeProducto.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxIdProducto.Text.Length) > 0)
            {

                accion = DAccion.ACCION_MODIFICAR;
                habilitarCajasDeTexto(true);
                textBoxNombre.Enabled = true;
                textBoxNombre.Focus();
                pictureBoxBuscarCategoria.Enabled = true;
                //textBoxBuscar.Clear();
                habilitarControles(false, true, false, false, true, true);
            }
            else
            {
                MessageBox.Show("Usted no ha SELECCIONADO ningun PRODUCTO ... !!!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewMantenimientoDeProducto_DoubleClick(object sender, EventArgs e)
        {
            
            this.label7.Visible = true;
            this.textBoxIdProducto.Visible = true;
            this.textBoxIdProducto.Enabled = false;
            this.textBoxIdProducto.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[0].Value);
            this.comboBoxPresentacion.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[2].Value);
            this.textBoxIdCategoria.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[3].Value);
            this.textBoxNombre.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[4].Value);
            this.textBoxMarca.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[5].Value);
            this.textBoxPCompra.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[6].Value);
            this.textBoxPVenta.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[7].Value);
            this.textBoxStock.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[8].Value);
            this.textBoxNombreCate.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[9].Value);
            byte[] imagenBuffer = (byte[])this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[10].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            this.pictureBoxImagen.Image = Image.FromStream(ms);
            this.pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            habilitarControles(false, false, true, true, true, true);

            this.tabControlProducto.SelectedIndex = 1;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(tabControlProducto.SelectedIndex == 0)
            {
                labelTotal.Location = new Point(565, 303);
                labelTotal.Text = "No se ha seleccionado ningun registro a eliminar";
                labelTotal.ForeColor = Color.Red;
                foreach (DataGridViewRow fila in dataGridViewMantenimientoDeProducto.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[11].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los registros Seleccionados?",
                    "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oProducto.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);

                            actualizarDataGridViewMantenimientoDeProductos();
                            this.labelTotal.Location = new Point(647, 303);
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }
                
                
            }
            if(tabControlProducto.SelectedIndex == 1)
            {
                tabControlProducto.SelectedIndex = 1;
            if (dataGridViewMantenimientoDeProducto.RowCount >= 1)
            {

                int filaSeleccionada = dataGridViewMantenimientoDeProducto.CurrentRow.Index;
                if (filaSeleccionada != -1 && (textBoxIdProducto.Text.Length) > 0)
                {
                    if (MessageBox.Show("Esta Seguro de ELIMINAR los datos del PRODUCTO?",
                    "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NProducto oNProductos = new NProducto();
                        Productos oProductos = new Productos();
                        int buscar = int.Parse(textBoxIdProducto.Text);
                        oProductos = oNProductos.BuscarProductoxId(buscar);
                        if (oProductos != null)
                        {
                            oProductos = getObjetoProductos();
                            oProductos.setIdProducto(buscar);
                            if (oNProductos.eliminarProductos(buscar))
                            {
                                MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                    "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                buttonNuevo.Focus();
                                textBoxIdProducto.Enabled = false;
                                habilitarCajasDeTexto(false);
                                limpiarCajasDeTexto();
                                habilitarControles(false, false, false, false, true, true);

                                tabControlProducto.SelectedIndex = 0;
                                actualizarDataGridViewMantenimientoDeProductos();
                                pictureBoxLupa.Visible = true;
                                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

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
        DProducto oProducto = new DProducto();
        private void frmMantenimientoDeProducto_Load(object sender, EventArgs e)
        {
            tabControlProducto.SelectedIndex = 0;
            this.comboBoxPresentacion.Items.Clear();
            cargarComboBoxPresentacion();
            limpiarCajasDeTexto();
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";
            habilitarControles(true, false, false, false, false, true);
        }

        private void tabControlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlProducto.SelectedIndex == 0)
            {
                this.limpiarCajasDeTexto();
                this.habilitarCajasDeTexto(false);
                this.label7.Visible = false;
                this.textBoxIdProducto.Visible = false;
                this.habilitarControles(true, false, false, false, true, true);
                this.buttonNuevo.Focus();

            }
            if (tabControlProducto.SelectedIndex == 1)
            {
                this.buttonNuevo.Enabled = true;
                this.buttonCancelar.Enabled = true;
                this.habilitarCajasDeTexto(false);
                this.textBoxNombre.Enabled = false;
                
                this.buttonNuevo.Focus();
                this.dataGridViewMantenimientoDeProducto.Visible = true;
                this.labelTotal.Location = new Point(647, 303);
                this.labelTotal.Visible = true;
                
                this.actualizarDataGridViewMantenimientoDeProductos();
                this.radioButtonNombre.Checked = false;
                this.radioButtonMarca.Checked = false;
                this.textBoxBuscarxNombre.Enabled = false;
                this.buttonBuscarxNombre.Visible = false;
                this.textBoxBuscarxMarca.Enabled = false;
                this.buttonBuscarxMarca.Visible = false;
                this.textBoxBuscarxNombre.Clear();
                this.textBoxBuscarxMarca.Clear();
                this.buttonImprimir.Enabled = false;

            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxNombre.TextLength) > 0)
                {
                    Productos oProductos = new Productos();
                    NProducto oNProductos = new NProducto();

                    String busqueda = textBoxNombre.Text;
                    oProductos = oNProductos.BuscarProductoxNombre(busqueda);


                    if (oProductos == null)
                    {

                        textBoxNombre.Enabled = false;
                        habilitarCajasDeTexto(true);
                        textBoxMarca.Focus();
                        pictureBoxBuscarCategoria.Enabled = true;

                        habilitarControles(false, true, false, false, true, false);
                    }
                    else if (oProductos != null)
                    {
                        MessageBox.Show("PRODUCTO encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoProductos(oProductos);
                        textBoxNombre.Enabled = false;

                        limpiarDataGridViewMantenimientoDeProductos();
                        actualizarDataGridViewMantenimientoDeProductos_1();
                        habilitarControles(false, false, true, true, true, false);
                        pictureBoxBuscarCategoria.Enabled = true;
                        buttonCancelar.Focus();


                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Productos Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNombre.Clear();

                        textBoxNombre.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre del PRODUCTO... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

                }
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (tabControlProducto.SelectedIndex == 0)
            {
                textBoxBuscarxNombre.Enabled = false;
                textBoxBuscarxNombre.Clear();
                buttonBuscarxNombre.Visible = false;
                textBoxBuscarxMarca.Enabled = false;
                textBoxBuscarxMarca.Clear();
                buttonBuscarxMarca.Visible = false;
                radioButtonNombre.Checked = false;
                radioButtonMarca.Checked = false;
                actualizarDataGridViewMantenimientoDeProductos();
                this.labelTotal.Location = new Point(647, 303);
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, true);
                buttonNuevo.Focus();



            }
            if (tabControlProducto.SelectedIndex == 1)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                label7.Visible = false;
                textBoxIdProducto.Visible = false;
                textBoxNombre.Enabled = false;
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();
            }

        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            if ((textBoxNombre.TextLength) > 0)
            {
                Productos oProductos = new Productos();
                NProducto oNProductos = new NProducto();

                String busqueda = textBoxNombre.Text;
                oProductos = oNProductos.BuscarProductoxNombre(busqueda);


                if (oProductos == null)
                {

                    textBoxNombre.Enabled = false;
                    habilitarCajasDeTexto(true);
                    textBoxMarca.Focus();
                    pictureBoxBuscarCategoria.Enabled = true;

                    habilitarControles(false, true, false, false, true, false);
                }
                else if (oProductos != null)
                {
                    MessageBox.Show("PRODUCTO encontrado ... !!!",
                      "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setObjetoProductos(oProductos);
                    textBoxNombre.Enabled = false;

                    limpiarDataGridViewMantenimientoDeProductos();
                    actualizarDataGridViewMantenimientoDeProductos_1();
                    habilitarControles(false, false, true, true, true, false);
                    pictureBoxBuscarCategoria.Enabled = true;
                    buttonCancelar.Focus();


                }
                else
                {
                    MessageBox.Show("No se pudo encontrar al Productos Solicitado",
                        "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNombre.Clear();

                    textBoxNombre.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre del PRODUCTO... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Focus();
                buttonCancelar.Enabled = true;
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }
        }

        private void radioButtonNombre_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxMarca.Visible = false;
            this.buttonBuscarxMarca.Visible = false;
            this.textBoxBuscarxNombre.Visible = true;
            this.buttonBuscarxNombre.Visible = true;
            this.textBoxBuscarxNombre.Enabled = true;
            this.textBoxBuscarxNombre.Clear();
            this.textBoxBuscarxNombre.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxMarca.Visible = true;
            limpiarDataGridViewMantenimientoDeProductos();
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(647, 303);
            habilitarControles(false, false, false, false, true, true);
        }

        private void textBoxBuscarxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxNombre.TextLength) > 0)
                {
                    tabControlProducto.SelectedIndex = 0;

                    NProducto oNProductoss = new NProducto();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonNombre.Checked == true)
                    {
                        Productos oProductoss = new Productos();
                        String buscarXNombre = textBoxBuscarxNombre.Text;
                        oProductoss = oNProductoss.BuscarProductoxNombre(buscarXNombre);
                        if (oProductoss == null)
                        {
                            MessageBox.Show("Los Nombre del Producto que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxNombre.Clear();
                            textBoxBuscarxNombre.Focus();
                        }
                        else if (oProductoss != null)
                        {
                            limpiarDataGridViewMantenimientoDeProductos();
                            actualizarDataGridViewMantenimientoDeProductos_1();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(539, 303);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre del Productos a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxNombre.Focus();
                    actualizarDataGridViewMantenimientoDeProductos();
                    labelTotal.Location = new Point(647, 303);
                }
                buttonCancelar.Enabled = true;
            }

        }

        private void buttonBuscarxNombre_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxNombre.TextLength) > 0)
            {
                tabControlProducto.SelectedIndex = 0;

                NProducto oNProductoss = new NProducto();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonNombre.Checked == true)
                {
                    Productos oProductoss = new Productos();
                    String buscarXNombre = textBoxBuscarxNombre.Text;
                    oProductoss = oNProductoss.BuscarProductoxNombre(buscarXNombre);
                    if (oProductoss == null)
                    {
                        MessageBox.Show("Los Nombre del Producto que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxNombre.Clear();
                        textBoxBuscarxNombre.Focus();
                    }
                    else if (oProductoss != null)
                    {
                        limpiarDataGridViewMantenimientoDeProductos();
                        actualizarDataGridViewMantenimientoDeProductos_1();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(539, 303);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese el Nombre del Productos a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxNombre.Focus();
                actualizarDataGridViewMantenimientoDeProductos();
                labelTotal.Location = new Point(647, 303);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxNombre.Clear();
            this.labelTotal.Location = new Point(647, 203);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";
       
        }

        private void radioButtonMarca_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxNombre.Visible = false;
            this.buttonBuscarxNombre.Visible = false;
            this.textBoxBuscarxMarca.Visible = true;
            this.buttonBuscarxMarca.Visible = true;
            this.textBoxBuscarxMarca.Enabled = true;
            this.textBoxBuscarxMarca.Clear();
            this.textBoxBuscarxMarca.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxMarca.Visible = true;
            limpiarDataGridViewMantenimientoDeProductos();
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(647, 303);
            habilitarControles(false, false, false, false, true, true);
        }

        private void textBoxBuscarxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxMarca.TextLength) > 0)
                {
                    tabControlProducto.SelectedIndex = 0;

                    NProducto oNProductoss = new NProducto();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonMarca.Checked == true)
                    {
                        Productos oProductoss = new Productos();
                        String buscarXMarca = textBoxBuscarxMarca.Text;
                        oProductoss = oNProductoss.BuscarProductoxMarca(buscarXMarca);
                        if (oProductoss == null)
                        {
                            MessageBox.Show("La Marca del Producto que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxMarca.Clear();
                            textBoxBuscarxMarca.Focus();
                        }
                        else if (oProductoss != null)
                        {
                            limpiarDataGridViewMantenimientoDeProductos();
                            actualizarDataGridViewMantenimientoDeProductos_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(539, 303);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese la Marca del Productos a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxMarca.Focus();
                    actualizarDataGridViewMantenimientoDeProductos();
                    labelTotal.Location = new Point(647, 303);
                }
                buttonCancelar.Enabled = true;
            }

        }

        private void buttonBuscarxMarca_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxMarca.TextLength) > 0)
            {
                tabControlProducto.SelectedIndex = 0;

                NProducto oNProductoss = new NProducto();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonMarca.Checked == true)
                {
                    Productos oProductoss = new Productos();
                    String buscarXMarca = textBoxBuscarxMarca.Text;
                    oProductoss = oNProductoss.BuscarProductoxMarca(buscarXMarca);
                    if (oProductoss == null)
                    {
                        MessageBox.Show("La Marca del Producto que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxMarca.Clear();
                        textBoxBuscarxMarca.Focus();
                    }
                    else if (oProductoss != null)
                    {
                        limpiarDataGridViewMantenimientoDeProductos();
                        actualizarDataGridViewMantenimientoDeProductos_2();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(539, 303);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese la Marca del Productos a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxMarca.Focus();
                actualizarDataGridViewMantenimientoDeProductos();
                labelTotal.Location = new Point(647, 303);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxMarca_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxMarca.Clear();
            this.labelTotal.Location = new Point(647, 203);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
        }

        private void textBoxPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumericoyPunto(e.KeyChar);
        }

        private void textBoxPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumericoyPunto(e.KeyChar);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            
            frmReporteProductos fm = new frmReporteProductos();
            fm.ShowDialog();
            
        }

        

        private void dataGridViewMantenimientoDeProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewMantenimientoDeProducto.Rows[e.RowIndex].Cells[11];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void dataGridViewMantenimientoDeProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                this.buttonEliminar.Enabled = true;
            }
            else
            {
                this.buttonEliminar.Enabled = false;
            }
        }

        private void textBoxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
        }
    }
}
