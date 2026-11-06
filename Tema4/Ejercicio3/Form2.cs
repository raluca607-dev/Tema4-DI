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
    public partial class Form2 : Form//TODO control de imagen correcta  
    {
        public Form2(String ruta)
        {
            InitializeComponent();
            try
            {

                pictureBox1.Image = Image.FromFile(ruta);
                this.Text = Path.GetFileName(ruta);
                imagenValida = true;
            }
            catch (OutOfMemoryException ex)
            {
                imagenValida = false;
            }
            catch (FileNotFoundException ex)
            {
                imagenValida = false;
            }
        }
        public bool imagenValida = false;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void sinDeforMaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sin deformar
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
