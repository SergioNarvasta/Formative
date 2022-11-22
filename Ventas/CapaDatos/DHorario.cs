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
    public class DHorario
    {
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;

        public Boolean registrarHorarios(Horario oHorarios)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarHorario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                //oSqlCommand.Parameters.Add(new SqlParameter("@idclientes", oHorarios.idHorario));
                //oSqlCommand.Parameters.Add(new SqlParameter("@idHorario", oHorarios.Codigo));
                oSqlCommand.Parameters.Add(new SqlParameter("@idEmpleado", oHorarios.idEmpleado));
                oSqlCommand.Parameters.Add(new SqlParameter("@turno", oHorarios.Turno));
                oSqlCommand.Parameters.Add(new SqlParameter("@horaEntrada", oHorarios.horaEntrada));
                oSqlCommand.Parameters.Add(new SqlParameter("@horaSalida", oHorarios.horaSalida));
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

        public List<Horario> obtenerDatosEnLista()
        {
            List<Horario> oListDHorarios = new List<Horario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("listarHorario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Horario oHorarios;

                while (oSqlDataReader.Read())
                {
                    oHorarios = new Horario();
                    oHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oHorarios.nombreEmpleado=(String)oSqlDataReader["Empleado"];
                    oHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oHorarios.Turno = (String)oSqlDataReader["turno"];
                    oHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];
                    oListDHorarios.Add(oHorarios);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDHorarios;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Horario> obtenerDatosEnListaXTurno()
        {
            List<Horario> oListDHorarios = new List<Horario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("listarHorarioXturno", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Horario oHorarios;

                while (oSqlDataReader.Read())
                {
                    oHorarios = new Horario();
                    oHorarios.Turno = (String)oSqlDataReader["turno"];
                    oListDHorarios.Add(oHorarios);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDHorarios;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }



        public List<Horario> consultarHorarioPorEmpleado(String busqueda)
        {
            List<Horario> oListDHorarios = new List<Horario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorEmpleado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Horario oHorarios;

                while (oSqlDataReader.Read())
                {
                    oHorarios = new Horario();
                    oHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oHorarios.Turno = (String)oSqlDataReader["turno"];
                    oHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];
                    oListDHorarios.Add(oHorarios);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDHorarios;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Horario> consultarHorarioPorTurno(String busqueda)
        {
            List<Horario> oListDHorarios = new List<Horario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorTurno", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Horario oHorarios;

                while (oSqlDataReader.Read())
                {
                    oHorarios = new Horario();
                    oHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oHorarios.Turno = (String)oSqlDataReader["turno"];
                    oHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];
                    oListDHorarios.Add(oHorarios);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDHorarios;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Horario> consultarHorarioPorCargo(String busqueda)
        {
            List<Horario> oListDHorarios = new List<Horario>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorCargo", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Horario oHorarios;

                while (oSqlDataReader.Read())
                {
                    oHorarios = new Horario();
                    oHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oHorarios.Turno = (String)oSqlDataReader["turno"];
                    oHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];
                    oListDHorarios.Add(oHorarios);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDHorarios;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }



        public Boolean modificarHorarios(int busqueda, Horario oHorarios)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarHorario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idHorario", oHorarios.Codigo));
                oSqlCommand.Parameters.Add(new SqlParameter("@idEmpleado", oHorarios.idEmpleado));
                oSqlCommand.Parameters.Add(new SqlParameter("@Turno", oHorarios.Turno));
                oSqlCommand.Parameters.Add(new SqlParameter("@horaEntrada", oHorarios.horaEntrada));
                oSqlCommand.Parameters.Add(new SqlParameter("@horaSalida", oHorarios.horaSalida));
                
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

        public Boolean eliminarHorarios(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarHorario", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Codigo", busqueda));


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

       

        public Horario consultarHorarioxEmpleado(String busqueda)
        {
            try
            {
                Horario oDHorarios;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorEmpleado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDHorarios = new Horario();
                    
                    oDHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oDHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oDHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oDHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oDHorarios.Turno = (String)oSqlDataReader["turno"];
                    oDHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oDHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];

                    oSqlDataReader.Close();
                    return oDHorarios;


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

        public Horario consultarHorarioxCargo(String busqueda)
        {
            try
            {
                Horario oDHorarios;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorCargo", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDHorarios = new Horario();

                    oDHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oDHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oDHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oDHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oDHorarios.Turno = (String)oSqlDataReader["turno"];
                    oDHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oDHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];

                    oSqlDataReader.Close();
                    return oDHorarios;


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

        public Horario consultarHorarioxTurno(String busqueda)
        {
            try
            {
                Horario oDHorarios;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosHorarioPorTurno", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDHorarios = new Horario();

                    oDHorarios.Codigo = (int)oSqlDataReader["idHorario"];
                    oDHorarios.idEmpleado = (int)oSqlDataReader["idEmpleado"];
                    oDHorarios.nombreEmpleado = (String)oSqlDataReader["Empleado"];
                    oDHorarios.cargo = (String)oSqlDataReader["cargo"];
                    oDHorarios.Turno = (String)oSqlDataReader["turno"];
                    oDHorarios.horaEntrada = (String)oSqlDataReader["horaEntrada"];
                    oDHorarios.horaSalida = (String)oSqlDataReader["horaSalida"];

                    oSqlDataReader.Close();
                    return oDHorarios;


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
