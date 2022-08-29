using System;
using Biblioteca;

namespace Ejercicio_04___Invento_Argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lapiceraAzul = new (ConsoleColor.Blue, 100);
            Boligrafo lapiceraRoja = new (ConsoleColor.Red, 50);
            string dibujo;

            Console.ForegroundColor = lapiceraAzul.GetColor();
            Console.WriteLine($"Tinta Inicial Azul: {lapiceraAzul.GetTinta()}");
            lapiceraAzul.Pintar(-4, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraAzul.Pintar(-4, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraAzul.Pintar(-3, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraAzul.Pintar(-12, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");
            Console.WriteLine("Recarga de tinta....");
            lapiceraAzul.Recargar();
            Console.WriteLine($"Tinta restante: {lapiceraAzul.GetTinta()}");

            Console.ForegroundColor = lapiceraRoja.GetColor();
            Console.WriteLine($"Tinta Inicial Roja: {lapiceraRoja.GetTinta()}");
            lapiceraRoja.Pintar(-4, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraRoja.Pintar(-4, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraRoja.Pintar(-3, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");
            Console.WriteLine(dibujo);
            lapiceraRoja.Pintar(-12, out dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");
            Console.WriteLine("Recarga de tinta....");
            lapiceraRoja.Recargar();
            Console.WriteLine($"Tinta restante: {lapiceraRoja.GetTinta()}");



            Console.ResetColor();
        }
    }
}
