namespace Tema1
{
    internal class Program
    {
        static void suma(int a, int b, out int c)
        {
            c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {


            int res;
            suma(12, 34,out res);
            Console.WriteLine("Resultado: {0}", res);

        }
    }
}
