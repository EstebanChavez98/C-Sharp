using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploList1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("José Carlos");
            names.Add("Kevin");
            names.Add("Carlos Antonio");
            names.Add("Pedro");
            names.Add("Juan");
            names.Add("Roberto");

            Console.WriteLine("Propiedad Count {0}", names.Count);
            Console.WriteLine("Propiedad Capacity {0} ", names.Capacity);
            Console.WriteLine("Elemento en la posicion 3 ----> {0}", names[3]);


            //recorreindo con foreach
            Console.WriteLine("Recorriendo con foreach");
            foreach(String nombre in names)
            {
                Console.WriteLine(nombre);
            }

            //recorriendo con for
            Console.WriteLine("Recorriendo con for");
            for (int i=0; i<names.Count; i++)
            {
                Console.WriteLine("Posicion {0} Nombre {1}", i, names[i]);
            }
            Console.ReadKey();
        }
    }
}
