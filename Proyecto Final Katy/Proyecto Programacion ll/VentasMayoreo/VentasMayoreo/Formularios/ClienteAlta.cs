using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace VentasMayoreo.Formularios
{
    public partial class ClienteAlta : Form
    {
        public ClienteAlta()
        {
            InitializeComponent();
            DateTime maximo = new DateTime(DateTime.Today.Year - 18, 12, 31);
            this.fecha.MaxDate = maximo;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                validaCadena(txtNombre);
                validaCadena(txtPaterno);
                validaCadena(txtMaterno);
                validaDireccion();
                validaNombre();             
                validaSexo();
                validaFechaNacimiento();
                validaTelefono();
                //Asignacion De Variables
                string nombre = txtNombre.Text;
                string paterno = txtPaterno.Text;
                string materno = txtMaterno.Text;
                string direccion = txtDireccion.Text;
                char sexo = obtenerSexo();
                string nacimiento = string.Format("{0}-{1}-{2}", fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
                string telefono = txtTelefono.Text;
                string monto = montoMaximo.Value.ToString();

                string comando = string.Format("exec insertarCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",nombre, paterno,materno,sexo,direccion,nacimiento,telefono,monto);
                if(Sql.executeCommand(comando))
                {
                    MessageBox.Show("Se Dio Correctamente de Alta");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Fallo La Alta");
                }
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                error.SetError(ActiveControl, ex.Message);
            }
        }
        //Validaciones
        private void validaCadena(TextBox t)
        {
            if(!validate.nameFormat(t.Text))
            {
                t.Focus();
                throw new Exception("Ingrese un Dato Adecuado Para Este Campo");
            }
        }
        private void validaNombre()
        {
            string comando = string.Format("Select * from Clientes where nombre = '{0}' and paterno='{1}' and materno ='{2}'",txtNombre.Text,txtPaterno.Text,txtMaterno.Text);
            if(Sql.exist(comando))
            {
                txtNombre.Focus();
                throw new Exception(String.Format("EL CLIENTE {0} {1} YA ESTA REGISTRADO",txtNombre.Text,txtPaterno.Text));
            }
        }
      private void validaDireccion()
        {
            if(string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.Focus();
                throw new Exception("Ingrese Una Direccion");
            }
        }
        private void validaSexo()
        {
            if(!(rdFemenino.Checked ||  rdMasculino.Checked))
            {
                grpSexo.Focus();
                throw new Exception("Seleccione El Sexo Del Cliente");
            }
                         
        }
        private void validaFechaNacimiento()
        {
            int resta = DateTime.Today.Year - fecha.Value.Year;
            if(resta>=100)
            {
                fecha.Focus();
                throw new Exception("Seleccione una Fecha Valida");
            }
        }
        private void validaTelefono()
        {
            Regex regex = new Regex("^[0-9]{10}$");
            if(!regex.IsMatch(txtTelefono.Text))
            {
                txtTelefono.Focus();
                throw new Exception("Ingrese Un Telefono Con El Formato Adecuado");
            }
        }
        private char obtenerSexo()
        {
            char sexo = ' ';
            if(rdFemenino.Checked)
            {
                sexo = rdFemenino.Text[0];
            }
            else
            {
                sexo = rdMasculino.Text[0];
            }
            return sexo;
        }
       private void limpiar()
        {
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            montoMaximo.Value = montoMaximo.Minimum;
            txtTelefono.Text = "";
            fecha.Value = fecha.MaxDate;
            rdFemenino.Checked = false;
            rdMasculino.Checked = false;
            error.Clear();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control control = sender as Control;
            if(!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) ||  e.KeyChar ==(char)Keys.Back))
            {
                e.Handled = true;
                error.SetError(control, "Ingrese Solo Letras");
            }
            else
            {
                error.SetError(control, null);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            error.SetError(control, null);
        }

        private void radio(object sender, EventArgs e)
        {
            error.SetError(grpSexo, null);
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(fecha, null);
        }

        private void direccionKey(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                error.SetError(txtDireccion, "Ingrese Un Formato Adecuado");
            }
            else
            {
                error.SetError(txtDireccion, null);
            }
        }
    }
}
