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
    public partial class VentaAlta : Form
    {
        private double totalVenta;
        public VentaAlta()
        {
            InitializeComponent();
            
        }
        private void VentaAlta_Load(object sender, EventArgs e)
        {          
            this.cmbSucursales.DataSource = Empresa.getSucursales();
            this.cmbClientes.DataSource = Empresa.getClientes();           
        }
       
        private void rdContado_Click(object sender, EventArgs e)
        {
            try
            {
                validaCliente();
                validaArticulosExistentes();
                this.grpVenta.Visible = false;
                abrirOperacion();
            }
            catch (Exception ex)
            {
                error.SetError(grpVenta, ex.Message);
                RadioButton rd = sender as RadioButton;
                rd.Checked = false;
            }
        }
        private void abrirOperacion()
        {
            this.grpOperacion.Visible = true;
            Empleado empleado = cmbEmpleados.SelectedItem as Empleado;
            cmbEmpleados.Visible = true;
            lblEmpleado.Visible = true;
            cmbEmpleados.DropDownStyle = ComboBoxStyle.Simple;
            this.cmbEmpleados.Enabled = false;
            this.txtCliente.Text = cmbClientes.SelectedItem.ToString();
            this.txtTotal.Text = string.Format("{0:c2}", totalVenta);
            if(rdCredito.Checked)
            {
                this.txtMonto.Visible = true;
                this.lblMonto.Visible = true;
                txtMonto.Text = string.Format("{0:c2}", ((Cliente)cmbClientes.SelectedItem).MontoMaximoCredito);
            }
        }
        private void validaCliente()
        {
            if (cmbClientes.SelectedIndex == -1)
            {
                throw new Exception("Seleccione el Nombre del Cliente Del ComboBox");
            }
        }
        private void validaArticulosExistentes()
        {
            if (cmbArticulos.Items.Count == 0)
            {
                throw new Exception("No Hay Articulos En Existencia");
            }
        }
        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSucursales.SelectedIndex!=-1)
            {
                Sucursal sucursal = cmbSucursales.SelectedItem as Sucursal;
                cmbEmpleados.Items.Clear();
                foreach(Empleado em in Empresa.getEmpleados())
                {
                    if(em.ClaveSucursal == sucursal.Clave)
                    {
                        this.cmbEmpleados.Items.Add(em);
                    }
                }
            }
        }
        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedIndex!=-1)
            {
                Empleado em = cmbEmpleados.SelectedItem as Empleado;
                DialogResult r = MessageBox.Show("Seguro Que Desea Ingresar Como " + em.ToString(), "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(r!=DialogResult.No)
                {
                    grpVenta.Visible = true;
                    this.cmbEmpleados.Hide();
                    this.cmbSucursales.Hide();
                    this.lblSucursal.Hide();
                    this.lblEmpleado.Hide();
                    cargarArticulos();
                    
                }
            }
        }
        private void cargarArticulos()
        {
            int claveSucursal = ((Sucursal)cmbSucursales.SelectedItem).Clave;
            this.cmbArticulos.Items.Clear();
            foreach (ArticuloAlmacenado articulo in Empresa.getArticulosSucursal(claveSucursal.ToString()))
            {
                if(articulo.Existencia>0)
                {
                    this.cmbArticulos.Items.Add(articulo);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex != -1)
            {
                ArticuloAlmacenado articulo = cmbArticulos.SelectedItem as ArticuloAlmacenado;
                Cliente cliente = cmbClientes.SelectedItem as Cliente;
                int cantidad = (int)this.cantidad.Value;
                double importe = cantidad * articulo.Precio;
                if (cantidad > 0 && cantidad <= articulo.Existencia)
                {
                    if (!detalleVenta.Items.ContainsKey(articulo.Descripcion))
                    {
                        if(rdCredito.Checked)
                        {
                            if(importe+totalVenta<=cliente.MontoMaximoCredito)
                            {
                                agregarCarrito(articulo, cantidad,importe);
                                if (cantidad == articulo.Existencia)
                                {

                                   cmbArticulos.Items.Remove(articulo);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Cliente Excede Su Monto Maximo De Credito");
                            }
                        }
                        else
                        {
                            agregarCarrito(articulo,cantidad,importe);
                            if (cantidad== articulo.Existencia)
                            {
                                cmbArticulos.Items.Remove(articulo);
                            }
                        }
                    }
                    else
                    {
                        ListViewItem item = detalleVenta.Items[articulo.Descripcion];
                        int cantidastock = Convert.ToInt32(item.SubItems[2].Text);
                        if (cantidad + cantidastock <= articulo.Existencia)
                        {
                            if (rdCredito.Checked)
                            {

                                if (importe + totalVenta <= cliente.MontoMaximoCredito)
                                {
                                    acumularArticulo(item, articulo, cantidastock, cantidad);
                                    if (cantidad + cantidastock == articulo.Existencia)
                                    {
                                        
                                        cmbArticulos.Items.Remove(articulo);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El Cliente excede su Monto Maximo De Credito");
                                }
                            }
                            else
                            {
                                acumularArticulo(item, articulo, cantidastock, cantidad);
                                if (cantidad + cantidastock == articulo.Existencia)
                                {
                                    cmbArticulos.Items.Remove(articulo);
                                }
                            }
                        }
                        else
                        {
                            error.SetError(this.cantidad, "Ingrese una cantidad entre 1 a " + (articulo.Existencia - cantidastock));
                        }
                    }
                }
                else
                {
                    error.SetError(this.cantidad, "La Cantidad Supera la existencia");
                }
               
            }             
        }
        private void acumularArticulo(ListViewItem item,ArticuloAlmacenado articulo,int cantidadstock,int cantidad)
        {
            int cantidadtotal = cantidad + cantidadstock;
            double importe = cantidad * articulo.Precio;
            double importetotal = cantidadtotal * articulo.Precio;
            item.SubItems[2].Text = cantidadtotal.ToString();
            item.SubItems[3].Text = importetotal.ToString();
            totalVenta += importe;
            txtTotal.Text = string.Format("{0:c2}", totalVenta);
            cmbArticulos.SelectedIndex = -1;
            cmbArticulos.Text = "";
            this.cantidad.Value = this.cantidad.Minimum;
        }
        private void agregarCarrito(ArticuloAlmacenado articulo,int cantidad,double importe)
        {
            ListViewItem item = new ListViewItem(articulo.Clave.ToString());
            item.SubItems.Add(articulo.Descripcion);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(importe.ToString());
            item.Name = articulo.Descripcion;
            detalleVenta.Items.Add(item);
            totalVenta += importe;
            txtTotal.Text = string.Format("{0:c2}", totalVenta);
            cmbArticulos.SelectedIndex = -1;
            cmbArticulos.Text = "";
            this.cantidad.Value = this.cantidad.Minimum;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (detalleVenta.SelectedItems.Count != 0)
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    ListViewItem item = detalleVenta.SelectedItems[0] as ListViewItem;
                    totalVenta -= Convert.ToDouble(item.SubItems[3].Text);
                    detalleVenta.Items.Remove(item);
                    txtTotal.Text = string.Format("{0:c2}", totalVenta);
                    int clave = Convert.ToInt32(item.SubItems[0].Text);
                    int claveSucursal = ((Sucursal)cmbSucursales.SelectedItem).Clave;
                    if (!buscaArticulo(clave))
                    {
                        cmbArticulos.Items.Add(Empresa.getArticulo(claveSucursal, clave));
                    }                      
                }
            }
        }
        private bool buscaArticulo(int clave)
        {
            bool respuesta = false;
            for(int i=0;i<cmbArticulos.Items.Count;i++)
            {
                ArticuloAlmacenado articulo = cmbArticulos.Items[i] as ArticuloAlmacenado;
                if(articulo.Clave == clave)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        private void cantidad_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(this.cantidad, null);
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            if(detalleVenta.Items.Count!=0)
            {
                DialogResult r = MessageBox.Show("Esta Seguro De Registrar La Venta ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.No)
                {
                    string tipo = getTipoCompra();
                    double importe = totalVenta;
                    int claveCliente = ((Cliente)cmbClientes.SelectedItem).Clave;
                    int claveEmpleado = ((Empleado)cmbEmpleados.SelectedItem).Clave;
                    string comando = string.Format("exec insertarVenta '{0}','{1}','{2}','{3}'", tipo, importe, claveCliente, claveEmpleado);
                    if (Sql.executeCommand(comando))
                    {
                        int claveVenta = obtenerClaveVenta();
                        int claveSucursal = ((Sucursal)cmbSucursales.SelectedItem).Clave;
                        foreach (ListViewItem articulo in detalleVenta.Items)
                        {
                            int claveArticulo = Convert.ToInt16(articulo.SubItems[0].Text);
                            int cantidad = Convert.ToInt16(articulo.SubItems[2].Text);
                            importe = Convert.ToDouble(articulo.SubItems[3].Text);
                            comando = string.Format("exec insertarDetalleVenta '{0}','{1}','{2}','{3}','{4}'", claveVenta, claveArticulo, cantidad, importe, claveSucursal);
                            Sql.executeCommand(comando);
                        }
                        MessageBox.Show("Se Guardo Correctamente la venta","Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.totalVenta = 0;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Insertar La Venta");
                    }
                }
            }
        }
        private string getTipoCompra()
        {
            string tipo;
            if(rdContado.Checked)
            {
                tipo = rdContado.Text;
            }
            else
            {
                tipo = rdCredito.Text;

            }
            return tipo;
        }
        private int obtenerClaveVenta()
        {
            int clave = 0;
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select IDENT_CURRENT('Ventas')");
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    clave = Convert.ToInt16(reader.GetValue(0).ToString());
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return clave;
        }
        private  void limpiar()
        {
            this.detalleVenta.Items.Clear();
            this.cantidad.Value = this.cantidad.Minimum;
            this.grpOperacion.Visible = false;
            cargarArticulos();
            this.grpVenta.Visible = true;
            this.cmbClientes.SelectedIndex = -1;
            this.cmbClientes.Text ="";
            this.rdContado.Checked = false;
            this.rdCredito.Checked = false;
            this.cmbEmpleados.Hide();
            this.lblEmpleado.Hide();
            this.txtMonto.Visible = false;
            this.lblMonto.Visible = false;
        }

       
    }
}
