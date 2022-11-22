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
   public class DProducto
    {
        SqlConnection oSqlConnection = new SqlConnection();
        SqlDataReader oSqlDataReader;

        public Boolean registrarProductos(Productos oProductos)
        {
            try
            {

                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("registrarProducto", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idCategoria", oProductos.idCategoria));
                oSqlCommand.Parameters.Add(new SqlParameter("@idPresentacion", oProductos.idPresentacion));
                oSqlCommand.Parameters.Add(new SqlParameter("@nombre", oProductos.nombre));
                oSqlCommand.Parameters.Add(new SqlParameter("@marca", oProductos.marca));
                oSqlCommand.Parameters.Add(new SqlParameter("@precioCompra", oProductos.precioCompra));
                oSqlCommand.Parameters.Add(new SqlParameter("@precioVenta", oProductos.precioVenta));
                oSqlCommand.Parameters.Add(new SqlParameter("@stock", oProductos.stock));
                
                oSqlCommand.Parameters.Add(new SqlParameter("@imagen", oProductos.imagen));
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

        public List<Productos> obtenerDatosEnLista()
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarProducto", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria=(String)oSqlDataReader["Descripcion"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Productos> obtenerDatosEnListaDeProductosxNombre(String buscar)
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxNombre", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos",buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Productos> obtenerDatosEnListaDeProductosxMarca(String buscar)
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxMarca", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }


        public List<Productos> obtenerDatosEnListaProductosIngresos()
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarProductoIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Productos> obtenerDatosEnListaDeProductosxNombreIngresos(String buscar)
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxNombreIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];


                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }
        public List<Productos> obtenerDatosEnListaDeProductosxMarcaIngresos(String buscar)
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxMarcaIngresos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }

        public List<Productos> obtenerDatosEnListaStock()
        {
            List<Productos> oListDProductos = new List<Productos>();
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("mostrarStockProductos", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                Productos oProductos;

                while (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.stock = (int)oSqlDataReader["stock_actual"];
                    oProductos.cantidad = (int)oSqlDataReader["cantidad_vendida"];
                    oProductos.stock_actual = (int)oSqlDataReader["Stoc_Actual"];

                    
                    oListDProductos.Add(oProductos);
                }
                oSqlDataReader.Close();
                oSqlConnection.Close();
                return oListDProductos;
            }
            catch (System.Exception e)
            {
                oSqlConnection.Close();
                MessageBox.Show("Error ...!!!" + e.Message);
                return null;
            }
        }


        public Boolean modificarProductos(int busqueda, Productos oProductos)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("editarProducto", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idProducto", oProductos.idProducto));
                oSqlCommand.Parameters.Add(new SqlParameter("@idCategoria", oProductos.idCategoria));
                oSqlCommand.Parameters.Add(new SqlParameter("@idPresentacion", oProductos.idPresentacion));
                oSqlCommand.Parameters.Add(new SqlParameter("@nombre", oProductos.nombre));
                oSqlCommand.Parameters.Add(new SqlParameter("@marca", oProductos.marca));
                
                oSqlCommand.Parameters.Add(new SqlParameter("@precioCompra", oProductos.precioCompra));
                oSqlCommand.Parameters.Add(new SqlParameter("@precioVenta", oProductos.precioVenta));
                oSqlCommand.Parameters.Add(new SqlParameter("@stock", oProductos.stock));
                oSqlCommand.Parameters.Add(new SqlParameter("@imagen", oProductos.imagen));
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

        public Boolean eliminarProductos(int busqueda)
        {
            try
            {
                oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("eliminarProducto", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@idProducto", busqueda));

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

        public Productos BuscarProductosxNombre(String buscar)
        {
            try
            {  Productos oProductos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxNombre", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    return oProductos;
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

        public Productos BuscarProductosxMarca(String buscar)
        {
            try
            {
                Productos oProductos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxMarca", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];

                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    return oProductos;
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

        public Productos BuscarProductosxId(int buscar)
        {
            try
            {
                Productos oProductos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("buscarProductoxId", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@Datos", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                    oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                    oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.categoria = (String)oSqlDataReader["Descripcion"];

                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    return oProductos;
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

        public Productos BuscarProductosxCategorias(String buscar)
        {
            try
            {
                Productos oProductos;
                SqlConnection oSqlConnection = ConexionBD.getConexion();
                oSqlConnection.Open();
                SqlCommand oSqlCommand = new SqlCommand("reporteProductoxCategorias", oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(new SqlParameter("@codigo", buscar));
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    oProductos = new Productos();
                    oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                    oProductos.nombre = (String)oSqlDataReader["Nombre"];
                    oProductos.marca = (String)oSqlDataReader["Marca"];
                    oProductos.categoria = (String)oSqlDataReader["descripcion"];
                    oProductos.presentacion= (String)oSqlDataReader["nombre"];
                    oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                    oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                    oProductos.stock = (int)oSqlDataReader["Stock"];
                    oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];

                    return oProductos;
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

      

        
       public void cargar(DataGridView Dgv)
        {
            //Dgv.Columns.Clear();
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "Eliminar";
            check.Name = "Eliminar";
            check.Width = 50;

            Dgv.Columns.Add(check);
            Dgv.Columns[Dgv.Columns.Count - 1].DisplayIndex = 0;
                
            
        }

       public void eliminar_Multiple(string idProducto,Label lbl)
       {
           oSqlConnection = ConexionBD.getConexion();
           oSqlConnection.Open();
           SqlCommand oSqlCommand = new SqlCommand("eliminarProducto", oSqlConnection);
           oSqlCommand.CommandType = CommandType.StoredProcedure;
           oSqlCommand.Parameters.Add(new SqlParameter("@idProducto", idProducto));
           oSqlCommand.ExecuteNonQuery();
           lbl.Text = "Registros Eliminados con Exito";
           oSqlConnection.Close();

       }

       public Productos BuscarProductosxNombreIngresos(String buscar)
       {
           try
           {
               Productos oProductos;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoxNombreIngresos", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oProductos = new Productos();
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                   oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                   oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                   oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];


                   return oProductos;
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

       public Productos BuscarProductosxMarcaIngresos(String buscar)
       {
           try
           {
               Productos oProductos;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoxMarcaIngresos", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oProductos = new Productos();
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.idCategoria = (int)oSqlDataReader["IdCategoria"];
                   oProductos.idPresentacion = (int)oSqlDataReader["IdPresentacion"];
                   oProductos.presentacion = (String)oSqlDataReader["presentacion"];

                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["PrecioCompra"];
                   oProductos.imagen = (Byte[])oSqlDataReader["Imagen"];


                   return oProductos;
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



       public List<Productos> obtenerDatosEnListaProductosComprobante()
       {
           List<Productos> oListDProductos = new List<Productos>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("mostrarProductoComprobante", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               Productos oProductos;

               while (oSqlDataReader.Read())
               {
                   oProductos = new Productos();

                   oProductos.idDetalle = (int)oSqlDataReader["idDetalleIngreso"];
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.presentacion = (String)oSqlDataReader["nombre"];
                   oProductos.stock = (int)oSqlDataReader["Stock"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["precioCompra"];
                   oProductos.precioVenta= (Decimal)oSqlDataReader["PrecioVenta"];
                   
                   oListDProductos.Add(oProductos);
               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDProductos;
           }
           catch (System.Exception e)
           {
               oSqlConnection.Close();
               MessageBox.Show("Error ...!!!" + e.Message);
               return null;
           }
       }
       public List<Productos> obtenerDatosEnListaDeProductosComprobantesxNombre(String buscar)
       {
           List<Productos> oListDProductos = new List<Productos>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoComprobantexNombres", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               Productos oProductos;

               while (oSqlDataReader.Read())
               {
                   oProductos = new Productos();
                   oProductos.idDetalle = (int)oSqlDataReader["idDetalleIngreso"];
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.presentacion = (String)oSqlDataReader["nombre"];
                   oProductos.stock = (int)oSqlDataReader["stock_inicial"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["precioCompra"];
                   oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                 
                   oListDProductos.Add(oProductos);
               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDProductos;
           }
           catch (System.Exception e)
           {
               oSqlConnection.Close();
               MessageBox.Show("Error ...!!!" + e.Message);
               return null;
           }
       }
       public List<Productos> obtenerDatosEnListaDeProductosComprobantesxMarca(String buscar)
       {
           List<Productos> oListDProductos = new List<Productos>();
           try
           {
               oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoComprobantexMarca", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               Productos oProductos;

               while (oSqlDataReader.Read())
               {
                   oProductos = new Productos();
                   oProductos.idDetalle = (int)oSqlDataReader["idDetalleIngreso"];
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.presentacion = (String)oSqlDataReader["nombre"];
                   oProductos.stock = (int)oSqlDataReader["stock_inicial"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["precioCompra"];
                   oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                   

                   oListDProductos.Add(oProductos);
               }
               oSqlDataReader.Close();
               oSqlConnection.Close();
               return oListDProductos;
           }
           catch (System.Exception e)
           {
               oSqlConnection.Close();
               MessageBox.Show("Error ...!!!" + e.Message);
               return null;
           }
       }

       public Productos BuscarProductosComprobantesxNombre(String buscar)
       {
           try
           {
               Productos oProductos;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoComprobantexNombre", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oProductos = new Productos();
                   oProductos.idDetalle = (int)oSqlDataReader["idDetalleIngreso"];
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.presentacion = (String)oSqlDataReader["nombre"];
                   oProductos.stock = (int)oSqlDataReader["stock_inicial"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["precioCompra"];
                   oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                   

                   return oProductos;
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

       public Productos BuscarProductosComprobantesxMarca(String buscar)
       {
           try
           {
               Productos oProductos;
               SqlConnection oSqlConnection = ConexionBD.getConexion();
               oSqlConnection.Open();
               SqlCommand oSqlCommand = new SqlCommand("buscarProductoComprobantexMarca", oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add(new SqlParameter("@datos", buscar));
               SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
               if (oSqlDataReader.Read())
               {
                   oProductos = new Productos();

                   oProductos.idDetalle = (int)oSqlDataReader["idDetalleIngreso"];
                   oProductos.idProducto = (int)oSqlDataReader["IdProducto"];
                   oProductos.nombre = (String)oSqlDataReader["Nombre"];
                   oProductos.marca = (String)oSqlDataReader["Marca"];
                   oProductos.categoria = (String)oSqlDataReader["Descripcion"];
                   oProductos.presentacion = (String)oSqlDataReader["nombre"];
                   oProductos.stock = (int)oSqlDataReader["stock_inicial"];
                   oProductos.precioCompra = (Decimal)oSqlDataReader["precioCompra"];
                   oProductos.precioVenta = (Decimal)oSqlDataReader["PrecioVenta"];
                  
                   return oProductos;
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
