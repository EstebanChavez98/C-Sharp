using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploComboBox
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

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblColor.Text = "Color Seleccionado: " + cmbColores.SelectedItem;
            lblPosicion.Text = "Posición: " + cmbColores.SelectedIndex;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color";
            lblPosicion.Text = "Posición: ";
            cmbColores.Text = "";
        }
    }
}
