using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    internal class Cometa : Astro , ITerraformable
    {
        public Cometa(string nombre,double radio) : base(nombre,radio) { }
        public Cometa() : base()
        {

        }
        public bool esHabitable()
        {
            return false;
        }

    }
}
