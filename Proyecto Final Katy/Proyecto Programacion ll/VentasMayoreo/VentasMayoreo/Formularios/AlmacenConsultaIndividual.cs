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
    public partial class AlmacenConsultaIndividual : Form
    {
        public AlmacenConsultaIndividual()
        {
            InitializeComponent();
        }

        private void AlmacenConsultaIndividual_Load(object sender, EventArgs e)
        {
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
        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            KeyValue sucursal = cmbSucursales.SelectedItem as KeyValue;

            string consulta =
                string.Format("select art.descripcion,existencia from Almacen a join Articulos art on a.claveArticulo=art.claveArticulo where a.claveSucursal={0}", sucursal.Key);
            Sql.setCommand(consulta);
            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            ListViewItem item = new ListViewItem(lector.GetValue(0).ToString());
                            item.SubItems.Add(lector.GetValue(1).ToString());

                            listView1.Items.Add(item);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(ex.Message);
                }
                Sql.Connection.Close();
            }
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
    }
}
