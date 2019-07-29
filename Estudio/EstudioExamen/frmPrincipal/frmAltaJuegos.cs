using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmAltaJuegos : Form
    {
        Dictionary<int, Juego> juego;
        public frmAltaJuegos(Dictionary<int, Juego> J)
        {
            InitializeComponent();
            juego = J;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult confirmar = MessageBox.Show("¿Desea confirmar el guardado?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if(validarDatos()==false)
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    if(buscarCodigo(codigo)==false)
                    {
                        string nombre = txtNombre.Text;
                        if(buscarNombre(nombre)==false)
                        {
                            string desarrollador = txtDesarrollador.Text;
                            int existencia = Convert.ToInt32(txtExistencia.Text);

                            Juego jue = new Juego(nombre, desarrollador, existencia);

                            juego.Add(codigo, jue);

                            limpia();

                            MessageBox.Show("Se ha guardado el videojuego", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Nombre Duplicado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Codigo Duplicado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(txtCodigo.Text=="")
                    {
                        errorProvider1.SetError(txtCodigo, "Ingrese los datos faltantes");
                    }
                    if(txtDesarrollador.Text=="")
                    {
                        errorProvider1.SetError(txtDesarrollador, "Ingrese los datos faltantes");
                    }
                    if(txtExistencia.Text=="")
                    {
                        errorProvider1.SetError(txtExistencia, "Ingrese los datos faltantes");
                    }
                    if(txtExistencia.Text=="0")
                    {
                        errorProvider1.SetError(txtExistencia, "La existencia debe ser mayor que 0");
                    }
                    if(txtNombre.Text=="")
                    {
                        errorProvider1.SetError(txtNombre, "Ingrese los datos faltantes");
                    }
                }

            }

        }
        public void limpia()
        {
            txtCodigo.Text = "";
            txtDesarrollador.Text = "";
            txtExistencia.Text = "";
            txtNombre.Text = "";

        }

        public bool buscarNombre(string nombre)
        {
            bool resultado = false;

            foreach(var item in juego)
            {
                if(nombre==item.Value.pNombre)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        public bool buscarCodigo(int codigo)
        {
            bool resultado = false;

            for(int i=0; i<juego.Keys.Count; i++)
            {
                if(juego.Keys.Equals(codigo))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        public bool validarDatos()
        {
            bool resultado = false;

            if(txtCodigo.Text=="" || txtNombre.Text=="" || txtDesarrollador.Text=="" || txtExistencia.Text=="" || txtExistencia.Text=="0")
            {
                resultado = true;
            }

            return resultado;
        }

        private void frmAltaJuegos_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDesarrollador.Text = "";
            txtExistencia.Text = "";
            txtNombre.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar) && (e.KeyChar!=(char)Keys.Back)))
            {
                errorProvider1.SetError(txtCodigo, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtCodigo, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (!(char.IsNumber)(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back) && (e.KeyChar!=(char)Keys.Space))
            {
                errorProvider1.SetError(txtNombre, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDesarrollador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (!(char.IsLetter(e.KeyChar))) && (e.KeyChar!=(char)Keys.Back) && (e.KeyChar!=(char)Keys.Space))
            {
                errorProvider1.SetError(txtDesarrollador, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDesarrollador, "");
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back))
            {
                errorProvider1.SetError(txtExistencia, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtExistencia, "");
            }
        }
    }
}
