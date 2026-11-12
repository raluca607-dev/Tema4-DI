using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    internal class Ordenador
    {
        public string Nombre { get; set; }
        private int ram;
        public int Ram
        {
            set
            {
                if (value >= 0)
                {
                    ram = value;
                }
                else
                {
                    throw new NegativeRAMException();
                }
            }
            get
            {
                return ram;
            }
        }

        public static bool IpValida(string ip)
        {
            string[] partes = ip.Split('.');
            if (partes.Length != 4)
            {
                return false;

            }


            for (int i = 0; i < partes.Length; i++)
            {
                int numero;
                if (!int.TryParse(partes[i], out numero))
                {
                    return false;
                }
                if (numero < 0 || numero > 255)
                {
                    return false;
                }
            }

            return true;
        }

        public Ordenador(string nombre,int ram)
        {
            Nombre = nombre;
            Ram = ram;
        }
    }
}
