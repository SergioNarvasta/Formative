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
    public partial class frmMantenimientoDeCliente : Form
    {
        DClientes oClientes = new DClientes();
        private int accion = DAccion.NO_ACCION;
        public frmMantenimientoDeCliente()
        {

            InitializeComponent();
            this.labelTotal.Location = new Point(646, 296);
            textBoxBuscarxDni.Enabled = false;
            buttonBuscarxDni.Visible = false;
            textBoxBuscarxApellidos.Enabled = false;
            buttonBuscarxApellidos.Visible = false;
            dataGridViewCliente.Visible = true;
            cargarComboBoxSucursal();
            actualizarDataGridViewCliente();
            accion = DAccion.ACCION_INSERTAR;
            habilitarControles(true, false, false, false, false,true);
            mensajeAyuda();
            
        }
        public frmMantenimientoDeCliente(Clientes oCliente)
        {
            InitializeComponent();
            cargarComboBoxSucursal();
            setObjetoClientes(oCliente);
        }

        private void limpiarCajasDeTexto()
        {

            textBoxDni.Text = "";
            textBoxApellidos.Text = "";
            textBoxNombres.Text = "";
            textBoxDireccion.Text = "";
            textBoxCelular.Text = "";
            comboBoxSucursal.SelectedIndex = -1;
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

        public Clientes getObjetoClientes()
        {
            Clientes oDClientes = new Clientes();
            
            oDClientes.setDni(int.Parse(textBoxDni.Text));
            oDClientes.setApellidos(textBoxApellidos.Text);
            oDClientes.setNombres((textBoxNombres.Text));
            oDClientes.setDireccion((textBoxDireccion.Text));
            //oDClientes.setDireccion((textBoxDireccion.Text));
            oDClientes.setCelular((textBoxCelular.Text));

            Sucursal oSucursal = (Sucursal)comboBoxSucursal.SelectedItem;
            oDClientes.setIdSucursal(oSucursal.getidSucursal());

            return oDClientes;
        }
        public void setObjetoClientes(Clientes oDClientes)
        {
            textBoxDni.Text = oDClientes.getDni() + "";
            textBoxApellidos.Text = oDClientes.getApellidos() + "";
            textBoxNombres.Text = oDClientes.getNombres() + "";
            textBoxDireccion.Text = oDClientes.getDireccion() + "";
            textBoxCelular.Text = oDClientes.getCelular() + "";
            comboBoxSucursal.SelectedIndex = int.Parse(oDClientes.getIdSucursal()) - 1;
        }

        public void actualizarDataGridViewCliente()
        {
                limpiarDataGridViewCliente();
                NClientes oNClientes = new NClientes();
                List<Clientes> oListClientes = oNClientes.obtenerDatosEnList();
                for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
                {
                    if (oListClientes[posicion].getDni() != 0)
                    {
                        dataGridViewCliente.Rows.Add(
                            oListClientes[posicion].getDni(),
                            oListClientes[posicion].getApellidos(),
                            oListClientes[posicion].getNombres(),
                            oListClientes[posicion].getDireccion(),
                            oListClientes[posicion].getCelular(),
                            oListClientes[posicion]);
                    }
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
                    
                }
            

        }
        public void actualizarDataGridViewCliente_1()
        {
            int buscar = int.Parse(textBoxBuscarxDni.Text);
            NClientes oNClientes = new NClientes();
            List<Clientes> oListClientes = oNClientes.obtenerDatosEnListaDeClientesxDni(buscar);
            for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
            {
                if (oListClientes[posicion].getDni() != 0)
                {
                    dataGridViewCliente.Rows.Add(
                        oListClientes[posicion].getDni(),
                        oListClientes[posicion].getApellidos(),
                        oListClientes[posicion].getNombres(),
                        oListClientes[posicion].getDireccion(),
                        oListClientes[posicion].getCelular(),
                        oListClientes[posicion]);
                }
                
            }


        }
        public void actualizarDataGridViewCliente_2()
        {
            String buscar = textBoxBuscarxApellidos.Text;
            NClientes oNClientes = new NClientes();
            List<Clientes> oListClientes = oNClientes.obtenerDatosEnListaDeClientesxApellidos(buscar);
            for (int posicion = 0; posicion < oListClientes.Count; posicion = posicion + 1)
            {
                if (oListClientes[posicion].getDni() != 0)
                {
                    dataGridViewCliente.Rows.Add(
                        oListClientes[posicion].getDni(),
                        oListClientes[posicion].getApellidos(),
                        oListClientes[posicion].getNombres(),
                        oListClientes[posicion].getDireccion(),
                        oListClientes[posicion].getCelular(),
                        oListClientes[posicion]);
                }

            }


        }
        

        
        private void limpiarDataGridViewCliente()
        {
            dataGridViewCliente.Rows.Clear();

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

        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxApellidos.Enabled = editable;
            textBoxCelular.Enabled = editable;
            textBoxDireccion.Enabled = editable;
            textBoxNombres.Enabled = editable;
            comboBoxSucursal.Enabled = editable;

        }

        private void mensajeAyuda()
        {
            toolTipMensajes.SetToolTip(this.buttonNuevo, "Nuevo registro");
            toolTipMensajes.SetToolTip(this.buttonGuardar, "Guardar registro");
            toolTipMensajes.SetToolTip(this.buttonModificar, "Modificar el resgistro seleccionado");
            toolTipMensajes.SetToolTip(this.buttonEliminar, "Eliminar el registro seleccionado");
            toolTipMensajes.SetToolTip(this.buttonCancelar, "Para cancelar una accion realizada");
            toolTipMensajes.SetToolTip(this.buttonImprimir, "Para imprimir todos los registros");
            toolTipMensajes.SetToolTip(this.pictureBoxLupa, "Para buscar los clientes");
            
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;

            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxApellidos.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar los Apellidos del Cliente",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxApellidos.Focus();
                }
                else if (textBoxNombres.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar los Nombres del Cliente",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombres.Focus();
                }
                else if (textBoxCelular.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Celular del Cliente",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCelular.Focus();
                }
                else if (textBoxDireccion.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Direccion del Cliente",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxDireccion.Focus();
                }
                else if (comboBoxSucursal.Text.Equals(""))
                {
                    MessageBox.Show("Falta Seleccionar el lugar de la compra...",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxSucursal.Focus();
                }
                
                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NClientes oNClientes = new NClientes();
                        if (oNClientes.registrarClientes(getObjetoClientes()))
                        {
                             habilitarControles(true,false,false,false,true,false);
                            buttonNuevo.Focus();
                            actualizarDataGridViewCliente();
                            habilitarCajasDeTexto(false);
                            textBoxDni.Enabled = false;
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
                    NClientes oNClientes = new NClientes();
                    Clientes oClientes = new Clientes();
                    if (oNClientes.editarClientes(int.Parse(textBoxDni.Text), getObjetoClientes()))
                    {
                        MessageBox.Show("Cliente Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewCliente();
                        limpiarCajasDeTexto();
                        tabControlCliente.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, false);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el CLIENTE ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewCliente_DoubleClick(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewCliente.CurrentRow.Index;
            if (filaSeleccionada != -1)
            {

                Clientes oClienteSeleccionado = (Clientes)dataGridViewCliente.Rows[filaSeleccionada].Cells[5].Value;
                setObjetoClientes(oClienteSeleccionado);
                Clientes oCliente = new Clientes();

                buttonGuardar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
                textBoxDni.Enabled = false;
                habilitarCajasDeTexto(false);
                habilitarControles(false, false, true, true, true,true);

            }

            this.tabControlCliente.SelectedIndex = 1;

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            int filaSeleccionada = dataGridViewCliente.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxDni.Text.Length) > 0)
            {
                textBoxApellidos.Focus();
                accion = DAccion.ACCION_MODIFICAR;
                habilitarControles(false, true, false, false, true,false);
                habilitarCajasDeTexto(true);
                textBoxApellidos.Focus();
                textBoxDni.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un registro ...!!!");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (tabControlCliente.SelectedIndex == 0)
            {

                foreach (DataGridViewRow fila in dataGridViewCliente.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells[6].Value))
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los registros Seleccionados?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oClientes.eliminar_Multiple(fila.Cells[0].Value.ToString(), this.labelTotal);

                            actualizarDataGridViewCliente();
                            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
                            labelTotal.ForeColor = Color.DarkGray;
                        }
                    }
                }


            }
            if (tabControlCliente.SelectedIndex == 1)
            {

                tabControlCliente.SelectedIndex = 1;
                if (dataGridViewCliente.RowCount >= 1)
                {

                    int filaSeleccionada = dataGridViewCliente.CurrentRow.Index;
                    if (filaSeleccionada != -1 && (textBoxDni.Text.Length) > 0)
                    {
                        if (MessageBox.Show("Esta Seguro de ELIMINAR los datos del CLIENTE?",
                        "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NClientes oNClientes = new NClientes();
                            Clientes oClientes = new Clientes();
                            int buscar = int.Parse(textBoxDni.Text);
                            oClientes = oNClientes.BuscarDniClientes(buscar);
                            if (oClientes != null)
                            {
                                oClientes = getObjetoClientes();
                                oClientes.setDni(buscar);
                                if (oNClientes.eliminarClientes(buscar))
                                {
                                    MessageBox.Show("Se ELIMINO el registro CORRECTAMENTE...!!!",
                                        "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    buttonNuevo.Focus();
                                    textBoxDni.Enabled = false;
                                    habilitarCajasDeTexto(false);
                                    limpiarCajasDeTexto();
                                    habilitarControles(false, false, false, false, true, false);

                                    tabControlCliente.SelectedIndex = 0;
                                    actualizarDataGridViewCliente();
                                    pictureBoxLupa.Visible = true;
                                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            
           labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
           habilitarControles(true, false, false, false, false,true);
        }

        private void tabControlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCliente.SelectedIndex == 0)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                textBoxDni.Enabled = false;
                habilitarControles(true, false, false, false, true,true);
                buttonNuevo.Focus();
              
            }
            if(tabControlCliente.SelectedIndex == 1)
            {
               this.buttonNuevo.Enabled = true;
               this.buttonCancelar.Enabled = true;
               this.habilitarCajasDeTexto(false);
               this.textBoxDni.Enabled = false;
               this.buttonNuevo.Focus();
               this.dataGridViewCliente.Visible = true;
               this.labelTotal.Location = new Point(646, 296);
               this.labelTotal.Visible = true;
               this.actualizarDataGridViewCliente();
               this.radioButtonDni.Checked = false;
               this.radioButtonApellidos.Checked = false;
               this.textBoxBuscarxDni.Enabled = false;
               this.buttonBuscarxDni.Visible = false;
               this.textBoxBuscarxApellidos.Enabled = false;
               this.buttonBuscarxApellidos.Visible = false;
               this.textBoxBuscarxDni.Clear();
               this.textBoxBuscarxApellidos.Clear();
               this.groupBoxDatos.Location = new Point(107, 50);
               this.groupBoxDatos.Size = new Size(590, 210);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
            limpiarCajasDeTexto();
            textBoxDni.Enabled = true;
            textBoxDni.Focus();
            pictureBoxLupa.Visible = true;
            this.groupBoxDatos.Location = new Point(107, 50);
            this.groupBoxDatos.Size = new Size(590, 210);
            habilitarControles(true, false, false, false, true,false);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                tabControlCliente.SelectedIndex = 1;
                if ((textBoxDni.TextLength) > 0)
                {
                    Clientes oClientes = new Clientes();
                    NClientes oNClientes = new NClientes();

                    int busqueda = int.Parse(textBoxDni.Text);
                    oClientes = oNClientes.BuscarDniClientes(busqueda);


                    if (oClientes == null)
                    {

                        textBoxDni.Enabled = false;
                        habilitarCajasDeTexto(true);
                        textBoxApellidos.Focus();
                        habilitarControles(false, true, false, false, true,false);
                    }
                    else if (oClientes != null)
                    {
                        MessageBox.Show("CLIENTE encontrado ... !!!",
                          "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setObjetoClientes(oClientes);
                        textBoxDni.Enabled = false;
                        this.groupBoxDatos.Location = new Point(107, 50);
                        this.groupBoxDatos.Size = new Size(590, 210);
                        //dataGridView1.Visible = true;
                       // limpiarDataGridView1();
                       // actualizarDataGridViewCliente_3();
                        habilitarControles(false, false, true, true, true,true);
                        buttonCancelar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar al Clientes Solicitado",
                            "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxDni.Clear();
                        
                        textBoxDni.Focus();
                        buttonCancelar.Enabled = true;
                        labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Dni del CLIENTE... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDni.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(tabControlCliente.SelectedIndex == 0)
            {
                textBoxBuscarxDni.Enabled = false;
                textBoxBuscarxDni.Clear();
                buttonBuscarxDni.Visible = false;
                textBoxBuscarxApellidos.Enabled = false;
                textBoxBuscarxApellidos.Clear();
                buttonBuscarxApellidos.Visible = false;
                radioButtonApellidos.Checked = false;
                radioButtonDni.Checked = false;
                actualizarDataGridViewCliente();
                this.groupBoxDatos.Location = new Point(107, 50);
                this.groupBoxDatos.Size = new Size(590, 210);
                this.labelTotal.Location = new Point(646, 296);
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false,false);
                buttonNuevo.Focus();

                
            
            }
            if (tabControlCliente.SelectedIndex == 1)
            {
                this.groupBoxDatos.Location = new Point(107, 50);
                this.groupBoxDatos.Size = new Size(590, 210);
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false,false);
                buttonNuevo.Focus();
            }
            
            
            
        }

        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
        }

       
        private void radioButtonDni_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxApellidos.Visible = false;
            this.buttonBuscarxApellidos.Visible = false;
            this.textBoxBuscarxDni.Visible = true;
            this.buttonBuscarxDni.Visible = true;
            this.textBoxBuscarxDni.Enabled = true;
            this.textBoxBuscarxDni.Clear();
            this.textBoxBuscarxDni.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxDni.Visible = true;
            
            this.labelTotal.Location = new Point(646, 296);
            actualizarDataGridViewCliente();
            
            
        }

        private void radioButtonApellidos_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxDni.Visible = false;
            this.buttonBuscarxDni.Visible = false;
            this.textBoxBuscarxApellidos.Visible = true;
            this.buttonBuscarxApellidos.Visible = true;
            this.textBoxBuscarxApellidos.Enabled = true;
            this.textBoxBuscarxApellidos.Clear();
            this.textBoxBuscarxApellidos.Focus();
            this.buttonCancelar.Enabled = true;
            this.buttonBuscarxApellidos.Visible = true;

            this.labelTotal.Location = new Point(646, 296);
            actualizarDataGridViewCliente();
            
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
            if ((textBoxDni.TextLength) > 0)
            {
                Clientes oClientes = new Clientes();
                NClientes oNClientes = new NClientes();

                int busqueda = int.Parse(textBoxDni.Text);
                oClientes = oNClientes.BuscarDniClientes(busqueda);


                if (oClientes == null)
                {

                    textBoxDni.Enabled = false;
                    habilitarCajasDeTexto(true);
                    textBoxApellidos.Focus();
                    habilitarControles(false, true, false, false, true,false);
                }
                else if (oClientes != null)
                {
                    MessageBox.Show("CLIENTE encontrado ... !!!",
                      "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setObjetoClientes(oClientes);
                    textBoxDni.Enabled = false;
                    this.groupBoxDatos.Location = new Point(107, 50);
                    this.groupBoxDatos.Size = new Size(590, 210);
                    
                    
                    habilitarControles(false, false, true, true, true,true);
                    buttonCancelar.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar al Clientes Solicitado",
                        "ERROR...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxDni.Clear();

                    textBoxDni.Focus();
                    buttonCancelar.Enabled = true;
                    labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

                }
            }
            else
            {
                MessageBox.Show("Ingrese el Dni del CLIENTE... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDni.Focus();
                buttonCancelar.Enabled = true;
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";

            }
        }

        private void textBoxBuscarxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorNumerico(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxDni.TextLength) > 0)
                {
                    tabControlCliente.SelectedIndex = 0;

                    NClientes oNClientess = new NClientes();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonDni.Checked == true)
                    {
                        Clientes oClientess = new Clientes();
                        int buscarXDni = int.Parse(textBoxBuscarxDni.Text);
                        oClientess = oNClientess.BuscarDniClientes(buscarXDni);
                        if (oClientess == null)
                        {
                            MessageBox.Show("EL Dni del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxDni.Clear();
                            textBoxBuscarxDni.Focus();
                        }
                        else if (oClientess != null)
                        {
                            limpiarDataGridViewCliente();
                            actualizarDataGridViewCliente_1();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(544, 296);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese el Dni del Clientes a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxDni.Focus();
                    actualizarDataGridViewCliente();
                    labelTotal.Location = new Point(646, 296);
                }
                buttonCancelar.Enabled = true;
            }
        }

        private void buttonBuscarxDni_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxDni.TextLength) > 0)
            {
                tabControlCliente.SelectedIndex = 0;

                NClientes oNClientess = new NClientes();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonDni.Checked == true)
                {
                    Clientes oClientess = new Clientes();
                    int buscarXDni = int.Parse(textBoxBuscarxDni.Text);
                    oClientess = oNClientess.BuscarDniClientes(buscarXDni);
                    if (oClientess == null)
                    {
                        MessageBox.Show("EL Dni del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxDni.Clear();
                        textBoxBuscarxDni.Focus();
                    }
                    else if (oClientess != null)
                    {
                        
                        limpiarDataGridViewCliente();
                        actualizarDataGridViewCliente_1();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(544, 296);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingrese el Dni del Clientes a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxDni.Focus();
                actualizarDataGridViewCliente();
                labelTotal.Location = new Point(646, 296);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxDni_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxDni.Clear();
            this.labelTotal.Location = new Point(646, 296);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
        }

        private void textBoxBuscarxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxApellidos.TextLength) > 0)
                {
                    tabControlCliente.SelectedIndex = 0;

                    NClientes oNClientes = new NClientes();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonApellidos.Checked == true)
                    {
                        Clientes oClientes = new Clientes();
                        String buscarXApellido = textBoxBuscarxApellidos.Text;
                        oClientes = oNClientes.BuscarApellidosClientes(buscarXApellido);
                        if (oClientes == null)
                        {
                            MessageBox.Show("Los Apellidos del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxApellidos.Clear();
                            textBoxBuscarxApellidos.Focus();
                        }
                        else if (oClientes != null)
                        {
                            limpiarDataGridViewCliente();
                            actualizarDataGridViewCliente_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(544, 296);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese los Apellidos del Clientes a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxApellidos.Focus();
                    actualizarDataGridViewCliente();
                    labelTotal.Location = new Point(630, 303);
                }
                buttonCancelar.Enabled = true;
            }
            
        }

        private void buttonBuscarxApellidos_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxApellidos.TextLength) > 0)
            {
                tabControlCliente.SelectedIndex = 0;

                NClientes oNClientess = new NClientes();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonApellidos.Checked == true)
                {
                    Clientes oClientes = new Clientes();
                    String buscarXApellido = textBoxBuscarxApellidos.Text;
                    oClientes = oNClientess.BuscarApellidosClientes(buscarXApellido);
                    if (oClientes == null)
                    {
                        MessageBox.Show("Los Apellidos del Clientes que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxApellidos.Clear();
                        textBoxBuscarxApellidos.Focus();
                    }
                    else if (oClientes != null)
                    {
                        limpiarDataGridViewCliente();
                        actualizarDataGridViewCliente_2();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(544, 296);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese los Apellidos del Clientes a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxDni.Focus();
                actualizarDataGridViewCliente();
                labelTotal.Location = new Point(630, 303);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxApellidos.Clear();
            this.labelTotal.Location = new Point(646, 296);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCliente.Rows.Count) + " Clientes";
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.buttonEliminar.Enabled = true;
            }
            else 
            {
                this.buttonEliminar.Enabled = false;

            }
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewCliente.Rows[e.RowIndex].Cells[6];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            frmReporteClientes fm = new frmReporteClientes();
            fm.ShowDialog();
        }

        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
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
