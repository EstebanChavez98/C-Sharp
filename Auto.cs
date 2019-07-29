using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayListAutos
{
    public class Auto
    {
        private string NumSerie;
        private string Nombre;
        private int Modelo;
        private string Marca;
        private int MaxPasajeros;
        
        public Auto( string serie, string nombre, int modelo, string marca, int pasajeros)
        {
            NumSerie = serie;
            Nombre = nombre;
            Modelo = modelo;
            Marca = marca;
            MaxPasajeros = pasajeros;
            

        }

        public string pNumSerie
        {
            get
            {
                return NumSerie;
            }
        }
        public string pNombre
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

        public int pMaxPasajeros
        {
            set
            {
                MaxPasajeros = value;
            }
            get
            {
                return MaxPasajeros;
            }
        }

        
    }
}
