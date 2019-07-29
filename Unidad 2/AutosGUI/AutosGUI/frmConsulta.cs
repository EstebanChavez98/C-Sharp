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
    public partial class frmConsulta : Form
    {

        Dictionary<string, Marca> dictionary;
        public frmConsulta(Dictionary<string, Marca> d)
        {
            InitializeComponent();
            dictionary = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            foreach(string clave in dictionary.Keys)
            {
                Marca m = dictionary[clave];
                dgvConsultas.Rows.Add(clave, m.pNombre, m.pCiudad, m.pDescripcion);
            }
        }
    }
}
