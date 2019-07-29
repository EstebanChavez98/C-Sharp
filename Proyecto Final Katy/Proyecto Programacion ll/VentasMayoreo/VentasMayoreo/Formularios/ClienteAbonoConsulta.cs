using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using VentasMayoreo.Clases;
namespace VentasMayoreo.Formularios
{
    public partial class ClienteAbonoConsulta : Form
    {
        public ClienteAbonoConsulta()
        {
            InitializeComponent();
            cargarClientesconAbono();
        }
        private void cargarClientesconAbono()
        {
            foreach(Cliente cliente in Empresa.getClienteConAbono())
            {
                this.cmbClientes.Items.Add(cliente);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClientes.SelectedIndex!=-1)
            {
                try
                {
                    abonos.Items.Clear();
                    int claveCliente= ((Cliente)cmbClientes.SelectedItem).Clave;
                    string comando = string.Format("select claveAbono,monto,fecha from Abonos where claveCliente ='{0}'", claveCliente);
                    Sql.setCommand(comando);
                    Sql.Connection.Open();
                    SqlDataReader reader = Sql.Command.ExecuteReader();
                    while(reader.Read())
                    {
                        string clave = reader.GetValue(0).ToString();
                        double monto = Convert.ToDouble(reader.GetValue(1).ToString());
                        string fecha = reader.GetDateTime(2).ToShortDateString();
                        ListViewItem item = new ListViewItem(clave.ToString());
                        item.SubItems.Add(string.Format("{0:c2}", monto));
                        item.SubItems.Add(fecha);
                        abonos.Items.Add(item);
                    }
                    Sql.Connection.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.Connection.Close();
                }
            }
        }
    }
}
