using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoVentana
{
    public class Alumno
    {
        private String Nombre;
        private String Domicilio;
        private String Carrera;
        private int Edad;

        public Alumno(String nombre, String domicilio, String carrera, int edad)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Carrera = carrera;
            Edad = edad;
        }

        public String pNombre
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

        public String pDomicilio
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

        public String pCarrera
        {
            get
            {
                return Carrera;
            }
            set
            {
                Carrera = value;
            }
        }

        public int pEdad
        {
            get
            {
                return Edad;
            }
            set
            {
                Edad = value;
            }
        }
    }
}
