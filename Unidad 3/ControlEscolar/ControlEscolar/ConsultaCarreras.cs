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
    public partial class frmConsultaCarreras : Form
    {
        public frmConsultaCarreras()
        {
            InitializeComponent();
        }

        private void frmConsultaCarreras_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            string strCon = UsoBD.ObtenerStrConeccion();
            //string strCon = "Data Source = JOCA-DELGADO\\JOCADELGADO; Initial Catalog=ControlEscolar; Integrated Security=True";
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
            
            string strComando = "select ClaveC, NombreC, NumAlumnos from Carreras";

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
                dgvCarreras.Rows.Clear();
                while (lector.Read())
                {
                    dgvCarreras.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());
                }
            }


            conn.Close();
        }
    }
}
