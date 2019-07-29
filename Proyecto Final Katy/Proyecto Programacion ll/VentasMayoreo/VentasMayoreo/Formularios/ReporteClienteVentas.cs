using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasMayoreo.Formularios
{
    public partial class ReporteClienteVentas : Form
    {
        public ReporteClienteVentas()
        {
            InitializeComponent();
        }

        private void ReporteClienteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasMayoreo.Clientes_Ventas' Puede moverla o quitarla según sea necesario.
            this.clientes_VentasTableAdapter.Fill(this.ventasMayoreo.Clientes_Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
