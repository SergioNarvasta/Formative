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
    public partial class frmVistaProductos_Ingresos : Form
    {
        public static int cambioDeEstado = 0;
        private int accion = DAccion.NO_ACCION;
       
        public frmVistaProductos_Ingresos()
        {
            InitializeComponent();
            this.textBoxBuscarxNombre.Enabled = false;
            this.textBoxBuscarxMarca.Enabled = false;
            this.buttonBuscarxNombre.Visible = false;
            this.buttonBuscarxMarca.Visible = false;
            this.actualizarDataGridViewMantenimientoDeProductos();
           
        }
        public void actualizarDataGridViewMantenimientoDeProductos()
        {
            limpiarDataGridViewMantenimientoDeProductos();
            NProducto oNProductos = new NProducto();
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListProductosIngresos();
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
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].precioCompra,
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
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosxNombreIngresos(buscar);
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
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].precioCompra,
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
            List<Productos> oListProductos = oNProductos.obtenerDatosEnListaDeProductosxMarcaIngresos(buscar);
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
                        oListProductos[posicion].categoria,
                        oListProductos[posicion].precioCompra,
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

        private void dataGridViewMantenimientoDeProducto_DoubleClick(object sender, EventArgs e)
        {
            frmMantenimientoDeIngresos fm = Owner as frmMantenimientoDeIngresos;
            fm.txtIdProducto.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[0].Value);
            fm.txtProducto.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[4].Value);
            fm.txtPrecioCompra.Text = Convert.ToString(this.dataGridViewMantenimientoDeProducto.CurrentRow.Cells[7].Value);

            this.Hide();
        }

        private void frmVistaProductos_Ingresos_Load(object sender, EventArgs e)
        {
           labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";
       
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
            this.buttonBuscarxMarca.Visible = true;
            limpiarDataGridViewMantenimientoDeProductos();
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(405, 193);
            
        }

        private void textBoxBuscarxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxNombre.TextLength) > 0)
                {
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
                            labelTotal.Location = new Point(405, 193);
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
                    labelTotal.Location = new Point(405, 193);
                }
                
            }

        }

        private void buttonBuscarxNombre_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxNombre.TextLength) > 0)
            {
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
                        labelTotal.Location = new Point(405, 193);
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
                labelTotal.Location = new Point(405, 193);
            }
        }

        private void textBoxBuscarxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxNombre.Clear();
            this.labelTotal.Location = new Point(405, 193);
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
            this.buttonBuscarxMarca.Visible = true;
            limpiarDataGridViewMantenimientoDeProductos();
            actualizarDataGridViewMantenimientoDeProductos();
            labelTotal.Location = new Point(405, 193);
           
        }

        private void textBoxBuscarxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCaracteres.ValidadorDeNumerosLetras(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if ((textBoxBuscarxMarca.TextLength) > 0)
                {
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
                            labelTotal.Location = new Point(405, 193);
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
                    labelTotal.Location = new Point(405, 193);
                }
               
            }
        }

        private void buttonBuscarxMarca_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscarxMarca.TextLength) > 0)
            {
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
                        labelTotal.Location = new Point(405, 193);
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
                labelTotal.Location = new Point(405, 193);
            }
        }

        private void textBoxBuscarxMarca_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxBuscarxMarca.Clear();
            this.labelTotal.Location = new Point(405, 193);
            labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewMantenimientoDeProducto.Rows.Count) + " Productos";

        }

    }
}
