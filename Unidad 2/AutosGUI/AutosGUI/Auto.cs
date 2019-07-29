using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosGUI
{
    public class Auto
    {
        private String NumerodeSerie;
        private String NombreAuto;
        private String ClaveMarca;
        private int MaxPasajeros;
        private String TipoManejo;

        public Auto(String numero, String nombre, String clave, int pasajeros, String manejo)
        {
            NumerodeSerie = numero;
            NombreAuto = nombre;
            ClaveMarca = clave;
            MaxPasajeros = pasajeros;
            TipoManejo = manejo;
        }

        public string pNumSerie
        {
            get
            {
                return NumerodeSerie;
            }
        }

        public string pNombre
        {
            get
            {
                return NombreAuto;
            }
            set
            {
                NombreAuto = value;
            }
        }

        public string pClave
        {
            get
            {
                return ClaveMarca;
            }
        }

        public int pPasajeros
        {
            get
            {
                return MaxPasajeros;
            }
            set
            {
                MaxPasajeros = value;
            }
        }

        public string pManejo
        {
            get
            {
                return TipoManejo;
            }
            set
            {
                TipoManejo = value;
            }
        }
    }
}
