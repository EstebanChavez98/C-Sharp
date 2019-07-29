using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class Categoria
    {
        
        private int clave;
        private string nombre;

        public Categoria(int clave,string nombre)
        {
            this.clave = clave;
            this.nombre = nombre;
        }

        public int Clave
        {
            get
            {
                return clave;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
