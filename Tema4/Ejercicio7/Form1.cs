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

        private Dictionary<string,Func<double,double,double>> tabla;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabla = new Dictionary<string, Func<double, double, double>>();

            tabla.Add("+",((num1,num2)=>num1+num2));
            tabla.Add("-", ((num1, num2) => num1 - num2));
            tabla.Add("*", ((num1, num2) => num1 * num2));
            tabla.Add("/", ((num1, num2) => num1 / num2));

        }

    }
}
