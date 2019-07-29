using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    public class Juego
    {

        private string Nombre;
        private int Existencia;
        private string Desarrollador;

        public Juego(string nombre, string desarrollador, int existencia)
        {
            Nombre = nombre;
            Desarrollador = desarrollador;
            Existencia = existencia;
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string pDesarrollador
        {
            get
            {
                return Desarrollador;
            }
            set
            {
                Desarrollador = value;
            }
        }
        public int pExistencia
        {
            get
            {
                return Existencia;
            }
            set
            {
                Existencia = value;
            }
        }
    }
}
