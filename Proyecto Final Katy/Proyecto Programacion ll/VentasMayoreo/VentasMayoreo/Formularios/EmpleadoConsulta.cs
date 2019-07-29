using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VentasMayoreo
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {

             WindowState = FormWindowState.Maximized;

            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select claveEmpleado, e.nombre, paterno, materno, sexo, e.direccion, e.telefono, s.claveSucursal, s.nombre from Empleados e inner join Sucursales s on e.claveSucursal=s.claveSucursal");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    dgvEmpleados.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString(), lector.GetValue(8).ToString());
                }
                Sql.Connection.Close();

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }

        }
    }
}
