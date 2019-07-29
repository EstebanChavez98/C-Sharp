using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BibliotecaGUI
{
    public partial class Principal : Form
    {

        //Hashtable HLibros = new Hashtable();

        Dictionary<string, Libro> dicLibros = new Dictionary<string, Libro>();
        List<Prestamo> listPrestamos = new List<Prestamo>();
        public Principal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaLibros altaLibros = new frmAltaLibros(dicLibros);
            altaLibros.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaLibros consultaL = new frmConsultaLibros(dicLibros);
            consultaL.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dicLibros.Keys.Count > 0)
            {
                frmPrestamoLibros prestamo = new frmPrestamoLibros(dicLibros, listPrestamos);
                prestamo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay libros, registre algun libro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTodoPrestamo consultaTodo = new frmConsultaTodoPrestamo(listPrestamos);
            consultaTodo.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFecha consultaIndividual = new txtFecha(listPrestamos);
            consultaIndividual.ShowDialog();
        }
    }
}
