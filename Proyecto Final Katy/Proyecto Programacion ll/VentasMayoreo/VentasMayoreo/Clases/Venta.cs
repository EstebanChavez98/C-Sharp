using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasMayoreo
{
    class Venta
    {
        private int claveVenta;
        private double importe;
        private string tipo;
        List<DetalleDeVenta> detalles;

        public Venta(int claveVenta,double importe,string tipo)
        {
            this.claveVenta = claveVenta;
            this.importe = importe;
            this.tipo = tipo;
            this.detalles = new List<DetalleDeVenta>();
            
        }
        public int ClaveVenta
        {
            get
            {
                return this.claveVenta;
            }
        }
        public double Importe
        {
            get
            {
                return this.importe;
            }
        }
        public string Tipo
        {
            get
            {
                return this.tipo;
            }
        }
        public override string ToString()
        {
            return this.claveVenta.ToString();
        }
    }
}
