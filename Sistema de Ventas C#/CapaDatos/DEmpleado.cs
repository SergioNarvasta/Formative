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
  public  class DEmpleado
    {
      
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        
        public Empleado consultarRegistroNick(String busqueda)
        {
            try
            {
                Empleado oDEmpleado;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("consultarNick", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@nick", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDEmpleado = new Empleado();
                    oDEmpleado.usuario_id = (int)oSqlDataReader["usuario_id"];

                    oDEmpleado.apellidoPaterno = ((String)oSqlDataReader["apellidoPaterno"]);
                    oDEmpleado.apellidoMaterno = ((String)oSqlDataReader["apellidoMaterno"]);
                    oDEmpleado.nombres = ((String)oSqlDataReader["nombres"]);
                    oDEmpleado.email = ((String)oSqlDataReader["email"]);
                    oDEmpleado.tipoDeUsuario = ((int)oSqlDataReader["tipoDeUsuario"]);
                    oDEmpleado.nick = ((String)oSqlDataReader["nick"]);
                    oDEmpleado.password = ((String)oSqlDataReader["password"]);
                    oDEmpleado.habilitar = ((String)oSqlDataReader["habilitar"]);
                    oDEmpleado.foto = ((byte[])oSqlDataReader["foto"]);
                    oDEmpleado.direccion = ((String)oSqlDataReader["direccion"]);
                    oDEmpleado.celular = ((String)oSqlDataReader["celular"]);
                    oDEmpleado.sexo = ((String)oSqlDataReader["sexo"]);
                    oDEmpleado.sueldo = ((Decimal)oSqlDataReader["sueldo"]);
                    oDEmpleado.idSucursal=((String)oSqlDataReader["idSucursal"]);
                    oSqlDataReader.Close();
                    return oDEmpleado;

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

        public Empleado recuperarContraseña(String busqueda)
        {
            try
            {
                Empleado oDEmpleado;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("recuperarContraseña", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@email", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDEmpleado = new Empleado();
                    oDEmpleado.apellidoPaterno = ((String)oSqlDataReader["apellidoPaterno"]);
                    oDEmpleado.password = ((String)oSqlDataReader["password"]);
                    oDEmpleado.foto = ((byte[])oSqlDataReader["foto"]);
                    oDEmpleado.email = ((String)oSqlDataReader["email"]);
                    oSqlDataReader.Close();
                    return oDEmpleado;

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
       
        public List<Empleado> obtenerDatosEnLista()
        {
            List<Empleado> oListDEmpleado = new List<Empleado>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("listarEmpleado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Empleado oEmpleado;
                
                while (oSqlDataReader.Read())
                {
                    oEmpleado = new Empleado();
                    
                    oEmpleado.usuario_id        = (int)oSqlDataReader["usuario_id"];
                    oEmpleado.apellidoPaterno   = (String)oSqlDataReader["apellidoPaterno"];
                    oEmpleado.apellidoMaterno   = (String)oSqlDataReader["apellidoMaterno"];
                    oEmpleado.nombres           = (String)oSqlDataReader["nombres"];
                    oEmpleado.email             = (String)oSqlDataReader["email"];
                    oEmpleado.tipoDeUsuario     = (int)oSqlDataReader["tipoDeUsuario"];
                    oEmpleado.nick              = (String)oSqlDataReader["nick"];
                    oEmpleado.password          = (String)oSqlDataReader["password"];
                    oEmpleado.habilitar         = (String)oSqlDataReader["habilitar"];
                    oEmpleado.foto              = (byte[])oSqlDataReader["foto"];
                    oEmpleado.direccion         = (String)oSqlDataReader["direccion"];
                    oEmpleado.celular           = (String)oSqlDataReader["celular"];
                    oEmpleado.sexo              = (String)oSqlDataReader["sexo"];
                    oEmpleado.sueldo            = (Decimal)oSqlDataReader["sueldo"];
                    oEmpleado.idSucursal        = (String)oSqlDataReader["idSucursal"];
                    oListDEmpleado.Add(oEmpleado);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDEmpleado;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Empleado> obtenerDatosEnListaDeEmpleados(int buscar)
        {
            List<Empleado> oListDEmpleado = new List<Empleado>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarEmpleadoporDni", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@dni", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Empleado oEmpleado;
                

                while (oSqlDataReader.Read())
                {
                    oEmpleado = new Empleado();

                    oEmpleado.usuario_id = (int)oSqlDataReader["usuario_id"];
                    oEmpleado.apellidoPaterno = (String)oSqlDataReader["apellidoPaterno"];
                    oEmpleado.apellidoMaterno = (String)oSqlDataReader["apellidoMaterno"];
                    oEmpleado.nombres = (String)oSqlDataReader["nombres"];
                    oEmpleado.email = (String)oSqlDataReader["email"];
                    oEmpleado.tipoDeUsuario = (int)oSqlDataReader["tipoDeUsuario"];
                    oEmpleado.nick = (String)oSqlDataReader["nick"];
                    oEmpleado.password = (String)oSqlDataReader["password"];
                    oEmpleado.habilitar = (String)oSqlDataReader["habilitar"];
                    oEmpleado.foto = (byte[])oSqlDataReader["foto"];
                    oEmpleado.direccion = (String)oSqlDataReader["direccion"];
                    oEmpleado.celular = (String)oSqlDataReader["celular"];
                    oEmpleado.sexo = (String)oSqlDataReader["sexo"];
                    oEmpleado.sueldo = (Decimal)oSqlDataReader["sueldo"];
                    oEmpleado.idSucursal = (String)oSqlDataReader["idSucursal"];
                    oListDEmpleado.Add(oEmpleado);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDEmpleado;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public Boolean registrarEmpleado(Empleado oEmpleado)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("insertarEmpleados",oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@usuario_id", oEmpleado.usuario_id));
                oSqlCommand.Parameters.Add(new SqlParameter("@apellidoPaterno", oEmpleado.apellidoPaterno));
                oSqlCommand.Parameters.Add(new SqlParameter("@apellidoMaterno", oEmpleado.apellidoMaterno));
                oSqlCommand.Parameters.Add(new SqlParameter("@nombres", oEmpleado.nombres));
                oSqlCommand.Parameters.Add(new SqlParameter("@email", oEmpleado.email));
                oSqlCommand.Parameters.Add(new SqlParameter("@tipoDeUsuario", oEmpleado.tipoDeUsuario));
                oSqlCommand.Parameters.Add(new SqlParameter("@nick", oEmpleado.nick));
                oSqlCommand.Parameters.Add(new SqlParameter("@password", oEmpleado.password));
                oSqlCommand.Parameters.Add(new SqlParameter("@habilitar",oEmpleado.habilitar));
                oSqlCommand.Parameters.Add(new SqlParameter("@foto", oEmpleado.foto));
                oSqlCommand.Parameters.Add(new SqlParameter("@direccion", oEmpleado.direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@celular", oEmpleado.celular));
                oSqlCommand.Parameters.Add(new SqlParameter("@sexo", oEmpleado.sexo));
                oSqlCommand.Parameters.Add(new SqlParameter("@sueldo", oEmpleado.sueldo));
                oSqlCommand.Parameters.Add(new SqlParameter("@idSucursal",oEmpleado.idSucursal));
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

        public Boolean modificarContraseña(int busqueda, Empleado oEmpleado)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("cambiarContraseña", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@usuario_id", oEmpleado.usuario_id));
                oSqlCommand.Parameters.Add(new SqlParameter("@password", oEmpleado.password));
                oSqlCommand.ExecuteNonQuery();
                oSqlConnection.Close();

                return true;
            }
            catch (System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("ERROR...!!!" + ex.Message);
                return false;
            }
        }

        public Empleado consultarDni(int busqueda)
        {
            try
            {
                Empleado oDEmpleado;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("consultarDni", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@dni", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDEmpleado = new Empleado();
                    oDEmpleado.usuario_id = ((int)oSqlDataReader["usuario_id"]);
                    oDEmpleado.password = ((String)oSqlDataReader["password"]);
                    
                    oSqlDataReader.Close();
                    return oDEmpleado;

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

        public Empleado consultarUsuario(int busqueda)
        {
            try
            {
                Empleado oDEmpleado;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("consultarUsuario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@dni", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDEmpleado = new Empleado();
                    oDEmpleado.usuario_id = ((int)oSqlDataReader["usuario_id"]);
                    oDEmpleado.apellidoPaterno = ((String)oSqlDataReader["apellidoPaterno"]);
                    oDEmpleado.apellidoMaterno = ((String)oSqlDataReader["apellidoMaterno"]);
                    oDEmpleado.nombres = ((String)oSqlDataReader["nombres"]);
                    oDEmpleado.email = ((String)oSqlDataReader["email"]);
                    oDEmpleado.tipoDeUsuario = ((int)oSqlDataReader["tipoDeUsuario"]);
                    oDEmpleado.nick = ((String)oSqlDataReader["nick"]);
                    oDEmpleado.password = ((String)oSqlDataReader["password"]);
                    oDEmpleado.habilitar = ((String)oSqlDataReader["habilitar"]);
                    oDEmpleado.foto = ((byte[])oSqlDataReader["foto"]);
                    oDEmpleado.direccion = ((String)oSqlDataReader["direccion"]);
                    oDEmpleado.celular = ((String)oSqlDataReader["celular"]);
                    oDEmpleado.sexo = ((String)oSqlDataReader["sexo"]);
                    oDEmpleado.sueldo = ((Decimal)oSqlDataReader["sueldo"]);
                    oDEmpleado.idSucursal=((String)oSqlDataReader["idSucursal"]);
                    oSqlDataReader.Close();
                    return oDEmpleado;


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

        public Boolean modificarEmpleado(int busqueda, Empleado oEmpleado)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarEmpleado",oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@usuario_id",oEmpleado.usuario_id));
                oSqlCommand.Parameters.Add(new SqlParameter("@apellidoPaterno", oEmpleado.apellidoPaterno));
                oSqlCommand.Parameters.Add(new SqlParameter("@apellidoMaterno", oEmpleado.apellidoMaterno));
                oSqlCommand.Parameters.Add(new SqlParameter("@nombres", oEmpleado.nombres));
                oSqlCommand.Parameters.Add(new SqlParameter("@email", oEmpleado.email));
                oSqlCommand.Parameters.Add(new SqlParameter("@tipoDeUsuario", oEmpleado.tipoDeUsuario));
                oSqlCommand.Parameters.Add(new SqlParameter("@nick", oEmpleado.nick));
                oSqlCommand.Parameters.Add(new SqlParameter("@password", oEmpleado.password));
                oSqlCommand.Parameters.Add(new SqlParameter("@habilitar", oEmpleado.habilitar));
                oSqlCommand.Parameters.Add(new SqlParameter("@foto", oEmpleado.foto));
                oSqlCommand.Parameters.Add(new SqlParameter("@direccion", oEmpleado.direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@celular", oEmpleado.celular));
                oSqlCommand.Parameters.Add(new SqlParameter("@sexo", oEmpleado.sexo));
                oSqlCommand.Parameters.Add(new SqlParameter("@sueldo", oEmpleado.sueldo));
                oSqlCommand.Parameters.Add(new SqlParameter("@idSucursal",oEmpleado.idSucursal));

                oSqlCommand.ExecuteNonQuery();
                oSqlConnection.Close();
                return true;
            }
            catch(System.Exception ex)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error...!!!" + ex.Message);
                return false;
            }
        }

        public Boolean eliminarEmpleado(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarEmpleado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@usuario_id", busqueda));
              

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

        public Empleado BuscarEmpleadoxTipo(String buscar)
        {
            try
            {
                Empleado oEmpleado;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reportePorTipoDeEmpleado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@tipo", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oEmpleado = new Empleado();
                    oEmpleado.tipo = (String)oSqlDataReader["nombreDeTipoDeUsuario"];
                    oEmpleado.usuario_id = (int)oSqlDataReader["usuario_id"];
                    oEmpleado.apellidoPaterno = (String)oSqlDataReader["apellidoPaterno"];
                    oEmpleado.apellidoMaterno = (String)oSqlDataReader["apellidoMaterno"];
                    oEmpleado.nombres = (String)oSqlDataReader["nombres"];
                    oEmpleado.email = (String)oSqlDataReader["email"];
                    oEmpleado.direccion = (String)oSqlDataReader["direccion"];
                    oEmpleado.celular = (String)oSqlDataReader["celular"];
                    oEmpleado.foto = (Byte[])oSqlDataReader["foto"];
                    oEmpleado.nombreSucursal=(String)oSqlDataReader["nombre"];

                    return oEmpleado;
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

    }
}
