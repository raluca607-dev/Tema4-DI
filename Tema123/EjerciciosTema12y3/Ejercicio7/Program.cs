namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Planeta
            //Console.WriteLine("\t--- Ejercicio 7 ---");

            //Planeta tierra = new("Tierra", 6378, false, 1);

            //Console.WriteLine("Planeta:");
            //Console.WriteLine(tierra);

            //Console.WriteLine("Es habitable? " + tierra.esHabitable());

            //tierra++;

            //Console.WriteLine("\nDespués de ++:");
            //Console.WriteLine(tierra);


            //tierra--;

            //Console.WriteLine("\nDespués de --:");
            //Console.WriteLine(tierra);

            //tierra.Satelites = 0;
            //tierra--;

            //Console.WriteLine("\nDespués de -- en 0:");
            //Console.WriteLine(tierra.Satelites);

            //Planeta otraTierra = new("Tierra", 5000, true, 20);

            //Console.WriteLine("\nComprobacion entre astros:");
            //Console.WriteLine(tierra.Equals(otraTierra));

            //String nom = "Tierra";
            //String nom2 = "\"TIERRA\"";
            //Console.WriteLine("\nComprobacion nombre:");
            //Console.WriteLine(tierra.Nombre);
            //Console.WriteLine("Nombre 1 : " + nom);
            //Console.WriteLine("Nombre 2 : " + nom2);
            //Console.WriteLine("Comprobación con Nombre 1 : " + tierra.Equals(nom));
            //Console.WriteLine("Comprobación con Nombre 2 : " + tierra.Equals(nom2));


            ////Cometa
            //Cometa cometa = new("Halley", 11);

            //Console.WriteLine("\n Cometa");
            //Console.WriteLine("Nombre: " + cometa.Nombre);
            //Console.WriteLine("Radio: " + cometa.Radio);
            //Console.WriteLine("Es habitable?: " + cometa.esHabitable());

            //try
            //{
            //    Planeta error = new("Prueba", -200, false, 0);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();

            // EJERCICIO 8

            Console.WriteLine("\t--- Ejercicio 8 ---");

            List<Astro> astros = new List<Astro>();
            int opciona = 0;
            bool bandera;
            do
            {
                do
                {
                    Console.WriteLine("\n----- MENÚ -----");
                    Console.WriteLine("1. Añadir Planeta");
                    Console.WriteLine("2. Añadir Cometa");
                    Console.WriteLine("3. Mostrar datos");
                    Console.WriteLine("4. Incrementar/Decrementar satélites");
                    Console.WriteLine("5. Eliminar no terraformables");
                    Console.WriteLine("6. Salir");
                    Console.Write("Selecciona una opción: ");
                    bandera = int.TryParse(Console.ReadLine(), out opciona);
                    if (!bandera)
                    {
                        Console.WriteLine("Eso no es un numero entero, try again.");
                    }
                } while (!bandera);

                switch (opciona)
                {
                    case 1:

                        var plNew = AddPlaneta();
                        Planeta planeta = new(plNew.name, plNew.radio, plNew.gas, plNew.lunas);
                        astros.Add(planeta);
                        break;
                    case 2:
                        var coNew = AddCometa();
                        Cometa cometa = new(coNew.name, coNew.radio);
                        astros.Add(cometa);
                        break;
                    case 3:
                        for (int i = 0; i < astros.Count; i++)
                        {
                            if (astros[i] is Planeta aux)
                            {
                                Console.WriteLine(" El planeta es habitable? :  " + ((Planeta)astros[i]).esHabitable() + "\n" + ((Planeta)astros[i]).ToString());
                            }
                            else if (astros[i] is Cometa)
                            {
                                Console.WriteLine(" El cometa es habitable? : " + ((Cometa)astros[i]).esHabitable() + "\n" + ((Cometa)astros[i]).Nombre);
                            }
                        }
                        break;
                    case 4:
                        string nombre = "\"" + PideNombre("Astro").ToUpper() + "\"";
                        int res = 0;

                        int a = astros.IndexOf(new Planeta(nombre, 0, true, 0)); //mejorar
                        do
                        {
                            Console.WriteLine("Quieres incrementar (\"I\") o decrementar (\"D\") el número de satélites?: ");
                            res = Console.ReadLine().ToUpper() == "I" ? 1 : 2;
                        }
                        while (res < 1 || res > 2);

                        Planeta p = (Planeta)astros[a];

                        if (res == 1)
                        {
                            p++;
                        }
                        else
                        {
                            p--;
                        }


                        break;
                    case 5://ITErraformable
                        for (int i = astros.Count - 1; i >= 0; i--)
                        {
                            if (astros[i] is ITerraformable aux)
                            {

                                if (!aux.esHabitable())
                                {
                                    astros.RemoveAt(i);
                                }
                            }

                        }
                        break;
                    case 6:
                        Console.WriteLine("Gracias. \nHasta luego!");
                        break;
                    default:
                        Console.WriteLine("Eso no es una opción válida");
                        break;
                }

            } while (opciona != 6);

        }

        static string PideNombre(String pedido)
        {
            string name;
            do
            {
                Console.WriteLine("Dime el nombre del " + pedido + ": ");
                name = Console.ReadLine();
            }
            while (name.Trim() == "");
            return name;
        }
        static (bool gas, string? name, double radio, int lunas) AddPlaneta()
        {
            bool gas = true;
            string gas1 = "";
            string? name = "";
            double radio = 0;
            int lunas = 0;
            bool valido;
            do
            {
                //overflow
                    valido = true;
                    Console.WriteLine("El planeta es gaseoso? S/N");
                    gas1 = Console.ReadLine().Trim();
                    if (gas1.Equals("S") || gas1.Equals("s"))
                    {
                        gas = true;
                    }
                    else if (gas1.Equals("N") || gas1.Equals("n"))
                    {
                        gas = false;
                    }
                    Console.WriteLine("Dime el nombre del planeta: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Dime el radio del planeta: ");
                    valido = double.TryParse(Console.ReadLine(), out radio);
                    Console.WriteLine("Dime cuántas lunas tiene: ");
                    valido = int.TryParse(Console.ReadLine(), out lunas);
                
                if (name == null || gas1 == null)
                {
                    valido = false;
                    Console.WriteLine("Uno de los datos es incorrecto");
                    Console.WriteLine("Nombre: " + name + "\nRadio: " + radio + "\nLunas: " + lunas + "\nGaseoso: " + gas);
                }
            }
            while (!valido);
            Console.WriteLine("Nombre: " + name + "\nRadio: " + radio + "\nLunas: " + lunas + "\nGaseoso: " + gas);

            return (gas, name, radio, lunas);


        }
        static (string name, double radio) AddCometa()
        {
            string name = "";
            double radio = 0;
            bool valido = false;
            do
            {
                    valido = true;
                    Console.WriteLine("Dime el nombre del cometa: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Dime el radio del cometa: ");
                    valido = double.TryParse(Console.ReadLine(), out radio);
                if (name == null)
                {
                    valido = false;
                    Console.WriteLine("Uno de los datos es incorrecto");
                    Console.WriteLine("Nombre: " + name + "\nRadio: " + radio);
                }
            }
            while (!valido);
            Console.WriteLine("Nombre: " + name + "\nRadio: " + radio);

            return (name, radio);
        }
    }
}
