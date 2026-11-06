using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        public string[] imagenes;
        public string[] archivos;
        public List<string> listaImagenes = new List<string>();
        private int posicion = 0;
        private string ruta;

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                 ruta = folderBrowserDialog1.SelectedPath;

                //MessageBox.Show("Carpeta seleccionada: " + ruta);

                if (Directory.Exists(ruta))
                {
                    int x = 10;
                    int y = 10;

                    archivos = Directory.GetFiles(ruta);
                    for (int i = 0; i < archivos.Length; i++)
                    {

                        //Compruebo que son imágenes y añado a una lista
                        string extension = Path.GetExtension(archivos[i]).ToLower();
                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                        {
                            listaImagenes.Add(archivos[i]);
                        }
                    }
                    //creo el array con imagenes para mostrarlas
                    imagenes = listaImagenes.ToArray();
                    for (int i = 0; i < imagenes.Length; i++)
                    {
                        try
                        {

                            PictureBox pc = new PictureBox();
                            pc.Image = Image.FromFile(imagenes[i]);
                            pc.Size = new Size(35, 35);
                            pc.SizeMode = PictureBoxSizeMode.Zoom;
                            pc.Location = new Point(x, y);
                            pc.Name = i.ToString();
                            panel1.Controls.Add(pc);
                            pc.Click += Pc_Click;

                            x += 45;
                            if (x + 35 > panel1.ClientSize.Width)
                            {
                                x = 10;
                                y += 45;
                            }

                        }
                        catch (OutOfMemoryException ex)
                        {
                        }

                    }


                    if (imagenes.Length > 0)
                    {
                        pictureBox1.Image = Image.FromFile(imagenes[posicion]);
                        this.Text = "Visor de imagenes " + Path.GetFileName(imagenes[posicion]);
                        actualizar_labels();

                    }



                }
            }
        }

        private void Pc_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pc)
            {
                int.TryParse(pc.Name, out posicion);

                pictureBox1.Image = Image.FromFile(imagenes[posicion]);
                this.Text = "Visor de imagenes " + Path.GetFileName(imagenes[posicion]);
                actualizar_labels();



            }
        }

        private void buttonAvance_Click(object sender, EventArgs e)
        {
            Avance(true);
        }
        private void buttonRetroceso_Click(object sender, EventArgs e)
        {
            Avance(false);

        }

        private void Avance(bool si)
        {

            if (imagenes == null || imagenes.Length == 0)
            {
                return;
            }

            if (si)
            {
                if (posicion < imagenes.Length - 1)
                {
                    posicion++;
                }
            }
            else
            {
                if (posicion > 0)
                {
                    posicion--;
                }
            }


            try
            {
                Image anterior = pictureBox1.Image; // <-
                pictureBox1.Image = Image.FromFile(imagenes[posicion]);
                this.Text = "Visor de imagenes " + Path.GetFileName(imagenes[posicion]);
                actualizar_labels();
                anterior.Dispose(); // para que cuando acabe con la imagen la saque de memoria
            }
            catch (OutOfMemoryException e)
            {
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
            {
                Avance(false);
            }
            else if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
            {
                Avance(true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }


        }

        private void actualizar_labels()
        {
            try
            {
                label1.Text = "Directorio de trabajo: " + Path.GetFullPath(ruta);
                FileInfo fich = new FileInfo(Path.GetFullPath(imagenes[posicion]));
                Image img = Image.FromFile(Path.GetFullPath(imagenes[posicion]));
                label2.Text = String.Format("Datos:\nNombre: {0}\nTamaño: {1}\nResolución: {2}x{3} " ,fich.Name, fich.Length, img.Width, img.Height);
            }
            catch (FileNotFoundException e)
            {

            }
            catch (OutOfMemoryException e)
            {

            }
            catch (ArgumentNullException e)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

