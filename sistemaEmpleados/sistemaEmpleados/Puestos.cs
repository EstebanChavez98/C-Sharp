using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEmpleados
{
    class Puestos
    {
        private string ClavePuesto;
        private string NombrePuesto;
        private string Horario;

        public Puestos (string clavePuesto, string nombrePuesto, string horario)
        {
            ClavePuesto = clavePuesto;
            NombrePuesto = nombrePuesto;
            Horario = horario;
        }

        public string pClavePuesto
        {
            get
            {
                return ClavePuesto;
            }
        }

        public string pNombrePuesto
        {
            set
            {
                NombrePuesto = value;
            }
            get
            {
                return NombrePuesto;
            }
        }

        public string pHorario
        {
            set
            {
                Horario = value;
            }
            get
            {
                return Horario;
            }
        }

    }
}
