using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Empleado
    {
       public int usuario_id { get; set; }
       public String apellidoPaterno { get; set; }
       public String apellidoMaterno { get; set; }
       public String nombres { get; set; }
       public String email { get; set; }
       public int tipoDeUsuario { get; set; }
       public String nick { get; set; }
       public String password { get; set; }
       public String habilitar { get; set; }
       public Byte[] foto { get; set; }
       public String direccion { get; set; }
       public String celular { get; set; }
       public String sexo { get; set; }
       public Decimal sueldo { get; set; }
       public String idSucursal { get; set; }
       public String tipo { get; set; }
       public String nombreSucursal { get; set; }
       public Empleado()
       {
            usuario_id = 0;
            apellidoPaterno = "";
            apellidoMaterno = "";
            nombres = "";
            email = "";
            nick = "";
            password = "";
            direccion = "";
            celular = "";
            sexo = "";
            tipo = "";
            nombreSucursal = "";

       }
       public int getUsuario_id()
       {
           return this.usuario_id;
       }
       public void setUsuario_id(int usuario_id)
       {
           this.usuario_id = usuario_id;
       }
       public String getApellidoPaterno()
       {
           return this.apellidoPaterno;
       }
       public void setApellidoPaterno(String apellidoPaterno)
       {
           this.apellidoPaterno = apellidoPaterno;
       }
       public String getApellidoMaterno()
       {
           return this.apellidoMaterno;
       }
       public void setApellidoMaterno(String apellidoMaterno)
       {
           this.apellidoMaterno = apellidoMaterno;
       }
       public String getNombre()
       {
           return this.nombres;
       }
       public void setNombre(String nombres)
       {
           this.nombres = nombres;
       }
       public String getDireccion()
       {
           return this.direccion;
       }
       public void setDireccion(String direccion)
       {
           this.direccion = direccion;
       }
       public String getCelular()
       {
           return this.celular;
       }
       public void setCelular(String celular)
       {
           this.celular = celular;
       }
       public String getSexo()
       {
           return this.sexo;
       }
       public void setSexo(String sexo)
       {
           this.sexo = sexo;
       }
       public String getEmail()
       {
           return this.email;
       }
       public void setEmail(String email)
       {
           this.email = email;
       }
       public Decimal getSueldo()
       {
           return this.sueldo;
       }
       public void setSueldo(Decimal sueldo)
       {
           this.sueldo = sueldo;
       }
       public int getTipoDeUsuario()
       {
           return this.tipoDeUsuario;
       }
       public void setTipoDeUsuario(int tipoDeUsuario)
       {
           this.tipoDeUsuario = tipoDeUsuario;
       }
       public String getNick()
       {
           return this.nick;
       }
       public void setNick(String nick)
       {
           this.nick = nick;
       }
       public String getPassword()
       {
           return this.password;
       }
       public void setPasword(String password)
       {
           this.password = password;
       }
       public String getHabilitar()
       {
           return this.habilitar;
       }
       public void setHabilitar(String habilitar)
       {
           this.habilitar = habilitar;
       }
       public byte[] getFoto()
       {
           return foto;
       }
       public void setFoto(byte[] foto)
       {
           this.foto = foto;
       }
      
       public String getIdSucursal()
       {
           return this.idSucursal;
       }
       public void setIdSucursal(String idSucursal)
       {
           this.idSucursal = idSucursal;
       }

       public String getTipo()
       {
           return this.tipo;
       }
       public void setTipo(String tip)
       {
           this.tipo = tip;
       }

       public String getSucursal()
       {
           return this.nombreSucursal;
       }
       public void setSucursal(String sucu)
       {
           this.nombreSucursal = sucu;
       }
       public override String ToString()
       {
           //return this.nick;
           return this.apellidoPaterno + " " + apellidoMaterno + " " + nombres;
       }

    }
}
