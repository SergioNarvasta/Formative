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
    public partial class frmVistaCategoria_Productos : Form
    {
        public frmVistaCategoria_Productos()
        {
            InitializeComponent();
            actualizarDataGridViewCategoria();
            textBoxBuscar.Focus();
            this.labelTotal.Location = new Point(636, 330);
        }
        public void actualizarDataGridViewCategoria()
        {
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnList();
            for (int posicion = 0; posicion < oListCategorias.Count; posicion = posicion + 1)
            {
                if (oListCategorias[posicion].getIdCategoria() != 0)
                {
                    dataGridViewCategoria.Rows.Add(
                        oListCategorias[posicion].getIdCategoria(),
                       
                        oListCategorias[posicion].getNombre(),
                        
                        oListCategorias[posicion]);
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCategoria.Rows.Count) + " Categorias";

            }


        }
        public void actualizarDataGridViewMantenimientoDeCategorias_1()
        {
            String buscar = textBoxBuscar.Text;
            limpiarDataGridViewCategorias();
            NCategorias oNCategorias = new NCategorias();
            List<Categorias> oListCategorias = oNCategorias.obtenerDatosEnListaDeCategorias(buscar);
            for (int posicion = 0; posicion < oListCategorias.Count; posicion = posicion + 1)
            {
                if (oListCategorias[posicion].idCategoria != 0)
                {
                    dataGridViewCategoria.Rows.Add(
                        oListCategorias[posicion].idCategoria,
                        oListCategorias[posicion]

                        );
                }
                labelTotal.Text = "Total de Registro : " + Convert.ToString(dataGridViewCategoria.Rows.Count) + " Categorias";

            }

        }
        private void limpiarDataGridViewCategorias()
        {
            dataGridViewCategoria.Rows.Clear();

        }

        private void dataGridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            
            frmMantenimientoDeProducto fm = Owner as frmMantenimientoDeProducto;
            fm.textBoxIdCategoria.Text = dataGridViewCategoria.CurrentRow.Cells[0].Value.ToString();
            fm.textBoxNombreCate.Text = dataGridViewCategoria.CurrentRow.Cells[1].Value.ToString();
            this.Hide();
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
                    Categorias oCategorias = new Categorias();
                    String buscar = (textBoxBuscar.Text);
                    oCategorias = oNCategorias.BuscarCategoriasxNombre(buscar);
                    if (oCategorias == null)
                    {
                        MessageBox.Show("El Nombre de la CATEGORIA que esta Buscando no esta REGISTRADO... !!!",
                                               "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBuscar.Clear();
                        textBoxBuscar.Focus();
                    }
                    else if (oCategorias != null)
                    {
                        limpiarDataGridViewCategorias();
                        actualizarDataGridViewMantenimientoDeCategorias_1();
                        labelTotal.Visible = true;
                        this.labelTotal.Location = new Point(535, 330);
                        labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCategoria.Rows.Count) + " Categorias encontrados";
                    }
                }
                else 
                {
                    MessageBox.Show("Ingrese el Nombre de la CTEGORIA a Buscar... !!!",
                        "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscar.Focus();
                    limpiarDataGridViewCategorias();
                    actualizarDataGridViewCategoria();
                    this.labelTotal.Location = new Point(636, 330);
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if ((textBoxBuscar.TextLength) > 0)
            {
                NCategorias oNCategorias = new NCategorias();
                SqlConnection oSqlConnection = new SqlConnection();
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                Categorias oCategorias = new Categorias();
                String buscar = (textBoxBuscar.Text);
                oCategorias = oNCategorias.BuscarCategoriasxNombre(buscar);
                if (oCategorias == null)
                {
                    MessageBox.Show("El Nombre de la CATEGORIA que esta Buscando no esta REGISTRADO... !!!",
                                           "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBuscar.Clear();
                    textBoxBuscar.Focus();
                }
                else if (oCategorias != null)
                {
                    limpiarDataGridViewCategorias();
                    actualizarDataGridViewMantenimientoDeCategorias_1();
                    labelTotal.Visible = true;
                    this.labelTotal.Location = new Point(535, 330);
                    labelTotal.Text = "Resultado de la Busqueda : " + Convert.ToString(dataGridViewCategoria.Rows.Count) + " Categorias encontrados";
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre de la CATEGORIA a Buscar... !!!",
                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscar.Focus();
                limpiarDataGridViewCategorias();
                actualizarDataGridViewCategoria();
                this.labelTotal.Location = new Point(636, 330);
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
