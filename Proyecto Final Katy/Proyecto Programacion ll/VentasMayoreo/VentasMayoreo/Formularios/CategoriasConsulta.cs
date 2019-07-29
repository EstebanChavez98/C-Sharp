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
    public partial class CategoriasConsulta : Form
    {
        public CategoriasConsulta()
        {
            InitializeComponent();
        }

        private void CategoriasConsulta_Load(object sender, EventArgs e)
        {
            foreach (Categoria categoria in Empresa.getCategorias())
                cmbClaves.Items.Add(categoria.Clave);
        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaves.SelectedIndex != -1)
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

    }
}
