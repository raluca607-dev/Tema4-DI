using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExamen
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            int cont = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (cont < 50)
                    {

                        CheckBox chk = new CheckBox();
                        chk.Text = cont.ToString();
                        chk.Location = new Point(x, y);
                        chk.Name = "chk" + cont.ToString();
                        chk.Size = new Size(30, 30);
                        chk.CheckedChanged += Chk_CheckedChanged;
                        toolTip1.SetToolTip(chk, "No marcado");
                        chk.TabIndex = i;
                        chk.Appearance = Appearance.Button;
                        this.Controls.Add(chk);
                    }
                    x += 65;
                    cont++;
                }
                x = 30;
                y += 40;
            }


        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                toolTip1.SetToolTip(chk, "Marcado");
                chksMarcados++;
            }
            else
            {
                chksMarcados--;

                toolTip1.SetToolTip(chk, "No marcado");
            }
        }
        private int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                BtnSalir.BackColor = Color.Beige;
                BtnJugar.BackColor = Color.Yellow;
            }
            else if (contador == 1)
            {
                BtnJugar.BackColor = Color.Beige;
                BtnReset.BackColor = Color.Yellow;
            }
            else if (contador == 2)
            {
                BtnReset.BackColor = Color.Beige;
                BtnSalir.BackColor = Color.Yellow;
            }
            contador++;
            if (contador == 3)
            {
                contador = 0;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox chk)
                {
                    chk.Checked = false;
                    chk.BackColor = SystemColors.Control;
                }

            }
            lblResultados.Text = "Resultados.";

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Se saldrá de la aplicación", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int chksMarcados = 0;
        private Random r = new Random();
        private int aciertos;
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            aciertos = 0;
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox chk)
                {
                    chk.BackColor = SystemColors.Control;
                }

            }
            int[] numeros = new int[6];

            if (chksMarcados == 6)
            {
                int posicion = 0;
                do
                {
                    int num = r.Next(1, 50);
                    if (!numeros.Contains(num))
                    {
                        numeros[posicion] = num;
                        posicion++;
                    }
                } while (posicion < 6);


                lblResultados.Text = "Resultados";
                foreach (int n in numeros)
                {
                    lblResultados.Text += " - " + n;
                }

                foreach (int i in numeros)
                {
                    foreach (Control cont in this.Controls)
                    {
                        if (cont is CheckBox c)
                        {
                            if ((c.Checked) && (i.ToString() == c.Text))
                            {
                                c.BackColor = Color.Gold;
                                aciertos++;
                            }
                        }
                    }
                }

                if (aciertos >= 1)
                {
                    FrmDatos formularioDatos = new FrmDatos();
                    if (formularioDatos.ShowDialog() == DialogResult.OK)
                    {
                        int edad = 18;
                        string nombre = "";

                        if (formularioDatos.txtNombre.Text != "")
                        {
                            nombre = formularioDatos.txtNombre.Text;
                        }

                        if (formularioDatos.cboEdad.SelectedItem != null)
                        {
                            edad = (int)formularioDatos.cboEdad.SelectedItem;
                        }

                        Record record = new Record(nombre, edad, aciertos);
                        lstNombres.Items.Add(record);
                    }
                    else
                    {
                        BtnReset.PerformClick();
                    }
                    formularioDatos.Dispose();
                }

            }
            else
            {
                MessageBox.Show("Marca exáctamente 6 opciones");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = lstNombres.SelectedItems.Count-1; i >= 0; i--)
            {
                lstNombres.Items.Remove(lstNombres.SelectedItems[i]);
            }
        }
    }
}
