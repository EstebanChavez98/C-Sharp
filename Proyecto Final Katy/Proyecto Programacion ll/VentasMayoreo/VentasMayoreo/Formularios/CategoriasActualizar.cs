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
namespace VentasMayoreo
{
    public partial class CategoriasActualizar : Form
    {
        public CategoriasActualizar()
        {
            InitializeComponent();
        }

        private void CategoriasActualizar_Load(object sender, EventArgs e)
        {
            foreach (Categoria categoria in Empresa.getCategorias())
                cmbClaves.Items.Add(categoria.Clave);
        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaves.SelectedIndex!=-1)
            {
                string clave = cmbClaves.Text;
                foreach (Categoria categoria in Empresa.getCategorias())
                    if (clave == categoria.Clave.ToString())
                        txtNombre.Text = categoria.Nombre;
            }
        }

        private void cmbClaves_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string clave = cmbClaves.Text;

            if (string.IsNullOrWhiteSpace(nombre))
                MessageBox.Show("Llene el campo.");
            else if (NombreDuplicado(nombre, clave))
                MessageBox.Show("Nombre duplicado.");
            else if (SinModificaciones(nombre, clave))
                MessageBox.Show("No se modificó.");
            else
            {
                string update =
                    string.Format("update Categorias set nombre='{0}' where claveCategoria={1}", nombre, clave);
                if (Sql.executeCommand(update))
                {
                    MessageBox.Show("Actualización exitosa.");
                    txtNombre.Text = "";
                    cmbClaves.SelectedIndex = -1;
                }
            }
        }

        private bool NombreDuplicado(string nombre,string clave)
        {
            bool duplicado = false;
            foreach (Categoria categoria in Empresa.getCategorias())
            {
                if (categoria.Clave.ToString() == clave)
                    continue;
                else
                {
                    if (categoria.Nombre == nombre)
                        duplicado = true;
                }
            }
            return duplicado;
        }
        private bool SinModificaciones(string nombre,string clave)
        {
            bool b = false;

            foreach (Categoria categoria in Empresa.getCategorias())
            {
                if (categoria.Clave.ToString() == clave && categoria.Nombre == nombre)
                    b = true;
            }

                return b;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '´')
            {
                errorProvider1.SetError(txtNombre, "Caracter inválido.");
                e.Handled = true;
            }
            else
                errorProvider1.SetError(txtNombre, "");
        }
    }
}
