using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    //abstract
    public  class ConexionBD
    {
        static SqlConnection conexion;
        public static SqlConnection getConexion()
        {

            string cadena = "Data Source=DESKTOP-B1VEPFB\\SQLEXPRESS;Initial Catalog=AGRICOLA_MILAGROS;Integrated Security=True";
            conexion = new SqlConnection(cadena);
            return conexion;
        }
       
        public void EjecutarSP(String NombreSP, ref List<Parametro> lst)
        {
            SqlCommand cmd;
            try
            {
                getConexion().Open();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            getConexion().Close();
        }
    }
}
