using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BibliotecaGUI
{
    public partial class frmAltaLibros : Form
    {

        Dictionary<string, Libro> dicLibro;
            

        public frmAltaLibros(Dictionary<string, Libro> libro)
        {
            InitializeComponent();
            dicLibro = libro;
        }

        private void lblNombreLibro_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaLibros_Load(object sender, EventArgs e)
        {
            rdGeneral.Checked = true;
            txtExistencia.Text = "0";

        }

        public bool validaDatos()
        {
            bool resultado = false;

            string isbn = txtISBN.Text;
            string nombre = txtNombreLibro.Text;
            string autor = txtAutor.Text;
            string editorial = txtEditorial.Text;
            

            if(rdGeneral.Checked || rdInterno.Checked)
            {
                resultado = false;
            }
            

            if (isbn == "" || nombre == "" || autor == "" || editorial == ""|| txtExistencia.Text=="")
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            if (chkAlumno.Checked == false && chkMaestro.Checked == false)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool buscarISBN(string isbn)
        {
            bool resultado = false;

            for(int i=0; i<dicLibro.Count;i++)
            {
                if(dicLibro.ContainsKey(isbn))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        public bool buscarNombre(string nombre)
        {
            bool resultado = false;

            foreach(var item in dicLibro)
            {
                if(nombre==item.Value.pNombre)
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Seguro de guardar el libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if(validaDatos()==false)
                {
                    string isbn = txtISBN.Text;
                    if(buscarISBN(isbn)==false)
                    {
                        string nombre = txtNombreLibro.Text;
                        if(buscarNombre(nombre)==false)
                        {
                            string autor = txtAutor.Text;
                            string editorial = txtEditorial.Text;
                            int existencia = Convert.ToInt32(txtExistencia.Text);
                            string uso, usos = "";
                            if(rdGeneral.Checked)
                            {
                                usos = "General";
                            }
                            if(rdInterno.Checked)
                            {
                                usos = "Interno";
                            }
                            uso = usos;

                            string usuario, usuarios = "";
                            if(chkAlumno.Checked)
                            {
                                usuarios += "Alumnos ";
                            }
                            if(chkMaestro.Checked)
                            {
                                usuarios += "Maestros";
                            }
                            usuario = usuarios;

                            Libro libro = new Libro(nombre, autor, editorial, existencia, uso, usuario);
                            dicLibro.Add(isbn, libro);

                            limpia();

                            MessageBox.Show("Libro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

                        }
                        else
                        {
                            MessageBox.Show("Nombre Duplicado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }else
                    {
                        MessageBox.Show("ISBN duplicado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }else
                {
                    MessageBox.Show("Datos incompletos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtAutor.Text == "")
                    {
                        errorProvider1.SetError(txtAutor, "Ingrese datos");
                    }
                    if (txtEditorial.Text == "")
                    {
                        errorProvider1.SetError(txtEditorial, "Ingrese datos");
                    }
                    if (txtExistencia.Text == "" || txtExistencia.Text=="0")
                    {
                        errorProvider1.SetError(txtExistencia, "Ingrese datos");
                    }
                    if (txtISBN.Text == "")
                    {
                        errorProvider1.SetError(txtISBN, "Ingrese datos");
                    }
                    if (txtNombreLibro.Text == "")
                    {
                        errorProvider1.SetError(txtNombreLibro, "Ingrese datos");
                    }
                }
            }
        }

        public void activarUsuario()
        {
            if (rdInterno.Checked == true)
            {
                grpUsuario.Enabled=false;
            }
        }

        public void limpia()
        {
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtExistencia.Text = "";
            txtISBN.Text = "";
            txtNombreLibro.Text = "";
            chkAlumno.Checked = false;
            chkMaestro.Checked = false;
            rdGeneral.Checked = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtExistencia.Text = "";
            txtISBN.Text = "";
            txtNombreLibro.Text = "";
            txtExistencia.Text = "0";
            rdGeneral.Checked = true;

            chkAlumno.Checked = false;
            chkMaestro.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtISBN, "Solo se permite letras y numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtISBN, "");
            }
        }

        private void txtNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back) && (e.KeyChar!=(char)Keys.Space))
            {
                errorProvider1.SetError(txtNombreLibro, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombreLibro, "");
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back) && (e.KeyChar!=(char)Keys.Space))
            {
                errorProvider1.SetError(txtAutor, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtAutor, "");
            }
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtEditorial, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtEditorial, "");
            }
        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar!=(char)Keys.Space) && (e.KeyChar!=(char)Keys.Back))
            {
                errorProvider1.SetError(txtExistencia, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtExistencia, "");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaLibros consultaLibros = new frmConsultaLibros(dicLibro);
            consultaLibros.ShowDialog();
        }

        private void rdGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if(rdGeneral.Checked)
            {
                grpUsuario.Visible = true;
            }
            else
            {
                grpUsuario.Visible = false;
            }
        }

        private void rdInterno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdGeneral.Checked)
            {
                grpUsuario.Visible = false;
            }

        }

        private void grpUso_Enter(object sender, EventArgs e)
        {

        }
    }
}
