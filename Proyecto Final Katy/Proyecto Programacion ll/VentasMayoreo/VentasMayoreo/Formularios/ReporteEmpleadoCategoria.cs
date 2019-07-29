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
    public partial class ReporteEmpleadoCategoria : Form
    {
        public ReporteEmpleadoCategoria()
        {
            InitializeComponent();
        }

        private void ReporteEmpleadoCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasMayoreo.Empleados_Categorias' Puede moverla o quitarla según sea necesario.
            this.empleados_CategoriasTableAdapter.Fill(this.ventasMayoreo.Empleados_Categorias);

            this.reportViewer1.RefreshReport();
        }
    }
}
