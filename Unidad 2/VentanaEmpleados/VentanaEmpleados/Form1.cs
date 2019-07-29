using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaEmpleados
{
    public partial class Form1 : Form
    {

        Dictionary<int, Empleado> dicEmpleados = new Dictionary<int, Empleado>();
        List<Departamento> listDepartamentos = new List<Departamento>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            /*foreach(Departamento dep in listDepartamentos)
            {
               // cmbDepartamento.Items.Add(dep.pNomDep);
            }*/
        }

        private void txtClaveEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            DialogResult confirmar = MessageBox.Show("Quiere confirmar el guardado de empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmar==DialogResult.Yes)
            {
                if (validaDatos() == false)
                {
                    int claveEmp = Convert.ToInt32(txtClaveEmpleado.Text);
                    if (validaClave(claveEmp) == false)
                    {
                        string nombre = txtNombre.Text;
                        if (validaNombre(nombre) == false)
                        {
                            string domilicio = txtDomicilio.Text;
                            string departamento = cmbDepartamento.Text;
                            string sexo;
                            string sexo1 = "";
                            if (rdMasculino.Checked)
                            {
                                sexo1 = "Masculino";
                            }
                            if (rdFemenino.Checked)
                            {
                                sexo1 = "Femenino";
                            }
                            sexo = sexo1;

                            string idiomas, idioma = "";
                            if (chkChinoMandarin.Checked)
                            {
                                idioma += "Chino Mandarin ";
                            }
                            if (chkIngles.Checked)
                            {
                                idioma += "Ingles ";
                            }
                            if (chkPortugues.Checked)
                            {
                                idioma += "Portugues ";
                            }
                            idiomas = idioma;

                            Empleado empleado = new Empleado(nombre, domilicio, departamento, sexo, idiomas);
                            dicEmpleados.Add(claveEmp, empleado);

                            limpia();

                            MessageBox.Show("Empleado guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Nombre duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        public bool validaDatos()
        {
            bool resultado = false;
            string clave = txtClaveEmpleado.Text;
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            string departamento = cmbDepartamento.Text;

            if (chkChinoMandarin.Checked || chkIngles.Checked || chkPortugues.Checked)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            if (rdFemenino.Checked || rdMasculino.Checked)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            if (clave == "" || nombre == "" || domicilio == "" || departamento == "")
            {
                resultado = true;
            }

            return resultado;
        }

        public bool validaDatosDep()
        {
            bool encontro = false;
            string claveDep, nombreDep, jefeDep;

            claveDep = txtClaveDepartamento.Text;
            nombreDep = txtNombreDepartamento.Text;
            jefeDep = txtJefeDepartamento.Text;

            if(claveDep=="" || nombreDep=="" || jefeDep=="")
            {
                encontro = true;
            }

            return encontro;


        }

        public bool validaClave(int clave)
        {
            bool encontro = false;
            for(int i=0; i<dicEmpleados.Count;i++)
            {
                if(dicEmpleados.ContainsKey(clave))
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }

        public bool validaNombre(string nombre)
        {
            bool encontro = false;

            foreach(var item in dicEmpleados)
            {
                if(nombre==item.Value.pNombre)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }

        public void limpia()
        {
            txtClaveEmpleado.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            cmbDepartamento.Text = "";
            chkChinoMandarin.Checked = false;
            chkIngles.Checked = false;
            chkPortugues.Checked = false;
        }

        public void limpiaDep()
        {
            txtNombreDepartamento.Text = "";
            txtJefeDepartamento.Text = "";
            txtClaveDepartamento.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClaveEmpleado.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            cmbDepartamento.Text = "";
            chkChinoMandarin.Checked = false;
            chkIngles.Checked = false;
            chkPortugues.Checked = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaEmpleado consulta = new ConsultaEmpleado(dicEmpleados);
            consulta.ShowDialog();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnDGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Quiere confirmar el guardado de empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmar==DialogResult.Yes)
            {
                if(validaDatosDep()==false)
                {
                    string claveDep = txtClaveDepartamento.Text;

                    if(validaClaveDep(claveDep)==false)
                    {
                        string nombreDep = txtNombreDepartamento.Text;

                        if(validaNomDep(nombreDep)==false)
                        {
                            string jefeDep = txtJefeDepartamento.Text;

                            if(validaJefe(jefeDep)==false)
                            {

                                Departamento departamento = new Departamento(claveDep, nombreDep, jefeDep);

                                listDepartamentos.Add(departamento);

                                limpiaDep();

                                MessageBox.Show("Departamento guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbDepartamento.Items.Add(departamento.pNomDep);
                            }
                            else
                            {
                                MessageBox.Show("Jefe duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Departamento duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave de departamento duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool validaClaveDep(string clave)
        {
            bool encontro = false;

            foreach(var item in listDepartamentos)
            {
                if(clave==item.pClaveDep)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }
        public bool validaNomDep(string nombre)
        {
            bool encontro = false;

            foreach(var item in listDepartamentos)
            {
                if(nombre==item.pNomDep)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }
        public bool validaJefe(string jefe)
        {
            bool encontro = false;

            foreach(var item in listDepartamentos)
            {
                if(jefe==item.pJefe)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }

        private void btnDCosulta_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento consultaDep = new frmConsultaDepartamento(listDepartamentos);
            consultaDep.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDLimpiar_Click(object sender, EventArgs e)
        {
            txtClaveDepartamento.Text = "";
            txtJefeDepartamento.Text = "";
            txtNombreDepartamento.Text = "";
        }

        private void btnDSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClaveDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtClaveDepartamento, "No se permiten espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtClaveDepartamento, "");
            }
        }

        private void txtNombreDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtNombreDepartamento, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombreDepartamento, "");
            }
        }

        private void txtJefeDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtJefeDepartamento, "Solo se permiten letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtJefeDepartamento, "");
            }
        }

        private void txtClaveEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtClaveEmpleado, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtClaveEmpleado, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtDomicilio, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtDomicilio, "");
            }
        }
    }
}
