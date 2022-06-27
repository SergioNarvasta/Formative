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
    public class DCategorias
    {
        
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;

        public Boolean registrarCategorias(Categorias oCategorias)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarCategoria", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@descripcion", oCategorias.nombre));
               
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

        public List<Categorias> obtenerDatosEnLista()
        {
            List<Categorias> oListDCategorias = new List<Categorias>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarCategorias", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Categorias oCategorias;

                while (oSqlDataReader.Read())
                {
                    oCategorias = new Categorias();
                    oCategorias.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oCategorias.nombre = (String)oSqlDataReader["Descripcion"];
                    
                    oListDCategorias.Add(oCategorias);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDCategorias;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Categorias> obtenerDatosEnListaDeCategoriasxNombre(String buscar)
        {
            List<Categorias> oListDCategorias = new List<Categorias>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosCategoriasxNombre", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Categorias oCategorias;
                while (oSqlDataReader.Read())
                {
                    oCategorias = new Categorias();
                    oCategorias.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oCategorias.nombre = (String)oSqlDataReader["Descripcion"];

                    oListDCategorias.Add(oCategorias);
                    

                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDCategorias;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Categorias> obtenerDatosEnListaDeCategoriasxCodigo(int buscar)
        {
            List<Categorias> oListDCategorias = new List<Categorias>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosCategorias", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Categorias oCategorias;
                while (oSqlDataReader.Read())
                {
                    oCategorias = new Categorias();
                    oCategorias.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oCategorias.nombre = (String)oSqlDataReader["Descripcion"];

                    oListDCategorias.Add(oCategorias);


                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDCategorias;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }


        public Boolean modificarCategorias(int busqueda, Categorias oCategorias)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarCategoria", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idCategoria", oCategorias.idCategoria));
                oSqlCommand.Parameters.Add(new SqlParameter("@descripcion", oCategorias.nombre));
                
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

        public Boolean eliminarCategorias(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarCategoria", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idCategoria", busqueda));

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

       

        public Categorias consultarCategoriasxCodigo(int busqueda)
        {
            try
            {
                Categorias oDCategorias;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosCategorias", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDCategorias = new Categorias();
                    oDCategorias.idCategoria = ((int)oSqlDataReader["IdCategoria"]);
                    oDCategorias.nombre = ((String)oSqlDataReader["Descripcion"]);
                   oSqlDataReader.Close();
                    return oDCategorias;


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

        public Categorias consultarCategoriasxNombres(String busqueda)
        {
            try
            {
                Categorias oDCategorias;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosCategoriasxNombre", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDCategorias = new Categorias();
                    oDCategorias.idCategoria = ((int)oSqlDataReader["IdCategoria"]);
                    oDCategorias.nombre = ((String)oSqlDataReader["Descripcion"]);
                    oSqlDataReader.Close();
                    return oDCategorias;


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

        public void eliminar_Multiple(string idCategoria, Label lbl)
        {
            oSqlConnection = ConexionBD.getConexion();
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand("eliminarCategoria", oSqlConnection);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
            oSqlCommand.ExecuteNonQuery();
            lbl.Text = "Registros Eliminados con Exito";
            oSqlConnection.Close();

        }

    }
}
