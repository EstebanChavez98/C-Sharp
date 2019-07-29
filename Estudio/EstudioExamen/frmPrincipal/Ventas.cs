using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    public class Ventas
    {

        private string CodigoVenta;
        private string NombreCliente;
        private int CodigoJuego;
        private string NombreJuego;

        public Ventas(string codigo, string cliente, int cJuego, string nJuego)
        {
            CodigoVenta = codigo;
            NombreCliente = cliente;
            CodigoJuego = cJuego;
            NombreJuego = nJuego;
        }

        public string pCodigo
        {
            get
            {
                return CodigoVenta;
            }
        }
        public string pNombreCliente
        {
            get
            {
                return NombreCliente;
            }
            set
            {
                NombreCliente = value;
            }
        }
        public int pCodigoJuego
        {
            get
            {
                return CodigoJuego;
            }
            set
            {
                CodigoJuego = value;
            }
        }
        public string pNombreJuego
        {
            get
            {
                return NombreJuego;
            }
            set
            {
                pNombreJuego = value;
            }
        }
    }
}
