using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Comprobante
    {
       public int idComprobante { get; set; }
       public String serie { get; set; }
       public String numeroDocumento { get; set; }
       public DateTime fecha { get; set; }
       public Decimal igv { get; set; }
       public String tipoDocumento { get; set; }
       public String Empleado { get; set; }
       public String Cliente { get; set; }
       public String Producto_Marca { get; set; }
       public String ubicacion { get; set; }
       public String tipoPago { get; set; }
       public Decimal precio { get; set; }
       public int cantidad { get; set; }
       //campos relacionados
       public int idtipoPago { get; set; }
       public int idempleado { get; set; }
       public int idcliente { get; set; }

       public Empleado oEmpleado { get; set; }
       public Clientes oCliente { get;set;}
       public TipoDePago oFormaPago { get; set; }
       public Productos oProducto { get; set; }
       public DetalleComprobante oDetalle { get; set; }
       // campo calculado
       public Decimal total { get; set; }


       public Comprobante()
       {
           oEmpleado = new Empleado();
           oCliente = new Clientes();
           oFormaPago = new TipoDePago();
           oProducto = new Productos();
           oDetalle = new DetalleComprobante();
       }
       public void setEmpleado(int dni)
       {
           this.idempleado = dni;
       }

       public void setCliente(int dni)
       {
           this.idcliente = dni;
       }
       public void setPago(int pago)
       {
           this.idtipoPago = pago;
       }

       
       private String m_Nombre;
       private Object m_Valor;
       private SqlDbType m_TipoDato;
       private ParameterDirection m_Direccion;
       private int m_Tamaño;

       public String Nombre
       {
           get { return m_Nombre; }
           set { m_Nombre = value; }
       }

       public Object Valor
       {
           get { return m_Valor; }
           set { m_Valor = value; }
       }

       public SqlDbType TipoDato
       {
           get { return m_TipoDato; }
           set { m_TipoDato = value; }
       }


       public ParameterDirection Direccion
       {
           get { return m_Direccion; }
           set { m_Direccion = value; }
       }


       public int Tamaño
       {
           get { return m_Tamaño; }
           set { m_Tamaño = value; }
       }
       public Comprobante(String objNombre, Object objValor,SqlDbType objTipoDato,ParameterDirection objDireccion,int objTamaño){
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_TipoDato = objTipoDato;
            m_Direccion =objDireccion;
            m_Tamaño = objTamaño;
        }
      
    }
}
