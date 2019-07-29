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
    public partial class frmConsultaAutos : Form
    {
        Dictionary<string, Marca> dicMarca;
        List<Auto> auto;
        public frmConsultaAutos(Dictionary<string, Marca> d, List<Auto> a)
        {
            InitializeComponent();
            dicMarca = d;
            auto = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaAutos_Load(object sender, EventArgs e)
        {
                foreach(var item1 in auto)
                {
                    Auto autos = item1;
                    dgvConsultaAuto.Rows.Add(autos.pNumSerie, autos.pNombre, autos.pManejo, autos.pClave, autos.pPasajeros);
                }
        }
    }
}
