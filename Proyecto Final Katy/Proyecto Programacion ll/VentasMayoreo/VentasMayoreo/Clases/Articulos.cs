using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class Articulo
    {
        private int clave;
        private string descripcion;
        private double precio;
        private int categoria;

        public Articulo(int clave, string descripcion,double precio, int categoria)
        {
            this.clave = clave;
            this.descripcion = descripcion;
            this.precio = precio;
            this.categoria = categoria;
        }

        public int Clave
        {
            get
            {
                return clave;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
        }
        public int Categoria
        {
            get
            {
                return categoria;
            }
        }
        public override string ToString()
        {
            return descripcion;
        }

    }
}
