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
    public partial class frmConsultaLibros : Form
    {
        Dictionary<string, Libro> dicLibro;

        public frmConsultaLibros(Dictionary<string, Libro> d)
        {
            InitializeComponent();
            dicLibro = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            foreach(string isbn in dicLibro.Keys)
            {
                Libro libro = dicLibro[isbn];
                dgvConsultaLibros.Rows.Add(isbn, libro.pNombre, libro.pAutor, libro.pEditorial, libro.pExistencia, libro.pUso);
            }
            dgvConsultaLibros.AutoResizeColumns();
        }
    }
}
