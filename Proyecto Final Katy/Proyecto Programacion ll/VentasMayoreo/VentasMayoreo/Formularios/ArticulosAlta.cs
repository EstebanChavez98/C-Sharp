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
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    public partial class AltaArticulos : Form
    {
        public AltaArticulos()
        {
            InitializeComponent();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescCaptura.Text = "";
            txtPrecioCaptura.Text = "";
            cmbCategorias.SelectedText = "";
            errorProvider1.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void txtDescCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != ','
                && e.KeyChar != '.')
            {
                errorProvider1.SetError(txtDescCaptura, "Caracter inválido");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtDescCaptura, "");
        }

        private void txtPrecioCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                errorProvider1.SetError(txtPrecioCaptura, "Ingrese solo valores numéricos.");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtPrecioCaptura, "");
        }

        private bool CamposVacios()
        {
            bool vacio = false;
            string desc = txtDescCaptura.Text;
            string precio = txtPrecioCaptura.Text;
            string categoria = cmbCategorias.Text;

            if (string.IsNullOrWhiteSpace(desc))
            {
                errorProvider1.SetError(txtDescCaptura, "Llene este campo.");
                vacio = true;
            }
            if (string.IsNullOrWhiteSpace(precio))
            {
                errorProvider1.SetError(txtPrecioCaptura, "Llene este campo.");
                vacio = true;
            }
            if (string.IsNullOrWhiteSpace(categoria))
            {
                errorProvider1.SetError(cmbCategorias, "Llene este campo.");
                vacio = true;
            }
            
            return vacio;

        }

        private void cmbCategorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AltaArticulos_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = Empresa.getCategorias();

            cmbCategorias.DataSource = categorias;

            AsignarClave();
        }

        private bool NombreDuplicado(string descripcion)
        {
            bool duplicado;

            string comando = string.Format("select descripcion from Articulos where descripcion='{0}' ", descripcion);
            duplicado = Sql.exist(comando);

            return duplicado;
        }
        private bool FormatoPrecioIncorrecto(string precio)
        {
            bool incorrecto = false;

            try
            {
                double p = Convert.ToDouble(precio);
                if (p == 0)
                    incorrecto = true;
            }
            catch(Exception e)
            {
                incorrecto = true;
            }

            return incorrecto;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescCaptura.Text;
            string precio = txtPrecioCaptura.Text;
            Categoria categoria = cmbCategorias.SelectedItem as Categoria;
            string claveCategoria = categoria.Clave.ToString();

            if (CamposVacios())
                MessageBox.Show("Hay campos vacios.");
            else if (NombreDuplicado(descripcion))
                MessageBox.Show(string.Format("El artículo con \"{0}\" ya existe.\nIngrese una nueva Descripción.", descripcion));
            else if (FormatoPrecioIncorrecto(precio))
                MessageBox.Show("El formato en el precio es incorrecto.");
            else
            {
                string insercion = string.Format("insert into Articulos(descripcion,precio,claveCategoria) values('{0}',{1},{2})", descripcion, precio, claveCategoria);

                try
                {
                    if (Sql.executeCommand(insercion))
                    {
                        MessageBox.Show("Registro exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiar_Click(btnLimpiar, new EventArgs());
                        AsignarClave();
                    }

                }
                catch(SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message); 
                }
            }

        }

        private void AsignarClave()
        {
            string consulta = "select IDENT_CURRENT('Articulos')";
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
                            txtClaveCaptura.Text = clave.ToString();
                        }
                    else
                        txtClaveCaptura.Text = "1";
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }
        }
    }
}
