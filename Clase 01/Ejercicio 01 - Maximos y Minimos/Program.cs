using System;

namespace Ejercicio_01___Maximos_y_Minimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Consigna
                Ingresar 5 números por consola, guardándolos en una variable escalar.
                Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */

            int numeroIngresado;
            int numeroMaximo;
            int numeroMinimo;
            int sumaTotalNumeros = 0;
            float promedioNumeros;
            bool flag = true;

            for (int contador = 0; contador < 5; contador++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    flag = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                while (!flag);
                if (contador == 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                }
                sumaTotalNumeros += numeroIngresado;
            }
            promedioNumeros = sumaTotalNumeros / 5;
            Console.WriteLine("El valor maximo es: {0}", numeroMaximo);
            Console.WriteLine("El valor minimo es: {0}", numeroMinimo);
            Console.WriteLine("El promedio es: {0}", promedioNumeros);

        }
    }
}
