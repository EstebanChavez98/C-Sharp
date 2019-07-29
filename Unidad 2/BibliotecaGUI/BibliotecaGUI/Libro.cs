using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGUI
{
    public class Libro
    {
        private string Nombre;
        private string Autor;
        private string Editorial;
        private int Existencia;
        private string Uso;
        private string Usuario;

        public Libro(string nombre, string autor, string editorial, int existencia, string uso, string usuario)
        {
            Nombre = nombre;
            Autor = autor;
            Editorial = editorial;
            Existencia = existencia;
            Uso = uso;
            Usuario = usuario;
        }

        public string pUsuario
        {
            get
            {
                return Usuario;
            }
            set
            {
                Usuario = value;
            }
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string pAutor
        {
            get
            {
                return Autor;
            }
            set
            {
                Autor = value;
            }
        }
        public string pEditorial
        {
            get
            {
                return Editorial;
            }
            set
            {
                Editorial = value;
            }
        }
        public int pExistencia
        {
            get
            {
                return Existencia;
            }
            set
            {
                Existencia = value;
            }
        }
        public string pUso
        {
            get
            {
                return Uso;
            }
            set
            {
                Uso = value;
            }
        }
    }
}
