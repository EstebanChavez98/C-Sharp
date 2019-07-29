using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class ArticuloAlmacenado : Articulo
    {
        private int existencia;

        public ArticuloAlmacenado(int clave, string descripcion, double precio, int categoria,int existencia) : base(clave, descripcion, precio, categoria)
        {
            this.existencia = existencia;
        }
        public int Existencia
        {
            get
            {
                return existencia;
            }
        }
    }

    
}
