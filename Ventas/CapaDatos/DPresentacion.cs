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
   public class DPresentacion
    {
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
       public List<Presentacion> obtenerDatosEnLista()
       {
           List<Presentacion> oListDPresentacion = new List<Presentacion>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("mostrarPresentacion", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               Presentacion oPresentacion;

               while (oSqlDataReader.Read())
               {
                   oPresentacion = new Presentacion();
                   oPresentacion.idPresentacion = (int)oSqlDataReader["idPresentacion"];
                   oPresentacion.nombre = (String)oSqlDataReader["nombre"];
                   oPresentacion.descripcion = (String)oSqlDataReader["descripcion"];
                   oListDPresentacion.Add(oPresentacion);
               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDPresentacion;
           }
           catch (System.Exception e)
           {
               oSqlConnection.Close();
               MessageBox.Show("Error ...!!!" + e.Message);
               return null;
           }
       }
       public List<Presentacion> obtenerDatosEnListaDePresentacionxNombre(String buscar)
       {
           List<Presentacion> oListDPresentacion = new List<Presentacion>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarDatosPresentacionxNombre", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               Presentacion oPresentacion;
               while (oSqlDataReader.Read())
               {
                   oPresentacion = new Presentacion();
                   oPresentacion.idPresentacion = (int)oSqlDataReader["idPresentacion"];
                   oPresentacion.nombre = (String)oSqlDataReader["nombre"];
                   oPresentacion.descripcion = (String)oSqlDataReader["descripcion"];

                   oListDPresentacion.Add(oPresentacion);


               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDPresentacion;
           }
           catch (System.Exception e)
           {
               oSqlConnection.Close();
               MessageBox.Show("Error ...!!!" + e.Message);
               return null;
           }
       }

       public Boolean registrarPresentacion(Presentacion oPresentacion)
       {
           try
           {

               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("registraPresentacion", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@nombre", oPresentacion.nombre));
               oSqlCommand.Parameters.Add(new SqlParameter("@descripcion", oPresentacion.descripcion));

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
       public Boolean modificarPresentacion(int busqueda, Presentacion oPresentacion)
       {
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("editarPresentacion", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@idPresentacion", oPresentacion.idPresentacion));
               oSqlCommand.Parameters.Add(new SqlParameter("@nombre", oPresentacion.nombre));
               oSqlCommand.Parameters.Add(new SqlParameter("@descripcion", oPresentacion.descripcion));


               oSqlCommand.ExecuteNonQuery();

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

       public Boolean eliminarPresentacion(int busqueda)
       {
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("eliminarPresentacion", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@idPresentacion", busqueda));

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

       public Presentacion consultarPresentacionxNombres(String busqueda)
       {
           try
           {
               Presentacion oDPresentacion;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarDatosPresentacionxNombre", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@Datos", busqueda));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oDPresentacion = new Presentacion();
                   oDPresentacion.idPresentacion = ((int)oSqlDataReader["idPresentacion"]);
                   oDPresentacion.nombre = ((String)oSqlDataReader["nombre"]);
                   oDPresentacion.descripcion = ((String)oSqlDataReader["descripcion"]);

                   oSqlDataReader.Close();
                   return oDPresentacion;


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

       public Presentacion consultarPresentacionxCodigo(int busqueda)
       {
           try
           {
               Presentacion oDPresentacion;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarDatosPresentacion", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@Datos", busqueda));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oDPresentacion = new Presentacion();
                   oDPresentacion.idPresentacion = ((int)oSqlDataReader["idPresentacion"]);
                   oDPresentacion.nombre = ((String)oSqlDataReader["nombre"]);
                   oDPresentacion.descripcion = ((String)oSqlDataReader["descripcion"]);

                   oSqlDataReader.Close();
                   return oDPresentacion;


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

       public void eliminar_Multiple(string idPresentacion, Label lbl)
       {
           oSqlConnection = ConexionBD.getConexion();
           oSqlConnection.Open();
           SqlCommand oSqlCommand = new SqlCommand("eliminarPresentacion", oSqlConnection);
           oSqlCommand.CommandType = CommandType.StoredProcedure;
           oSqlCommand.Parameters.Add(new SqlParameter("@idPresentacion", idPresentacion));
           oSqlCommand.ExecuteNonQuery();
           lbl.Text = "Registros Eliminados con Exito";
           oSqlConnection.Close();

       }

       
    }
}
