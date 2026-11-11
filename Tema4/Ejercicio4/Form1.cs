using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarLabels();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String texto = txtAdd.Text;

            if (texto != "" && !listBoxMulti.Items.Contains(texto))
            {
                listBoxMulti.Items.Add(texto);
            }
            ActualizarLabels();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (rblista1.Checked)
            {
                if (listBoxMulti.SelectedItems.Count > 0)
                {

                    for (int i = listBoxMulti.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        listBoxMulti.Items.Remove(listBoxMulti.SelectedItems[i]);
                    }
                }
            }
            else if (rbLista2.Checked)
            {
                if (listBoxUnica.SelectedIndex != -1)
                {
                    listBoxUnica.Items.RemoveAt(listBoxUnica.SelectedIndex);
                }
            }
            ActualizarLabels();

        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (sender is RadioButton rb)
            {
                if (rb == rblista1 || rb == rbLista2)
                {
                    buttonQuitar.Text = "Eliminar de " + rb.Tag;
                }
                else
                {
                    buttonQuitar.Text = "Eliminar";
                }

                if (rb == rb1a2 || rb == rb2a1)
                {
                    buttonTrasp.Text = "Traspaso " + rb.Tag;
                }
                else
                {
                    buttonQuitar.Text = "Traspasar";
                }
            }
            ActualizarLabels();


        }
        private void buttonTrasp_Click(object sender, EventArgs e)
        {

            if (rb1a2.Checked)
            {
                if (listBoxMulti.SelectedItems.Count > 0)
                {
                    for (int i = listBoxMulti.SelectedItems.Count - 1; i >= 0; i--)
                    {

                        listBoxUnica.Items.Add(listBoxMulti.SelectedItems[i]);
                        listBoxMulti.Items.Remove(listBoxMulti.SelectedItems[i]);

                    }
                }
            }
            else if (rb2a1.Checked)
            {
                if (listBoxUnica.SelectedIndex != -1)
                {
                    listBoxMulti.Items.Add(listBoxUnica.SelectedItem);
                    listBoxUnica.Items.Remove(listBoxUnica.SelectedItem);

                }
            }

            ActualizarLabels();

        }

        private void ActualizarLabels()
        {
            String texto1 = listBoxMulti.Items.Count.ToString();

            String texto2 = "Índices: ";

            for (int i = 0; i < listBoxMulti.SelectedItems.Count; i++)
            {
                texto2 += listBoxMulti.SelectedIndices[i] + " ";
            }

            if (listBoxMulti.SelectedItems.Count == 0)
            {
                lbl2.Text = "La lista no tiene nongún indice seleccionado";

            }
            else
            {
                lbl2.Text = $"La lista 1 tiene seleccionados los índices {texto2}";

            }
            lbl1.Text = $"La lista 1 contiene {texto1} elementos";

            toolTip1.SetToolTip(listBoxUnica, "Elementos: " + listBoxUnica.Items.Count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMulti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLabels();

        }

        private static String titulo = "Ejercicio 4";
        private static int contTitulo = titulo.Length;
        private static int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            String tituloFinal = titulo.Substring(contTitulo);
            this.Text = tituloFinal;
            contTitulo--;


            if (cont % 2 == 0)
            {
                this.Icon = Properties.Resources.Icono1;
            }
            else
            {
                this.Icon = Properties.Resources.icono2;
            }


            if (contTitulo < 0)
            {
                contTitulo = titulo.Length;

                cont++;
            }
        }
    }
}
