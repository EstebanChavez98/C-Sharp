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
namespace VentasMayoreo
{
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        public int finalClaveEmpleado()
        {
            int c = 0;
            try
            {
              
                Sql.Connection.Open();
                Sql.setCommand("select IDENT_CURRENT('Empleados')");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while (lector.Read())
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

        public bool validaDatos()
        {
            bool c = false;
            if(string.IsNullOrEmpty(cmbSucursal.Text))
            {
                c = true;
            }
            if (string.IsNullOrWhiteSpace(txtAmat.Text) || txtAmat.Text.Length < 3)
            {
                c = true;
            }
            if (string.IsNullOrWhiteSpace(txtApat.Text) || txtApat.Text.Length < 3)
            {
                c = true;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length < 5)
            {
                c= true;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Length < 3)
            {
                c = true;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length != 10)
            {
                c = true;
            }
            if (rdFemenino.Checked==false && rdMasculino.Checked==false)
            {
                c = true;
            }

            return c;
        }

        public int obtenSucursal(string nombre)
        {
            int clave = 0;

            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select claveSucursal from Sucursales where nombre='" + nombre + "'");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while (lector.Read())
                {
                    clave = Convert.ToInt32(lector.GetInt32(0));
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }

            return clave;
        }

        private void AltaEmpleado_Load(object sender, EventArgs e)
        {
            txtClaveEmpleado.Text = finalClaveEmpleado().ToString();

            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select nombre from Sucursales");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    cmbSucursal.Items.Add(lector.GetValue(0).ToString());
                }
                Sql.Connection.Close();

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }

        }

        public void limpiar()
        {
            txtAmat.Text = "";
            txtApat.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbSucursal.Text = "";
            rdFemenino.Checked = false;
            rdMasculino.Checked = false;
            txtClaveEmpleado.Text = Convert.ToString(finalClaveEmpleado());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("desea confirmar al empleado?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if (validaDatos() == false)
                {
                    if (!Sql.exist("select claveEmpleado from Empleados where nombre='" + txtNombre.Text + "' and paterno='" + txtApat.Text + "' and materno='" + txtAmat.Text + "'"))
                    {
                        string nombre = txtNombre.Text;
                        string apat = txtApat.Text;
                        string amat = txtAmat.Text;
                        string direccion = txtDireccion.Text;
                        double telefono = Convert.ToDouble(txtTelefono.Text);
                        int sucursal = obtenSucursal(cmbSucursal.Text);

                        char sexo = 'M';
                        if(rdFemenino.Checked)
                        {
                            sexo = 'F';
                        }
                        if(rdMasculino.Checked)
                        {
                            sexo = 'M';
                        }

                        string comando = string.Format("insert into Empleados(claveSucursal, nombre, paterno, materno, sexo, direccion, telefono) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", sucursal, nombre, apat, amat, sexo, direccion, telefono);
                        if(Sql.executeCommand(comando))
                        {
                            MessageBox.Show("Empleado agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();

                        }
                        else
                        {
                            MessageBox.Show("no se pudo insertar");
                        }


                    }
                    else
                    {
                        MessageBox.Show("ya está registrado el empleado");
                    }
                }
                else
                {
                    MessageBox.Show("Datos incompletos.");
                    if(string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Length<3)
                    {
                        errorProvider1.SetError(txtNombre, "Inserte datos");
                    }
                    if (string.IsNullOrWhiteSpace(txtApat.Text) || txtApat.Text.Length<3)
                    {
                        errorProvider1.SetError(txtApat, "inserte datos");
                    }
                    if(string.IsNullOrWhiteSpace(txtAmat.Text) || txtAmat.Text.Length<3)
                    {
                        errorProvider1.SetError(txtAmat, "inserte datos");
                    }
                    if(string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length<5)
                    {
                        errorProvider1.SetError(txtDireccion, "inserte datos");
                    }
                    if(string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length <3)
                    {
                        errorProvider1.SetError(txtTelefono, "inserte datos");
                    }
                }

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtNombre, "No se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtApat, "no se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtApat, "");
            }
        }

        private void txtAmat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtAmat, "No se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtAmat, "");
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtTelefono, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }
    }
}
