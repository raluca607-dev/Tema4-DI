using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExamen
{
    internal class Record
    {
        public string nombre { set; get; }
        private int edad;
        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return edad;
            }
        }
        public int puntuacion { set; get; }

        public Record(string nombre, int edad, int puntuacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.puntuacion = puntuacion;
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}", nombre, edad, puntuacion);
        }

    }
}
