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
    public partial class frmRegistroActividad : Form
    {
        public frmRegistroActividad()
        {
            InitializeComponent();
        }
        
        private void RegistroActividad_Load(object sender, EventArgs e)
        {
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

            string strComando = "select NombreAct from Actividades";


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
                cmbActividades.Items.Clear();
                while (lector.Read())
                {
                    cmbActividades.Items.Add(lector.GetValue(0).ToString());
                }
            }

            conn.Close();
            conn = new SqlConnection();
            conn = UsoBD.ConectaBD(strCon);
            strComando = "select * from Alumnos";
            SqlDataReader lector2;
            lector2 = UsoBD.Consulta(strComando, conn);
            if (lector2 == null)
            {
                MessageBox.Show("Error en consulta");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
                conn.Close();
            }
            if (lector2.HasRows)
            {
                cmbAlumnos.Items.Clear();
                while (lector2.Read())
                {
                    cmbAlumnos.Items.Add(lector2.GetValue(0)+" "+lector2.GetValue(1).ToString() +" "+ lector2.GetValue(2).ToString() +" "+ lector2.GetValue(3).ToString() );
                }
            }
            conn.Close();
        }

        int credits_Actividad = 0;

        private void cmbActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            string strComando = "select Creditos from Actividades where NombreAct like '" + cmbActividades.SelectedItem.ToString() + "'";
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
            if (lector.HasRows) {
                while (lector.Read()) {
                    credits_Actividad = Convert.ToInt32(lector.GetValue(0));
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int creditos_total = 0;
            String numcontrol = cmbAlumnos.SelectedItem.ToString().Substring(0,7);
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

            string strComando = "select sum(ac.Creditos) as 'creditos en total' from Actividades_Alumno aa inner join Actividades ac on aa.IDActividad = ac.ActividadID inner join Alumnos al on aa.IDAlumno = al.NumControl where al.NumControl = " + Convert.ToInt32(numcontrol);
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
                while (lector.Read())
                {
                    try
                    {
                        creditos_total = Convert.ToInt32(lector.GetValue(0));
                    }
                    catch (Exception err) {
                        creditos_total = 0;
                    }
                    finally {
                        
                    }
                }
            }
            conn.Close();
            MessageBox.Show("Creditos Del Alumno en Total: " + creditos_total + " Creditos De la Actividad: " + credits_Actividad);
            if ((creditos_total + credits_Actividad) > 5)
            {
                MessageBox.Show("El alumno Excede el Total De Creditos Maximos....");
            }
            else {
                try
                {
                    strCon = UsoBD.ObtenerStrConeccion();
                    conn = UsoBD.ConectaBD(strCon);
                    strComando = "insert into Actividades_Alumno values((select ActividadID from Actividades where NombreAct like '%" + cmbActividades.SelectedItem.ToString() + "%' )," + numcontrol + ")";
                    UsoBD.Consulta(strComando, conn);
                    MessageBox.Show("Registro hecho.");
                    limpiar();
                }
                catch (Exception doña_reclamo) {
                    MessageBox.Show(doña_reclamo.Message);
                }
            }
            conn.Close();
        }

        public void limpiar()
        {
            cmbActividades.Text = "";
            cmbAlumnos.Text = "";
        }

        
    }
}
