using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosTema12y3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int suma(int a, int b, out int c)
        {
            c = a + b;
            return c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            bool valido = false;
            try
            {
                n1 = Convert.ToInt32(textBox1.Text.Trim());
                n2 = Convert.ToInt32(textBox2.Text.Trim());
                valido = true;
            }
            catch (FormatException)
            {
                label2.Text = "= La operacion no es valida";
                valido = false;
            }


            if (valido)
            {
                int res;
                suma(n1, n2, out res);
                label2.Text = "= " + res;
            }
        }
    }
}
