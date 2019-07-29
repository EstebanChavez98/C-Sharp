using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ControlEscolar
{
    public partial class frmAltaActividad : Form
    {
        public frmAltaActividad()
        {
            InitializeComponent();
        }
        
        public bool Valida()
        {
            bool con=false;

            if(txtActividad.Text=="" || txtCreditos.Text=="" || txtTutor.Text=="")
            {
                con = true;
            }

            return con;
        }

        public int ClaveFinal()
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

            string strComando = "select ActividadID from Actividades";

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
                c++;
            }
            conn.Close();
            return c;
        }

        public bool obtenerNombre(string nombre)
        {
            bool c = false;

            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);

            if (conn == null)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                c = true;
                return c;

            }

            string strComando = "select NombreAct from Actividades where NombreAct='" + nombre + "'";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if (lector == null)
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

        public void limpiar()
        {
            txtActividad.Text = "";
            txtCreditos.Text = "";
            txtTutor.Text = "";
            txtClave.Text = Convert.ToString(ClaveFinal());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult con = MessageBox.Show("Confirmar guardado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(con == DialogResult.Yes)
            {
                if(Valida()==false)
                {
                    string nombre = txtActividad.Text;
                    if(obtenerNombre(nombre)==false)
                    {
                        string tutor = txtTutor.Text;
                        int creditos = Convert.ToInt32(txtCreditos.Text);
                        int alu = 0;

                        string strCon = UsoBD.ObtenerStrConeccion();
                        SqlConnection conn = UsoBD.ConectaBD(strCon);
                        if (conn == null)
                        {
                            MessageBox.Show("Imposible conectar con los datos");
                            foreach (SqlError err in UsoBD.ESalida.Errors)
                            {
                                MessageBox.Show(err.Message);
                            }
                            return;
                            conn.Close();
                        }



                        string strComando = "insert into Actividades(NombreAct, AlumnosReg, Tutor, Creditos)";
                        strComando += " Values(@Nombre, @Alu, @Tutor, @Creditos)";


                        SqlCommand cmd = new SqlCommand(strComando, conn);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Alu", alu);
                        cmd.Parameters.AddWithValue("@Tutor", tutor);
                        cmd.Parameters.AddWithValue("@Creditos", creditos);
                        
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
                        MessageBox.Show("Actividad Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Actividad ya registrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Datos incompletos. Complete los datos faltantes.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(txtActividad.Text=="")
                    {
                        errorProvider1.SetError(txtActividad, "Faltan datos");
                    }
                    if(txtCreditos.Text=="")
                    {
                        errorProvider1.SetError(txtCreditos, "Faltan datos");
                    }
                    if(txtTutor.Text=="")
                    {
                        errorProvider1.SetError(txtTutor, "Faltan datos");
                    }
                }
            }
        }

        private void txtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtCreditos, "solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtCreditos, "");
            }
        }



        private void txtCreditos_TextChanged(object sender, EventArgs e)
        {
            if (txtCreditos.Text.ToString().Equals("")) {
                return;
            }
            if (txtCreditos.Text == "1" || txtCreditos.Text == "2" || txtCreditos.Text == "3")
            {
                //MessageBox.Show("Caracter Valido");
            }
            else {
                //MessageBox.Show("NELL PRRO");
                txtCreditos.Text = "";
            }
        }

        private void txtActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtActividad, "No se permiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtActividad, "");
            }
        }

        private void txtTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                errorProvider1.SetError(txtTutor, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(txtTutor, "");
            }
        }

        private void frmAltaActividad_Load(object sender, EventArgs e)
        {
            txtClave.Text = ClaveFinal().ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaAct act = new frmConsultaAct();
            act.ShowDialog();
        }
    }
}
