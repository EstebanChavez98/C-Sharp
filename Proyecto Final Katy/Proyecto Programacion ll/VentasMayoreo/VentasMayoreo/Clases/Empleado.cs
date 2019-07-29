using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo.Clases
{
    class Empleado
    {
        private int clave;
        private int claveSucursal;
        private string nombre;
        private string paterno;
        private string materno;
        private char sexo;
        private string direccion;
        private string telefono;

        public Empleado(int clave, int claveSucursal, string nombre, string paterno, string materno, char sexo, string direccion, string telefono)
        {
            this.clave = clave;
            this.claveSucursal = claveSucursal;
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.sexo = sexo;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public int Clave
        {
            get
            {
                return this.clave;
            }
        }
        public int ClaveSucursal
        {
            get
            {
                return this.claveSucursal;
            }
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
        public char Sexo
        {
            get
            {
                return this.sexo;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", nombre, paterno, materno);
        }
    }
}
