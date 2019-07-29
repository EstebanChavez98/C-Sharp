using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas
{
    class Clientes
    {
        private string ClaveCliente;
        private string NombreCliente;
        private string Direccion;
        private int Telefono;
        private double SaldoPendiente;
        private double MontoMaximoCredito;

        public Clientes(string claveCliente, string nombreCliente, string direccion, int telefono, double montoMaximo)
        {
            ClaveCliente = claveCliente;
            NombreCliente = nombreCliente;
            Direccion = direccion;
            Telefono = telefono;
            MontoMaximoCredito = montoMaximo;
        }

        public string pClaveCliente
        {
            set
            {
                ClaveCliente = value;
            }
            get
            {
                return ClaveCliente;
            }
        }

        public string pNombreCliente
        {
            set
            {
                NombreCliente = value;
            }
            get
            {
                return NombreCliente;
            }
        }

        public string pDireccion
        {
            set
            {
                Direccion = value;
            }
            get
            {
                return Direccion;
            }
        }

        public int pTelefono
        {
            set
            {
                Telefono = value;
            }
            get
            {
                return Telefono;
            }
        }

        public double pMontoMaximo
        {
            set
            {
                MontoMaximoCredito = value;
            }
            get
            {
                return MontoMaximoCredito;
            }
        }
    }
}
