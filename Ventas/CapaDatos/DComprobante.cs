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
  public  class DComprobante
  {
      ConexionBD cm = new ConexionBD();
      SqlConnection oSqlConnection = new SqlConnection();
      SqlDataReader oSqlDataReader;
      public String GenerarIdVenta()
      {
          List<Parametro> lst = new List<Parametro>();
          int objIdVenta;
          try
          {
              lst.Add(new Parametro("@idComprobante", "", SqlDbType.Int, ParameterDirection.Output, 4));
              cm.EjecutarSP("generarIdComprobate", ref lst);
              objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());         
          }
          catch (System.Exception e)
          {
              oSqlConnection.Close();
              MessageBox.Show("Error ...!!!" + e.Message);
              return null;
          }
          return Convert.ToString(objIdVenta);
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


      public String NumeroComprobante(String objTipoDocumento)
      {
          List<Parametro> lst = new List<Parametro>();
          String NroCorrelativo = "";
          try
          {
              lst.Add(new Parametro("@TipoDocumento", objTipoDocumento));
              lst.Add(new Parametro("@NroCorrelativo", "", SqlDbType.VarChar, ParameterDirection.Output, 7));
              cm.EjecutarSP("NumeroCorrelativo", ref lst);
              NroCorrelativo = Convert.ToString(lst[1].Valor.ToString());
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return Convert.ToString(NroCorrelativo);
      }


      public List<Comprobante> obtenerDatosEnLista()
      {
          List<Comprobante> oListDComprobante = new List<Comprobante>();
          try
          {
              oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("mostrarComprobante", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;

              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              Comprobante oComprobante;

              while (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];
                  oComprobante.idempleado = (int)oSqlDataReader["IdEmpleado"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.idcliente=(int)oSqlDataReader["DniCliente"];
                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.idtipoPago = (int)oSqlDataReader["IdFormaPago"];

                  oComprobante.total = (Decimal)oSqlDataReader["Total"];

                  oListDComprobante.Add(oComprobante);
              }
              oSqlDataReader.Close();
              oSqlConnection.Close();
              return oListDComprobante;
          }
          catch (System.Exception e)
          {
              oSqlConnection.Close();
              MessageBox.Show("Error ...!!!" + e.Message);
              return null;
          }
      }

      public List<Comprobante> consultarComprobantePorApellidos(String busqueda)
      {
          List<Comprobante> oListDComprobantes = new List<Comprobante>();
          try
          {
              oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("buscarComprobnatePorCliente", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              Comprobante oComprobante;

              while (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];
                  oComprobante.idempleado = (int)oSqlDataReader["IdEmpleado"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];
                  oComprobante.Cliente=(String)oSqlDataReader["Cliente"];
                  oComprobante.idtipoPago = (int)oSqlDataReader["IdFormaPago"];

                  oComprobante.total = (Decimal)oSqlDataReader["Total"];
                 
                  oListDComprobantes.Add(oComprobante);
              }
              oSqlDataReader.Close();
              oSqlConnection.Close();
              return oListDComprobantes;
          }
          catch (System.Exception e)
          {
              oSqlConnection.Close();
              MessageBox.Show("Error ...!!!" + e.Message);
              return null;
          }
      }


      public Boolean registrarComprobante(Comprobante oComprobante)
      {
          try
          {

              oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("registraComprobante", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@idempleado", oComprobante.idempleado));
              oSqlCommand.Parameters.Add(new SqlParameter("@idcliente", oComprobante.idcliente));
              oSqlCommand.Parameters.Add(new SqlParameter("@serie", oComprobante.serie));
              oSqlCommand.Parameters.Add(new SqlParameter("@numerodocumento", oComprobante.numeroDocumento));
              oSqlCommand.Parameters.Add(new SqlParameter("@tipodocumento", oComprobante.tipoDocumento));
              oSqlCommand.Parameters.Add(new SqlParameter("@fechaventa", oComprobante.fecha));
              oSqlCommand.Parameters.Add(new SqlParameter("@idpago", oComprobante.idtipoPago));
              oSqlCommand.Parameters.Add(new SqlParameter("@total",oComprobante.total));
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

      public void eliminar_Multiple(string idComprobante,Label lbl)
      {
          oSqlConnection = ConexionBD.getConexion();
          oSqlConnection.Open();
          SqlCommand oSqlCommand = new SqlCommand("eliminarComprobante", oSqlConnection);
          oSqlCommand.CommandType = CommandType.StoredProcedure;
          oSqlCommand.Parameters.Add(new SqlParameter("@idComprobante", idComprobante));
          oSqlCommand.ExecuteNonQuery();
          lbl.Text = "Registros Eliminados con Exito";
          oSqlConnection.Close();

      }

      public Comprobante consultarComprobantexApellidos(String busqueda)
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("buscarComprobnatePorCliente", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];
                  oComprobante.idempleado = (int)oSqlDataReader["IdEmpleado"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];
                  oComprobante.idtipoPago = (int)oSqlDataReader["IdFormaPago"];

                  oComprobante.total = (Decimal)oSqlDataReader["Total"];
                  oSqlDataReader.Close();
                  return oComprobante;


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
      public Comprobante consultarComprobante()
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprobante", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];

                  oComprobante.Empleado = (String)oSqlDataReader["Empleado"];

                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];

                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.ubicacion = (String)oSqlDataReader["Direccion"];
                  oComprobante.tipoPago = (String)oSqlDataReader["nombre"];
                  oComprobante.total = (Decimal)oSqlDataReader["total"];

                  oSqlDataReader.Close();
                  return oComprobante;


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

      public Comprobante consultarComprobantexDocumento(String busqueda)
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprobantexBoleta", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@boleta", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];

                  oComprobante.Empleado = (String)oSqlDataReader["Empleado"];

                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];

                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.ubicacion = (String)oSqlDataReader["Direccion"];
                  oComprobante.tipoPago = (String)oSqlDataReader["nombre"];
                  oComprobante.total = (Decimal)oSqlDataReader["total"];

                  oSqlDataReader.Close();
                  return oComprobante;


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

      public Comprobante consultarComprobantexPago(String busqueda)
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprobantexPago", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];

                  oComprobante.Empleado = (String)oSqlDataReader["Empleado"];

                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];

                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.ubicacion = (String)oSqlDataReader["Direccion"];
                  oComprobante.tipoPago = (String)oSqlDataReader["nombre"];
                  oComprobante.total = (Decimal)oSqlDataReader["total"];

                  oSqlDataReader.Close();
                  return oComprobante;


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

      public Comprobante consultarComprobantexEmpleado(String busqueda)
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprobantexEmpleado", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];

                  oComprobante.Empleado = (String)oSqlDataReader["Empleado"];

                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];

                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.ubicacion = (String)oSqlDataReader["Direccion"];
                  oComprobante.tipoPago = (String)oSqlDataReader["nombre"];
                  oComprobante.total = (Decimal)oSqlDataReader["total"];

                  oSqlDataReader.Close();
                  return oComprobante;


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

      public Comprobante consultarComprobantexCliente(String busqueda)
      {
          try
          {
              Comprobante oComprobante;
              SqlConnection oSqlConnection = ConexionBD.getConexion();
              oSqlConnection.Open();
              SqlCommand oSqlCommand = new SqlCommand("reporteMostrarComprobantexCliente", oSqlConnection);
              oSqlCommand.CommandType = CommandType.StoredProcedure;
              oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
              SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
              if (oSqlDataReader.Read())
              {
                  oComprobante = new Comprobante();
                  oComprobante.idComprobante = (int)oSqlDataReader["IdComprobante"];
                  oComprobante.fecha = (DateTime)oSqlDataReader["FechaVenta"];

                  oComprobante.Empleado = (String)oSqlDataReader["Empleado"];

                  oComprobante.tipoDocumento = (String)oSqlDataReader["TipoDocumento"];
                  oComprobante.serie = (String)oSqlDataReader["Serie"];
                  oComprobante.numeroDocumento = (String)oSqlDataReader["NroDocumento"];
                  oComprobante.idcliente = (int)oSqlDataReader["DniCliente"];

                  oComprobante.Cliente = (String)oSqlDataReader["Cliente"];
                  oComprobante.ubicacion = (String)oSqlDataReader["Direccion"];
                  oComprobante.tipoPago = (String)oSqlDataReader["nombre"];
                  oComprobante.total = (Decimal)oSqlDataReader["total"];

                  oSqlDataReader.Close();
                  return oComprobante;


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
