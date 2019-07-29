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
namespace VentasMayoreo.Formularios
{
    public partial class VentaConsulta : Form
    {
        public VentaConsulta()
        {
            InitializeComponent();
        }

        private void VentaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                string comando = "select v.claveVenta,c.nombre+' '+c.paterno+' '+c.materno as nombre,e.nombre,v.fecha,v.tipo,v.importe from Ventas v join Clientes c on c.claveCliente = v.claveCliente join Empleados e on e.claveEmpleado = v.claveEmpleado";
                Sql.setCommand(comando);
                Sql.Connection.Open();
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string cliente = reader.GetString(1);
                    string empleado = reader.GetString(2);
                    string fecha = reader.GetDateTime(3).ToShortDateString();
                    string tipo = reader.GetString(4);
                    string importe = string.Format("{0:c2}", reader.GetValue(5).ToString());
                    ventas.Rows.Add(clave, cliente, empleado, fecha,tipo, importe);
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
