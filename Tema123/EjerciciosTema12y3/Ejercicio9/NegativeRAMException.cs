using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    internal class NegativeRAMException : Exception
    {
        public NegativeRAMException() :base("La memoria RAM debe ser mayor que 0"){
        }
    }
}
