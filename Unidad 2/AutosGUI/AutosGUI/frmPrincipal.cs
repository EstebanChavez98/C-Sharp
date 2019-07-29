using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosGUI
{
    public partial class frmPrincipal : Form
    {
        Dictionary<string, Marca> dicMarcas = new Dictionary<string, Marca>();
        List<Auto> listAutos = new List<Auto>();
        public frmPrincipal()
        {
            InitializeComponent();
            // inicializar con valores el dictionary
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Form1 frmMarcas = new Form1(dicMarcas);
            frmMarcas.Show();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            if (dicMarcas.Keys.Count > 0)
            {
                frmAuto frmAutos = new frmAuto(dicMarcas, listAutos);
                frmAutos.Show();
            }
            else
                MessageBox.Show("No hay marcas registradas, registre una marca antes de entrar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
