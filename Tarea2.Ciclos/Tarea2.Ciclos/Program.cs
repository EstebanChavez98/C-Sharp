using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0, n2=0, i;

            do
            {
                Console.WriteLine("Escribe el numero a multiplicar: ");
                n1 = int.Parse(Console.ReadLine());

            } while (n1<1 || n1>12);

            do
            {
                Console.WriteLine("Escribe el rango final: ");
                n2 = int.Parse(Console.ReadLine());
            } while (n2 < 10);

            Console.WriteLine();
            Console.WriteLine("numero: {0}", n1);
            Console.WriteLine("Rango final: {0}\n", n2);

            Console.WriteLine("Tabla de Multiplicar: \n");

            for(i=1; i<n2+1; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n1, i, (n1*i));
            }


            Console.ReadKey();
        }
    }
}
