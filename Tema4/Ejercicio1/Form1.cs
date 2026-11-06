using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form//TODO icono. Efecto botones. Tecla, no carácter.
    {
        public Form1()
        {
            InitializeComponent();

            GenerarBotones();

        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (sender is Button boton)
            {
                x += boton.Location.X;
                y += boton.Location.Y;
            }

            Text = String.Format("X: {0,5} , Y: {1,5}", x, y);

        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                izquierda.BackColor = Color.PowderBlue;
            }
            else if (e.Button == MouseButtons.Right)
            {
                derecha.BackColor = Color.PowderBlue;
            }
            else if (e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2 || e.Button == MouseButtons.Middle)
            {
                derecha.BackColor = Color.PowderBlue;
                izquierda.BackColor = Color.PowderBlue;

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                izquierda.BackColor = SystemColors.Control;

            }
            else if (e.Button == MouseButtons.Right)
            {
                derecha.BackColor = SystemColors.Control;

            }
            else
            {
                izquierda.BackColor = SystemColors.Control;
                derecha.BackColor = SystemColors.Control;

            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Escape)
            //{
            //    Text = "Mouse Tester";
            //}
            //else
            //{
            //    Text = String.Format(" {0,5}", e.KeyChar);
            //}
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Text = "Mouse Tester";
            }
            else
            {
                Text = String.Format(" {0,5}", e.KeyCode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerarBotones()
        {
            int x = 35;
            int y = 135;
            int nombre = 1;

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 5; j++)
                {

                    Button bot = new Button();

                    bot.Location = new Point(x, y);
                    bot.Name = "btn" + i.ToString();
                    bot.Size = new Size(75, 25);
                    bot.Text = nombre.ToString();
                    bot.MouseDown += Bot_MouseDown;
                    bot.MouseUp += Bot_MouseUp;
                    bot.MouseMove += Form1_MouseMove;
                    bot.BackColor = Color.LightGray;

                    Controls.Add(bot);

                    x += 80;
                    nombre++;

                }

                x = 35;
                y += 30;
            }

        }

        private void Bot_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button bot)
            {
                bot.BackColor = Color.LightGray;
                bot.ForeColor = Color.Black;
            }
        }

        private void Bot_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button bot)
            {
                bot.BackColor = Color.Pink;
                bot.ForeColor = Color.White;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)

            {
                e.Cancel = true;
            }
        }

    }
}
