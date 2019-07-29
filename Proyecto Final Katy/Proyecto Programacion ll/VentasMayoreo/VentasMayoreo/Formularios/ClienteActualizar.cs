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
    public partial class ClienteActualizar : Form
    {
        public ClienteActualizar()
        {
            InitializeComponent();
            cargarClientes();
        }
        private void cargarClientes()
        {
            cmbClientes.Items.Clear();
            foreach(Cliente cliente in Empresa.getClientes())
            {
                cmbClientes.Items.Add(cliente);
            }
        }  
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = cmbClientes.SelectedItem as Cliente;
                validaCadena(txtNombre, cliente.Nombre);
                validaCadena(txtPaterno, cliente.Paterno);
                validaCadena(txtMaterno, cliente.Materno);
                validaDireccion(cliente.Direccion);
                validaMontoMaximo();
                string nombre = txtNombre.Text.Trim();
                string paterno = txtPaterno.Text.Trim();
                string materno = txtMaterno.Text.Trim(); ;
                string direccion = txtDireccion.Text.Trim();
                double monto = (double)this.monto.Value;
                string comando = string.Format("exec actualizarCliente '{0}','{1}','{2}','{3}','{4}','{5}'", cliente.Clave, nombre,paterno,materno, direccion, monto);
                if(Sql.executeCommand(comando))
                {
                    MessageBox.Show("Se Actualizo Correctamente el Cliente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.groupBox2.Visible = false;
                    groupBox1.Enabled = true;
                    limpiar();
                    cargarClientes();           
                }

            }catch(Exception ex)
            {
                error.SetError(ActiveControl, ex.Message);
            }

        } 
        private void validaCadena(TextBox nuevo,string old)
        {
            if (!nuevo.ReadOnly)
            {
                nuevo.Focus();
                if (!nuevo.Text.Trim().Equals(old))
                {
                    if (!validate.nameFormat(nuevo.Text))
                    {
                        throw new Exception("Ingrese un Dato Adecuado Para Este Campo");
                    }
                }
                else
                {
                    throw new Exception("Intenta Actualizar " + nuevo.Text + " A " + old);
                }
            }
        }
        private void validaDireccion(string old)
        {
            if (!txtDireccion.ReadOnly)
            {
                if (txtDireccion.Text.Trim().Equals(old))
                {
                    txtDireccion.Focus();
                    throw new Exception("Ingrese Una Nueva Dirección");
                }
                else if (string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length < 4)
                {
                    txtDireccion.Focus();
                    throw new Exception("Ingrese una Direccion Valida");
                }
            }
            
        }
        private void validaMontoMaximo()
        {       
            if (!monto.ReadOnly)
            {
                double monto = (double)this.monto.Value;
                Cliente cliente = cmbClientes.SelectedItem as Cliente;             
                if (cliente.MontoMaximoCredito == monto)
                {
                    this.monto.Focus();
                    throw new Exception("Ingrese Una Monto Maximo De Credito Diferente a " + monto);
                }
              
            }        
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chNombre.Checked)
            {
                txtNombre.ReadOnly = false;
            }
            else
            {
                txtNombre.ReadOnly = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chApellido.Checked)
            {
                txtPaterno.ReadOnly = false;
            }
            else
            {
                txtPaterno.ReadOnly = true;
            }
        }

        private void chDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if(chDireccion.Checked)
            {
                txtDireccion.ReadOnly = false;
            }
            else
            {
                txtDireccion.ReadOnly = true;
            }
        }

        private void chMonto_CheckedChanged(object sender, EventArgs e)
        {
            if(chMonto.Checked)
            {
                monto.ReadOnly = false;
            }
            else
            {
                monto.Enabled = true; ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validaSeleccionComobo())
            {
                error.SetError(cmbClientes, "Seleccione un Cliente");
            }
            else if(!validaSeleccionCampos())
            {
                error.SetError(groupBox1, "seleccione un Campo A Modificar");
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.groupBox2.Visible = true;
            }            
        }
        private bool validaSeleccionCampos()
        {
            bool respuesta = false;
            if(chNombre.Checked || chApellido.Checked || chDireccion.Checked || chMonto.Checked )
            {
                respuesta = true;
            }
            return respuesta;
        }
        private bool validaSeleccionComobo()
        {
            bool respuesta = false;
            if(cmbClientes.SelectedIndex !=-1)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClientes.SelectedIndex!=-1)
            {
                error.SetError(cmbClientes, null);
                Cliente cliente = cmbClientes.SelectedItem as Cliente;
                txtClave.Text = cliente.Clave.ToString();
                txtNombre.Text = cliente.Nombre;
                txtPaterno.Text = cliente.Paterno;
                txtMaterno.Text = cliente.Materno;
                txtDireccion.Text = cliente.Direccion;
                monto.Value = (decimal)cliente.MontoMaximoCredito;
            }         
        }

        private void chNombre_Click(object sender, EventArgs e)
        {
            error.SetError(groupBox1, null);
        }
        private void limpiar()
        {
            cmbClientes.SelectedIndex = -1;          
            chNombre.Checked = false;
            chApellido.Checked = false;
            chDireccion.Checked = false;
            chMonto.Checked = false;
            txtNombre.ReadOnly = true;
            txtPaterno.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            monto.ReadOnly = true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
       {
            TextBox tex = sender as TextBox;
            if(validate.nameFormat(tex.Text))
            {
                error.SetError(tex, null);
            }
        }
        /*private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control control = sender as Control;
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                error.SetError(control, "Ingrese Solo Letras");
            }
            else
            {
                error.SetError(control, null);
            }
        }*/
        private void chMaterno(object sender, EventArgs e)
        {
            if(materno.Checked)
            {
                txtMaterno.ReadOnly = false;
            }
            else
            {
                txtMaterno.ReadOnly = true;
            }
        }

        private void monto_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(monto, null);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || (char)Keys.Back == e.KeyChar || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                error.SetError(txtDireccion, "Ingrese una Direccion Adecuada");
            }
            else
            {
                error.SetError(txtDireccion, null);
            }
        }
    }
}
