using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaEmpleados
{
    public partial class frmConsultaDepartamento : Form
    {
        List<Departamento> listDep;
        public frmConsultaDepartamento(List<Departamento> dep)
        {
            InitializeComponent();
            listDep = dep;
        }

        private void frmConsultaDepartamento_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
            foreach(var item in listDep)
            {
                Departamento dep = item;
                dgvConsultaDep.Rows.Add(dep.pClaveDep, dep.pNomDep, dep.pJefe);
            }
            dgvConsultaDep.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
