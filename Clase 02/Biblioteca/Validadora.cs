using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validadora
    {
        public static bool ValidarNumerico (string numeroIngresado, int valorMinimo, int valorMaximo)
        {
            int numero = int.Parse(numeroIngresado);
            return (EsNumerico(numeroIngresado) && ComprobarRangoValido(numero, valorMinimo, valorMaximo);
        }

        public static bool ComprobarRangoValido (int valor, int valorMinimo, int valorMaximo)
        {
            return valor > valorMinimo && valor < valorMaximo;
        }

        public static bool ValidarNumerico(int numeroIngresado, int valorMinimo, int valorMaximo)
        {
            return ComprobarRangoValido(numeroIngresado, valorMinimo, valorMaximo);
        }

        private static bool EsNumerico (string numero)
        {
            int retorno;
            if (int.TryParse(numero, out retorno))
            {
                return true;
            }
            return false;
        }
    }
}
