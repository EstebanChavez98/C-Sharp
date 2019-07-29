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
    public partial class Almacenes : Form
    {
        public Almacenes()
        {
            InitializeComponent();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            cmbArticulos.DataSource = Empresa.getArticulos();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (Articulo articulo in Empresa.getArticulos())
                auto.Add(articulo.Descripcion);
            cmbArticulos.AutoCompleteCustomSource = auto;

            string consulta = "select claveSucursal,nombre from Sucursales";
            Sql.setCommand(consulta);
            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();
                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            KeyValue k = new KeyValue(lector.GetValue(0).ToString(), lector.GetValue(1).ToString());
                            cmbSucursales.Items.Add(k);
                            cmbSucursales.AutoCompleteCustomSource.Add(k.Value);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }
            cmbArticulos.SelectedIndex = -1;
        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbSucursales, "");
            cmbArticulos.SelectedIndex = -1;
        }

        private void cmbSucursales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '´')
            {
                e.Handled = true;
            }
            else
                e.KeyChar = e.KeyChar.ToString().ToUpper().ElementAt(0);
        }

        private void cmbArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '´')
            {
                e.Handled = true;
            }
            else
                e.KeyChar = e.KeyChar.ToString().ToUpper().ElementAt(0);
        }
        private bool CamposVacios()
        {
            bool vacio = false;
            int sucursal = cmbSucursales.SelectedIndex;
            int articulo = cmbArticulos.SelectedIndex;

            if (sucursal==-1)
            {
                errorProvider1.SetError(cmbSucursales, "Seleccione una sucursal.");
                vacio = true;
            }
            if (articulo==-1)
            {
                errorProvider1.SetError(cmbArticulos, "Seleccione un artículo.");
                vacio = true;
            }
            if (nudCantidad.Value==0)
            {
                errorProvider1.SetError(nudCantidad, "Seleccione una cantidad mayor a 0.");
                vacio = true;
            }
            return vacio;
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbArticulos, "");
            if (cmbSucursales.SelectedIndex!=-1 && cmbArticulos.SelectedIndex!=-1)
            {
                Articulo articulo = cmbArticulos.SelectedItem as Articulo;
                string claveArticulo = articulo.Clave.ToString();
                KeyValue sucursal = cmbSucursales.SelectedItem as KeyValue;
                string consulta =
                    string.Format("select existencia from Almacen where claveSucursal={0} and claveArticulo={1}", sucursal.Key, articulo.Clave.ToString());
                Sql.setCommand(consulta);
                if (Sql.AbrirConexion())
                {
                    try
                    {
                        SqlDataReader lector = Sql.Command.ExecuteReader();
                        if (lector.HasRows)
                            while (lector.Read())
                                txtPrecioCaptura.Text = lector.GetValue(0).ToString();
                        else
                            txtPrecioCaptura.Text = "0";
                    }catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        Sql.Connection.Close();
                    }
                }
                Sql.Connection.Close();
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(nudCantidad, "");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex != -1 && cmbSucursales.SelectedIndex != -1)
            {
                Articulo articulo = cmbArticulos.SelectedItem as Articulo;
                string claveArticulo = articulo.Clave.ToString();
                KeyValue sucursal = cmbSucursales.SelectedItem as KeyValue;
                string claveSucursal = sucursal.Key;
                string cantidad = nudCantidad.Value.ToString();
                if (CamposVacios())
                    MessageBox.Show("Hay campos vacíos.");
                else if (AlmacenExistente(claveSucursal, claveArticulo))
                {
                    string update =
                        string.Format("update Almacen set existencia=(existencia + {0}) where claveSucursal={1} and claveArticulo={2}", cantidad, claveSucursal, claveArticulo);
                    if (Sql.executeCommand(update))
                    {
                        MessageBox.Show("Existencia actualizada.");
                        Limpiar();
                    }
                }
                else
                {
                    string insert =
                        string.Format("insert into Almacen(claveSucursal,claveArticulo,existencia) values({0},{1},{2})", claveSucursal, claveArticulo, cantidad);
                    if (Sql.executeCommand(insert))
                    {
                        MessageBox.Show("Registro exitoso.");
                        Limpiar();
                    }
                }
            }
            else
                MessageBox.Show("Hay campos vacíos.");
        }
        private bool AlmacenExistente(string sucursal,string articulo)
        {
            bool existente = false;
            string consulta =
                string.Format("select existencia from Almacen where claveSucursal={0} and claveArticulo={1}", sucursal, articulo);

            existente=Sql.exist(consulta);

            return existente;
        }
        private void Limpiar()
        {
            cmbArticulos.SelectedIndex = -1;
            cmbSucursales.SelectedIndex = -1;
            nudCantidad.Value = 0;
            txtPrecioCaptura.Text = "";
        }
    }
}
