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
    public partial class frmMantenimientoDeHorario : Form
    {
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;
       
        public frmMantenimientoDeHorario()
        {
            InitializeComponent();
            textBoxBuscarxApellidos.Enabled = false;
            buttonBuscarxApellidos.Enabled = false;
            textBoxCodigo.Visible = false;
            comboBoxEmpleado.Text = "Seleccione un Empleado";
            cargarComboBoxEmpleado();
            actualizarDataGridViewHorario();
            accion = DAccion.ACCION_INSERTAR;
            habilitarControles(true, false, false, false, false, true);
           
        }
        private void cargarComboBoxEmpleado()
        {
            NEmpleado oNEmpleado = new NEmpleado();
            List<Empleado> oListEmpleado = oNEmpleado.obtenerDatosEnList();
            for (int i = 0; i < oListEmpleado.Count; i++)
            {
                comboBoxEmpleado.Items.Add(oListEmpleado[i]);

            }
        }

        private void limpiarCajasDeTexto()
        {

            textBoxCodigo.Text = "";
            textBoxTurno.Text = "";
            textBoxHSalida.Text = "";
            textBoxHEntrada.Text = "";
            comboBoxEmpleado.Text = "Seleccione un Empleado";
        }

        public Horario getObjetoHorario()
        {
            Horario oDHorario = new Horario();

            oDHorario.setTurno(textBoxTurno.Text);
            oDHorario.setHoraEntrada(textBoxHEntrada.Text);
            oDHorario.setHoraSalida((textBoxHSalida.Text));
            
            Empleado oEmpleado = (Empleado)comboBoxEmpleado.SelectedItem;
            oDHorario.setIdEmpleado(oEmpleado.getUsuario_id());

            return oDHorario;
        }
        public Horario getObjetoHorario_1()
        {
            Horario oDHorario = new Horario();
            oDHorario.setCodigo(int.Parse(textBoxCodigo.Text));
            oDHorario.setTurno(textBoxTurno.Text);
            oDHorario.setHoraEntrada(textBoxHEntrada.Text);
            oDHorario.setHoraSalida((textBoxHSalida.Text));

            Empleado oEmpleado = (Empleado)comboBoxEmpleado.SelectedItem;
            oDHorario.setIdEmpleado(oEmpleado.getUsuario_id());

            return oDHorario;
        }

        public void setObjetoHorario(Horario oDHorario)
        {
            textBoxCodigo.Text = oDHorario.getCodigo() + "";
            textBoxTurno.Text = oDHorario.getTurno() + "";
            textBoxHEntrada.Text = oDHorario.getHoraEntrada() + "";
            textBoxHSalida.Text = oDHorario.getHoraSalida() + "";
            comboBoxEmpleado.SelectedIndex = oDHorario.getIdEmpleado()-1;
        }

        public void actualizarDataGridViewHorario()
        {
            limpiarDataGridViewHorario();
            NHorario oNHorario = new NHorario();
            List<Horario> oListHorario = oNHorario.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListHorario.Count; posicion = posicion + 1)
            {
                if (oListHorario[posicion].getCodigo() != 0)
                {
                    dataGridViewHorario.Rows.Add(
                        oListHorario[posicion].getCodigo(),
                        oListHorario[posicion].getIdEmpleado(),
                        oListHorario[posicion].getNombreEmpleado(),
                        oListHorario[posicion].getCargo(),
                        oListHorario[posicion].getTurno(),
                        oListHorario[posicion].getHoraEntrada(),
                        oListHorario[posicion].getHoraSalida()
                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewHorario.Rows.Count) + " Horario";

            }


        }
        public void actualizarDataGridViewHorario_2()
        {
            String buscar = textBoxBuscarxApellidos.Text;
            NHorario oNHorario = new NHorario();
            List<Horario> oListHorario = oNHorario.obtenerDatosEnListaDeHorarioxEmpleado(buscar);
            for (int posicion = 0; posicion < oListHorario.Count; posicion = posicion + 1)
            {
                if (oListHorario[posicion].getCodigo() != 0)
                {
                    dataGridViewHorario.Rows.Add(
                       oListHorario[posicion].getCodigo(),
                        oListHorario[posicion].getIdEmpleado(),
                        oListHorario[posicion].getNombreEmpleado(),
                        oListHorario[posicion].getCargo(),
                        oListHorario[posicion].getTurno(),
                        oListHorario[posicion].getHoraEntrada(),
                        oListHorario[posicion].getHoraSalida());
                }
                 labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewHorario.Rows.Count) + " Horario";


            }


        }

        private void limpiarDataGridViewHorario()
        {
            dataGridViewHorario.Rows.Clear();

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

        private void habilitarCajasDeTexto(Boolean editable)
        {
            textBoxTurno.Enabled = editable;
            textBoxHEntrada.Enabled = editable;
            textBoxHSalida.Enabled = editable;
            comboBoxEmpleado.Enabled = editable;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tabControlHorario.SelectedIndex = 1;

            if (accion == DAccion.ACCION_INSERTAR)
            {
                if (textBoxTurno.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar el Turno del Empleado",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxTurno.Focus();
                }
                else if (textBoxHEntrada.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Hora de Entrada del Empleado",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxHEntrada.Focus();
                }
                else if (textBoxHSalida.Text.Equals(""))
                {
                    MessageBox.Show("Falta llenar la Hora de Salida del Empleado",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxHSalida.Focus();
                }
               
                else if (comboBoxEmpleado.Text.Equals(""))
                {
                    MessageBox.Show("Falta Seleccionar el Empleado...",
                        "INFORMACION.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxEmpleado.Focus();
                }

                else
                {
                    if (MessageBox.Show("¿Desea guardarlo?", "Confirme el guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NHorario oNHorario = new NHorario();
                        if (oNHorario.registrarHorario(getObjetoHorario()))
                        {
                            habilitarControles(true, false, false, false, true, false);
                            buttonNuevo.Focus();
                            actualizarDataGridViewHorario();
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
            }
            else if (accion == DAccion.ACCION_MODIFICAR)
            {
                if (MessageBox.Show("Esta Seguro de guardar los datos?",
                       "Confirmar el Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NHorario oNHorario = new NHorario();
                    Horario oHorario = new Horario();
                    if (oNHorario.editarHorario(int.Parse(textBoxCodigo.Text), getObjetoHorario_1()))
                    {
                        MessageBox.Show("Horario Modificado Exitosamente ... !!!",
                         "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarDataGridViewHorario();
                        limpiarCajasDeTexto();
                        tabControlHorario.SelectedIndex = 0;
                        habilitarControles(true, false, false, false, true, false);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el HORARIO ... !!!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewHorario_DoubleClick(object sender, EventArgs e)
        {
            //int filaSeleccionada = dataGridViewHorario.CurrentRow.Index;
            //if (filaSeleccionada != -1)
            //{

            //    Horario oHorarioSeleccionado = (Horario)dataGridViewHorario.Rows[filaSeleccionada].Cells[0].Value;
            //    setObjetoHorario(oHorarioSeleccionado);
            //    Horario oHorario = new Horario();

            //    buttonGuardar.Enabled = false;
            //    buttonModificar.Enabled = true;
            //    buttonEliminar.Enabled = true;
            //    textBoxCodigo.Enabled = false;
            //    habilitarCajasDeTexto(false);
            //    habilitarControles(false, false, true, true, true, true);

            //}
            this.label2.Visible = true;
            this.textBoxCodigo.Visible = true;
            this.textBoxCodigo.Text = Convert.ToString(this.dataGridViewHorario.CurrentRow.Cells[0].Value);
            this.comboBoxEmpleado.Text = Convert.ToString(this.dataGridViewHorario.CurrentRow.Cells[2].Value);
            this.textBoxTurno.Text = Convert.ToString(this.dataGridViewHorario.CurrentRow.Cells[3].Value);
            this.textBoxHEntrada.Text = Convert.ToString(this.dataGridViewHorario.CurrentRow.Cells[4].Value);
            this.textBoxHSalida.Text = Convert.ToString(this.dataGridViewHorario.CurrentRow.Cells[5].Value);


            this.tabControlHorario.SelectedIndex = 1;
            habilitarControles(false, false, true, true, true, true);

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridViewHorario.CurrentRow.Index;
            if (filaSeleccionada != -1 && (textBoxCodigo.Text.Length) > 0)
            {
                textBoxTurno.Focus();
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

        private void tabControlHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlHorario.SelectedIndex == 0)
            {
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                textBoxCodigo.Enabled = false;
                habilitarControles(true, false, false, false, true, true);
                buttonNuevo.Focus();

            }
            if (tabControlHorario.SelectedIndex == 1)
            {
                this.buttonNuevo.Enabled = true;
                this.buttonCancelar.Enabled = true;
                this.habilitarCajasDeTexto(false);
                this.textBoxCodigo.Enabled = false;
                this.buttonNuevo.Focus();
                this.dataGridViewHorario.Visible = true;
                this.labelTotal.Location = new Point(646, 296);
                this.labelTotal.Visible = true;
                this.actualizarDataGridViewHorario();
                this.radioButtonEmpleado.Checked = false;
                this.textBoxBuscarxApellidos.Enabled = false;
                this.buttonBuscarxApellidos.Visible = false;
                this.textBoxBuscarxApellidos.Clear();
                this.groupBoxDatos.Location = new Point(107, 50);
                this.groupBoxDatos.Size = new Size(590, 210);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            tabControlHorario.SelectedIndex = 1;
            limpiarCajasDeTexto();
            habilitarCajasDeTexto(true);
            textBoxTurno.Enabled = true;
            textBoxTurno.Focus();
            this.groupBoxDatos.Location = new Point(107, 50);
            this.groupBoxDatos.Size = new Size(590, 210);
            habilitarControles(true, true, false, false, true, false);
      
        }

        private void textBoxTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (tabControlHorario.SelectedIndex == 0)
            {
                textBoxBuscarxApellidos.Enabled = false;
                textBoxBuscarxApellidos.Clear();
                buttonBuscarxApellidos.Visible = false;
                radioButtonEmpleado.Checked = false;
                actualizarDataGridViewHorario();
                this.groupBoxDatos.Location = new Point(107, 50);
                this.groupBoxDatos.Size = new Size(590, 210);
                this.labelTotal.Location = new Point(646, 296);
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();



            }
            if (tabControlHorario.SelectedIndex == 1)
            {
                this.groupBoxDatos.Location = new Point(107, 50);
                this.groupBoxDatos.Size = new Size(590, 210);
                limpiarCajasDeTexto();
                habilitarCajasDeTexto(false);
                habilitarControles(true, false, false, false, false, false);
                buttonNuevo.Focus();
            }
            
        }

        private void textBoxHEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);

        }

        private void radioButtonEmpleado_Click(object sender, EventArgs e)
        {
            this.textBoxBuscarxApellidos.Enabled = true;
            this.buttonBuscarxApellidos.Enabled = true;
            this.textBoxBuscarxApellidos.Clear();
            this.textBoxBuscarxApellidos.Focus();
            this.buttonCancelar.Enabled = true;
            
            this.labelTotal.Location = new Point(646, 296);
            actualizarDataGridViewHorario();
        }

        private void textBoxHSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);

        }

        private void textBoxBuscarxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxApellidos.TextLength) > 0)
                {
                    tabControlHorario.SelectedIndex = 0;

                    NHorario oNHorarios = new NHorario();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonEmpleado.Checked == true)
                    {
                        Horario oHorarios = new Horario();
                        String buscarXApellido = textBoxBuscarxApellidos.Text;
                        oHorarios = oNHorarios.BuscarEmpleadoHorario(buscarXApellido);
                        if (oHorarios == null)
                        {
                            MessageBox.Show("El Empleado que esta Buscando no tiene ningun Horario REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscarxApellidos.Clear();
                            textBoxBuscarxApellidos.Focus();
                        }
                        else if (oHorarios != null)
                        {
                            limpiarDataGridViewHorario();
                            actualizarDataGridViewHorario_2();
                            labelTotal.Visible = true;
                            labelTotal.Location = new Point(544, 296);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewHorario.Rows.Count) + " Horarios encontrados";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese los Apellidos del Empleado a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscarxApellidos.Focus();
                    actualizarDataGridViewHorario();
                    labelTotal.Location = new Point(630, 303);
                }
                buttonCancelar.Enabled = true;
            }
            
        }

        private void buttonBuscarxApellidos_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxApellidos.TextLength) > 0)
            {
                tabControlHorario.SelectedIndex = 0;

                NHorario oNHorarios = new NHorario();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonEmpleado.Checked == true)
                {
                    Horario oHorarios = new Horario();
                    String buscarXApellido = textBoxBuscarxApellidos.Text;
                    oHorarios = oNHorarios.BuscarEmpleadoHorario(buscarXApellido);
                    if (oHorarios == null)
                    {
                        MessageBox.Show("El Empleado que esta Buscando no tiene ningun Horario REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscarxApellidos.Clear();
                        textBoxBuscarxApellidos.Focus();
                    }
                    else if (oHorarios != null)
                    {
                        limpiarDataGridViewHorario();
                        actualizarDataGridViewHorario_2();
                        labelTotal.Visible = true;
                        labelTotal.Location = new Point(544, 296);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewHorario.Rows.Count) + " Horarios encontrados";
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingrese los Apellidos del Empleado a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscarxApellidos.Focus();
                actualizarDataGridViewHorario();
                labelTotal.Location = new Point(630, 303);
            }
            buttonCancelar.Enabled = true;
        }

        private void textBoxBuscarxApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxApellidos.Clear();
            this.labelTotal.Location = new Point(646, 296);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewHorario.Rows.Count) + " Horarios";
      
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            frmReporteHorario fm = new frmReporteHorario();
            fm.ShowDialog();
        }
        
    }
}
