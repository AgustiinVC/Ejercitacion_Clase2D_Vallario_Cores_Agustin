using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarNumerico(string numeroIngresado, int valorMinimo, int valorMaximo)
        {
            int.TryParse(numeroIngresado, out int numero);
            return (EsNumerico(numeroIngresado) && Validar(numero, valorMinimo, valorMaximo));
        }
        public static bool Validar (int valor, int min, int max)
        {
            return (valor > min && valor < max);
        }

        private static bool EsNumerico(string numero)
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


