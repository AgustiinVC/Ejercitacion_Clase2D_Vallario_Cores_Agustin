using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        //Atributos de la clase Cuenta

        private string titular;
        private decimal cantidad;


        //Constructor para inicializar los atributos

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // Metodos getter para titular y cantidad
        public string GetTitular()
        {
            return titular;

        }
        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"TITULAR: {GetTitular()} \t DINERO: ${GetCantidad()}");
            return sb.ToString();
        }

        public void Ingresar(decimal cantidadIngresada)
        {
            if (cantidadIngresada > 0)
            {
                cantidad += cantidadIngresada;
            }
        }
        public void Retirar(decimal cantidadIngresada)
        {
            if (cantidadIngresada > 0)
            {
                cantidad -= cantidadIngresada;
            }
        }
    }
}
