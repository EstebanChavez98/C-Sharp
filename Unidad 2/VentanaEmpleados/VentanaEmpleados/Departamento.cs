using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaEmpleados
{
    public class Departamento
    {
        private string ClaveDepartamento;
        private string NombreDepartamento;
        private string JefeDepartamento;

        public Departamento(string clave, string nombre, string jefe)
        {
            ClaveDepartamento = clave;
            NombreDepartamento = nombre;
            JefeDepartamento = jefe;
        }

        public string pClaveDep
        {
            get
            {
                return ClaveDepartamento;
            }
        }

        public string pNomDep
        {
            get
            {
                return NombreDepartamento;
            }
            set
            {
                NombreDepartamento = value;
            }
        }
        public string pJefe
        {
            get
            {
                return JefeDepartamento;
            }
            set
            {
                JefeDepartamento = value;
            }
        }
    }
}
