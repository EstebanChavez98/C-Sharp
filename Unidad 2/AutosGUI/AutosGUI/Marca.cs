using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosGUI
{
    public class Marca
    {
        
        private String Nombre;
        private String Descripcion;
        private String Ciudad;

        public Marca(String nombre, String descripcion, String ciudad)
        {
            
            Nombre = nombre;
            Descripcion = descripcion;
            Ciudad = ciudad;
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

        public string pDescripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }

        public string pCiudad
        {
            get
            {
                return Ciudad;
            }
            set
            {
                Ciudad = value;
            }
        }
    }
}
