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
    public partial class frmReporteAlumnos : Form
    {
        public frmReporteAlumnos()
        {
            InitializeComponent();
        }

        private void ReporteAlumnos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'DataSet1.ReporteAlumnos' table. You can move, or remove it, as needed.
            this.ReporteAlumnosTableAdapter.Fill(this.DataSet1.ReporteAlumnos);

            this.reportViewer1.RefreshReport();
        }
    }
}
