using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    class Auto
    {
        private string numSerie;
        private string descripcion;
        private int Modelo;
        private string Marca;

        public Auto (string serie, string desc, int modelo, string marca)
        {
            numSerie = serie;
            descripcion = desc;
            Modelo = modelo;
            Marca = marca;
        }

        public string pDescripcion
        {
            set
            {
                descripcion = value;
            }
            get
            {
                return descripcion;
            }
        }
        
        public string pNumSerie
        {
            get
            {
                return numSerie;
            }
        }

        public int pModelo
        {
            set
            {
                Modelo = value;
            }
            get
            {
                return Modelo;
            }
        }

        public string pMarca
        {
            set
            {
                Marca = value;
            }
            get
            {
                return Marca;
            }
        }

    }
}
