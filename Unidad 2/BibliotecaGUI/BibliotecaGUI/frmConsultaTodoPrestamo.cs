using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGUI
{
    public partial class frmConsultaTodoPrestamo : Form
    {
        List<Prestamo> prestamos;
        public frmConsultaTodoPrestamo(List<Prestamo> p)
        {
            InitializeComponent();
            prestamos = p;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaTodoPrestamo_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            foreach(var item in prestamos)
            {
                Prestamo pres = item;
                dgvConsultaTodo.Rows.Add(pres.pCodigo, pres.pUsuario, pres.pNombreU, pres.pDomicilio, pres.pLibro, pres.pFecha);
            }
            dgvConsultaTodo.AutoResizeColumns();
        }
    }
}
