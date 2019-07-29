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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = Empresa.getArticulos();
            List<Categoria> categorias = Empresa.getCategorias();

            foreach (Articulo articulo in articulos)
            {
                string categoria = "";
                foreach (Categoria cat in categorias)
                    if (cat.Clave == articulo.Categoria)
                        categoria = cat.Nombre;

                dataGridView1.Rows.Add(articulo.Clave, articulo.Descripcion, articulo.Precio, categoria);
            }
        }
    }
}
