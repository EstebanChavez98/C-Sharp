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
    public partial class frmReporteRegAct : Form
    {
        public frmReporteRegAct()
        {
            InitializeComponent();
        }

        private void frmReporteRegAct_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'DataSet1.ReporteRegActividad' table. You can move, or remove it, as needed.
            this.ReporteRegActividadTableAdapter.Fill(this.DataSet1.ReporteRegActividad);

            this.reportViewer1.RefreshReport();
        }
    }
}
