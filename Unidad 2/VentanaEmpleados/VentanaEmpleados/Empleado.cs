using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaEmpleados
{
    public class Empleado
    {
        private string Nombre;
        private string Domicilio;
        private string Departamento;
        private string Sexo;
        private string Idiomas;

        public Empleado(string nombre, string domicilio, string departamento, string sexo, string idioma)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Departamento = departamento;
            Sexo = sexo;
            Idiomas = idioma;
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set {
                Nombre = value;
            }
        }
        public string pDomicilio
        {
            get
            {
                return Domicilio;
            }
            set
            {
                Domicilio = value;
            }
        }
        public string pDepartamento
        {
            get
            {
                return Departamento;
            }
            set
            {
                Departamento = value;
            }
        }
        public string pSexo
        {
            get
            {
                return Sexo;
            }
            set
            {
                Sexo = value;
            }
        }
        public string pIdiomass
        {
            get
            {
                return Idiomas;
            }
            set
            {
                Idiomas = value;
            }
        }
    }
}
