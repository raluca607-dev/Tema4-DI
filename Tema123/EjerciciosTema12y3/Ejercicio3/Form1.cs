
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random numero = new Random();
        public (int num1, int num2, int num3) aleatorio()
        {
            return (numero.Next(1, 8), numero.Next(1, 8), numero.Next(1, 8));
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int credito = Convert.ToInt32(label2.Text);
            credito = credito - 2;
            var numeros = aleatorio();

            textBox1.Text = numeros.num1.ToString();
            textBox2.Text = Convert.ToString(numeros.num2);
            textBox3.Text = Convert.ToString(numeros.num3);

            int n1 = numeros.num1;
            int n2 = numeros.num2;
            int n3 = numeros.num3;

            if (n1 == n2 && n2 == n3)
            {
                credito = credito + 20;
                label1.Text = "Premio de 20€!";
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
#if PRUEBA

                credito = credito - 5;
#else
                credito = credito + 5;

#endif
                label1.Text = "Premio de 5€!";

            }
            else
            {
                label1.Text = "No hay premio :(";
            }
            label2.Text = credito.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int credito = Convert.ToInt32(label2.Text);
            credito = credito + 10;
            label2.Text = credito.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
