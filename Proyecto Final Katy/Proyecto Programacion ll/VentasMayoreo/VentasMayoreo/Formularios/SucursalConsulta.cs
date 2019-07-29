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
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    public partial class ConsultaSucursales : Form
    {
        public ConsultaSucursales()
        {
            InitializeComponent();
        }

        private void ConsultaSucursales_Load(object sender, EventArgs e)
        {
           // WindowState = FormWindowState.Maximized;

            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select claveSucursal, nombre, direccion, telefono from Sucursales");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    dgvSucursales.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }

           
        }

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
