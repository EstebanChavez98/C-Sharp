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
    public partial class ArticulosConsultaNombre : Form
    {
        public ArticulosConsultaNombre()
        {
            InitializeComponent();
        }

        private void cmbClaves_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != ','
                && e.KeyChar != '.')
            {
                errorProvider1.SetError(cmbNombres, "Caracter inválido");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(cmbNombres, "");
                e.KeyChar=e.KeyChar.ToString().ToUpper()[0];
            }
        }

        private void ArticulosConsultaNombre_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = Empresa.getArticulos();
            AutoCompleteStringCollection nombres = new AutoCompleteStringCollection();
            for (int i = 0; i < articulos.Count; i++)
                nombres.Add(articulos[i].Descripcion);
            cmbNombres.AutoCompleteCustomSource = nombres;
            cmbNombres.DataSource = articulos;
            
           
        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Articulo> articulos = Empresa.getArticulos();
            //Articulo articulo = articulos[cmbNombres.SelectedIndex];
            Articulo articulo = cmbNombres.SelectedItem as Articulo;
            List<Categoria> categorias = Empresa.getCategorias();

            string categoria = null;

            foreach (Categoria c in categorias)
                if (c.Clave == articulo.Categoria)
                {
                    categoria = c.Nombre;
                    break;
                }

            txtClave.Text = articulo.Clave.ToString();
            txtCategoria.Text = categoria;
            txtPrecioCaptura.Text ="$" + articulo.Precio.ToString();

        }
    }
}
