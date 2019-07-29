using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGUI
{
    public class Prestamo
    {
        private string CodigoPrestamo;
        private string Usuario;
        private string Libro;
        private string NombreU;
        private string Domicilio;
        private DateTime Fecha;

        public Prestamo(string codigo, string usuario, string libro, string nombre, string domicilio, DateTime fecha)
        {
            CodigoPrestamo = codigo;
            Usuario = usuario;
            Libro = libro;
            NombreU = nombre;
            Domicilio = domicilio;
            Fecha = fecha;
        }
        public string pCodigo
        {
            get
            {
                return CodigoPrestamo;
            }
        }
        public DateTime pFecha
        {
            get
            {
                return Fecha;
            }
        }
        public string pUsuario
        {
            get
            {
                return Usuario;
            }
        }
        public string pLibro
        {
            get
            {
                return Libro;
            }
        }
        public string pNombreU
        {
            get
            {
                return NombreU;
            }
            set
            {
                NombreU = value;
            }
        }
        public string pDomicilio
        {
            get
            {
                return Domicilio;
            }
            set
            {
                Domicilio = value;
            }
        }
    }
}
