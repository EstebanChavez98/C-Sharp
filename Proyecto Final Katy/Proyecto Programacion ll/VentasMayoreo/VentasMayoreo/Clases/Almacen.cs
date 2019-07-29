using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class Almacen
    {
        private string sucursal;
        private string articulo;
        private string existencia;

        public Almacen(string sucursal,string articulo,string existencia)
        {
            this.sucursal = sucursal;
            this.articulo = articulo;
            this.existencia = existencia;
        }

        public string Sucursal
        {
            get
            {
                return sucursal;
            }
        }
        public string Articulo
        {
            get
            {
                return articulo;
            }
        }
        public string Existencia
        {
            get
            {
                return existencia;
            }
        }

    }
}
