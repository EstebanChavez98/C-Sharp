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
using System.Data.SqlClient;
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    public partial class AltaSucursal : Form
    {
        public AltaSucursal()
        {
            InitializeComponent();

        }

        public int ClaveSucursal()
        {
            int c = 0;
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select IDENT_CURRENT('Sucursales')");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    c = Convert.ToInt32(lector.GetValue(0).ToString());
                }
                c++;
                Sql.Connection.Close();

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }

            return c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtClave.Text = ClaveSucursal().ToString();

        }

        public bool validacion()
        {
            bool c = false;

            if(string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length<5)
            {
                c = true;
            }
            
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Length<5)
            {
                c = true;
            }

            if(string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length!=10)
            {
                c = true;
            }
            return c;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtNombre, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtDireccion, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtTelefono, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

       
        public void limpiar()
        {
            txtClave.Text = Convert.ToString(ClaveSucursal());
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            errorProvider1.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Seguro de agregar la sucursal?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if(validacion()==false)
                {

                    string nombre = txtNombre.Text;

                    if(!Sql.exist("select nombre from Sucursales where nombre='" + nombre + "'"))
                    {

                        string direccion = txtDireccion.Text;
                        double telefono = Convert.ToDouble(txtTelefono.Text);
                        
                        string comando = string.Format("insert into Sucursales(nombre, direccion, telefono) values('{0}', '{1}', '{2}')", nombre, direccion, telefono);
                        if(Sql.executeCommand(comando))
                        {
                            MessageBox.Show("Sucursal agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("no se pudo insertar");
                        }

                        limpiar();


                    }
                    else
                    {
                        MessageBox.Show("La sucursal ya esta agregado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete los datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Length<5)
                    {
                        errorProvider1.SetError(txtNombre, "Ingrese Datos");
                    }
                    if(string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length<5)
                    {
                        errorProvider1.SetError(txtDireccion, "Ingrese Datos");
                    }
                    if(string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length!=10)
                    {
                        errorProvider1.SetError(txtTelefono, "Ingrese Datos");
                    }
                }
            }
        }
    }
}
