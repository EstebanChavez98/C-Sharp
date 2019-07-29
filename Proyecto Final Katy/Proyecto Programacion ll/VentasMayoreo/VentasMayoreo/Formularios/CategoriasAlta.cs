using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasMayoreo
{
    public partial class CategoriasAlta : Form
    {
        public CategoriasAlta()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
                MessageBox.Show("Llene el campo.");
            else if (NombreDuplicado(nombre))
                MessageBox.Show("Nombre duplicado.");
            else
            {
                string insercion = string.Format("insert into Categorias(nombre) values('{0}')", nombre);

                if (Sql.executeCommand(insercion))
                {
                    MessageBox.Show("Registro exitoso.");
                    txtNombre.Text = "";
                    AsignarClave();
                }
            }
                
        }

        private bool NombreDuplicado(string nombre)
        {
            bool duplicado;

            string comando = string.Format("select nombre from Categorias where nombre='{0}' ", nombre);
            duplicado = Sql.exist(comando);

            return duplicado;
        }
        private void AsignarClave()
        {
            string consulta = "select IDENT_CURRENT('Categorias')";
            Sql.setCommand(consulta);
            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            int clave = Convert.ToInt32(lector.GetValue(0).ToString()) + 1;
                            txtClave.Text = clave.ToString();
                        }
                    else
                        txtClave.Text = "1";
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }
        }

        private void CategoriasAlta_Load(object sender, EventArgs e)
        {
            AsignarClave();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar!='´')
            {
                errorProvider1.SetError(txtNombre, "Caracter inválido.");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtNombre, "");
        }
    }
}
