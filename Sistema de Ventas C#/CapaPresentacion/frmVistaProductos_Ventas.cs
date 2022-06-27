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
    public partial class frmVistaProductos_Ventas : Form
    {
        public frmVistaProductos_Ventas()
        {
            InitializeComponent();
            radioButtonNombre.Checked = false;
            radioButtonMarca.Checked = false;
            textBoxBuscar.Enabled = false;
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(642, 331);
           
        }
        public void actualizarDataGridViewMantenimientoDeProductos()
        {
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaProductosComprobantes();
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idDetalle!= 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idDetalle,
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta
                  
                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }

        public void actualizarDataGridViewMantenimientoDeProductos_1()
        {
            String buscar = textBoxBuscar.Text;
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosComprobantesPorNombre(buscar);
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idDetalle != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idDetalle,
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }
        public void actualizarDataGridViewMantenimientoDeProductos_2()
        {
            String buscar = textBoxBuscar.Text;
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosComprobantesPorMarca(buscar);
            for (int posicion = 0; posicion < oListProductos.Count; posicion = posicion + 1)
            {
                if (oListProductos[posicion].idDetalle != 0)
                {
                    dataGridViewMantenimientoDeProducto.Rows.Add(
                        oListProductos[posicion].idDetalle,
                        oListProductos[posicion].idProducto,
                        oListProductos[posicion].nombre,
                        oListProductos[posicion].marca,
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].presentacion,
                        oListProductos[posicion].stock,
                        oListProductos[posicion].precioCompra,
                        oListProductos[posicion].precioVenta);
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

            }

        }
        private void limpiarDataGridViewMantenimientoDeProductos()
        {
            dataGridViewMantenimientoDeProducto.Rows.Clear();

        }

        
        private void dataGridViewProducto_DoubleClick_1(object sender, EventArgs e)
        {


            frmMantenimientoDeComprobantes fm = Owner as frmMantenimientoDeComprobantes;
            fm.txtIdProducto.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[1].Value);
            fm.txtNombre.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[2].Value);
            fm.txtMarca.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[3].Value);
            fm.txtStock.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[6].Value);
            fm.txtPVenta.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[8].Value);
            

            this.Hide();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscar.TextLength) > 0)
            {

                NProducto oNProductos = new NProducto();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();

                if (radioButtonNombre.Checked == true)
                {
                    Productos oProductos = new Productos();
                    String buscar = (textBoxBuscar.Text);
                    oProductos = oNProductos.BuscarProductoxNombre(buscar);
                    if (oProductos == null)
                    {
                        MessageBox.Show("El Nombre del Producto que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscar.Clear();
                        textBoxBuscar.Focus();
                    }
                    else if (oProductos != null)
                    {
                        
                        limpiarDataGridViewMantenimientoDeProductos();
                        actualizarDataGridViewMantenimientoDeProductos_1();
                        labelTotal.Visible = true;
                        this.labelTotal.Location = new Point(538, 331);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                    }
                }
                if (radioButtonMarca.Checked == true)
                {
                    Productos oProductos = new Productos();
                    String buscar = textBoxBuscar.Text;
                    oProductos = oNProductos.BuscarProductoxMarca(buscar);
                    if (oProductos == null)
                    {
                        MessageBox.Show("La Marca del Producto que esta Buscando no es REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscar.Clear();
                        textBoxBuscar.Focus();
                    }
                    else if (oProductos != null)
                    {
                        limpiarDataGridViewMantenimientoDeProductos();
                        actualizarDataGridViewMantenimientoDeProductos_2();
                        labelTotal.Visible = true;
                        this.labelTotal.Location = new Point(538, 331);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre o la Marca del PRODUCTO a Buscar... !!!",
                   "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscar.Focus();
                actualizarDataGridViewMantenimientoDeProductos();
                this.labelTotal.Location = new Point(642, 331);
            }
        }

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscar.TextLength) > 0)
                {

                    NProducto oNProductos = new NProducto();
                    SqlConnection oSqlConnection = new SqlConnection();
                    oSqlConnection = ConexionBD.getConexion();
                    oSqlConnection.Open();

                    if (radioButtonNombre.Checked == true)
                    {
                        Productos oProductos = new Productos();
                        String buscar = (textBoxBuscar.Text);
                        oProductos = oNProductos.BuscarProductoxNombre(buscar);
                        if (oProductos == null)
                        {
                            MessageBox.Show("El Nombre del Producto que esta Buscando no esta REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscar.Clear();
                            textBoxBuscar.Focus();
                        }
                        else if (oProductos != null)
                        {
                            limpiarDataGridViewMantenimientoDeProductos();
                            actualizarDataGridViewMantenimientoDeProductos_1();
                            labelTotal.Visible = true;
                            this.labelTotal.Location = new Point(538, 331);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                        }
                    }
                    if (radioButtonMarca.Checked == true)
                    {
                        Productos oProductos = new Productos();
                        String buscar = textBoxBuscar.Text;
                        oProductos = oNProductos.BuscarProductoxMarca(buscar);
                        if (oProductos == null)
                        {
                            MessageBox.Show("La Marca del Producto que esta Buscando no es REGISTRADO... !!!",
                                                   "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxBuscar.Clear();
                            textBoxBuscar.Focus();
                        }
                        else if (oProductos != null)
                        {
                            limpiarDataGridViewMantenimientoDeProductos();
                            actualizarDataGridViewMantenimientoDeProductos_2();
                            labelTotal.Visible = true;
                            this.labelTotal.Location = new Point(538, 331);
                            labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos encontrados";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o la Marca del PRODUCTO a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscar.Focus();
                    actualizarDataGridViewMantenimientoDeProductos();
                    this.labelTotal.Location = new Point(642, 331);
                }
                
            }
        }

        private void radioButtonNombre_Click(object sender, EventArgs e)
        {
            
            textBoxBuscar.Enabled = true;
            textBoxBuscar.Focus();
            
            labelTotal.Visible = true;
            textBoxBuscar.Clear();
            limpiarDataGridViewMantenimientoDeProductos();
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(642, 331);
           
        }

        private void radioButtonMarca_Click(object sender, EventArgs e)
        {
            this.textBoxBuscar.Enabled = true;
            this.textBoxBuscar.Focus();
            this.labelTotal.Location = new Point(642, 331);
            this.textBoxBuscar.Clear();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dataGridViewMantenimientoDeProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (Convert.ToInt32(e.Value) >= 11)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
