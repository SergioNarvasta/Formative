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
   public class DProveedor
   {
       ConexionBD cm = new ConexionBD();
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;
        public String NumeroComprobante(String objTipoDocumento)
        {
            List<Parametro> lst = new List<Parametro>();
            String NroCorrelativo = "";
            try
            {
                lst.Add(new Parametro("@TipoDocumento", objTipoDocumento));
                lst.Add(new Parametro("@NroCorrelativo", "", SqlDbType.VarChar, ParameterDirection.Output, 7));
                cm.EjecutarSP("NumeroCorrelativoProveedor", ref lst);
                NroCorrelativo = Convert.ToString(lst[1].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(NroCorrelativo);
        }

        public Boolean registrarProveedor(Proveedor oProveedor)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarProveedor", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                //oSqlCommand.Parameters.Add(new SqlParameter("@idclientes", oProveedor.idCliente));
                oSqlCommand.Parameters.Add(new SqlParameter("@razon", oProveedor.razonsocial));
                oSqlCommand.Parameters.Add(new SqlParameter("@sector", oProveedor.sectorcomercial));
                oSqlCommand.Parameters.Add(new SqlParameter("@numero", oProveedor.numerodocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@tipo", oProveedor.tipododocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@direccion", oProveedor.direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@telefono", oProveedor.telefono));
                oSqlCommand.Parameters.Add(new SqlParameter("@email", oProveedor.email));
                oSqlCommand.Parameters.Add(new SqlParameter("@url", oProveedor.url));

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

        public List<Proveedor> obtenerDatosEnLista()
        {
            List<Proveedor> oListDProveedor = new List<Proveedor>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarProveedor", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Proveedor oProveedor;

                while (oSqlDataReader.Read())
                {
                    oProveedor = new Proveedor();

                    oProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oProveedor.email = (String)oSqlDataReader["email"];
                    oProveedor.url = (String)oSqlDataReader["url"];

                    oListDProveedor.Add(oProveedor);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProveedor;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Proveedor> consultarProveedorPorRazonSocial(String busqueda)
        {
            List<Proveedor> oListDProveedor = new List<Proveedor>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorRazonSocial", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Proveedor oProveedor;

                while (oSqlDataReader.Read())
                {
                    oProveedor = new Proveedor();

                    oProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oProveedor.email = (String)oSqlDataReader["email"];
                    oProveedor.url = (String)oSqlDataReader["url"]; 
                    
                    oListDProveedor.Add(oProveedor);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProveedor;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Proveedor> consultarProvedorPorSectorComercial(String busqueda)
        {
            List<Proveedor> oListDProveedor = new List<Proveedor>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorSectorComercial", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Proveedor oProveedor;

                while (oSqlDataReader.Read())
                {
                    oProveedor = new Proveedor();

                    oProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oProveedor.email = (String)oSqlDataReader["email"];
                    oProveedor.url = (String)oSqlDataReader["url"];

                    oListDProveedor.Add(oProveedor);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProveedor;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Proveedor> consultarProvedorPorBoleta(String busqueda)
        {
            List<Proveedor> oListDProveedor = new List<Proveedor>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorBoleta", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Proveedor oProveedor;

                while (oSqlDataReader.Read())
                {
                    oProveedor = new Proveedor();

                    oProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oProveedor.email = (String)oSqlDataReader["email"];
                    oProveedor.url = (String)oSqlDataReader["url"];

                    oListDProveedor.Add(oProveedor);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProveedor;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Proveedor> consultarProvedorPorFactura(String busqueda)
        {
            List<Proveedor> oListDProveedor = new List<Proveedor>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorFactura", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Proveedor oProveedor;

                while (oSqlDataReader.Read())
                {
                    oProveedor = new Proveedor();

                    oProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oProveedor.email = (String)oSqlDataReader["email"];
                    oProveedor.url = (String)oSqlDataReader["url"];

                    oListDProveedor.Add(oProveedor);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProveedor;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public Boolean modificarProveedor(int busqueda, Proveedor oProveedor)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarProveedor", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idproveedor", oProveedor.idprovedor));
                oSqlCommand.Parameters.Add(new SqlParameter("@razon", oProveedor.razonsocial));
                oSqlCommand.Parameters.Add(new SqlParameter("@sector", oProveedor.sectorcomercial));
                oSqlCommand.Parameters.Add(new SqlParameter("@numero", oProveedor.numerodocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@tipo", oProveedor.tipododocumento));
                oSqlCommand.Parameters.Add(new SqlParameter("@direccion", oProveedor.direccion));
                oSqlCommand.Parameters.Add(new SqlParameter("@telefono", oProveedor.telefono));
                oSqlCommand.Parameters.Add(new SqlParameter("@email", oProveedor.email));
                oSqlCommand.Parameters.Add(new SqlParameter("@url", oProveedor.url));

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

        public Boolean eliminarProveedor(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarProveedor", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idproveedor", busqueda));


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

        public Proveedor consultarProveedorxRazonSocial(String busqueda)
        {
            try
            {
                Proveedor oDProveedor;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorRazonSocial", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDProveedor = new Proveedor();

                    oDProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oDProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oDProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oDProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oDProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oDProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oDProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oDProveedor.email = (String)oSqlDataReader["email"];
                    oDProveedor.url = (String)oSqlDataReader["url"]; 

                    oSqlDataReader.Close();
                    return oDProveedor;


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

        public Proveedor consultarProveedorxSectorComercial(String busqueda)
        {
            try
            {
                Proveedor oDProveedor;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorSectorComercial", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDProveedor = new Proveedor();
                    oDProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oDProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oDProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oDProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oDProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oDProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oDProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oDProveedor.email = (String)oSqlDataReader["email"];
                    oDProveedor.url = (String)oSqlDataReader["url"]; 
                    
                    oSqlDataReader.Close();
                    return oDProveedor;


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

        public Proveedor consultarProveedorxBoleta(String busqueda)
        {
            try
            {
                Proveedor oDProveedor;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorBoleta", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDProveedor = new Proveedor();
                    oDProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oDProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oDProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oDProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oDProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oDProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oDProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oDProveedor.email = (String)oSqlDataReader["email"];
                    oDProveedor.url = (String)oSqlDataReader["url"];

                    oSqlDataReader.Close();
                    return oDProveedor;


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

        public Proveedor consultarProveedorxFactura(String busqueda)
        {
            try
            {
                Proveedor oDProveedor;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorFactura", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDProveedor = new Proveedor();
                    oDProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oDProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oDProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oDProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oDProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oDProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oDProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oDProveedor.email = (String)oSqlDataReader["email"];
                    oDProveedor.url = (String)oSqlDataReader["url"];

                    oSqlDataReader.Close();
                    return oDProveedor;


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

        public Proveedor consultarProveedorxId(int busqueda)
        {
            try
            {
                Proveedor oDProveedor;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarDatosProveedorPorId", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", busqueda));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oDProveedor = new Proveedor();
                    oDProveedor.idprovedor = (int)oSqlDataReader["idProveedor"];
                    oDProveedor.razonsocial = (String)oSqlDataReader["razonSocial"];
                    oDProveedor.sectorcomercial = (String)oSqlDataReader["sectorComercial"];
                    oDProveedor.numerodocumento = (String)oSqlDataReader["numeroDocumento"];
                    oDProveedor.tipododocumento = (String)oSqlDataReader["tipoDocumento"];
                    oDProveedor.direccion = (String)oSqlDataReader["direccion"];
                    oDProveedor.telefono = (String)oSqlDataReader["telefono"];
                    oDProveedor.email = (String)oSqlDataReader["email"];
                    oDProveedor.url = (String)oSqlDataReader["url"];

                    oSqlDataReader.Close();
                    return oDProveedor;


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

       public void eliminar_Multiple(string idProveedor, Label lbl)
        {
            oSqlConnection = ConexionBD.getConexion();
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand("eliminarProveedor", oSqlConnection);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add(new SqlParameter("@idproveedor", idProveedor));
            oSqlCommand.ExecuteNonQuery();
            lbl.Text = "Registros Eliminados con Exito";
            oSqlConnection.Close();

        }

       
    }
}
