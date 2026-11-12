namespace Archivos
{

    class Foo : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Estoy cerrado!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inicio");

            using (Foo f = new Foo())
            {
                Console.WriteLine("Procesando Foo");
            }
                Console.WriteLine("Fin");


            //string directory;
            //string separator;
            //string fullName;
            //StreamWriter s;
            //// If only use Windows, you don’t need to do this
            //if (Environment.OSVersion.Platform == PlatformID.Unix)
            //{
            //    directory = Environment.GetEnvironmentVariable("HOME");
            //    separator = "/";
            //}
            //else
            //{
            //    directory = Environment.GetEnvironmentVariable("homepath");
            //    separator = "\\";
            //}
            //fullName = directory + separator + "testfile.txt";
            //Console.WriteLine(fullName);
            //// Open File
            //using (s = new StreamWriter(fullName))
            //{

            //    // Write File
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        s.Write("{0,-2}", i);
            //    }
            //    s.WriteLine();
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        s.WriteLine($"Line :{i,3}");
            //    }
            //}


            // Close File. Needs try-catch.
            ////s.Close();


            //string query = "My user path is %HOMEDRIVE%%HOMEPATH% " + "and my architechture is %PROCESSOR_ARCHITECTURE%";
            //string str = Environment.ExpandEnvironmentVariables(query);
            //Console.WriteLine(str);





        }
    }
}
