using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaArreglo
{
    class Program
    {

        double[] arreglo = new double[7];


        static void Main(string[] args)
        {
            Program pro = new tiendaArreglo.Program();

            pro.ventasPorDia();

            foreach(double ventas in Program.arreglo)
            {
                Console.WriteLine(ventas);
            }

            Console.ReadKey();
        }

        public void ventasPorDia()
        {
            int numDia;
            double venta;
            Console.WriteLine("Dia para ingresar la venta: ");
            numDia = Convert.ToInt32(Console.ReadLine());

            while (numDia < 0 || numDia > 6)
            {
                Console.WriteLine("No existe el dia. Dia para ingresar la venta: ");
                numDia = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nombreDia(numDia));

            Console.WriteLine("Venta del dia: ");
            venta = Convert.ToInt32(Console.ReadLine());
            arreglo[numDia] = venta;

        }

        public string nombreDia(int n)
        {
            string dia = "";

            switch (n)
            {
                case 0:
                    dia = "Domingo";
                    break;
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
            }

            return dia;
        }
    }
}
