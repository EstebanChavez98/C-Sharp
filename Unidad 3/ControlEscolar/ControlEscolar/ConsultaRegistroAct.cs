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
    public partial class frmConsultaRegistroAct : Form
    {
        public frmConsultaRegistroAct()
        {
            InitializeComponent();
        }

        private void ConsultaRegistroAct_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

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

            }

            string strComando = "select aa.IDActividad, ac.NombreAct, aa.IDAlumno, al.NombreAlu, al.ApellidoP, al.ApellidoM from Actividades ac inner join Actividades_Alumno aa on ac.ActividadId = aa.IDActividad inner join Alumnos al on aa.IDAlumno = al.NumControl";

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
                dgvRegistroAct.Rows.Clear();
                while (lector.Read())
                {
                    dgvRegistroAct.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());
                }
            }


            conn.Close();
        }
    }
}
