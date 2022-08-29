using System;
using Biblioteca;

namespace Ejercicio_02____Cuantas_Primaveras_tenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaA = new Persona("Agustin", "21/06/1994", 38164258);
            Persona personaB = new Persona("Rocio", "06/09/2014", 48356794);
            Persona personaC = new Persona("Belen", "12/02/2001", 40199032);

            Console.Write(personaA.Mostrar());
            personaA.EsMayorDeEdad();

            Console.Write(personaB.Mostrar());
            personaB.EsMayorDeEdad();

            Console.Write(personaC.Mostrar());
            personaC.EsMayorDeEdad();
        }
    }
}
