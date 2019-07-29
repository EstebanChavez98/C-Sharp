using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasMayoreo.DataSets;

namespace VentasMayoreo.Formularios
{
    public partial class ReporteClienteAbono : Form
    {
        public ReporteClienteAbono()
        {
            InitializeComponent();
        }

        private void ReporteClienteAbono_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasMayoreo.Clientes1' Puede moverla o quitarla según sea necesario.
            this.clientes1TableAdapter.Fill(this.ventasMayoreo.Clientes1);

            this.reportViewer1.RefreshReport();
        }
    }
}
