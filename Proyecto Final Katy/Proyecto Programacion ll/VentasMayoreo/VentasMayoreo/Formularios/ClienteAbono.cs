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
    public partial class ClienteAbono : Form
    {
        public ClienteAbono()
        {
            InitializeComponent();
        }

        private void ClienteAbono_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        private void cargarClientes()
        {
            cmbClientes.Items.Clear();
            foreach(Cliente cliente in Empresa.getClientes())
            {
                if(cliente.SaldoPendiente>0)
                     cmbClientes.Items.Add(cliente);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listClientes.Items.Clear();
            error.SetError(cmbClientes, null);
            Cliente cliente = cmbClientes.SelectedItem as Cliente;
            ListViewItem item = new ListViewItem(cliente.Clave.ToString());
            item.SubItems.Add(cliente.Nombre);
            item.SubItems.Add(cliente.SaldoPendiente.ToString());
            listClientes.Items.Add(item);
            cantidad.Maximum = (decimal)cliente.SaldoPendiente;
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = (double)this.cantidad.Value;
                if (cmbClientes.SelectedIndex!=-1)
                {
                    Cliente cliente = cmbClientes.SelectedItem as Cliente;
                    DialogResult r = MessageBox.Show(string.Format("Seguro de Abonar la cantidad de {0:c2} Al Cliente {1} ", cantidad, cliente.ToString()), "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r != DialogResult.No)
                    {
                        string comando = string.Format("exec abonarCliente '{0}','{1}'", cliente.Clave, cantidad);
                        if (Sql.executeCommand(comando))
                        {
                            MessageBox.Show("Se Abono Exitosamente Al Cliente " + cliente.Nombre + " La Cantiadad de " + cantidad, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            error.SetError(this.cantidad, null);
                            limpiar();
                            cargarClientes();
                        }
                    }
                    else
                    {
                        limpiar();
                    }           
                }
                else
                {
                    error.SetError(cmbClientes, "Seleccione Un Cliente");
                }
            }catch(Exception ex)
            {
                error.SetError(this.cantidad, ex.Message);
            }
        }
        private void limpiar()
        {
            this.cantidad.Value = this.cantidad.Minimum;
            listClientes.Items.Clear();
            cmbClientes.Text = "";
            cargarClientes();
        }
    }
}
