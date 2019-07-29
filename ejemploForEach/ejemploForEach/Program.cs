using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploForEach
{
    class Program
    {
        public string titulo()
        {
            return "Hola crayola";
        }

        public string rating()
        {
            return "5 estrellas";
        }


        static void Main(string[] args)
        {
            /* Program pro = new Program();

            

            Console.ReadKey();*/

           string[] pets = { "Perro", "Gato", "Pajaro", "Oso", "cocodrilo" };

            foreach(string value in pets)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
