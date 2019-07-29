using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class DetalleDeVenta
    {
        private int claveArticulo;
        private string articulo;
        private int cantidad;
        private double precio;
        private double importe;

        public DetalleDeVenta(int clavearticulo,string articulo,int cantidad,double precio,double importe)
        {
            this.claveArticulo = clavearticulo;
            this.articulo = articulo;
            this.cantidad = cantidad;
            this.precio = precio;
            this.importe = importe;
        }
        public int ClaveArticulo
        {
            get
            {
                return this.claveArticulo;
            }
        }
       public string Articulo
        {
            get
            {
                return this.articulo;
            }
        }
        
        
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public double Importe
        {
            get
            {
                return importe;
            }
            
        }
       

    }
}
