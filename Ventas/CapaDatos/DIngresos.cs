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
   public class DIngresos
    {
       ConexionBD cm = new ConexionBD();
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;

        public String GenerarIdIngresos()
        {
            List<Parametro> lst = new List<Parametro>();
            int objIdIngreso;
            try
            {
                lst.Add(new Parametro("@idingreso", "", SqlDbType.Int, ParameterDirection.Output, 4));
                cm.EjecutarSP("generarIdIngresos", ref lst);
                objIdIngreso = Convert.ToInt32(lst[0].Valor.ToString());


            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
            return Convert.ToString(objIdIngreso);
        }
        public String GenerarSerieDocumento()
        {
            List<Parametro> lst = new List<Parametro>();
            String Serie = "";
            try
            {
                lst.Add(new Parametro("@Serie", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                cm.EjecutarSP("SerieDocumento", ref lst);
                Serie = Convert.ToString(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(Serie);
        }
        public String NumeroIngresos(String objTipoDocumento)
        {
            List<Parametro> lst = new List<Parametro>();
            String NroCorrelativo = "";
            try
            {
                lst.Add(new Parametro("@TipoDocumento", objTipoDocumento));
                lst.Add(new Parametro("@NroCorrelativo", "", SqlDbType.VarChar, ParameterDirection.Output, 7));
                cm.EjecutarSP("NumeroCorrelativoIngresos", ref lst);
                NroCorrelativo = Convert.ToString(lst[1].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(NroCorrelativo);
        }

        public Boolean registrarIngresos(Ingresos oIngresos)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@empleado", oIngresos.dniempleado));
                oSqlCommand.Parameters.Add(new SqlParameter("@proveedor", oIngresos.idproveedor));
                oSqlCommand.Parameters.Add(new SqlParameter("@fecha", oIngresos.fechaingreso));
                oSqlCommand.Parameters.Add(new SqlParameter("@serie", oIngresos.serie));
                oSqlCommand.Parameters.Add(new SqlParameter("@numero", oIngresos.numerodocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@tipo", oIngresos.tipodocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@estado",oIngresos.estado));
               oSqlCommand.Parameters.Add(new SqlParameter("@total", oIngresos.total));

                
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
        public List<Ingresos> obtenerDatosEnLista()
        {
            List<Ingresos> oListDIngresos = new List<Ingresos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Ingresos oIngresos;

                while (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["idIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["fechaIngreso"];

                    oIngresos.dniempleado = (int)oSqlDataReader["DniEmpleado"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.idproveedor = (int)oSqlDataReader["idProveedor"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];
                    oIngresos.estado = (String)oSqlDataReader["estado"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];


                    
                    oListDIngresos.Add(oIngresos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDIngresos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public Boolean modificarEstadoIngreso(int busqueda, Ingresos oIngreso)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("anularIngresoDeCompras", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idingreso", oIngreso.idingreso));
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

        public Ingresos consultarIdIngreso(int busqueda)
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("consultarIdIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idingreso", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.estado = ((String)oSqlDataReader["estado"]);
                    
                    oSqlDataReader.Close();
                    return oIngresos;

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

        public void Modificar_Multiple(string idingreso, Label lbl)
        {
            oSqlConnection = ConexionBD.getConexion();
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand("anularIngresoDeCompras", oSqlConnection);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add(new SqlParameter("@idingreso", idingreso));
            oSqlCommand.ExecuteNonQuery();
            lbl.Text = "Estado Modificado con Exito";
            oSqlConnection.Close();

        }


        public Ingresos consultarIngresosxEmpleados(String busqueda)
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprasxEmplado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@empleado", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["IdIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["FechaIngreso"];

                    oIngresos.empelado = (String)oSqlDataReader["Empleado"];

                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];

                    oIngresos.direccion = (String)oSqlDataReader["direccion"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];

                    oSqlDataReader.Close();
                    return oIngresos;


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

        public Ingresos consultarIngresosxProveeedotr(String busqueda)
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprasxProveedor", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@proveedor", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["IdIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["FechaIngreso"];

                    oIngresos.empelado = (String)oSqlDataReader["Empleado"];

                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];

                    oIngresos.direccion = (String)oSqlDataReader["direccion"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];

                    oSqlDataReader.Close();
                    return oIngresos;


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

        public Ingresos consultarIngresosxEstado(String busqueda)
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprasxEstado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@estado", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["IdIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["FechaIngreso"];

                    oIngresos.empelado = (String)oSqlDataReader["Empleado"];

                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];

                    oIngresos.direccion = (String)oSqlDataReader["direccion"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];

                    oSqlDataReader.Close();
                    return oIngresos;


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

        public Ingresos consultarIngresosxDocumento(String busqueda)
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprasxDocumento", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@documento", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["IdIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["FechaIngreso"];

                    oIngresos.empelado = (String)oSqlDataReader["Empleado"];

                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];

                    oIngresos.direccion = (String)oSqlDataReader["direccion"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];

                    oSqlDataReader.Close();
                    return oIngresos;


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

        public Ingresos consultarIngresos()
        {
            try
            {
                Ingresos oIngresos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteMostrarCompras", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oIngresos = new Ingresos();
                    oIngresos.idingreso = (int)oSqlDataReader["IdIngreso"];
                    oIngresos.fechaingreso = (DateTime)oSqlDataReader["FechaIngreso"];

                    oIngresos.empelado = (String)oSqlDataReader["Empleado"];

                    oIngresos.tipodocumento = (String)oSqlDataReader["tipoDocumento"];
                    oIngresos.serie = (String)oSqlDataReader["serie"];
                    oIngresos.numerodocumento = (String)oSqlDataReader["nroDocumento"];
                    oIngresos.proveedor = (String)oSqlDataReader["Proveedor"];

                    oIngresos.direccion = (String)oSqlDataReader["direccion"];
                    oIngresos.total = (Decimal)oSqlDataReader["total"];

                    oSqlDataReader.Close();
                    return oIngresos;


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

        public List<Ingresos> obtenerDatosEnListaXTurno()
        {
            List<Ingresos> oListDIngresoss = new List<Ingresos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("listarIngresoXEstado", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Ingresos oIngresoss;

                while (oSqlDataReader.Read())
                {
                    oIngresoss = new Ingresos();
                    oIngresoss.estado = (String)oSqlDataReader["estado"];
                    oListDIngresoss.Add(oIngresoss);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDIngresoss;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
      
    }
}
