using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTicket
{
    class Program
    {
        Dictionary<int, Ticket> dicBoletos = new Dictionary<int, Ticket>();

        static void Main(string[] args)
        {

        }

        public void VentaBoletos()
        {
            Console.WriteLine("Venta de Boletos: ");
            Console.WriteLine("Numero de Ticket: ");
            int numBoleto = Convert.ToInt32(Console.ReadLine());
            if(dicBoletos.ContainsKey(numBoleto)==false)
            {
                // no existe, puedo agregar 
                // pedir todos los datos de ticket
                Console.WriteLine("Destino: ");
                string destino = Console.ReadLine().ToUpper();
                Console.WriteLine("Nombre de pasajero: ");
                string pasajero = Console.ReadLine().ToUpper();
                Console.WriteLine("Costo: ");
                double costo = Convert.ToDouble(Console.ReadLine());
                while(costo<1)
                {
                    Console.WriteLine("Costo invilado, vuelva ingresar el costo: ");
                    costo = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Numero de Camion: ");
                int camion = Convert.ToInt32(Console.ReadLine());
                while(camion <1)
                {
                    Console.WriteLine("Numero de camion invalido, vuelva a ingresar el numero de camion: ");
                    camion = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Numero de Asiento: ");
                int asiento = Convert.ToInt32(Console.ReadLine());
                while(asiento<1)
                {
                    Console.WriteLine("Numero de asiento invalido, vuelva a ingresar el numero de asiento: ");
                    asiento = Convert.ToInt32(Console.ReadLine());
                }

                // Validacion de asiento y camion
                Ticket ticket = new Ticket(destino, pasajero, costo, camion, asiento);

                dicBoletos.Add(numBoleto, ticket); 
            }
            else
            {
                Console.WriteLine("Boleto {0} Duplicado", numBoleto);
            }

        }

        public void imprimirBoletos(string Destino)
        {
            for(int i=0; i<dicBoletos.Count; i++)
            {
                var dato = dicBoletos.ElementAt(i);
                Ticket t = dato.Value;
                if (t.pDestino.Equals(Destino))
                {
                    //desplegar
                    Console.WriteLine("Nombre Pasajero {0}", t.pPasajero);
                }
            }
        }

        public void cambioPasajero()
        {
            Console.WriteLine("Cambio de Pasajero");
            Console.WriteLine("Numero de ticket");
            int numBoleto = Convert.ToInt32(Console.ReadLine());
            if (dicBoletos.ContainsKey(numBoleto))
            {
                Console.WriteLine("Nuevo pasajero");
                string pasajero = Console.ReadLine().ToUpper();

                dicBoletos[numBoleto].pPasajero = pasajero;
                Console.WriteLine("Pasajero Cambiado");
            }
            else
            {
                Console.WriteLine("No existe {0}", numBoleto);
            }
            Console.ReadKey();
        }

        public bool validaAsiento(int numA, int numC)
        {
            bool retorno = false;
            foreach(Ticket ticket in dicBoletos.Values)
            {
                if((ticket.pNumAsiento==numA) && ticket.pNumCamion==numC)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
