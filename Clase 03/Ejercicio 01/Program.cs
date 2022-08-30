using System;
using Biblioteca;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string numeroIngresado;
            int numeroValidado;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio;
            int sumaTotal = 0;

            do
            {
                Console.WriteLine($"Numeros ingresados actualmente {cantidad}");
                Console.Write($"Ingrese un numero entre -100 y 100: ");
                numeroIngresado = Console.ReadLine();
                if (Validador.ValidarNumerico(numeroIngresado, -100, 100))
                {
                    numeroValidado = int.Parse(numeroIngresado);
                    Console.WriteLine("El numero es valido.");
                    cantidad++;
                    sumaTotal += numeroValidado;
                    if (cantidad == 0 || numeroValidado < minimo)
                    {
                        minimo = numeroValidado;
                    }
                    if (cantidad == 0 || numeroValidado > maximo)
                    {
                        maximo = numeroValidado;
                    }
                }
                else
                {
                    Console.WriteLine("El numero NO es valido. Ingrese otro numero.");
                }
            }
            while (cantidad < 10);
            promedio = (float)sumaTotal / cantidad;

            Console.WriteLine($"El numero maximo es: {maximo}, el minimo es {minimo} y el promedio es {promedio}");
        }
    }
}
