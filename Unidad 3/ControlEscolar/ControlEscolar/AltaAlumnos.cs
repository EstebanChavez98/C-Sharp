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
using LibreriaBD;

namespace ControlEscolar
{
    public partial class frmAltaAlumnos : Form
    {
        public frmAltaAlumnos()
        {
            InitializeComponent();
        }

        public int damefinal()
        {
            int c = 0;
            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("error de conexion");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return c;
            }

            string strComando = "select NumControl from Alumnos";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if (lector == null)
            {
                MessageBox.Show("error de consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return c;
                conn.Close();
            }

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    c = Convert.ToInt32(lector.GetValue(0).ToString());
                }
                c+=2;
            }
            conn.Close();
            return c;

            /*int c = 0;
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = JOCA-DELGADO\\JOCADELGADO; Initial Catalog=ControlEscolar; Integrated Security=True";
                conexion.Open();
                String sql = "select NumControl from Alumnos";
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader tabla = comando.ExecuteReader();
                if (tabla.HasRows)
                {
                    while (tabla.Read())
                    {
                        c = int.Parse(tabla.GetValue(0).ToString());
                    }
                    c+=2;
                }
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error de?: " + err.Message);
            }
            return c;*/

        }

        private void frmAltaEmpleados_Load(object sender, EventArgs e)
        {
            mcNac.Visible = false;
            txtNumControl.Text = damefinal().ToString();


            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible conectar con datos");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }

            string strComando = "select NombreC from Carreras";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
                conn.Close();
            }

            if (lector.HasRows)
            {
                cmbCarrera.Items.Clear();
                while (lector.Read())
                {
                    cmbCarrera.Items.Add(lector.GetValue(0).ToString());
                }
            }

            conn.Close();

        }

        private void txtFechaNac_Click(object sender, EventArgs e)
        {
            mcNac.Visible = true;
        }

        private void mcNac_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaNac.Text = mcNac.SelectionEnd.Date.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult con = MessageBox.Show("Confirmar la alta del alumno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (con == DialogResult.Yes)
            {
                if (validaDatos() == false)
                {
                    string nombre = txtNombre.Text;
                    string aPat = txtApeP.Text;
                    string aMat = txtApeM.Text;
                    if (buscaAlumno(nombre, aPat, aMat) == false)
                    {
                        string curp = txtCurp.Text;
                        if (buscaCurp(curp) == false)
                        {
                            DateTime fechNac = Convert.ToDateTime(txtFechaNac.Text);
                            double telefono = Convert.ToDouble(txtTelefono.Text);
                            string carrera = cmbCarrera.SelectedItem.ToString();
                            int clave = consigueCarrera(carrera);

                            char sexo = 'H';
                            if (rdFemenino.Checked)
                            {
                                sexo = 'M';
                            }
                            if (rdMasculino.Checked)
                            {
                                sexo = 'H';
                            }

                            string tutor = txtTutor.Text;


                            string strCon = UsoBD.ObtenerStrConeccion();
                            SqlConnection conn = UsoBD.ConectaBD(strCon);
                            if(conn==null)
                            {
                                MessageBox.Show("Imposible conectar con los datos");
                                foreach(SqlError err in UsoBD.ESalida.Errors)
                                {
                                    MessageBox.Show(err.Message);
                                }
                                return;
                                conn.Close();
                            }
                            
                            

                            string strComando = "insert into Alumnos(NombreAlu, ApellidoP, ApellidoM, Curp, FechaNac, Sexo, Telefono, Carrera, Tutor)";
                            strComando += " Values(@Nombre, @aPat, @aMat, @Curp, @FNac, @Sexo, @Telefono, @ClaveC, @Tutor)";


                            SqlCommand cmd = new SqlCommand(strComando, conn);
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@aPat", aPat);
                            cmd.Parameters.AddWithValue("@aMat", aMat);
                            cmd.Parameters.AddWithValue("@Curp", curp);
                            cmd.Parameters.AddWithValue("@FNac", fechNac);
                            cmd.Parameters.AddWithValue("@Sexo", sexo);
                            cmd.Parameters.AddWithValue("@Telefono", telefono);
                            cmd.Parameters.AddWithValue("@ClaveC", clave);
                            cmd.Parameters.AddWithValue("@Tutor", tutor);

                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error al insertar");
                                foreach (SqlError err in ex.Errors)
                                {
                                    MessageBox.Show(err.Message);

                                }
                                conn.Close();
                            }
                            limpiar();
                            MessageBox.Show("Alumno Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("CURP duplicada, cambie de curp", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El alumno ya está dado de alta", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Datos incompletos. Ingrese los datos faltantes", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtNombre.Text == "")
                    {
                        errorProvider1.SetError(txtNombre, "Ingrese datos");
                    }
                    if (txtApeP.Text == "")
                    {
                        errorProvider1.SetError(txtApeM, "Ingrese datos");
                    }
                    if (txtApeM.Text == "")
                    {
                        errorProvider1.SetError(txtApeM, "Ingrese datos");
                    }
                    if (txtCurp.Text == "")
                    {
                        errorProvider1.SetError(txtCurp, "Ingrese datos");
                    }
                    if (txtFechaNac.Text == "")
                    {
                        errorProvider1.SetError(txtFechaNac, "Ingrese datos");
                    }
                    if (txtTelefono.Text == "")
                    {
                        errorProvider1.SetError(txtTelefono, "Ingrese datos");
                    }
                    if (cmbCarrera.Text == "")
                    {
                        errorProvider1.SetError(cmbCarrera, "Seleccione una carrera");
                    }
                    if (txtTutor.Text == "")
                    {
                        errorProvider1.SetError(txtTutor, "Ingrese datos");
                    }
                }
            }

        }
                
        public void limpiar()
        {
            txtApeM.Text = "";
            txtApeP.Text = "";
            txtCurp.Text = "";
            txtFechaNac.Text = "";
            txtNombre.Text = "";
            txtNumControl.Text = "";
            txtTelefono.Text = "";
            txtTutor.Text = "";
            rdFemenino.Checked = false;
            rdMasculino.Checked = false;
            txtNumControl.Text = Convert.ToString(damefinal());
            cmbCarrera.Text = "";
        }

        public int consigueCarrera(string carrera)
        {
            int clave = 0;
            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if(conn==null)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return clave;

            }
            
            string strComando = "select ClaveC from Carreras where NombreC='" + carrera + "'";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if(lector==null)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    clave = Convert.ToInt32(lector.GetValue(0));
                }
            }


            return clave;
        }

        public bool buscaAlumno(string nombre, string aPat, string aMat)
        {
            bool c = false;

            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);

            if(conn==null)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                c = true;
                return c;

            }
           
            string strComando = "select NumControl from Alumnos where NombreAlu='" + nombre + "' and ApellidoP='"+ aPat + "' and ApellidoM='"+ aMat+"'" ;

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if(lector==null)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }

            if (lector.HasRows)
            {
                c = true;
            }


            return c;  
        }

        public bool buscaCurp(string curp)
        {
            bool c = false;

            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if(conn==null)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                c = true;
                return c;

            }
  
            string strComando = "select NombreAlu from Alumnos where Curp='"+ curp+ "'";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);

            if(lector==null)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }

            if (lector.HasRows)
            {
                c = true;
            }


            return c;
        }

        public bool validaDatos()
        {
            bool c = false;

            if (rdFemenino.Checked == false && rdMasculino.Checked==false)
            {
                c = true;
            }

            if(txtNombre.Text=="" || txtApeP.Text=="" || txtApeM.Text=="" || txtCurp.Text=="" || txtFechaNac.Text=="" || txtTelefono.Text=="" || txtTutor.Text=="" || cmbCarrera.Text=="")
            {
                c = true;
            }




            return c;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtNombre, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtApeP, "No se permiten numeros ni caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtApeP, "");
            }
        }

        private void txtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtApeM, "No se permiten numeros ni caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtApeM, "");
            }
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtCurp, "No se permiten caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtCurp, "");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(txtTelefono, "solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void txtTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtTutor, "No se permiten numeros ni caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtTutor, "");
            }
        }
    }
}
