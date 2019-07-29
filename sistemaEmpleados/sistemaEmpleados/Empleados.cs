using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEmpleados
{
    class Empleado
    {
        private string ClaveEmpleado;
        private string Nombre;
        private string Departamento;
        private double SueldoDiario;
        private int DiasTrabajados;
        private string ClavePuesto;
        private string NombrePuesto;

        public Empleado(string claveEmpleado, string nombre, string departamento, string clavePuesto, string nombrePuesto, double sueldoDiario)
        {
            ClaveEmpleado = claveEmpleado;
            Nombre = nombre;
            Departamento = departamento;
            SueldoDiario = sueldoDiario;
            ClavePuesto = clavePuesto;
            NombrePuesto = nombrePuesto;
        }

        public string pNombrePuesto
        {
            set
            {
                NombrePuesto = value;
            }
            get
            {
                return NombrePuesto;
            }
        }
        public string pClavePuesto
        {
            get
            {
                return ClavePuesto;
            }
            set
            {
                ClavePuesto = value;
            }
        }
        public string pClaveEmpleado
        {
            get
            {
                return ClaveEmpleado;
            }
        }

        public string nombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }

        public string pDepartamento
        {
            set
            {
                Departamento = value;
                if(Departamento.Equals(""))
                {
                    Departamento = "POR ASIGNAR";
                }
            }
            get
            {
                return Departamento;
            }
        }

        public double pSueldoDiario
        {

            set
            {
                SueldoDiario = value;
                if(SueldoDiario<=0)
                {
                    SueldoDiario = 150;
                }
            }
            get
            {
                return SueldoDiario;
            }
        }

        public int pDiasLaborados
        {
            set
            {
                DiasTrabajados += value;
            }
            get
            {
                return DiasTrabajados;
            }
        }
    }
}
