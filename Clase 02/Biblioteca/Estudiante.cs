using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            int notaFinal = -1;
            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                notaFinal = random.Next(6, 10);
            }
            return notaFinal;
        }

        public static string Mostrar(Estudiante alumno)
        {
            int notaFinal = alumno.CalcularNotaFinal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {alumno.nombre} {alumno.apellido} \t Legajo: {alumno.legajo}");
            sb.AppendLine($"Nota Primer Parcial: {alumno.notaPrimerParcial} \t Nota Segundo Parcial: {alumno.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {alumno.CalcularPromedio()}");

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado :(");
            }

            return sb.ToString();
        }
    }
}
