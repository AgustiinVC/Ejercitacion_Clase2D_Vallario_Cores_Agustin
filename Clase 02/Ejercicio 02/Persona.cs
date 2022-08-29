using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Persona
    {
        //Atributos de la clase Persona

        private string nombre;
        private string fechaDeNacimiento;
        private int dni;


        //Constructor para inicializar los atributos

        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        // Metodos getter y setter
        public string GetNombre()
        {
            return nombre;

        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public void SetFechaDeNacimiento(string fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public int GetDni()
        {
            return dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            DateTime añoActual = DateTime.Now;
            DateTime fechaNacimiento = DateTime.Parse(GetFechaDeNacimiento());
            return añoActual.Year - fechaNacimiento.Year;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {GetNombre()} \t Fecha: {GetFechaDeNacimiento()} \t Dni: {GetDni()} \t Edad: {CalcularEdad()} años.");
            return sb.ToString();
        }

        public void EsMayorDeEdad()
        {
            string mensaje = "Es menor de edad.";
            int edad = CalcularEdad();

            if (CalcularEdad() > 17)
            {
                mensaje = mensaje.Replace("menor", "mayor");
            }
            Console.WriteLine(mensaje);
        }
    }
}

