using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    internal class GestorMatriz
    {
        public int[,] Matriz { get; set; }

        public GestorMatriz(int nfilas, int ncolumnas)
        {
            Matriz = new int[nfilas, ncolumnas];
            Random r = new Random();

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = r.Next(-5, 21);
                }
            }

        }

        public GestorMatriz() : this(3, 4)
        {

        }

        public (int, bool) SumaFila(int fila)
        {
            int suma = 0;
            if (fila >= 0 && fila < Matriz.GetLength(0))
            {
                for (int i = 0; i < Matriz.GetLength(1); i++)
                {
                    suma += Matriz[fila, i];
                }


                return (suma, true);
            }
            else
            {
                return (0, false);

            }

        }

        public bool SumaColumna(int columna, out int suma)
        {
            suma = 0;
            if (columna >= 0 && columna < Matriz.GetLength(1))
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    suma += Matriz[i,columna];//TODO revisar
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public double[,] SumaMatriz(object obj)
        {
            double[,] nuevoArray = new double[Matriz.GetLength(0), Matriz.GetLength(1)];


            if (obj is int[,] matrizInt)
            {
                if (matrizInt.GetLength(0) == Matriz.GetLength(0)
                    && matrizInt.GetLength(1) == Matriz.GetLength(1))
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            nuevoArray[i, j] = matrizInt[i, j] + Matriz[i, j];
                        }
                    }
                    return nuevoArray;
                }
                else
                {
                    throw new MatrizException("Las matrices no tienen el mismo tamaño");
                }
            }
            if (obj is double[,] matrizDouble)
            {
                if (matrizDouble.GetLength(0) == Matriz.GetLength(0)
                    && matrizDouble.GetLength(1) == Matriz.GetLength(1))
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            nuevoArray[i, j] = matrizDouble[i, j] + Matriz[i, j];
                        }
                    }
                    return nuevoArray;
                }
                else
                {
                    throw new MatrizException("Las matrices no tienen el mismo tamaño");
                }
            }
            if (obj is GestorMatriz matrizGestor)
            {
                if (matrizGestor.Matriz.GetLength(0) == Matriz.GetLength(0)
                    && matrizGestor.Matriz.GetLength(1) == Matriz.GetLength(1))
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            nuevoArray[i, j] = matrizGestor.Matriz[i, j] + Matriz[i, j];
                        }

                    }
                    return nuevoArray;
                }
                else
                {

                    throw new MatrizException("Las matrices no tienen el mismo tamaño");

                }
            }

            throw new MatrizException("El objeto pasado como parámeto no es una matriz");


        }

        public double[] Medias(bool foc)
        {
            double media;

            if (foc)
            {//filas
                double[] nuevoArray = new double[Matriz.GetLength(0)];

                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    media = 0;
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        media += Matriz[i, j];
                    }
                    nuevoArray[i] = media / Matriz.GetLength(1);
                }

                return nuevoArray;
            }
            else
            {//columnas
                double[] nuevoArray = new double[Matriz.GetLength(1)];


                for (int i = 0; i < Matriz.GetLength(1); i++)
                {
                    media = 0;
                    for (int j = 0; j < Matriz.GetLength(0); j++)
                    {
                        media += Matriz[j,i];
                    }
                    media = media / Matriz.GetLength(0);
                    nuevoArray[i] = media;
                }

                return nuevoArray;
            }
        }

        public static void MostrarMatriz<T>(T[,] mat)
        {
            char letra = 'A';
            Console.WriteLine("- - - - - - - - MATRIZ - - - - - - - -");
            Console.Write("  ");
            for (int i = 0; i <= mat.GetLength(0); i++)
            {
                Console.Write("{0,7}", i + 1);

            }
            Console.WriteLine();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write("{0,5:.00}", letra);
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0,7:0.00}", mat[i, j]);
                }
                Console.WriteLine();
                letra++;
            }
        }
    }
}
