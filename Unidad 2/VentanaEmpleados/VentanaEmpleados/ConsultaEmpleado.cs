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
    public partial class ConsultaEmpleado : Form
    {
        Dictionary<int, Empleado> dicEmp;
        public ConsultaEmpleado(Dictionary<int, Empleado> d)
        {
            InitializeComponent();
            dicEmp = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            foreach(int clave in dicEmp.Keys)
            {
                Empleado m = dicEmp[clave];
                dgvConsultaEmpleado.Rows.Add(clave, m.pNombre, m.pDomicilio, m.pDepartamento, m.pSexo, m.pIdiomass);
            }
            dgvConsultaEmpleado.AutoResizeColumns();
        }
    }
}
