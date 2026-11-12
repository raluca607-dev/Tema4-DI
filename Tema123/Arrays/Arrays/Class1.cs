using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] bi = new int[3, 5]; // OJO, cambia respecto a Java.
            Random g = new Random();
            Console.WriteLine("Array bidimensional");
            for (i = 0; i < bi.GetLength(0); i++) // Cantidad de filas
            {
                for (j = 0; j < bi.GetLength(1); j++) // Cantidad de columnas
                {
                    bi[i, j] = g.Next(1, 21);
                }
            }
            for (i = 0; i <= bi.GetUpperBound(0); i++) // Limite superior de filas
            {
                for (j = 0; j <= bi.GetUpperBound(1); j++) //Limite superior de columnas
                {
                    Console.Write("{0,3}", bi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("El nº de dimensiones del array es {0}", bi.Rank);
        }
    }
}
