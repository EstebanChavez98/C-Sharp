using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosGUI
{
    public partial class Form1 : Form
    {
        Dictionary<string, Marca> dicMarcas;
        public Form1(Dictionary<string, Marca> d)
        {
            InitializeComponent();
            dicMarcas = d;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar =  MessageBox.Show("Seguro que desea guardar la marca?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmar==DialogResult.Yes)
            {
                if(validaDatos())
                {
                    string clave = txtClave.Text;
                    if (validaClave(clave)==false)
                    {
                        string nombre = txtNombre.Text;
                        if (validaMarca(nombre) == false)
                        {
                            string ciudad = cmbCiudad.Text;

                            string descripcion = txtDescripcion.Text;

                            Marca marc = new Marca(nombre, descripcion, ciudad);
                            dicMarcas.Add(clave, marc);

                            Limpia();

                            MessageBox.Show("Marca Guardada", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nombre Duplicado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave Duplicada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Datos incompletos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void Limpia()
        {
            txtClave.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbCiudad.Text = "";
        }

        public bool validaDatos()
        {
            bool resultado = true;

            string clave=txtClave.Text;
            string nombre =txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string ciudad = cmbCiudad.Text;
            if (clave == "" || nombre == "" || descripcion == "" || ciudad == "")
            {
                resultado = false;
            }

            return resultado;
        }

        public bool validaClave(String clave)
        {
            bool encontro = false;
            for(int i =0;i<dicMarcas.Count;i++)
            {
                if(dicMarcas.ContainsKey(clave))
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        public bool validaMarca(string nombre)
        {
            bool encontro = false;
            foreach(var item in dicMarcas)
            {
                if(nombre==item.Value.pNombre)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbCiudad.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(dicMarcas);
            consulta.ShowDialog();
        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
            {
                errorProvider1.SetError(txtClave, "No se permiten espacios en blanco");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtClave, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtDescripcion, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");
            }
        }
    }
}
