using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    internal class Planeta : Astro, ITerraformable
    {
      //  private bool gaseoso;
        private int satelites;
        public bool Gaseoso { set; get; }
        //{
        //    set
        //    {
        //        gaseoso = value;
        //    }
        //    get
        //    {
        //        return gaseoso;
        //    }
        //}

        public int Satelites
        {
            set
            {
                if (value < 0)
                {
                    satelites = 0;
                }
                else
                {
                    satelites = value;
                }
            }
            get
            {
                return satelites;
            }
        }

        public Planeta(string nombre, double radio, bool gaseoso, int satelites) : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.Satelites = satelites;
        }
        public Planeta() : this("", 1, false, 0)
        {
        }
        public bool esHabitable()
        {
            if (this.Gaseoso && (this.Radio > 2000 && this.Radio < 8000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,10},{1,4}, {2:.00}", this.Nombre, this.Satelites, this.Radio);
        }

        public static Planeta operator ++(Planeta p)
        {
            p.Satelites++;
            return p;
        }

        public static Planeta operator --(Planeta p)
        {
            if (p.Satelites == 0)
            {
                return p;
            }
            else
            {
                p.Satelites--;
                return p;
            }
        }


    }
}
