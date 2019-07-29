using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Ticket
    {
        private int Numero;
        private string Destino;
        private string NombrePasajero;
        private double Costo;
        private int NumCamion;
        private int NumAsiento;

        public Ticket(int num, string destino, string pasajero, double costo, int camion, int asiento)
        {
            Numero = num;
            Destino = destino;
            NombrePasajero = pasajero;
            Costo = costo;
            NumCamion = camion;
            NumAsiento = asiento;
        }

        public int pNumeroBoleto
        {
            get
            {
                return Numero;
            }
        }

        public int pNumAsiento
        {
            get
            {
                return NumAsiento;
            }
            set
            {
                NumAsiento = value;
            }
        }
        public int pNumCamion
        {
            get
            {
                return NumCamion;
            }
            set
            {
                NumCamion = value;
            }
        }
        public double pCosto
        {
            get
            {
                return Costo;
            }
            set
            {

                Costo = value;
            }
        }

        public string pDestino
        {
            get
            {
                return Destino;
            }
            set
            {
                Destino = value;
            }
        }
        public string toString()
        {
            return "Numero Boleto " + NumCamion + " Destino " + Destino + " Nombre Pasajero " + NombrePasajero + " Costo " + Costo;
        }
    }
}
