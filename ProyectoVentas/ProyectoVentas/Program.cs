using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();

            char opc;

            do
            {
                pro.menu();
                int n = Convert.ToInt32(Console.ReadLine());

                while (n < 1 || n > 7)
                {
                    Console.WriteLine("ESA OPCION NO EXISTE, VUELVA A ELEGIR: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                switch (n)
                {
                    case 1:
                        Console.WriteLine("holi");
                        break;
                    case 2:
                        Console.WriteLine("holix2");
                        break;
                    case 3:
                        Console.WriteLine("holix3");
                        break;
                    case 4:
                        Console.WriteLine("holix4");
                        break;
                    case 5:
                        Console.WriteLine("holix5");
                        break;
                    case 6:
                        Console.WriteLine("holix6");
                        break;
                    case 7:
                        Console.WriteLine("holix7");
                        break;
                }

                Console.WriteLine("QUIERE SEGUIR CON EL MENU? (1/SI 2/NO)");
                opc = Convert.ToChar(Console.ReadLine());
            } while (opc != '2');

            Console.ReadKey();
        }

        public void menu()
        {
            Console.WriteLine("---------------MENÚ--------------");
            Console.WriteLine("1.- ALTA DE CLIENTE.");
            Console.WriteLine("2.- ALTA DE ARTICULO.");
            Console.WriteLine("3.- VENTAS.");
            Console.WriteLine("4.- BUSQUEDA/MODIFICACION DE ARTICULOS.");
            Console.WriteLine("5.- PAGO O ABONO DE CLIENTES.");
            Console.WriteLine("6.- CONSULTA DE VENTAS");
            Console.WriteLine("7.- CONSULTA DE CLIENTES\n");
            Console.WriteLine("A QUE OPCION DESEA ENTRAR?\n");
        }
    }
}
