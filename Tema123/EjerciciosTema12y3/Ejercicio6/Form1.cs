using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Quieres poner \"" + textBox1.Text + "\" como titulo?","Titulo" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(a== DialogResult.Yes)
            {
               this.Text = textBox1.Text;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
