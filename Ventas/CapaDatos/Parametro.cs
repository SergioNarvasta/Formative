using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Parametro
    {
        private String m_Nombre;
        private Object m_Valor;
        private SqlDbType m_TipoDato;
        private ParameterDirection m_Direccion;
        private int m_Tamaño;

        public String Nombre{
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }

        public Object Valor{
            get { return m_Valor; }
            set { m_Valor = value; }
        }

        public SqlDbType TipoDato{
            get { return m_TipoDato; }
            set { m_TipoDato = value; }
        }


        public ParameterDirection Direccion{
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }


        public int Tamaño{
            get { return m_Tamaño; }
            set { m_Tamaño = value; }
        }

        public Parametro(String objNombre,Object objValor) {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_Direccion = ParameterDirection.Input;
        }

        public Parametro(String objNombre, Object objValor,SqlDbType objTipoDato,ParameterDirection objDireccion,int objTamaño){
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_TipoDato = objTipoDato;
            m_Direccion =objDireccion;
            m_Tamaño = objTamaño;
        }

    }
}
