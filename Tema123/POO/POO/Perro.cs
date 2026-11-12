using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    internal class Perro
    {
        public string Raza { set; get; }//los elementos publicos 
        //automáticamente se crean asi
        public string nombre;

        private int _edad; //parte privada en minuscula con _
        // Nota: aunque lo veas así en este ejemplo,
        // en C# NO haremos el set y el get de esta forma.
        // La correcta se explica en un apartado posterior.

        public int Edad // parte publica en mayuscula
        {
            set
            {
                if (value<0)
                {
                    _edad = 0;
                }
                else
                {
                    _edad = value;
                }
            }
            get
            {
                return this._edad;
            }
        }
        //public int getEdad()
        //{
        //    return edad;
        //}
        //public void setEdad(int edad)
        //{
        //    this.edad = edad;
        //}

        public Perro()
        {
            this.Edad = 0;
            this.raza = "";
            this.nombre = "";
        }

    }
}
