using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, Func<double, double, double>> tabla;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabla = new Dictionary<string, Func<double, double, double>>();

            tabla.Add("+", ((num1, num2) => num1 + num2));
            tabla.Add("-", ((num1, num2) => num1 - num2));
            tabla.Add("*", ((num1, num2) => num1 * num2));
            tabla.Add("/", ((num1, num2) => num1 / num2));

        }
        private string simbolo = "+";

        private void radioSuma_CheckedChanged(object sender, EventArgs e)
        {

            if (sender is RadioButton rb)
            {
                if (rb.Text == "+")
                {
                    label1.Text = "+";
                    simbolo = "+";
                }
                else if (rb.Text == "-")
                {
                    label1.Text = "-";
                    simbolo = "-";

                }
                else if (rb.Text == "*")
                {
                    label1.Text = "*";
                    simbolo = "*";

                }
                else if (rb.Text == "/")
                {
                    label1.Text = "/";
                    simbolo = "/";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = true;
            double num1;
            double num2;
            if (!double.TryParse(textBox1.Text, out num1))
            {

                valido = false;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {

                valido = false;
            }

            double resultado = 0;

            if (valido)
            {

                if (radioSuma.Checked)
                {

                    resultado = tabla[simbolo](num1, num2);

                }
                else if (radioResta.Checked)
                {
                    resultado = tabla[simbolo](num1, num2);

                }
                else if (radioMultiplicacion.Checked)
                {
                    resultado = tabla[simbolo](num1, num2);

                }
                else if (radioDivision.Checked)
                {
                    if (num2 != 0)
                    {
                        resultado = tabla[simbolo](num1, num2);

                    }
                    else
                    {
                        label2.Text = "=";

                    }

                }
                label2.Text = "= " + resultado.ToString();
            }
            else
            {
                label2.Text = "=";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tx)
            {

                if (!double.TryParse(tx.Text, out double num))
                {
                    tx.BackColor = Color.LightPink;
                }
                else
                {
                    tx.BackColor = SystemColors.Window;
                }
            }
        }
    }
}
