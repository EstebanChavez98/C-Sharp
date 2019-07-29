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
namespace VentasMayoreo.Formularios
{
    public partial class ClienteConsulta : Form
    {
        public ClienteConsulta()
        {
            InitializeComponent();
            cargarClientes();
        }
        private void cargarClientes()
        {
            foreach(Cliente cliente in Empresa.getClientes())
            {
                cmbClientes.Items.Add(cliente);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClientes.SelectedIndex!=-1)
            {
                Cliente cliente = cmbClientes.SelectedItem as Cliente;
                txtClave.Text = Convert.ToString(cliente.Clave);
                txtSexo.Text = Convert.ToString(cliente.Sexo);
                txtFecha.Text = cliente.FechaNacimiento;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtMonto.Text = string.Format("{0:c2}", cliente.MontoMaximoCredito);
                txtSaldo.Text = string.Format("{0:c2}", cliente.SaldoPendiente);
            }
        }
    }
}
