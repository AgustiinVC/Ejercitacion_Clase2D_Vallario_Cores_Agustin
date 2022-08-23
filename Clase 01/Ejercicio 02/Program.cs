using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Consigna
                Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
                Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!". */

            int numeroIngresado;
            double cuadrado;
            double cubo;
            bool flagNumeroIngresado;

            Console.WriteLine("Ingrese un número: ");

            do
            {
                flagNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (!flagNumeroIngresado || numeroIngresado < 1)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    flagNumeroIngresado = false;
                }
            }
            while (!flagNumeroIngresado);

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine("Numero Ingresado: {0} {3}" +
                                " -- Cuadrado del numero ingresado: {1} {3}" +
                                " -- Cubo del numero ingresado:     {2}", numeroIngresado, cuadrado, cubo, Environment.NewLine);

        }
    }
}
