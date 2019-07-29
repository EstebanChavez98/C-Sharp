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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreraAlta ca = new frmCarreraAlta();
            ca.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCarreras cca = new frmConsultaCarreras();
            cca.ShowDialog();
        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumnos aa = new frmAltaAlumnos();
            aa.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaAlumno ca = new frmConsultaAlumno();
            ca.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           /* try {
                string strCon = UsoBD.ObtenerStrConeccion();
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                String sql = "select (ac.Creditos) as 'creditos en total' from Actividades_Alumno aa inner join Actividades ac on aa.IDActividad = ac.ActividadID inner join Alumnos al";
                sql += " on aa.IDAlumno = al.NumControl where al.NumControl = 1817001";
                SqlDataReader tabla;
                SqlCommand comando = new SqlCommand(sql, conn);
                tabla = comando.ExecuteReader();
                if (tabla.HasRows) {
                    while (tabla.Read()) {
                        MessageBox.Show(tabla.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception er) {
                MessageBox.Show(er.Message);
            }*/
        }

        private void altaDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaActividad act = new frmAltaActividad();
            act.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaAct con = new frmConsultaAct();
            con.ShowDialog();
        }

        private void registrarEnActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresoDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroActividad reg = new frmRegistroActividad();
            reg.ShowDialog();
        }

        private void consultaDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRegistroAct Creg = new frmConsultaRegistroAct();
            Creg.ShowDialog();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCarrera repC = new frmReporteCarrera();
            repC.ShowDialog();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteAlumnos repA = new frmReporteAlumnos();
            repA.ShowDialog();
        }

        private void reporteDeRegistroDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteRegAct repRA = new frmReporteRegAct();
            repRA.ShowDialog();
        }

        private void reporteDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteActividades repact = new frmReporteActividades();
            repact.ShowDialog();
        }
    }
}
