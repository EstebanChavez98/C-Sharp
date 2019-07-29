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
    public partial class frmConsultaAlumno : Form
    {
        public frmConsultaAlumno()
        {
            InitializeComponent();
        }

        private void ConsultaAlumnos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

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
           
            string strComando = "select NumControl, NombreAlu, ApellidoP, ApellidoM, Curp, FechaNac, Sexo, Telefono, Carrera, c.NombreC, Tutor from Alumnos a inner join Carreras c on a.Carrera=c.ClaveC";

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
                dgvAlumnos.Rows.Clear();
                while (lector.Read())
                {
                    dgvAlumnos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString(), lector.GetValue(8).ToString(), lector.GetValue(9).ToString(), lector.GetValue(10).ToString());
                }
            }


            conn.Close();
        }
    }
}
