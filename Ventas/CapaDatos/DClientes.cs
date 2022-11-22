using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
   public class DClientes
    {
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;

        public Boolean registrarClientes(Clientes oClientes)
        {
            try
            {
                
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarCliente", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                //oSqlCommand.Parameters.Add(new SqlParameter("@idclientes", oClientes.idCliente));
                oSqlCommand.Parameters.Add(new SqlParameter("@Dni",oClientes.Dni));
                oSqlCommand.Parameters.Add(new SqlParameter("@Apellidos", oClientes.Apellidos));
                oSqlCommand.Parameters.Add(new SqlParameter("@Nombres", oClientes.Nombres));
                oSqlCommand.Parameters.Add(new SqlParameter("@Direccion", oClientes.Direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@Celular", oClientes.Celular));
                oSqlCommand.Parameters.Add(new SqlParameter("@idsucursal", oClientes.idSucursal));
                oSqlCommand.ExecuteNonQuery();
                oSqlConnection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error...!!!" + ex.Message);
                return false;
            }
        }

        public List<Clientes> obtenerDatosEnLista()
        {
            List<Clientes> oListDClientes = new List<Clientes>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarClientes", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Clientes oClientes;

                while (oSqlDataReader.Read())
                {
                    oClientes = new Clientes();
                    oClientes.Dni = (int)oSqlDataReader["Dni"];
                    oClientes.Apellidos = (String)oSqlDataReader["Apellidos"];
                    oClientes.Nombres = (String)oSqlDataReader["Nombres"];
                    oClientes.Direccion = (String)oSqlDataReader["Direccion"];
                    oClientes.Celular = (String)oSqlDataReader["Celular"];
                    oClientes.idSucursal = (String)oSqlDataReader["idSucursal"];
                    oListDClientes.Add(oClientes);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDClientes;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Clientes> consultarClientePorDni(int busqueda)
        {
            List<Clientes> oListDClientes = new List<Clientes>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosClientePorDni", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Clientes oClientes;

                while (oSqlDataReader.Read())
                {
                    oClientes = new Clientes();
                    oClientes.Dni = (int)oSqlDataReader["Dni"];
                    oClientes.Apellidos = (String)oSqlDataReader["Apellidos"];
                    oClientes.Nombres = (String)oSqlDataReader["Nombres"];
                    oClientes.Direccion = (String)oSqlDataReader["Direccion"];
                    oClientes.Celular = (String)oSqlDataReader["Celular"];
                    oClientes.idSucursal = (String)oSqlDataReader["idSucursal"];
                    oListDClientes.Add(oClientes);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDClientes;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Clientes> consultarClientePorApellidos(String busqueda)
        {
            List<Clientes> oListDClientes = new List<Clientes>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosClientePorApellidosONombres", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Clientes oClientes;

                while (oSqlDataReader.Read())
                {
                    oClientes = new Clientes();
                    oClientes.Dni = (int)oSqlDataReader["Dni"];
                    oClientes.Apellidos = (String)oSqlDataReader["Apellidos"];
                    oClientes.Nombres = (String)oSqlDataReader["Nombres"];
                    oClientes.Direccion = (String)oSqlDataReader["Direccion"];
                    oClientes.Celular = (String)oSqlDataReader["Celular"];
                    oClientes.idSucursal = (String)oSqlDataReader["idSucursal"];
                    oListDClientes.Add(oClientes);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDClientes;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }


        public Boolean modificarClientes(int busqueda, Clientes oClientes)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarCliente", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                //oSqlCommand.Parameters.Add(new SqlParameter("@idcliente", oClientes.idCliente));
                oSqlCommand.Parameters.Add(new SqlParameter("@Dni", oClientes.Dni));
                oSqlCommand.Parameters.Add(new SqlParameter("@Apellidos", oClientes.Apellidos));
                oSqlCommand.Parameters.Add(new SqlParameter("@Nombres", oClientes.Nombres));
                oSqlCommand.Parameters.Add(new SqlParameter("@Direccion", oClientes.Direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@Celular", oClientes.Celular));
                oSqlCommand.Parameters.Add(new SqlParameter("@idSucursal", oClientes.idSucursal));

                oSqlCommand.ExecuteNonQuery();
                oSqlConnection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error...!!!" + ex.Message);
                return false;
            }
        }

        public Boolean eliminarClientes(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarClientes", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@dni", busqueda));


                oSqlCommand.ExecuteNonQuery();
                oSqlConnection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error...!!!" + ex.Message);
                return false;
            }
        }

        public Clientes consultarClientexDni(int busqueda)
        {
            try
            {
                Clientes oDClientes;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosClientePorDni", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDClientes = new Clientes();
                    //oDClientes.idCliente = ((int)oSqlDataReader["IdCliente"]);
                    oDClientes.Dni = ((int)oSqlDataReader["Dni"]);
                    oDClientes.Apellidos = ((String)oSqlDataReader["Apellidos"]);
                    oDClientes.Nombres = ((String)oSqlDataReader["Nombres"]);
                    oDClientes.Direccion = ((String)oSqlDataReader["Direccion"]);
                    oDClientes.Celular = ((String)oSqlDataReader["Celular"]);
                    oDClientes.idSucursal = ((String)oSqlDataReader["idSucursal"]);
                    oSqlDataReader.Close();
                    return oDClientes;


                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error....!!!" + ex.Message);
                return null;
            }
        }

        public Clientes consultarClientexApellidos(String busqueda)
        {
            try
            {
                Clientes oDClientes;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosClientePorApellidosONombres", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDClientes = new Clientes();
                    //oDClientes.idCliente = ((int)oSqlDataReader["IdCliente"]);
                    oDClientes.Dni = ((int)oSqlDataReader["Dni"]);
                    oDClientes.Apellidos = ((String)oSqlDataReader["Apellidos"]);
                    oDClientes.Nombres = ((String)oSqlDataReader["Nombres"]);
                    oDClientes.Direccion = ((String)oSqlDataReader["Direccion"]);
                    oDClientes.Celular = ((String)oSqlDataReader["Celular"]);
                    oDClientes.idSucursal = ((String)oSqlDataReader["idSucursal"]);
                    oSqlDataReader.Close();
                    return oDClientes;


                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error....!!!" + ex.Message);
                return null;
            }
        }

        public void eliminar_Multiple(string idClientes, Label lbl)
        {
            oSqlConnection = ConexionBD.getConexion();
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand("eliminarClientes", oSqlConnection);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add(new SqlParameter("@dni", idClientes));
            oSqlCommand.ExecuteNonQuery();
            lbl.Text = "Registros Eliminados con Exito";
            oSqlConnection.Close();

        }

       
    }
}
