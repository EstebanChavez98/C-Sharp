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
    public partial class frmAuto : Form
    {
        Dictionary<string, Marca> dicMarcas;
        List<Auto> autos;
        public frmAuto(Dictionary<string, Marca> d, List<Auto> a)
        {
            InitializeComponent();
            dicMarcas = d;
            autos = a;
        }

        private void frmAuto_Load(object sender, EventArgs e)
        {
            foreach(Marca m in dicMarcas.Values)
            {
                cmbMarcaAuto.Items.Add(m.pNombre);
            }
        }

        private void txtNombreAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumSerie_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAuto_Click(object sender, EventArgs e)
        {
            string serie, nombre, clave, manejo;
            int pasajeros=0;

            DialogResult confirmar = confirmar = MessageBox.Show("Seguro que desea guardar el auto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                if (validaDatos() == true)
                {
                    serie = txtNumSerie.Text;
                    nombre = txtNombreAuto.Text;
                    clave = cmbMarcaAuto.Text;
                    pasajeros = Convert.ToInt32(nudPasajeros.Text);
                    string tipo = "";
                    if (rdAutomatica.Checked)
                    {
                        tipo = "Automatico";
                    }
                    if (rdEstandar.Checked)
                    {
                        tipo = "Estandar";
                    }
                    manejo = tipo;

                    if (validaSerie(serie) == false)
                    {
                        autos.Add(new Auto(serie, nombre, clave, pasajeros, manejo));
                        Limpiar();
                        MessageBox.Show("Datos Guardados", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Numero de serie repetida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Datos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //DialogResult confirmar = confirmar = MessageBox.Show("Seguro que desea guardar el auto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public void Limpiar()
        {
            txtNumSerie.Text = "";
            txtNombreAuto.Text = "";
            nudPasajeros.ResetText();
            cmbMarcaAuto.Text = "";

        }

        public bool validaDatos()
        {
            bool resultado = false;

            string serie = txtNumSerie.Text;
            string nombre = txtNombreAuto.Text;
            string marca = cmbMarcaAuto.Text;
            int pasajeros = Convert.ToInt32(nudPasajeros.Text); 

            if(serie=="" || nombre=="" || marca=="")
            {
                resultado = true;
            }
            if (pasajeros > 2)
            {
                resultado = true;
            }
            else
                resultado = false;

            return resultado;
        }

        public bool validaSerie(string serie)
        {
            bool encontro = false;
            foreach(var item in autos)
            {
                if(serie==item.pNumSerie)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        private void btnLimpiarAuto_Click(object sender, EventArgs e)
        {
            txtNumSerie.Text = "";
            txtNombreAuto.Text = "";
            nudPasajeros.ResetText();
            cmbMarcaAuto.Text = "";
            
        }

        private void btnSalirAuto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaAutos frmCAutos = new frmConsultaAutos(dicMarcas, autos);
            frmCAutos.ShowDialog();
        }

        private void txtNombreAuto_KeyPress(object sender, KeyPressEventArgs e)
        {


            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back) && (e.KeyChar!=(char)Keys.Space))
            {
                errorProvider1.SetError(txtNombreAuto, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombreAuto, "");
            }
        }

        private void txtNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtNombreAuto, "No se permiten espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombreAuto, "");
            }
        }
    }
}
