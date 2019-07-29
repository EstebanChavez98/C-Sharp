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
using System.Data.SqlClient;
namespace VentasMayoreo.Formularios
{
    public partial class VentaDetallecs : Form
    {
        public VentaDetallecs()
        {
            InitializeComponent();
            cargarClientes();
        }
        private void cargarClientes()
        {
            foreach(Cliente cliente in Empresa.getClientesConVenta())
            {
                cmbCliente.Items.Add(cliente);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCliente.SelectedIndex!=-1)
            {
                this.detalleVenta.Items.Clear();
                cmbVenta.Items.Clear();
                cmbVenta.Text = "";
                txtTotal.Text = "";
                txtTipo.Text = "";
                int claveCliente = ((Cliente)cmbCliente.SelectedItem).Clave;
                string comando = string.Format("select claveVenta,importe,tipo from Ventas where claveCliente ='{0}'",claveCliente);
                Sql.setCommand(comando);
                Sql.Connection.Open();
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    int claveventa = Convert.ToInt16(reader.GetValue(0).ToString());
                    double importe = Convert.ToDouble(reader.GetValue(1).ToString());
                    string tipo = reader.GetString(2);
                    List<DetalleDeVenta> detalles = new List<DetalleDeVenta>();                    
                    Venta venta = new Venta(claveventa, importe, tipo);
                    cmbVenta.Items.Add(venta);

                }
                Sql.Connection.Close();
            }
        }

        private void cmbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbVenta.SelectedIndex!=-1)
            {
                detalleVenta.Items.Clear();
                int claveVenta = ((Venta)cmbVenta.SelectedItem).ClaveVenta;
                foreach(DetalleDeVenta detalle in Empresa.getDetalleVenta(claveVenta))
                {
                    ListViewItem item = new ListViewItem(detalle.ClaveArticulo.ToString());
                    item.SubItems.Add(detalle.Articulo);
                    item.SubItems.Add(detalle.Cantidad.ToString());
                    item.SubItems.Add(detalle.Precio.ToString());
                    item.SubItems.Add(detalle.Importe.ToString());
                    this.detalleVenta.Items.Add(item);
                }
                txtTotal.Text = string.Format("{0:c2}", ((Venta)cmbVenta.SelectedItem).Importe);
                txtTipo.Text = string.Format("{0:c2}", ((Venta)cmbVenta.SelectedItem).Tipo);
            }
        }
    }
}
