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
    public partial class frmPrestamoLibros : Form
    {
        Dictionary<string, Libro> libro;
        List<Prestamo> prestamo;
        public frmPrestamoLibros(Dictionary<string, Libro> l,  List<Prestamo> p)
        {
            InitializeComponent();
            libro = l;
            prestamo = p;
        }

        private void frmPrestamoLibros_Load(object sender, EventArgs e)
        {
            foreach(Libro l in libro.Values)
            {
                cmbLibro.Items.Add(l.pNombre);
            }
            rdMaestro.Checked = true;
        }

        public bool validarDatos()
        {
            bool resultado = false;

            if(rdAlumno.Checked)
            {
                resultado = false;
            }
            if(rdMaestro.Checked)
            {
                resultado = false;
            }
            if(cmbLibro.Text=="")
            {
                resultado = true;
            }
            
            if(dtpFechaDevolucion.Value==DateTime.Today)
            {
                resultado = true;
            }            

            return resultado;
        }

        public bool buscarUso(string nombre)
        {
            bool resultado = false;

            foreach(var item in libro)
            {
                if(nombre==item.Value.pNombre)
                {
                    string uso = item.Value.pUso;
                    if (uso == "Interno")
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            return resultado;
        }

        public string buscarIsbn(string nombre)
        {
            string existencia = "";
            foreach (var item in libro)
            {
                if (nombre == item.Value.pNombre)
                {
                    existencia = item.Key;
                }
            }
            return existencia;
        }

        public int buscarExistencia(string nombre)
        {
            int existencia = 0;
            foreach(var item in libro)
            {
                if(nombre==item.Value.pNombre)
                {
                    existencia = item.Value.pExistencia;
                }
            }
            return existencia; 
        }

        public void restarExistencia(string nombre)
        {
            foreach(var item in libro)
            {
                if(nombre==item.Value.pNombre)
                {
                    item.Value.pExistencia = item.Value.pExistencia - 1;
                }
            }
        }

        public void limpia()
        {
            rdAlumno.Checked = true;
            cmbLibro.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCodigo.Text = "";
        }

        public bool buscarCodigo(string codigo)
        {
            bool resultado = false;

            foreach(var item in prestamo)
            {
                if(codigo==item.pCodigo)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        public bool confirmarUsuario(string nombre)
        {
            bool resultado = false;

            foreach(var item in libro)
            {
                if(nombre==item.Value.pNombre)
                {

                }
            }

            return resultado;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿seguro que desea guardar el prestamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if (validarDatos() == false)
                {

                    DateTime fecha1 = DateTime.Today;
                    int dia = dtpFechaDevolucion.Value.Day - fecha1.Day;

                    if(dia<1 || dia>7)
                    {
                        MessageBox.Show("La fecha de devolucion no debe ser mayor de 7 dias", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string nombre = cmbLibro.Text;
                        if (buscarUso(nombre) == false)
                        {

                            string usuario, usuarios = "";
                            if (rdAlumno.Checked)
                            {
                                usuarios = "Alumno";
                            }
                            if (rdMaestro.Checked)
                            {
                                usuarios = "Maestro";
                            }
                            usuario = usuarios;

                            string nombreUsuario = txtNombre.Text;
                            string domicilio = txtDireccion.Text;
                            string isbn = buscarIsbn(nombre);
                            string codigo = txtCodigo.Text;

                            if (buscarCodigo(codigo) == false)
                            {

                                if (buscarExistencia(nombre) >=1)
                                {

                                    restarExistencia(nombre);


                                    DateTime fecha = dtpFechaDevolucion.Value;

                                    Prestamo prestamos = new Prestamo(codigo, usuario, isbn, nombreUsuario, domicilio, fecha);

                                    prestamo.Add(prestamos);

                                    limpia();

                                    MessageBox.Show("Se ha registrado el prestamo", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No hay copias en existencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                MessageBox.Show("Codigo duplicado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Solo se pueden prestar los libros de uso general", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(txtCodigo.Text=="")
                    {
                        errorProvider1.SetError(txtCodigo, "Ingrese los datos");
                    }
                    if(txtDireccion.Text=="")
                    {
                        errorProvider1.SetError(txtDireccion, "Ingrese los datos");
                    }
                    if(txtNombre.Text=="")
                    {
                        errorProvider1.SetError(txtNombre, "Ingrese los datos");
                    }
                }
            }
        }

        private void cmbLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar!=(char)Keys.Space) && (e.KeyChar!=(char)Keys.Back))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtDireccion, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdAlumno.Checked = true;
            cmbLibro.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCodigo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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
