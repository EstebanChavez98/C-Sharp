using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmConsultaJuegos : Form
    {
        Dictionary<int, Juego> juegos;
        public frmConsultaJuegos(Dictionary<int, Juego> J)
        {
            InitializeComponent();
            juegos = J;
        }

        private void frmConsultaJuegos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            foreach(int codigo in juegos.Keys)
            {
                Juego jue = juegos[codigo];
                dgvConsultaJuegos.Rows.Add(codigo, jue.pNombre, jue.pDesarrollador, jue.pExistencia);
            }
            dgvConsultaJuegos.AutoResizeColumns();
        }
    }
}
