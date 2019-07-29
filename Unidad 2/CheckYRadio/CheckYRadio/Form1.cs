using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckYRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFavorita_Click(object sender, EventArgs e)
        {
            string favorita = "";
            if (rdAccion.Checked)
                favorita = "Acción";
            if (rdComedia.Checked)
                favorita = "Comedia";
            if (rdAnimadas.Checked)
                favorita = "Animadas";
            if (rdCienciaF.Checked)
                favorita = "Ciencia Ficción";
            MessageBox.Show(favorita);
        }

        private void grpRadio_Enter(object sender, EventArgs e)
        {

        }

        private void btnPreferidas_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            if (chkAccion.Checked)
                seleccion += "Accion ";
            if (chkComedia.Checked)
                seleccion += "Comedia ";
            if (chkAnimadas.Checked)
                seleccion += "Animadas ";
            if (chkCienciaF.Checked)
                seleccion += "Ciencia Ficción ";
            MessageBox.Show(seleccion);
        }
    }
}
