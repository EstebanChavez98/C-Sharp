using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo.Clases
{
    class Persona
    {
        private string nombre;
        private string paterno;
        private string materno;
        private char sexo;
        private string fechaNacimiento;
        private string direccion;
        private string telefono;

        public Persona(string nombre,string paterno,string materno,char sexo,string fecha,string direccion,string telefono)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.sexo = sexo;
            this.fechaNacimiento = fecha;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Paterno
        {
            get
            {
                return this.paterno;
            }
        }
        public string Materno
        {
            get
            {
                return this.materno;
            }
        }
        public char Sexo
        {
            get
            {
                return this.sexo;
            }
        }
        public string FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", nombre, paterno, materno);
        }


    }
}
