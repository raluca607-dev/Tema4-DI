using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Aceptar";
            BackColor = Color.MistyRose;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "Cancelar";
            BackColor = Color.FromArgb(23,53,134);
        }
    }
}
