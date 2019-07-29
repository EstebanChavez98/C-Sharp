using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoVentana
{
    public partial class frmConsultas : Form
    {

        Dictionary<long, Alumno> dictionary;
        public frmConsultas(Dictionary<long, Alumno> d)
        {
            InitializeComponent();
            dictionary = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            foreach(long llave in dictionary.Keys)
            {
                Alumno a = dictionary[llave];
                dgvAlumno.Rows.Add(llave, a.pNombre, a.pEdad);
            }
        }
    }
}
