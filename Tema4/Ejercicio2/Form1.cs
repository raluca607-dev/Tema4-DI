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

namespace Ejercicio2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir del formulario?", "Mi formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            int rojo;
            int verde;
            int azul;

            bool valido = true;

            if (!int.TryParse(textBoxRojo.Text, out rojo) || rojo < 0 || rojo > 255)
            {
                valido = false;
            }
            if (!int.TryParse(textBoxVerde.Text, out verde) || verde < 0 || verde > 255)
            {
                valido = false;
            }
            if (!int.TryParse(textBoxAzul.Text, out azul) || azul < 0 || azul > 255)
            {
                valido = false;
            }

            if (valido)
            {
                label4.Text = "";
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
            else
            {
                label4.Text = "Introduce números entre 0 y 255";
            }
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            String imag = textBoxImagen.Text;

            if (File.Exists(imag) && !String.IsNullOrWhiteSpace(imag))
            {
                pictureBox1.ImageLocation = imag;
            }
            else
            {
                MessageBox.Show("No se encontró la ruta.");
                pictureBox1.Image = null;
            }
        }
       
        private void textBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = buttonColor;
        }

       
        private void textBoxImagen_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = buttonImagen;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox t)
                {
                    if (t.Name == textBoxImagen.Name)
                    {
                        t.Text = "";
                    }
                    else
                    {
                        t.Text = "0";
                    }
                }

            }

            this.BackColor = SystemColors.Control;
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button bot)
            {
                bot.BackColor = Color.PowderBlue;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button bot)
            {
                bot.BackColor = SystemColors.Control;
            }
        }

        private void textBoxRojo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
