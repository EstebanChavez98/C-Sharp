using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class frmReporteActividades : Form
    {
        public frmReporteActividades()
        {
            InitializeComponent();
        }

        private void ReporteActividades_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'DataSet1.Actividades' table. You can move, or remove it, as needed.
            this.ActividadesTableAdapter.Fill(this.DataSet1.Actividades);

            this.reportViewer1.RefreshReport();
        }
    }
}
