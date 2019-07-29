using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    public partial class AlmacenConsultaGeneral : Form
    {
        public AlmacenConsultaGeneral()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AlmacenConsultaGeneral_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Empresa.getAlmacenGeneral();
        }
    }
}
