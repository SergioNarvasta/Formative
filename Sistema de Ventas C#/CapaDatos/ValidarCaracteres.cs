using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ValidarCaracteres
    {
        public static Boolean ValidadorNumerico(char e)
        {
            String ValidarCaracteres = "0123456789\b";
            Boolean existe = ValidarCaracteres.Contains(e);
            if (existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static Boolean ValidadorNumericoyPunto(char e)
        {
            String ValidarCaracteres = "0123456789.\b";
            Boolean existe = ValidarCaracteres.Contains(e);
            if (existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static Boolean ValidadorDeLetras(char e)
        {
            String validarLetaras = "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPKRSTUVWXYZáéíóú\b";
            Boolean existe = validarLetaras.Contains(e);
            if (existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static Boolean ValidadorDeNumerosLetras(char e)
        {
            String ValidarCaracteres = "0123456789abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPKRSTUVWXYZáéíóúº:.-\b";
            Boolean existe = ValidarCaracteres.Contains(e);
            if (existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
