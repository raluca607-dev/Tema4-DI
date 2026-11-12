using System.Numerics;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int seleccion = -1;

            GestorMatriz gm = new GestorMatriz();
            do
            {
                opcion = 0;
                seleccion = -1;
                string[] opciones = { "1. MOSTRAR TABLA", "2. MOSTRAR MEDIAS", "3. MOSTRAR SUMA DE 1 FILA","4. MOSTRAR SUMA DE 1 COLUMNA",
                    "5. INCREMENTO ALEATORIO","6. CAMBIAR MATRIZ","7. SALIR" };
                Console.CursorVisible = false;
                PintaMenu(opciones, opcion);
                do
                {
                    ConsoleKeyInfo tecla = Console.ReadKey();
                    switch (tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            opcion = opcion < opciones.Length - 1 ? opcion + 1 : opcion;
                            break;
                        case ConsoleKey.UpArrow:
                            opcion = opcion > 0 ? opcion - 1 : opcion;
                            break;
                        case ConsoleKey.Enter:
                            seleccion = opcion;
                            break;
                        case ConsoleKey.Escape:
                            seleccion = opciones.Length - 1;
                            break;
                    }

                    PintaMenu(opciones, opcion);
                    if (seleccion != 1)
                    {
                        Console.WriteLine("opcion elegida : {0}", seleccion + 1);
                    }
                }
                while (seleccion == -1);
                seleccion++;

                switch (seleccion)
                {
                    case 1:
                        MostrarTabla(gm);
                        EsperaTecla();
                        break;

                    case 2:
                        MostrarMedias(gm);
                        EsperaTecla();
                        break;

                    case 3:
                        SumaFila(gm);
                        EsperaTecla();
                        break;

                    case 4:
                        SumaColumna(gm);
                        EsperaTecla();
                        break;

                    case 5:
                        IncrementoAleatorio(gm);
                        EsperaTecla();
                        break;

                    case 6:
                        var matNueva = CambiarMatriz();
                        gm = new GestorMatriz(matNueva.Item1, matNueva.Item2);
                        break;

                    case 7:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        break;
                }


            }
            while (seleccion != 7);


        }
        static void PintaMenu(string[] opciones, int opcion)
        {
            Console.Clear();
            Console.WriteLine("----- MENÚ -----");
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }

                Console.WriteLine(opciones[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void MostrarTabla(GestorMatriz gm)
        {

            GestorMatriz.MostrarMatriz(gm.Matriz);
        }

        static void MostrarMedias(GestorMatriz gm)

        {
            double[] vectorTemp = gm.Medias(true);

            //Usar vectores auxiliares
            Console.WriteLine("\"MEDIAS DE FILAS:");
            for (int i = 0; i < vectorTemp.Count(); i++)
            {
                Console.Write("{0,7}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < vectorTemp.Count(); i++)
            {
                Console.Write("{0,7:.00}", vectorTemp[i]);
            }
            Console.WriteLine();


            vectorTemp = gm.Medias(false);

            Console.WriteLine("\"MEDIAS DE COLUMNAS:");
            for (int i = 0; i < vectorTemp.Count(); i++)
            {
                Console.Write("{0,7}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < vectorTemp.Count(); i++)
            {
                Console.Write("{0,7:.00}", vectorTemp[i]);
            }

            Console.WriteLine();

        }

        static void SumaFila(GestorMatriz gm)
        {
            int l;
            bool valido = true;
            do
            {

                do
                {
                    valido = true;
                    Console.WriteLine("Dime una fila del 0 al {0}", gm.Matriz.GetUpperBound(0));
                    if (!int.TryParse(Console.ReadLine(), out l))
                    {
                        Console.WriteLine("Número no válido");
                        valido = false;
                    }
                }
                while (!valido);
                var sum = gm.SumaFila(l);
                if (sum.Item2)
                {
                    Console.WriteLine("La suma de los elementos de la fila {0} es:\n{1}", l, sum.Item1);
                }
                else
                {
                    valido = false;
                    Console.WriteLine("No se puede hacer la suma, el número de fila está fuera de rango.");
                }
            }
            while (!valido);

        }

        static void SumaColumna(GestorMatriz gm)
        {
            int c;
            bool valido = true;
            do
            {

                do
                {
                    valido = true;
                    Console.WriteLine("Dime una columna del 0 al {0}", gm.Matriz.GetLength(1) - 1);
                    if (!int.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Número no válido");
                        valido = false;
                    }
                }
                while (!valido);

                int res;
                if (gm.SumaColumna(c, out res))
                {
                    Console.WriteLine("La suma de los elementos de la columna {0} es:\n{1}", c, res);
                }
                else
                {
                    valido = false;
                    Console.WriteLine("No se puede hacer la suma, el número de columna está fuera de rango.");
                }
            }
            while (!valido);
        }

        static void IncrementoAleatorio(GestorMatriz gm)
        {
            double[,] nuevoArray = new double[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];

            Random r = new Random();

            for (int i = 0; i < nuevoArray.GetLength(0); i++)
            {
                for (int j = 0; j < nuevoArray.GetLength(1); j++)
                {
                    nuevoArray[i, j] = r.NextDouble() * 10 + 1;
                }
            }
            Console.WriteLine("MATRIZ PRINCIPAL:");
            GestorMatriz.MostrarMatriz(gm.Matriz);
            Console.WriteLine("\nMATRIZ NUEVA:");
            GestorMatriz.MostrarMatriz(nuevoArray);


            Console.WriteLine("\nMATRICES SUMADAS:");
            GestorMatriz.MostrarMatriz(gm.SumaMatriz(nuevoArray));



        }

        static (int, int) CambiarMatriz()
        {
            int c;
            int l;
            bool valido = true;

            do
            {
                valido = true;
                Console.WriteLine("Dime un número para las filas");
                if (!int.TryParse(Console.ReadLine(), out l))
                {
                    Console.WriteLine("Número no válido");
                    valido = false;
                }
            }
            while (!valido);

            do
            {
                valido = true;
                Console.WriteLine("Dime un número para las columnas");
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Número no válido");
                    valido = false;
                }
            }
            while (!valido);
            return (l, c);

        }

        static void EsperaTecla()
        {
            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
