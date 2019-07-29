using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source = JOCA-DELGADO\\JOCADELGADO; Initial Catalog=Empresa; Integrated Security=True";
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach(SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;

            }
            SqlDataReader lector = null;
            string strComando = "select ClaveDepto, NombreDepto, NombreJefeDepto from Departamento";
            SqlCommand cmd = new SqlCommand(strComando, conn);
            try
            {
                lector = cmd.ExecuteReader();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error en consulta");
                foreach(SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }

            if(lector.HasRows)
            {
                cmbDeptos.Items.Clear();
                while(lector.Read())
                {
                    cmbDeptos.Items.Add(lector.GetValue(0).ToString());
                }
            }

            string clave = cmbDeptos.SelectedItem.ToString();



            conn.Close();
        }


    }
}
