using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Consigna
                Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
                Validar que el dato ingresado por el usuario sea un número.
                Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
                Si ingresa "salir", cerrar la consola.
                Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola. */
            int numeroIngresado;
            string cadenaIngresada;
            string respuestaIngresada;
            string respuesta;
            int cantidadDivisores = 0;
            bool esNumero;
            bool flagPrimerPrimo = true;

            do
            {
                Console.Write("Ingrese un numero: ");

                do
                {
                    cadenaIngresada = Console.ReadLine();
                    esNumero = int.TryParse(cadenaIngresada, out numeroIngresado);
                    if (!esNumero && cadenaIngresada != "salir")
                    {
                        Console.WriteLine("ERROR. Ingrese un numero:");
                    }
                }
                while (!esNumero && cadenaIngresada != "salir");

                if (cadenaIngresada != "salir")
                {
                    if (numeroIngresado > 2)
                    {
                        // Todos los numeros primos hasta el numero que se ingresa
                        for (int numeros = 2; numeros < (numeroIngresado + 1); numeros++)
                        {
                            for (int contador = 2; contador < numeros; contador++)
                            {
                                if (numeros % contador == 0)
                                {
                                    cantidadDivisores++;
                                }
                            }
                            if (flagPrimerPrimo)
                            {
                                flagPrimerPrimo = false;
                                Console.Write("Los numeros primos hasta {0} son: ", numeroIngresado);
                            }

                            if (cantidadDivisores == 0)
                            {
                                Console.Write(numeros + " ");
                            }
                            cantidadDivisores = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay numeros primos.");
                    }
                }
                else
                {
                    Environment.Exit(0); //Cierro la consola
                }
                flagPrimerPrimo = true;
                Console.Write("{0}¿Desea volver a ingresar otro numero? Ingrese \" si \" para volver a operar:  ", Environment.NewLine);
                respuestaIngresada = Console.ReadLine();
                respuesta = respuestaIngresada.ToLower();
            }
            while (respuesta == "si");   
        }
    }
}
