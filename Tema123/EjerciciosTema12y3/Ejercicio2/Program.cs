#nullable disable
namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int edad;
            double peso;
            Console.WriteLine("Dime tu nombre");
            name = Console.ReadLine();
            Console.WriteLine("Dime tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime tu peso");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nombre:{0,12}, Edad: {1,4} \n\tPeso:{2,5:.0}\n\"{0}\" \\{1}\\",name,edad,peso);

        }
    }
}
