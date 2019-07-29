using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String datos = "Usuario" + txtNombreU.Text + "Password " + txtPassword.Text;
            lblDatos.Text = datos;

            MessageBox.Show("Accediendo", "Ingreso", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Error);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreU.Text = "";
            txtPassword.Text = "";
            lblDatos.Text = "";
        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
