
namespace Ejercicio5
{ // Arreglé el fallo del ejercicio 4
    internal class Program
    {
        static void Main(string[] args)
        {

#if PRUEBA
            int res = 0;
            Factorial(5, ref res);
            Console.WriteLine("Resultado: {0}", res);
#else
            Asteriscos(9);
#endif
            Console.ReadLine();
        }
        static bool Factorial(int num, ref int res)
        {
            res = 1;
            if (num <= 0 || num > 10)
            {
                return false;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    res *= i;
                }
                return true;
            }
        }

        static Random aleatorio = new Random();
        static void Asteriscos(int cantidad = 10)
        {
            for (int i = 0; i < cantidad; i++)
            {
                int fila = aleatorio.Next(1, 11);
                int columna = aleatorio.Next(1, 21);

                Console.SetCursorPosition(columna, fila);
                Console.Write("*");

            }

            Console.SetCursorPosition(0, 13);
        }
    }
}

