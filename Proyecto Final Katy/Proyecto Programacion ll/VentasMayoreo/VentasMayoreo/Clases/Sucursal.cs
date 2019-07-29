using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo.Clases
{
    class Sucursal
    {
        private int clave;
        private string nombre;
        private string direccion;
        private string telefono;

        public Sucursal(int clave,string nombre,string direccion,string numero)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = numero;     
        }
        public int Clave
        {
            get
            {
                return this.clave;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
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
            return this.nombre;
        }
    }
}
