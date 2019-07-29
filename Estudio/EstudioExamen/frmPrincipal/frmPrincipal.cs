using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {

        Dictionary<int, Juego> Juegos = new Dictionary<int, Juego>();
        List<Ventas> Ventas = new List<Ventas>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaJuegos altaJuegos = new frmAltaJuegos(Juegos);
            altaJuegos.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaJuegos consultaJuegos = new frmConsultaJuegos(Juegos);
            consultaJuegos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
