using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Ordenador> ordenadores = new Dictionary<string, Ordenador>();

            int opcion = 0;
            int seleccion = -1;
            do
            {
                seleccion = -1;
                opcion = 0;
                //opcional

                string[] opiciones = { "1. Añadir nuevo equipo", "2. Añadir varios equipos", "3. Elimina un dato por clave", "4. Muestra la lista de nombres", "5. Muestra un elemento de la coleccion a partir de la clave", "6. Salir" };
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
                switch (seleccion)
                {
                    case 1:
                        NuevoEquipo(ordenadores);
                        Espera();
                        break;
                    case 2:
                        VariosEquipos(ordenadores);
                        Espera();

                        break;
                    case 3:
                        EliminarEquipo(ordenadores);
                        Espera();

                        break;
                    case 4:
                        MostrarNombres(ordenadores);
                        Espera();

                        break;
                    case 5:
                        MostrarEquipo(ordenadores);
                        Espera();

                        break;
                    case 6:
                        Console.WriteLine("Hasta Luego!");
                        break;
                }


            } while (seleccion != 6);
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
        static void NuevoEquipo(Dictionary<string, Ordenador> ordenadores)
        {
            bool valido = true;
            string? ip;
            string nombre;
            int ram;
            do
            {
                valido = true;
                Console.WriteLine("Dime la ip del equipo: ");
                ip = Console.ReadLine();
                if (!Ordenador.IpValida(ip))
                {
                    Console.WriteLine("Ip no válida.");
                    valido = false;
                }
                else if (ordenadores.ContainsKey(ip))
                {
                    Console.WriteLine("La ip ya existe.");
                    valido = false;
                }

            }
            while (!valido);

            do
            {
                valido = true;
                Console.WriteLine("Dime un nombre para el equipo: ");
                nombre = Console.ReadLine().Trim();
                if (nombre == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío");
                    valido = false;
                }

            }
            while (!valido);

            do
            {

                Console.WriteLine("Ahora dime la cantidad de RAM del equipo: ");
                if (!int.TryParse(Console.ReadLine().Trim(), out ram))
                {
                    Console.WriteLine("La RAM tiene que ser un número entero.");
                }
                else if (ram < 0)
                {
                    Console.WriteLine("La RAM tiene que ser mayor que 0.");
                    valido = false;
                }
                else
                {
                    valido = true;
                }
            }
            while (!valido);

            Ordenador ord = new Ordenador(nombre, ram);
            ordenadores.Add(ip, ord);
        }
        static void VariosEquipos(Dictionary<string, Ordenador> ordenadores)
        {
            bool valido = true;
            string datos;
            string[] equipo;
            string ip = "";
            int ram;
            do
            {
                valido = true;
                Console.WriteLine("Introduce los equipos (ip1:ram1,ip2:ram2...) : ");
                datos = Console.ReadLine();
                equipo = datos.Split(',');


                List<string> ips = new List<string>();
                Dictionary<string, Ordenador> equipos = new Dictionary<string, Ordenador>();
                for (int i = 0; i < equipo.Count(); i++)
                {

                    string[] ord = equipo[i].Split(':');
                    //Comprobación ip

                    if (!Ordenador.IpValida(ord[0]))
                    {
                        Console.WriteLine("La ip " + (i + 1) + " no es válida");
                        valido = false;
                    }
                    else if (ips.Contains(ord[0]) || ordenadores.ContainsKey(ord[0]))
                    {
                        valido = false;
                        Console.WriteLine("La ip " + (i + 1) + " ya existe. Las ip's no pueden repetirse");
                    }
                    else
                    {
                        ip = ord[0];
                        ips.Add(ip);
                    }
                    //Comprobación RAM
                    if (!int.TryParse(ord[1], out ram))
                    {
                        Console.WriteLine("La ram " + (i + 1) + " no es un entero válido");
                        valido = false;

                    }
                    else if (ram < 0)
                    {
                        valido = false;
                        Console.WriteLine("La ram " + (i + 1) + " no puede ser menor que 0");
                    }

                    //1.1.1.1:3,1.1.1.1:2
                }
                if (valido)
                {
                    for (int i = 0; i < equipo.Count(); i++)
                    {
                        string[] ord = equipo[i].Split(':');
                        ip = ord[0];
                        int.TryParse(ord[1], out ram);
                        string nombre = "NONAME_" + ord[0];

                        if (valido)
                        {
                            Ordenador nuevoEquipo = new Ordenador(nombre, ram);
                            ordenadores.Add(ip, nuevoEquipo);
                        }
                    }
                }

            }
            while (!valido);
        }
        static void EliminarEquipo(Dictionary<string, Ordenador> ordenadores)
        {
            Console.WriteLine("Introduce la IP del equipo que quieres eliminar:");
            string ip = Console.ReadLine();

            if (ordenadores.ContainsKey(ip))
            {
                if (ordenadores.Remove(ip))
                {
                    Console.WriteLine("Equipo eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("El equipo no se pudo eliminar");
                }
            }
            else
            {
                Console.WriteLine("No existe ningún equipo con esa IP.");
            }
        }
        static void MostrarNombres(Dictionary<string, Ordenador> ordenadores)
        {
            foreach (Ordenador ord in ordenadores.Values)
            {
                Console.WriteLine(ord.Nombre);
            }
        }
        static void MostrarEquipo(Dictionary<string, Ordenador> ordenadores)
        {
            Console.WriteLine("Introduce la IP del equipo:");
            string ip = Console.ReadLine();

            if (ordenadores.ContainsKey(ip))
            {
                Console.WriteLine("Nombre: " + ordenadores[ip].Nombre);
                Console.WriteLine("RAM: " + ordenadores[ip].Ram);
            }
            else
            {
                Console.WriteLine("El equipo no existe.");
            }
        }
        static void Espera()
        {
            Console.WriteLine("Pulsa una tecla para contnuar...");
            Console.ReadKey();
        }
    }
}
