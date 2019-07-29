using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ControlEscolar
{
    public partial class frmCarreraAlta : Form
    {
        public frmCarreraAlta()
        {
            InitializeComponent();
        }
        public int damefinal()
        {

            int c = 0;
            string strCon = UsoBD.ObtenerStrConeccion();
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if(conn==null)
            {
                MessageBox.Show("error de conexion");
                foreach(SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return c;
            }

            string strComando = "select ClaveC from Carreras";

            SqlDataReader lector = UsoBD.Consulta(strComando, conn);
            if(lector==null)
            {
                MessageBox.Show("error de consulta");
                foreach(SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return c;
                conn.Close();
            }

            if(lector.HasRows)
            {
                while(lector.Read())
                {
                    c = Convert.ToInt32(lector.GetValue(0).ToString());
                }
                c++;
            }
            conn.Close();
            return c;

        }
        private void frmCarreraAlta_Load(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(damefinal());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Confirmar la alta de la carrera?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                if (validarDatos() == false)
                {
                    string nombre = txtNombre.Text;
                    if (buscaNombre(nombre) == false)
                    {
                        int Al = 0;

                        string strCon = UsoBD.ObtenerStrConeccion();
                        SqlConnection conn = UsoBD.ConectaBD(strCon);
                        if(conn==null)
                        {
                            MessageBox.Show("Imposible conectar con los datos");
                            foreach (SqlError err in UsoBD.ESalida.Errors)
                            {
                                MessageBox.Show(err.Message);
                            }
                            return;

                        }

                        string strComando = "insert into Carreras(NombreC, NumAlumnos)";
                        strComando += " Values(@Nombre, @NumAl)";


                        SqlCommand cmd = new SqlCommand(strComando, conn);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@NumAl", Al);
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
                        MessageBox.Show("Carrera guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nombre Duplicado, ingrese otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Complete la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if(txtNombre.Text=="")
                    {
                        errorProvider1.SetError(txtNombre, "Ingrese datos");
                    }
                }
            }


        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtClave.Text = Convert.ToString(damefinal());
        }

        public bool validarDatos()
        {
            bool c = false;

            if(txtClave.Text=="" || txtNombre.Text=="")
            {
                c = true;
            }

            return c;
        }

        public bool buscaNombre(string nombre)
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
            
            string strComando = "select NombreC from Carreras where NombreC='" + nombre + "'";

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaCarreras cc = new frmConsultaCarreras();
            cc.ShowDialog();
        }
    }
}
