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
    public partial class ClienteConsultas : Form
    {
        public ClienteConsultas()
        {
            InitializeComponent();
            cargarClientes();
            
        }
        private void cargarClientes()
        {
            foreach(Cliente cliente in Empresa.getClientes())
            {
                int clave = cliente.Clave;
                string nombre = cliente.Nombre;
                string paterno = cliente.Paterno;
                string materno = cliente.Materno;
                char sexo = cliente.Sexo;
                string fecha = cliente.FechaNacimiento;
                string dir = cliente.Direccion;
                string tel = cliente.Telefono;
                string monto = string.Format("{0:c2}", cliente.MontoMaximoCredito);
                string saldo = string.Format("{0:c2}", cliente.SaldoPendiente);
                dtrClientes.Rows.Add(clave,nombre, paterno, materno, sexo, fecha, dir, tel, monto, saldo);
            }
        }
    }
}
