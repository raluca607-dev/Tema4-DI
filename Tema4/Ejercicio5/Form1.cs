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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            String[] datos = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#", "Reset" };
            int x = 30;
            int y = 75;
            int cont = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Button boton = new Button();

                    boton.Text = datos[cont];
                    boton.Size = new Size(60, 50);
                    boton.Location = new Point(x, y);
                    boton.BackColor = Color.LightCyan;

                    this.Controls.Add(boton);
                    cont++;
                    x += 65;
                    boton.Click += Boton_Click;
                    boton.MouseEnter += Form1_MouseEnter;
                    boton.MouseLeave += Form1_MouseLeave;
                    boton.KeyPress += Form1_KeyPress;


                }
                x = 30;
                y += 55;
            }
            Button btnReset = new Button();
            btnReset.Text = datos[cont];
            btnReset.Size = new Size(190, 30);
            btnReset.Location = new Point(x, y);
            btnReset.BackColor = Color.LightCyan;
            this.Controls.Add(btnReset);
            btnReset.Click += BtnReset_Click;
            btnReset.KeyPress += Form1_KeyPress;




        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.LightCyan;
                }
                if (c is TextBox txt)
                {

                    txt.Text = "";
                }
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {

                textBox1.Text += btn.Text;
                btn.BackColor = Color.Thistle;

            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor != Color.Thistle)
                {
                    btn.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                if (btn.BackColor != Color.Thistle)
                {
                    btn.BackColor = Color.LightCyan;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '*' || e.KeyChar == '#')
            {
                textBox1.Text += e.KeyChar;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                if (textBox1.Text.Length!=0)
                {

                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }



        }

        private void itemMenuGrabar_Click(object sender, EventArgs e)
        {
            Form2 nuevo = new Form2();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                if (nuevo.textBox1.Text != "" && textBox1.Text != "")
                {
                    using (StreamWriter sr = new StreamWriter("..\\PruebaEjercicio5.txt", true))
                    {

                        sr.WriteLine(nuevo.textBox1.Text + ":" + textBox1.Text);
                    }
                    MessageBox.Show("GUARDADO");

                }
                else
                {
                    MessageBox.Show("No puede haber campos vacíos");
                }
            }
            nuevo.Dispose();

        }
        private bool abierto = false;

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!abierto)
            {

                Form3 nuevo = new Form3();
                abierto = true;

                nuevo.FormClosed += (s, args) =>// Object Sender , EventArgs e 
                {
                    abierto = false;
                };
                nuevo.Show();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La aplicacion esta mola pila", "Acerca de...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
