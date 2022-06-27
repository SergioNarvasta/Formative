using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Horario
    {
         public int Codigo { get; set; }
       public int idEmpleado { get; set; }
      public String Turno { get; set; }
      public String horaEntrada { get; set; }
      public String horaSalida { get; set; }
      public String nombreEmpleado { get;set; }
      public String cargo { get; set; }
      
      public Horario()
      {
          Codigo = 0;
          idEmpleado = 0;
          Turno = "";
          horaEntrada = "";
          horaSalida = "";
          nombreEmpleado = "";
          cargo = "";
          
      }
      public int getCodigo()
      {
          return this.Codigo;
      }
      public void setCodigo(int codigo)
      {
          this.Codigo = codigo;
      }
      public int getIdEmpleado()
      {
          return this.idEmpleado;
      }
      public void setIdEmpleado(int idEmpleado)
      {
          this.idEmpleado = idEmpleado;
      }
      public String getTurno()
      {
          return this.Turno;
      }
      public void setTurno(String turno)
      {
          this.Turno = turno;
      }
      public String getHoraEntrada()
      {
          return this.horaEntrada;
      }
      public void setHoraEntrada(String horaEntra)
      {
          this.horaEntrada = horaEntra;
      }
      public String getHoraSalida()
      {
          return this.horaSalida;
      }
      public void setHoraSalida(String horaSali)
      {
          this.horaSalida = horaSali;
      }
      public String getNombreEmpleado()
      {
          return this.nombreEmpleado;
      }
      public void setNombreEmpleado(String Empleado)
      {
          this.nombreEmpleado = Empleado;
      }
      public String getCargo()
      {
          return this.cargo;
      }
      public void setCargo(String Cargo)
      {
          this.cargo = Cargo;
      }
       
      public override String ToString()
      {
          return this.Turno;
      }
    }
}
