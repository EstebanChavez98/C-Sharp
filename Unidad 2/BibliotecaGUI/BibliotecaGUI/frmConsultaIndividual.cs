using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGUI
{
    public partial class txtFecha : Form
    {
        List<Prestamo> pres;
        public txtFecha(List<Prestamo> p)
        {
            InitializeComponent();
            pres = p;
        }

        private void txtFecha_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigo.Text;

            foreach(var item in pres)
            {
                if(codigo==item.pCodigo)
                {
                    txtUsuario.Text = item.pUsuario;
                    txtNombreUsuario.Text = item.pNombreU;
                    txtDireccion.Text = item.pDomicilio;
                    txtISBN.Text = item.pLibro;
                    txtFechaDev.Text = Convert.ToString(item.pFecha);

                    break;
                }
                else
                    MessageBox.Show("No existe el codigo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool buscarCodigo(string codigo)
        {
            bool resultado = false;

            foreach(var item in pres)
            {
                if(codigo==item.pCodigo)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (!(char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtCodigo, "no se permiten espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtCodigo, "");
            }
        }
    }
}
