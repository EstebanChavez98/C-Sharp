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
    public partial class ArticulosActualizar : Form
    {
        public ArticulosActualizar()
        {
            InitializeComponent();
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

            return vacio;

        }
        private bool NombreDuplicado(string descripcion, string clave)
        {
            bool duplicado=false;

            string comando = string.Format("select claveArticulo,descripcion from Articulos where descripcion='{0}' ", descripcion);
            Sql.setCommand(comando);
            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            string claveArt = lector.GetValue(0).ToString();
                            if (claveArt == clave)
                                continue;
                            duplicado = true;
                            
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }

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
            catch (Exception e)
            {
                incorrecto = true;
            }

            return incorrecto;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            string descripcion = txtDescCaptura.Text;
            string precio = txtPrecioCaptura.Text;
            string clave = cmbClaves.Text;
            string claveCategoria = Empresa.getClaveCategoria(categoria);
            

            if (CamposVacios())
                MessageBox.Show("Hay campos vacios.");
            else if (NombreDuplicado(descripcion,clave))
                MessageBox.Show(string.Format("El artículo con \"{0}\" ya existe.\nIngrese una nueva Descripción.", descripcion));
            else if (FormatoPrecioIncorrecto(precio))
                MessageBox.Show("El formato en el precio es incorrecto.");
            else
            {
                Articulo a = new Articulo(Convert.ToInt32(clave), descripcion, Convert.ToDouble(precio), Convert.ToInt32(claveCategoria));
                foreach (Articulo art in Empresa.getArticulos())
                    if (a.Equals(art))
                    {
                        MessageBox.Show("No se modificó ningún campo.");
                        return;
                    }
                string update =
                    string.Format("update Articulos set descripcion='{0}',precio={1} where claveArticulo = {2}", descripcion, precio, clave);
                if (Sql.executeCommand(update))
                {
                    MessageBox.Show("Actualización exitosa.");
                    txtDescCaptura.Text = "";
                    txtPrecioCaptura.Text = "";
                    txtCategoria.Text = "";
                    cmbClaves.SelectedIndex = -1;
                    ArticulosActualizar_Load(this, new EventArgs());
                }
            }
        }

        private void ArticulosActualizar_Load(object sender, EventArgs e)
        {
            foreach (Articulo articulo in Empresa.getArticulos())
                cmbClaves.Items.Add(articulo.Clave);

        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaves.SelectedIndex != -1)
            {
                string clave = cmbClaves.SelectedItem.ToString();
                foreach (Articulo articulo in Empresa.getArticulos())
                    if (articulo.Clave == Convert.ToInt32(clave))
                    {
                        txtDescCaptura.Text = articulo.Descripcion;
                        txtPrecioCaptura.Text = articulo.Precio.ToString();
                        txtCategoria.Text = Empresa.getNombreCategoria(articulo.Categoria);
                    }
            }
        }
    }
}
