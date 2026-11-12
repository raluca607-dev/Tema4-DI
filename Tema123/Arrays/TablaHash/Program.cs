namespace TablaHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> edades = new Dictionary<string, int>();

            // Introducir elementos (calve, valor) La clave tiene q ser única
            edades.Add("Ana", 20);
            edades.Add("Juan", 31);
            edades.Add("Pablo", 2);
            edades.Add("Maria", 12);

            // Mostrar un elemento mediante hashing
            Console.WriteLine("Ana tiene {0} años", edades["Ana"]);

            // Recorrer la colección pares clave/valor
            foreach (KeyValuePair<String, int> de in edades)
            {
                Console.WriteLine("{0} tiene {1} años", de.Key, de.Value);
            }

            // Recorrer la colección solo de valores
            foreach (int de in edades.Values)
            {
                Console.WriteLine(de);
            }

            // Recorrer la colección solo de claves
            foreach (string de in edades.Keys)
            {
                Console.WriteLine(de);
            }
        }
    }
}
