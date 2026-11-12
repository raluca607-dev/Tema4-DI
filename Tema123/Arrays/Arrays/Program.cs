namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int[,] bi = new int[3, 5]; // OJO, cambia respecto a Java.
            Random g = new Random();
            Console.WriteLine("Array bidimensional");

            //GetLength devuelve la cantidad de elementos de la dimension pasada como parámetro
            for (int i = 0; i < bi.GetLength(0); i++) // Cantidad de filas
            {
                for (int j = 0; j < bi.GetLength(1); j++) // Cantidad de columnas
                {
                    bi[i, j] = g.Next(1, 21);
                }
            }

            //GetUpprBound me da el último índice
            for (int i = 0; i <= bi.GetUpperBound(0); i++) // Limite superior de filas
            {
                for (int j = 0; j <= bi.GetUpperBound(1); j++) //Limite superior de columnas
                {
                    Console.Write("{0,3}", bi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("El nº de dimensiones del array es {0}", bi.Rank);
            //Rank me da el número de dimensiones




           //tablas dentadas
            int[][] tabla = new int[3][];
            tabla[0] = new int[4];
            tabla[1] = new int[2];
            tabla[2] = new int[5];
            for (int i = 0; i < tabla.Length; i++)
            {
                for (int j = 0; j < tabla[i].Length; j++)
                {
                    tabla[i][j] = g.Next(10, 40);
                }
            }
            for (int i = 0; i < tabla.Length; i++)
            {
                for (int j = 0; j < tabla[i].Length; j++)
                {
                    Console.Write("{0,3}", tabla[i][j]);
                }
                Console.WriteLine();
            }


        }
    }
}
