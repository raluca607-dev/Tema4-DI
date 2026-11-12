using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    internal abstract class Astro
    {
        private string nombre;
        private double radio;
        public string Nombre
        {
            set
            {
                nombre = value.ToUpper();
            }
            get
            {
                return "\"" + nombre + "\"";
            }
        }
        public double Radio
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El radio debe ser positivo");
                }
                else
                {
                    radio = value;
                }
            }
            get
            {
                return radio;
            }
        }

        public Astro() : this("Tierra", 6378)
        {

        }
        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }
            if (obj is Astro)
            {
                if (((Astro)obj).Nombre == this.Nombre)
                {
                    return true;
                }
            }
            if (obj.GetType() == typeof(String))
            {
                if ((String)obj == this.Nombre)
                {
                    return true;
                }
            }
            return false;


        }
    }
}
