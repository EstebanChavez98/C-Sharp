using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasMayoreo.Clases;
namespace VentasMayoreo
{
    class Cliente : Persona
    {
        private int clave;
        private double montoMaximoCredito;
        private double saldoPendiete;

        public Cliente (int clave,string nombre,string paterno,string materno,char sexo,string fecha,string direccion,string telefono,double montoMaximoCredito,double saldoPendiente)
            :base(nombre,paterno,materno,sexo,fecha,direccion,telefono)
        {
            this.clave = clave;
            this.montoMaximoCredito = montoMaximoCredito;
            this.saldoPendiete = saldoPendiente;
        }
      
        public int Clave
        {
           get { return this.clave; }
        }
       
     
        public double SaldoPendiente
        {
            get
            {
                return this.saldoPendiete;
            }
        }
    
      
        public double MontoMaximoCredito
        {
            get
            {
                return this.montoMaximoCredito;
            }
          
        }      

    }
}
