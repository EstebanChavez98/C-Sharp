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
    public partial class SucursalConsultaIndividual : Form
    {
        public SucursalConsultaIndividual()
        {
            InitializeComponent();
            cargarSucursales();
        }
        private void cargarSucursales()
        {
            foreach(Sucursal sucursal in Empresa.getSucursales())
            {
                cmbSucursal.Items.Add(sucursal);
            }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSucursal.SelectedIndex!=-1)
            {
                Sucursal sucursal = cmbSucursal.SelectedItem as Sucursal;
                txtClave.Text = sucursal.Clave.ToString();
                txtDireccion.Text = sucursal.Direccion;
                txtTelefono.Text = sucursal.Telefono;

            }
        }
    }
}
