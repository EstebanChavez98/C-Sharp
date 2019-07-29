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
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = Empresa.getArticulos();
            foreach (Articulo articulo in articulos)
                cmbClaves.Items.Add(articulo.Clave);
        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaves.SelectedIndex!=-1)
            {
                string clave = cmbClaves.Text;
                string consulta = "select a.descripcion,precio,c.nombre from Articulos a join Categorias c on c.claveCategoria=a.claveCategoria where claveArticulo=" + clave;
                Sql.setCommand(consulta);

                if (Sql.AbrirConexion())
                {
                    try
                    {
                        SqlDataReader lector = Sql.Command.ExecuteReader();

                        if (lector.HasRows)
                            while (lector.Read())
                            {
                                string descripcion = lector.GetValue(0).ToString();
                                string precio = "$" + lector.GetValue(1).ToString();
                                string categoria = lector.GetValue(2).ToString();

                                txtDescCaptura.Text = descripcion;
                                txtPrecioCaptura.Text = precio;
                                txtCategoria.Text = categoria;
                            }
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
}
