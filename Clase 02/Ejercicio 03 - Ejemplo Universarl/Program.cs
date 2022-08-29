using System;
using BibliotecaEjer02;

namespace Ejercicio_03___Ejemplo_Universarl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoA = new Estudiante("Rodriguez", "112485", "Agustin");
            Estudiante alumnoB = new Estudiante("Fenix", "1256", "Joaquin");
            Estudiante alumnoC = new Estudiante("Gianni", "147788", "Rosario");

            alumnoA.SetNotaPrimerParcial(10);
            alumnoA.SetNotaSegundoParcial(10);

            alumnoB.SetNotaPrimerParcial(2);
            alumnoB.SetNotaSegundoParcial(2);

            alumnoC.SetNotaPrimerParcial(8);
            alumnoC.SetNotaSegundoParcial(6);

            Console.WriteLine(Estudiante.Mostrar(alumnoA));
            Console.WriteLine(Estudiante.Mostrar(alumnoB));
            Console.WriteLine(Estudiante.Mostrar(alumnoC));
        }
    }
}
