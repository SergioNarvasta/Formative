using CapaDatos;
using CapaNegocio;
using CapaPresentacion;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmMantenimientoDeEmpleado : Form
    {
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;

        public frmMantenimientoDeEmpleado()
        {
            InitializeComponent();
            textBoxNick.Enabled = false;
            textBoxPassword.Enabled = false;
            mostraImagen();
            cargarListBoxTipoDeUsuario();
            cargarComboBoxSucursal();
            //groupBoxHabilitar.Visible = false;
            habilitarCajasDeTexto(false);
            habilitarControles(true, false, false, false, false, false, false);
            actualizarDataGridViewMantenimientoDeEmpleado();
            //textBoxBuscar.Visible = false;
            accion = DAccion.ACCION_INSERTAR;
            //accion = DAccion.ACCION_MODIFICAR;
            //this.WindowState = FormWindowState.Normal;


        }
        public frmMantenimientoDeEmpleado(Empleado oEmpleado)
        {
            InitializeComponent();
            mostraImagen();
            cargarListBoxTipoDeUsuario();
            setObjetoEmpleado(oEmpleado);
            cargarComboBoxSucursal();

        }
        private void mostraImagen()
        {

            dataGridViewMantenimientoDeEmpleado.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.lupa,
                Name = "lupa",
                HeaderText = "Detalle"
            });
        }


        private void cargarListBoxTipoDeUsuario()
        {
            NTipoDeUsuario oCCTipoDeUsuario = new NTipoDeUsuario();
            List<tipoDeUsuario> oListCETipoDeUsuario = oCCTipoDeUsuario.obtenerDatosEnList();
            for (int i = 0; i < oListCETipoDeUsuario.Count; i++)
            {
                listBoxTipoDeUsuario.Items.Add(oListCETipoDeUsuario[i]);
            }
        }
        private void cargarComboBoxSucursal()
        {
            NSucursal oNSucursal = new NSucursal();
            List<Sucursal> oListSucursal = oNSucursal.obtenerDatosEnList();
            for (int i = 0; i < oListSucursal.Count; i++)
            {
                comboBoxSucursal.Items.Add(oListSucursal[i]);

            }
        }
        public Empleado getObjetoEmpleado()
        {
            Empleado oDEmpleado = new Empleado();
            oDEmpleado.setUsuario_id(int.Parse(textBoxUsuario_id.Text));
            oDEmpleado.setApellidoPaterno(textBoxApellidoPaterno.Text);
            oDEmpleado.setApellidoMaterno((textBoxApellidoMaterno.Text));
            oDEmpleado.setNombre((textBoxNombres.Text));
            oDEmpleado.setDireccion((textBoxDireccion.Text));
            oDEmpleado.setCelular((textBoxCelular.Text));

            oDEmpleado.setSexo(Convert.ToString(comboBoxSexo.SelectedIndex));
            oDEmpleado.setEmail((textBoxEmail.Text));
            oDEmpleado.setSueldo(Convert.ToDecimal(textBoxSueldo.Text));

            tipoDeUsuario oDTipoDeUsuario = (tipoDeUsuario)listBoxTipoDeUsuario.SelectedItem;
            oDEmpleado.setTipoDeUsuario(oDTipoDeUsuario.getTipoDeUsuario_id());

            oDEmpleado.setNick((textBoxNick.Text));
            oDEmpleado.setPasword((textBoxPassword.Text));

            if (radioButton1.Checked) { oDEmpleado.setHabilitar("1"); }
            else if (radioButton2.Checked) { oDEmpleado.setHabilitar("2"); }


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            oDEmpleado.setFoto(ms.ToArray());

            Sucursal oSucursal = (Sucursal)comboBoxSucursal.SelectedItem;
            oDEmpleado.setIdSucursal(oSucursal.getidSucursal());

            return oDEmpleado;
        }
        public void setObjetoEmpleado(Empleado oDEmpleado)
        {
            textBoxUsuario_id.Text = oDEmpleado.getUsuario_id() + "";
            textBoxApellidoPaterno.Text = oDEmpleado.getApellidoPaterno() + "";
            textBoxApellidoMaterno.Text = oDEmpleado.getApellidoMaterno() + "";
            textBoxNombres.Text = oDEmpleado.getNombre() + "";
            textBoxDireccion.Text = oDEmpleado.getDireccion() + "";
            textBoxCelular.Text = oDEmpleado.getCelular() + "";
            comboBoxSexo.SelectedIndex = int.Parse(oDEmpleado.getSexo());
            textBoxEmail.Text = oDEmpleado.getEmail() + "";
            textBoxSueldo.Text = oDEmpleado.getSueldo() + "";

            listBoxTipoDeUsuario.SelectedIndex = oDEmpleado.getTipoDeUsuario() - 1;

            textBoxNick.Text = oDEmpleado.getNick() + "";
            textBoxPassword.Text = oDEmpleado.getPassword() + "";

            if (oDEmpleado.getHabilitar() == "1") { radioButton1.Checked = true; }
            else if (oDEmpleado.getHabilitar() == "2") { radioButton2.Checked = true; }

            MemoryStream stream = new MemoryStream(oDEmpleado.getFoto());
            pictureBox1.Image = Image.FromStream(stream);

            comboBoxSucursal.SelectedIndex = int.Parse(oDEmpleado.getIdSucursal()) - 1;
        }
        private void limpiarCajasDeTexto()
        {

            textBoxUsuario_id.Text = "";
            textBoxApellidoPaterno.Text = "";
            textBoxApellidoMaterno.Text = "";
            textBoxNombres.Text = "";
            textBoxDireccion.Text = "";
            textBoxCelular.Text = "";
            comboBoxSexo.SelectedIndex = -1;
            textBoxEmail.Text = "";
            textBoxSueldo.Text = "";
            textBoxNick.Text = "";
            textBoxPassword.Text = "";
            listBoxTipoDeUsuario.SelectedIndex = -1;
            pictureBox1.Image = pictureBox1.BackgroundImage;
            comboBoxSucursal.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxApellidoMaterno.Enabled = editable;
            textBoxApellidoPaterno.Enabled = editable;
            textBoxCelular.Enabled = editable;
            textBoxDireccion.Enabled = editable;
            textBoxEmail.Enabled = editable;
            textBoxNombres.Enabled = editable;
            textBoxSueldo.Enabled = editable;
            textBoxUsuario_id.Enabled = editable;
            comboBoxSexo.Enabled = editable;
            listBoxTipoDeUsuario.Enabled = editable;
            groupBoxHabilitar.Enabled = editable;
            comboBoxSucursal.Enabled = editable;

        }
        private void habilitarControles(Boolean cNuevo, Boolean cGuardar, Boolean cEditar,
            Boolean cEliminar, Boolean cCancelar, Boolean cFoto, Boolean cGenerar)
        {

            buttonNuevo.Enabled = cNuevo;
            buttonGuardar.Enabled = cGuardar;
            buttonModificar.Enabled = cEditar;
            buttonEliminar.Enabled = cEliminar;
            buttonCancelar.Enabled = cCancelar;
            //buttonSalir.Enabled = cSalir;
            buttonFoto.Enabled = cFoto;
            buttonGenerar.Enabled = cGenerar;
        }

        public void actualizarDataGridViewMantenimientoDeEmpleado()
        {
            limpiarDataGridViewMantenimientoDeEmpleado();
            NEmpleado oNEmpleado = new NEmpleado();
            List<Empleado> oListEmpleado = oNEmpleado.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListEmpleado.Count; posicion = posicion + 1)
            {
                if (oListEmpleado[posicion].usuario_id != 0)
                {
                    dataGridViewMantenimientoDeEmpleado.Rows.Add(
                        oListEmpleado[posicion].usuario_id,
                        oListEmpleado[posicion].apellidoPaterno,
                        oListEmpleado[posicion].apellidoMaterno,
                        oListEmpleado[posicion].nombres,
                        oListEmpleado[posicion].direccion,
                        oListEmpleado[posicion].celular,
                        oListEmpleado[posicion].sexo,
                        oListEmpleado[posicion].email,
                        oListEmpleado[posicion].sueldo,
                        oListEmpleado[posicion],
                        oListEmpleado[posicion].password,
                        oListEmpleado[posicion].tipoDeUsuario,
                        oListEmpleado[posicion].foto,
                        oListEmpleado[posicion].idSucursal
                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
                linkLabelReporte.Visible = true;
            }

        }

        private void limpiarDataGridViewMantenimientoDeEmpleado()
        {
            dataGridViewMantenimientoDeEmpleado.Rows.Clear();
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (accion == DAccion.ACCION_INSERTAR)
            {
                NEmpleado oNEmpleado = new NEmpleado();
                if (oNEmpleado.consultarRegistroNick(textBoxNick.Text) == null)
                {
                    if (oNEmpleado.registrarEmpleado(getObjetoEmpleado()))
                    {
                        
                            //accion = DAccion.NO_ACCION;
                            MessageBox.Show("Empleado Registrado Exitosamente ... !!!",
                                "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarDataGridViewMantenimientoDeEmpleado();
                            limpiarCajasDeTexto();
                            habilitarCajasDeTexto(false);
                            pictureBoxLupa.Visible = true;
                            //textBoxBuscar.Visible = false;
                            textBoxUsuario_id.Visible = true;
                            textBoxUsuario_id.Enabled = false;
                            buttonNuevo.Focus();
                            //textBoxBuscar.Clear();
                            dataGridViewMantenimientoDeEmpleado.Enabled = true;
                            habilitarControles(true, false, false, false, false, false, false);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar el EMPLEADO ... !!!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //accion = DAccion.NO_ACCION;
                    MessageBox.Show("EL USUARIO ya EXISTE ... !!!",
                            "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNick.Enabled = true;
                    textBoxPassword.Enabled = true;
                    textBoxNick.Focus();
                    buttonGenerar.Visible = false;
                    pictureBoxLupa.Visible = true;
                    //textBoxBuscar.Visible = false;
                    textBoxUsuario_id.Visible = true;
                    textBoxUsuario_id.Enabled = false;
                    //textBoxBuscar.Clear();
                    habilitarControles(true, false, false, false, false, false, false);
                }
            }
            else
            {
                if (accion == DAccion.ACCION_MODIFICAR)
                {
                    if (MessageBox.Show("Esta Seguro de guardar los datos?",
                       "Confirmar el Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NEmpleado oNEmpleado = new NEmpleado();
                        Empleado oEmpleado = new Empleado();
                        if (oNEmpleado.editarEmpleado(int.Parse(textBoxUsuario_id.Text), getObjetoEmpleado()))
                        {
                            MessageBox.Show("Empleado Modificado Exitosamente ... !!!",
                             "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //accion = DAccion.NO_ACCION;
                            actualizarDataGridViewMantenimientoDeEmpleado();
                            habilitarCajasDeTexto(false);
                            limpiarCajasDeTexto();
                            pictureBoxLupa.Visible = true;
                            //textBoxBuscar.Visible = false;
                            textBoxUsuario_id.Visible = true;
                            textBoxUsuario_id.Enabled = true;
                            dataGridViewMantenimientoDeEmpleado.Enabled = true;
                            //textBoxBuscar.Clear();
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar el EMPLEADO ... !!!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                pictureBox1.Image = Image.FromFile(nombreDeFoto);
                linkLabelReporte.Visible = true;
                
            }
        }
        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            string cadena = textBoxNombres.Text;
            string cadena2 = textBoxApellidoMaterno.Text;
            string cadena3 = textBoxApellidoPaterno.Text;

            if (textBoxUsuario_id.Text.Equals(""))
            {
                MessageBox.Show("Falta llenar el Dni del Empleado",
                    "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsuario_id.Focus();
            }
            else if (textBoxApellidoPaterno.Text.Equals(""))
            {
                MessageBox.Show("Falta llenar el Apellido Paterno del Empleado",
                    "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxApellidoPaterno.Focus();
            }
            else if (textBoxApellidoMaterno.Text.Equals(""))
            {
                MessageBox.Show("Falta llenar el Apellido Materno del Empleado",
                    "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxApellidoMaterno.Focus();
            }
            else if (textBoxNombres.Text.Equals(""))
            {
                MessageBox.Show("Falta llenar el o los Nombres del Empleado",
                    "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNombres.Focus();
            }
            else
            {
                textBoxNick.Text                = cadena.Substring(0, 1) + textBoxApellidoPaterno.Text + cadena2.Substring(0, 1);
                textBoxPassword.Text            = cadena3.Substring(0, 1) + textBoxUsuario_id.Text + cadena2.Substring(0, 1);
                linkLabelReporte.Visible        = true;
             }

        }

        private void buttonNuevo_MouseClick(object sender, MouseEventArgs e)
        {
            limpiarCajasDeTexto();
            textBoxUsuario_id.Enabled = true;
            textBoxUsuario_id.Focus();
            listBoxTipoDeUsuario.Enabled = false;
            listBoxTipoDeUsuario.SelectedIndex = -1;
            //groupBoxHabilitar.Visible = false;
            pictureBoxLupa.Visible = false;
            linkLabelReporte.Visible = true;
            //textBoxBuscar.Visible = false;
            textBoxUsuario_id.Visible = true;
            
            //textBoxBuscar.Clear();
          
            habilitarControles(true, false, false, false, true, false, true);
        }
        private void textBoxUsuario_id_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                if ((textBoxUsuario_id.TextLength) > 0)
                {
                    Empleado oEmpleado = new Empleado();
                    NEmpleado oNEmpleado = new NEmpleado();

                    int busqueda = int.Parse(textBoxUsuario_id.Text);
                    oEmpleado = oNEmpleado.BuscarDniEmpleado(busqueda);


                    if (oEmpleado == null)
                    {

                        textBoxUsuario_id.Enabled = false;
                        groupBoxHabilitar.Visible = true;
                        habilitarCajasDeTexto(true);
                        textBoxApellidoPaterno.Focus();
                        linkLabelReporte.Visible = true;
                        habilitarControles(false, true, false, false, true, true, true);
                    }
                    else if (oEmpleado != null)
                    {
                        MessageBox.Show("EMPLEADO encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoEmpleado(oEmpleado);
                        textBoxUsuario_id.Enabled = false;
                        listBoxTipoDeUsuario.Enabled = false;
                        groupBoxHabilitar.Visible = true;
                        groupBoxHabilitar.Enabled = false;
                        linkLabelReporte.Visible = false;
                        dataGridViewMantenimientoDeEmpleado.Rows.Clear();
                        actualizarDataGridViewMantenimientoDeEmpleado_1();
                        habilitarControles(false, false, true, true, true, false, false);
                        dataGridViewMantenimientoDeEmpleado.Enabled = true;
                        buttonCancelar.Focus();
                        
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           

                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Empleado Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsuario_id.Clear();
                        textBoxUsuario_id.Visible = false;
                        textBoxUsuario_id.Focus();
                        buttonCancelar.Enabled = true;
                        linkLabelReporte.Visible = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Dni del EMPLEADO... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsuario_id.Focus();
                    buttonCancelar.Enabled = true;
                    linkLabelReporte.Visible = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           
                }
            }
        }

        private void dataGridViewMantenimientoDeEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                int filaSeleccionada = dataGridViewMantenimientoDeEmpleado.CurrentRow.Index;
                if (filaSeleccionada != -1)
                {
                    
                    Empleado oEmpleadoSeleccionado = (Empleado)dataGridViewMantenimientoDeEmpleado.Rows[filaSeleccionada].Cells[9].Value ;
                    setObjetoEmpleado(oEmpleadoSeleccionado);
                    Empleado oEmpleado = new Empleado();
                    textBoxUsuario_id.Enabled = false;
                    groupBoxHabilitar.Visible = true;
                    pictureBoxLupa.Visible = true;
                    linkLabelReporte.Visible = true;
                    //textBoxBuscar.Visible = false;
                    textBoxUsuario_id.Visible = true;
                    
                    //textBoxBuscar.Clear();
                    
                    habilitarControles(true, false, true, true, true, false, false);

                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewMantenimientoDeEmpleado.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxUsuario_id.Text.Length) > 0)
            {
                textBoxApellidoPaterno.Focus();
                accion = DAccion.ACCION_MODIFICAR;
                habilitarCajasDeTexto(true);
                textBoxUsuario_id.Enabled = false;
                pictureBoxLupa.Visible = true;
                linkLabelReporte.Visible = true;
                //textBoxBuscar.Visible = false;
                textBoxUsuario_id.Visible = true;
                textBoxUsuario_id.Enabled = false;
                //textBoxBuscar.Clear();
                habilitarControles(false, true, false, false, true, true, true);
            }
            else
            {
                MessageBox.Show("Usted no ha SELECCIONADO ningun EMPLEADO ... !!!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkLabelReporte.Visible = true;
              
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewMantenimientoDeEmpleado.RowCount >= 1)
            {
                int filaSeleccionada = dataGridViewMantenimientoDeEmpleado.CurrentRow.Index;
                if (filaSeleccionada != -1 && (textBoxUsuario_id.Text.Length) > 0)
                {
                    if (MessageBox.Show("Esta Seguro de ELIMINAR los datos del EMPLEADO?",
                    "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NEmpleado oNEmpleado = new NEmpleado();
                        Empleado oEmpleado = new Empleado();
                        int buscar = int.Parse(textBoxUsuario_id.Text);
                        oEmpleado = oNEmpleado.BuscarDniEmpleado(buscar);
                        if (oEmpleado != null)
                        {
                            oEmpleado = getObjetoEmpleado();
                            if (oNEmpleado.eliminarEmpleado(buscar))
                            {
                                MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                    "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //accion = DAccion.NO_ACCION;
                                habilitarCajasDeTexto(false);
                                limpiarCajasDeTexto();
                                actualizarDataGridViewMantenimientoDeEmpleado();
                                pictureBoxLupa.Visible = true;
                                //textBoxBuscar.Visible = false;
                                textBoxUsuario_id.Visible = true;
                                textBoxUsuario_id.Enabled = false;
                                linkLabelReporte.Visible = true;
                                dataGridViewMantenimientoDeEmpleado.Enabled = true;
                                habilitarControles(true, false, false, false, false, false, false);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo ELIMINAR el registro...!!!",
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                accion = DAccion.NO_ACCION;
                                linkLabelReporte.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo ELIMINAR el registro...!!!",
                                   "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            accion = DAccion.NO_ACCION;
                            linkLabelReporte.Visible = true;
                        }
                    }
                    else
                    {
                        accion = DAccion.NO_ACCION;
                        linkLabelReporte.Visible = true;
                    }
                }
                else
                {

                    MessageBox.Show("Se tiene que seleccionar un REGISTRO....!!!",
                               "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accion = DAccion.NO_ACCION;
                    linkLabelReporte.Visible = true;
                }


            }
            else
            {
                MessageBox.Show("No Existen REGISTROS....!!!",
                               "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                accion = DAccion.NO_ACCION;
                linkLabelReporte.Visible = true;
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //accion = DAccion.NO_ACCION;
            habilitarControles(true, false, false, false, false, false, false);
            limpiarCajasDeTexto();
            habilitarCajasDeTexto(false);
            pictureBoxLupa.Visible = true;
            linkLabelReporte.Visible = true;
            //textBoxBuscar.Visible = false;
            textBoxUsuario_id.Visible = true;
            //textBoxBuscar.Clear();
            textBoxUsuario_id.Enabled = true;
            textBoxUsuario_id.Focus();
            actualizarDataGridViewMantenimientoDeEmpleado();
            dataGridViewMantenimientoDeEmpleado.Enabled = true;
        }

        private void frmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {

            //this.Size = new Size(791, 538);
            //this.Top = 10;
            //this.Left = 246;
            //buttonNuevo.Focus();
            ////Form.Size = new System.Drawing.Size(882, 356);
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(3, 10);
            
            //frmMantenimientoEmpleado fm = new frmMantenimientoEmpleado();
            //fm.StartPosition = FormStartPosition.CenterScreen;
            //this.pictureBoxLupa.Location = new Point(362, 288);
            textBoxUsuario_id.Enabled = true;
            textBoxUsuario_id.Focus();



        }

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            //cambioDeEstado = 0; Dispose();
            this.Close();
            
        }

        public void actualizarDataGridViewMantenimientoDeEmpleado_1()
        {
            int buscar = int.Parse(textBoxUsuario_id.Text);
            limpiarDataGridViewMantenimientoDeEmpleado();
            NEmpleado oNEmpleado = new NEmpleado();
            List<Empleado> oListEmpleado = oNEmpleado.obtenerDatosEnListaDeEmpleados(buscar);
            for (int posicion = 0; posicion < oListEmpleado.Count; posicion = posicion + 1)
            {
                if (oListEmpleado[posicion].usuario_id != 0)
                {
                    dataGridViewMantenimientoDeEmpleado.Rows.Add(
                        oListEmpleado[posicion].usuario_id,
                        oListEmpleado[posicion].apellidoPaterno,
                        oListEmpleado[posicion].apellidoMaterno,
                        oListEmpleado[posicion].nombres,
                        oListEmpleado[posicion].direccion,
                        oListEmpleado[posicion].celular,
                        oListEmpleado[posicion].sexo,
                        oListEmpleado[posicion].email,
                        oListEmpleado[posicion].sueldo,
                        oListEmpleado[posicion],
                        oListEmpleado[posicion].password,
                        oListEmpleado[posicion].tipoDeUsuario,
                        oListEmpleado[posicion].foto,
                        oListEmpleado[posicion].idSucursal
                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
            }

        }
        
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado  fm = new frmReporteEmpleado();
            fm.ShowDialog();
        }

        private void pictureBoxLupa_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Clicks == 1)
            {
                if ((textBoxUsuario_id.TextLength) > 0)
                {
                    Empleado oEmpleado = new Empleado();
                    NEmpleado oNEmpleado = new NEmpleado();

                    int busqueda = int.Parse(textBoxUsuario_id.Text);
                    oEmpleado = oNEmpleado.BuscarDniEmpleado(busqueda);


                    if (oEmpleado == null)
                    {
                        MessageBox.Show("EL DNI del Empleado no esta registrado ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxUsuario_id.Enabled = true;
                        textBoxUsuario_id.Focus();
                        textBoxUsuario_id.Clear();
                        
                    }
                    else if (oEmpleado != null)
                    {
                        MessageBox.Show("EMPLEADO encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoEmpleado(oEmpleado);
                        textBoxUsuario_id.Enabled = false;
                        listBoxTipoDeUsuario.Enabled = false;
                        groupBoxHabilitar.Visible = true;
                        groupBoxHabilitar.Enabled = false;
                        linkLabelReporte.Visible = false;
                        dataGridViewMantenimientoDeEmpleado.Rows.Clear();
                        actualizarDataGridViewMantenimientoDeEmpleado_1();
                        habilitarControles(false, false, true, true, true, false, false);
                        dataGridViewMantenimientoDeEmpleado.Enabled = false;
                        buttonCancelar.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Empleado Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsuario_id.Clear();
                        textBoxUsuario_id.Visible = false;
                        textBoxUsuario_id.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Dni del EMPLEADO... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsuario_id.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeEmpleado.Rows.Count) + " Empleados";
           
                }
            }
        }

        
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string texto = textBoxEmail.Text;
            bool validar = texto.Contains("@gmail.com") || texto.Contains("@hotmail.com");
            if (validar == true)
            {
               
            }
            else
            {
                //accion = DAccion.NO_ACCION;
                MessageBox.Show("ERROR, El formato correcto del Email debe ser example@gmail.com o example@hotmail.com",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Clear();
                textBoxEmail.Focus();
            }
        }

        private void dataGridViewMantenimientoDeEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 14)
            {

                this.textBoxDni1.Text = dataGridViewMantenimientoDeEmpleado.CurrentRow.Cells[0].Value.ToString();
                Reportes.frmReporteEmpleadoIndividual frm = new Reportes.frmReporteEmpleadoIndividual();
                frm.Dni = int.Parse(textBoxDni1.Text);
                frm.ShowDialog();
            }
        }

        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
        }

        private void textBoxSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumericoyPunto(e.KeyChar);
        }

        private void textBoxApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
        }

        private void textBoxApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
        }

        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
        }
    }
}


       
    

