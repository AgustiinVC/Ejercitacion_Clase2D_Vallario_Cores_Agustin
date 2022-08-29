using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo (ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }   

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta ()
        {
            return tinta;
        }

        private void SetTinta (short tintaIngresada)
        {
            short tintaResultante = (short)(this.tinta + tintaIngresada);
            if (tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar ()
        {
            short tintaRestante = GetTinta();
            short tintaARecargar = (short)(cantidadTintaMaxima - tintaRestante);
            SetTinta(tintaARecargar);
        }

        public void Pintar(short gasto, out string dibujo)
        {
            int tintaPostDibujo;
            StringBuilder sb = new StringBuilder();
            
            dibujo = "";

            if (GetTinta() > 0)
            {
                tintaPostDibujo = GetTinta() + gasto;
                if (tintaPostDibujo > 0)
                {
                    SetTinta((short)gasto);
                    for (int i = 0; i < -gasto; i++)
                    {
                        sb.Append('*');
                    }   
                }
                else
                {
                    for (int i = 0; i < GetTinta(); i++)
                    {
                        sb.Append('*');
                    }
                }
                dibujo = sb.ToString();
            }
        }
    }
}
