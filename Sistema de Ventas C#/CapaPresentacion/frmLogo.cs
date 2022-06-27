using CapaDatos;
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
    public partial class frmLogo : Form
    {
        ConexionBD cm = new ConexionBD();
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        public frmLogo()
        {
            InitializeComponent();
           

        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(240, 40);
            //conteoRegistros();
            
        }
        //private void conteoRegistros()
        //{
        //    SqlCommand oSqlCommand = new SqlCommand("totalDatosRegistrados", oSqlConnection);
        //    oSqlCommand.CommandType = CommandType.StoredProcedure;
        //    SqlParameter total = new SqlParameter("@totalVentas", 0); total.Direction = ParameterDirection.Output;
        //    SqlParameter productos = new SqlParameter("@totalProductos", 0); productos.Direction = ParameterDirection.Output;
        //    SqlParameter categorias = new SqlParameter("@totalCategorias", 0); categorias.Direction = ParameterDirection.Output;
        //    SqlParameter presentacion = new SqlParameter("@totalPresentacion", 0); presentacion.Direction = ParameterDirection.Output;
        //    SqlParameter clientes = new SqlParameter("@totalClientes", 0); clientes.Direction = ParameterDirection.Output;
        //    SqlParameter empleados = new SqlParameter("@totalEmpleados", 0); empleados.Direction = ParameterDirection.Output;
        //    oSqlCommand.Parameters.Add(total);
        //    oSqlCommand.Parameters.Add(productos);
        //    oSqlCommand.Parameters.Add(categorias);
        //    oSqlCommand.Parameters.Add(presentacion);
        //    oSqlCommand.Parameters.Add(clientes);
        //    oSqlCommand.Parameters.Add(empleados);
        //    oSqlConnection.Open();
        //    oSqlCommand.ExecuteNonQuery();
        //    lblTotalVentas.Text = oSqlCommand.Parameters["@totalVentas"].Value.ToString();
        //    oSqlConnection.Close();
        //}
    }
}
