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
    public partial class frmConsultaAct : Form
    {
        public frmConsultaAct()
        {
            InitializeComponent();
        }

        private void ConsultaActividades_Load(object sender, EventArgs e)
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

            string strComando = "select ActividadId, NombreAct, AlumnosReg, Tutor, Creditos from Actividades";

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
                dgvActividades.Rows.Clear();
                while (lector.Read())
                {
                    dgvActividades.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString());
                }
            }


            conn.Close();
        }
    }
}
