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

namespace VentasMayoreo
{
    public partial class ActualizarEmpleado : Form
    {
        public ActualizarEmpleado()
        {
            InitializeComponent();
        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {

        }

        public bool validaDatos()
        {
            bool con = false;

            if(string.IsNullOrWhiteSpace(cmbEmpleados.Text))
            {
                con = true;
            }
            if(string.IsNullOrWhiteSpace(txtAmat.Text) || txtAmat.Text.Length<3)
            {
                con = true;
            }
            if(string.IsNullOrWhiteSpace(txtApat.Text) || txtApat.Text.Length<3)
            {
                con = true;
            }
            if(string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text.Length<5)
            {
                con = true;
            }
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Length<3)
            {
                con = true;
            }
            if(string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length!=10)
            {
                con = true;
            }

            return con;
        }

        public void limpiar()
        {
            txtAmat.Text = "";
            txtApat.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbEmpleados.Text = "";
            errorProvider1.Clear();
        }

        private void ActualizarEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select claveEmpleado from Empleados");
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    cmbEmpleados.Items.Add(lector.GetValue(0).ToString()/* + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString()*/);
                }
                Sql.Connection.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (validaDatos() == false)
            {
                int clave = Convert.ToInt32(cmbEmpleados.Text);
                try
                {
                    Sql.Connection.Open();
                    Sql.setCommand("update Empleados set nombre='" + txtNombre.Text + "', paterno='" + txtApat.Text + "', materno='" + txtAmat.Text + "', direccion='" + txtDireccion.Text + "', telefono='" + txtTelefono.Text + "' where claveEmpleado='"+clave+"'");
                    Sql.Command.ExecuteReader();
                    Sql.Connection.Close();
                    MessageBox.Show("Empleado actualizado!!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.Connection.Close();
                }
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos incompletos");
                if(string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length<3)
                {
                    errorProvider1.SetError(txtNombre, "Complete los datos");
                }
                if(string.IsNullOrEmpty(txtApat.Text) || txtApat.Text.Length<3)
                {
                    errorProvider1.SetError(txtApat, "Complete los datos");
                }
                if(string.IsNullOrEmpty(txtAmat.Text) || txtAmat.Text.Length<3)
                {
                    errorProvider1.SetError(txtAmat, "Complete los datos");
                }
                if(string.IsNullOrEmpty(txtDireccion.Text) || txtDireccion.Text.Length<3)
                {
                    errorProvider1.SetError(txtDireccion, "Complete los datos");
                }
                if(string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length!=10)
                {
                    errorProvider1.SetError(txtTelefono, "Complete los datos");
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

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbEmpleados.Text))
            {
                int clave = Convert.ToInt32(cmbEmpleados.Text);
                try
                {
                    Sql.Connection.Open();
                    Sql.setCommand("select nombre, paterno, materno, direccion, telefono from Empleados where claveEmpleado='" + clave + "'");
                    SqlDataReader lector = Sql.Command.ExecuteReader();
                    while (lector.Read())
                    {
                        txtNombre.Text = lector.GetValue(0).ToString();
                        txtApat.Text = lector.GetValue(1).ToString();
                        txtAmat.Text = lector.GetValue(2).ToString();
                        txtDireccion.Text = lector.GetValue(3).ToString();
                        txtTelefono.Text = lector.GetValue(4).ToString();
                    }
                    Sql.Connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
