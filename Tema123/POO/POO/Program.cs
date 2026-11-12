namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Perro objPerro = new Perro();
            objPerro.raza = "Mastín";
            objPerro.nombre = "Laika";
            //objPerro.setEdad(5);
            objPerro.Edad = 2; //equivalente al ""objPerro.setEdad(5)"";
            // el 2 pasa a ser el value en el set
            Console.WriteLine(objPerro.Edad); 
            Console.ReadLine(); 
        }
    }
}
