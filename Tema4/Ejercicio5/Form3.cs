using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Consolas", 10);
            string ruta = "..\\PruebaEjercicio5.txt";
            string nombre;
            string numero;
            string linea;
            try
            {

                using (StreamReader sr = new StreamReader(ruta))
                {
                    linea = sr.ReadLine();
                    while (linea != "" && linea != null)
                    {
                        string[] datos = linea.Split(':');
                        nombre = datos[0];
                        numero = datos[1];

                        //textBox1.Text += String.Format("{0,15}{1,20}\r\n", nombre, numero);
                        textBox1.Text += nombre.PadRight(20);
                        textBox1.Text += numero;
                        textBox1.Text += "\r\n";

                        linea = sr.ReadLine();
                    }
                }
            }
            catch (UnauthorizedAccessException a)
            {

            }
            catch (IOException a)
            {
            }

        }
    }
}
