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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|Todos los archivos|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form2 ventana = new Form2(openFileDialog1.FileName);
                
                if (ventana.imagenValida)
                {

                    if (checkBoxModal.Checked)
                    {
                        ventana.ShowDialog();
                    }
                    else
                    {
                        ventana.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede abrir la imágen");
                }
            }
        }

        private void checkBoxModal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModal.Checked)
            {
                checkBoxModal.ForeColor = Color.Red;
            }
            else
            {
                checkBoxModal.ForeColor = Color.Black;
            }
        }

        int segundos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;

            this.Text = "Visor de imágenes " + minutos.ToString("D2") + ":" + segundosRestantes.ToString("D2");
        }
    }
}
