using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using VentasMayoreo.Formularios;
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Sql.inicializar(getConnection());
        }

        private  string getConnection()
        {
            string cadena = "";
            int contador = 0;
            contador = ConfigurationManager.ConnectionStrings.Count;
            if (contador > 0)
            {
                cadena = ConfigurationManager.ConnectionStrings[contador - 1].ConnectionString;
            }
            return cadena;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteAlta alta = new ClienteAlta();
            alta.Show();
        }

        private void puntoVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaAlta venta = new VentaAlta();
            venta.ShowDialog();
        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteAbono abono = new ClienteAbono();
            abono.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Empresa.numeroClientes()>0)
            {
                ClienteActualizar actualizar = new ClienteActualizar();
                actualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Hay Clientes Dados De Alta","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Empresa.numeroClientes() > 0)
            {
                ClienteConsulta consulta = new ClienteConsulta();
                consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Hay Clientes Dados De Alta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Empresa.numeroClientes() > 0)
            {
                ClienteBaja baja = new ClienteBaja();
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Hay Clientes Dados De Alta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //EmpleadoAlta alta = new EmpleadoAlta();
           // alta.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaArticulos ar = new AltaArticulos();
            ar.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaArticulos ar = new ConsultaArticulos();
            ar.ShowDialog();
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoArticulos ar = new ListadoArticulos();
            ar.ShowDialog();
        }

        private void detalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDetallecs detalle = new VentaDetallecs();
            detalle.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaConsulta venta = new VentaConsulta();
            venta.ShowDialog();
        }

        private void abonosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteAbonoConsulta c = new ClienteAbonoConsulta();
            c.ShowDialog();
        }

      

        private void clienteContadoYCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteClienteVentas ventas = new ReporteClienteVentas();
            ventas.ShowDialog();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ArticulosActualizar actualizar = new ArticulosActualizar();
            actualizar.ShowDialog();
        }

        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacenes almacen = new Almacenes();
            almacen.ShowDialog();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlmacenConsultaGeneral consulta = new AlmacenConsultaGeneral();
            consulta.ShowDialog();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlmacenConsultaIndividual consulta = new AlmacenConsultaIndividual();
            consulta.ShowDialog();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CategoriasAlta alta = new CategoriasAlta();
            alta.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriasActualizar actualizar = new CategoriasActualizar();
            actualizar.ShowDialog();
        }

        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriasListado consulta = new CategoriasListado();
            consulta.ShowDialog();
        }

        private void individualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CategoriasConsulta consulta = new CategoriasConsulta();
            consulta.ShowDialog();
        }

        

        private void altaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AltaSucursal sucursal = new AltaSucursal();
            sucursal.ShowDialog();
        }

        private void individualToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultaSucursales consulta = new ConsultaSucursales();
            consulta.ShowDialog();
        }

       
        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado actualizar = new ActualizarEmpleado();
            actualizar.ShowDialog();
        }

        private void todosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaEmpleados consulta = new ConsultaEmpleados();
            consulta.ShowDialog();
        }

        private void actualizacionesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AltaEmpleado alta = new AltaEmpleado();
            alta.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteConsultas consulta = new ClienteConsultas();
            consulta.ShowDialog();
        }

        private void individualNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticulosConsultaNombre consulta = new ArticulosConsultaNombre();
            consulta.ShowDialog();
        }

       

        private void ventaPorCategoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReporteEmpleadoCategoria reporte = new ReporteEmpleadoCategoria();
            reporte.ShowDialog();
        }

        private void individualToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SucursalConsultaIndividual consulta = new SucursalConsultaIndividual();
            consulta.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercadeNosotros acerca = new AcercadeNosotros();
            acerca.ShowDialog();
        }
    }
}
