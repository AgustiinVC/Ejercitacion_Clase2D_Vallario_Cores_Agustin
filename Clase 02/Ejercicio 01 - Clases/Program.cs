using System;
using CuentaInterna;

namespace Ejercicio_01___Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal cantidadAIngresar;
            bool continuar;
            string respuesta;

            Cuenta cuentaA = new Cuenta("Agustin", 110922);

            do
            {
                continuar = false;

                Console.WriteLine($"Cuenta => {cuentaA.Mostrar()}" );

                Console.Write("1 - Depositar \t 2 - Retirar\n Ingrese su opcion: ");

                while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion < 1 || opcion > 2))
                {
                    Console.Write("Ingrese una opcion valida 1 - Depositar \t 2 - Retirar\n Ingrese su opcion: ");
                }

                Console.Write("Ingrese el monto: ");

                if (decimal.TryParse(Console.ReadLine(), out cantidadAIngresar))
                {
                    switch (opcion)
                    {
                        case 1:
                            cuentaA.Ingresar(cantidadAIngresar);
                            break;
                        case 2:
                            cuentaA.Retirar(cantidadAIngresar);
                            break;
                    }
                }

                Console.WriteLine($"Cuenta => {cuentaA.Mostrar()}");
                do
                {
                    Console.WriteLine("¿Quiere volver a realizar una operacion? (si / no)");
                    respuesta = Console.ReadLine();
                }
                while (respuesta.ToLower() != "si" && respuesta.ToLower() != "no");

                if ( respuesta.ToLower() == "si")
                {
                    continuar = true;
                }
            }
            while (continuar);
            Console.WriteLine("Gracias por usar nuestra aplicacion. Adios!");
        }
    }
}
