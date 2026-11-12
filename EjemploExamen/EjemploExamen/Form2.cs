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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            for (int i = 18; i <= 100; i++)
            {
                cboEdad.Items.Add(i);
            }
        }

        private void btnAceptar_Enter(object sender, EventArgs e)
        {
            Button boton=(Button)sender;
            boton.BackColor= Color.LightBlue;
        }

        private void btnAceptar_Leave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = SystemColors.Control;
        }
    }
}
