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
namespace VentasMayoreo.Formularios
{
    public partial class ClienteBaja : Form
    {
        public ClienteBaja()
        {
            InitializeComponent();
            cargarClientes();
        }
        private void cargarClientes()
        {
            cmbClientes.Items.Clear();
            foreach (Cliente cliente in Empresa.getClientes())
            {
                cmbClientes.Items.Add(cliente);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1)
            {
                Cliente cliente = cmbClientes.SelectedItem as Cliente;
                DialogResult r = MessageBox.Show("Estas Seguro De Eliminar Al Cliente " + cliente.Nombre, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.No)
                {
                    if (Sql.executeCommand("delete from Clientes where claveCliente = " + cliente.Clave))
                    {
                        MessageBox.Show("Se Elimino Correctamente Al Cliente " + cliente.Nombre);
                        cargarClientes();
                        cmbClientes.SelectedIndex = -1;
                        cmbClientes.Text = "";
                    }
                }
            }
        }
        
    }
}
