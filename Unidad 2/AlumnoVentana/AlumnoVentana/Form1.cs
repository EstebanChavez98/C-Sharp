using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoVentana
{
    public partial class Form1 : Form
    {
        long NCConsecutivo = 1000;
        Dictionary<long, Alumno> dicAlumnos = new Dictionary<long, Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNControl_TextChanged(object sender, EventArgs e)
        {

        }

        public void calculaNC()
        {
            NCConsecutivo += 2;
            int año = DateTime.Now.Year;
            string numControl = año.ToString().Substring(2, 2) + "17" + NCConsecutivo;
            txtNControl.Text = numControl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NCConsecutivo += 2;
            calculaNC();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Estas seguro de guardar al alumno? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                if (validaDatos())
                {
                    string Nombre = txtNombre.Text;
                    string Domicilio = txtDomicilio.Text;
                    int Edad = Convert.ToInt32(txtEdad.Text);

                    long nControl = Convert.ToInt64(txtNControl.Text);
                    string Carrera = cmbCarrera.SelectedItem.ToString();
                    //aumentar el contador, crear el objeto alumno, agregarlo al dictionary

                    Alumno alu = new Alumno(Nombre, Domicilio, Carrera, Edad);
                    dicAlumnos.Add(nControl, alu);
                    calculaNC();
                    Limpia();

                    DialogResult guardado = MessageBox.Show("Alumno guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult error = MessageBox.Show("Datos Incompletos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                        
        }

        public void Limpia()
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtEdad.Text = "";
            cmbCarrera.Text = "";
        }

        public bool validaDatos()
        {
            bool resultado = true;

            string edad = txtEdad.Text;
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            string carrera = cmbCarrera.Text;
            if(edad=="" || nombre=="" || domicilio=="" || carrera=="")
            {
                resultado = false;
            }

            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtEdad.Text = "";
            cmbCarrera.Text = "";

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultas consulta = new frmConsultas(dicAlumnos);
            consulta.ShowDialog();
        }
    }
}
