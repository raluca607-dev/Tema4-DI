
namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)//Ejecuta ultima opcion si error
        {
            int opcion = 0;
            int seleccion = -1;
            bool opcionTodas = false;
            bool valido = true;

            do
            {
                seleccion = -1;
                opcion = 0;
                //opcional

                string[] opiciones = { "1. Año bisiesto", "2. Suma de rango", "3. Todas las opciones", "4. Salir" };
                Console.CursorVisible = false;
                PintaMenu(opiciones, opcion);
                do
                {

                    ConsoleKeyInfo tecla = Console.ReadKey();
                    switch (tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            opcion = opcion < opiciones.Length - 1 ? opcion + 1 : opcion;
                            break;
                        case ConsoleKey.UpArrow:
                            opcion = opcion > 0 ? opcion - 1 : opcion;
                            break;
                        case ConsoleKey.Spacebar:
                            seleccion = opcion;
                            break;
                        case ConsoleKey.Enter:
                            seleccion = opcion;
                            break;
                        case ConsoleKey.Escape:
                            seleccion = opiciones.Length - 1;
                            break;

                    }
                    PintaMenu(opiciones, opcion);
                    if (seleccion != -1)
                    {
                        Console.WriteLine("Opción elegida: {0}", seleccion + 1);
                    }

                } while (seleccion == -1); // Última opción Salir

                seleccion++;

                opcionTodas = false;
                switch (seleccion)
                {
                    case 1:
                        OpcionBisiesto();

                        if (opcionTodas)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        OpcionSuma();

                        break;
                    case 3:
                        opcionTodas = true;

                        goto case 1;


                    case 4:
                        Console.WriteLine("Hasta luego!");

                        break;
                    default:
                        if (valido)
                        {
                            Console.WriteLine("Opcion incorrecta.");
                        }
                        break;
                }
                if (seleccion != 4)
                {
                    Console.WriteLine("\nPulsa una tecla para volver al menú. ");
                    Console.ReadKey(true);

                }
                else
                {
                    Console.WriteLine("\nPulsa una tecla para salir. ");
                    Console.ReadKey(true);
                }
            }
            while (seleccion != 4);


        }

        static void OpcionBisiesto()
        {
            int num = PedirNumero("Introduce un número positivo y menor que 10000: ");


            if (Bisiesto(num))
            {
                Console.WriteLine("El año es bisiesto");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                Console.WriteLine();
            }
        }
        static int PedirNumero(string texto)
        {
            int num = 0;
            do
            {
                bool valido = true;
                try
                {
                    Console.Write(texto);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    valido = false;
                    Console.WriteLine("Dato no válido");
                    Console.WriteLine();
                }
                if ((num <= 0 || num >= 10000) && valido)
                {
                    Console.WriteLine("El número no es válido.");
                    Console.WriteLine();
                }

            } while (num <= 0 || num >= 10000);

            return num;
        }

        static bool Bisiesto(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void OpcionSuma()
        {
            int num1 = PedirNumero("Introduce el primer número positivo y menor que 10000: ");
            int num2 = PedirNumero("Introduce el segundo número positivo y menor que 10000: ");

            int? resultado = SumaRango(num1, num2);

            if (resultado == null)
            {
                Console.WriteLine("Error: el primer número no puede ser mayor que el segundo.");
            }
            else
            {
                Console.WriteLine("La suma del rango es: " + resultado);
                Console.WriteLine();
            }
        }
        static int? SumaRango(int primero, int segundo)
        {
            if (primero > segundo)
            {
                return null;
            }

            int suma = 0;

            for (int i = primero; i <= segundo; i++)
            {
                suma += i;
            }

            return suma;
        }
        static void PintaMenu(string[] opciones, int opcion)
        {
            string titulo = "----- MENÚ -----";
            Console.Clear();
            Console.WriteLine(titulo);

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


    }

}
