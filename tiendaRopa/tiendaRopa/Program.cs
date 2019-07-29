using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaRopa
{
    class Program
    {
        double[] arreglo = new double[7];


        static void Main(string[] args)
        {
            Program pro = new tiendaRopa.Program();

            pro.menu();
            Console.ReadKey();
            
        }

        public void capturaVentas()
        {
            char opc;
            int dia;
            //Pedir dia
            do
            {
                Console.WriteLine("Cual dia desea ingresar? ");
                Console.WriteLine("0.- Domingo");
                Console.WriteLine("1.- Lunes");
                Console.WriteLine("2.- Martes");
                Console.WriteLine("3.- Miercoles");
                Console.WriteLine("4.- Jueves");
                Console.WriteLine("5.- Viernes");
                Console.WriteLine("6.- Sabado");
                dia = Convert.ToInt32(Console.ReadLine());

                while (dia < 0 || dia > 6)
                {
                    Console.WriteLine("No existe el dia. Cual dia desea ingresar?");
                    dia = Convert.ToInt32(Console.ReadLine());
                }
                double ventas = 0;
                Console.WriteLine("Ingreso de la venta: ");
                ventas = Convert.ToDouble(Console.ReadLine());
                while (ventas < 1)
                {
                    Console.WriteLine("Ingreso invalido. Vuelva a dar el ingreso: ");
                    ventas = Convert.ToDouble(Console.ReadLine());
                }
                switch (dia)
                {
                    case 0:
                        arreglo[0] += ventas;
                        break;
                    case 1:
                        arreglo[1] += ventas;
                        break;
                    case 2:
                        arreglo[2] += ventas;
                        break;
                    case 3:
                        arreglo[3] += ventas;
                        break;
                    case 4:
                        arreglo[4] += ventas;
                        break;
                    case 5:
                        arreglo[5] += ventas;
                        break;
                    case 6:
                        arreglo[6] += ventas;
                        break;
                }


                Console.WriteLine("Quiere seguir capturando ventas? (1/SI 2/NO)");
                opc = Convert.ToChar(Console.ReadLine());

            } while (opc != '2');
            menu();
        }

        public void totalVendido()
        {
            double ventas = 0;
            for(int i=0; i<arreglo.Length; i++)
            {
                ventas += arreglo[i];
            }
            Console.WriteLine("Venta total: {0}", ventas);
            menu();
        }

        public void totalDia()
        {
            for (int i = 0; i <=6; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Domingo");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 1:
                        Console.WriteLine("Lunes");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        Console.WriteLine(arreglo[i]);
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        Console.WriteLine(arreglo[i]);
                        break;
                }
            }
            menu();
        }

        public void diasSinCapturar()
        {
            for (int i = 0; i <arreglo.Length; i++)
            {
                if (arreglo[i]==0)
                {
                    switch(i)
                    {
                        case 0:
                            Console.WriteLine("Domingo");
                            break;
                        case 1:
                            Console.WriteLine("Lunes");
                            break;
                        case 2:
                            Console.WriteLine("Martes");
                            break;
                        case 3:
                            Console.WriteLine("Miercoles");
                            break;
                        case 4:
                            Console.WriteLine("Jueves");
                            break;
                        case 5:
                            Console.WriteLine("Viernes");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                    }
                }
            }
            menu();
        }

        public void menu()
        {
            Console.WriteLine("----------TIENDA DE ROPA----------\n");
            Console.WriteLine("1.- Capturar las ventas");
            Console.WriteLine("2.- Obtener total vendido");
            Console.WriteLine("3.- Total vendido de un dia");
            Console.WriteLine("4.- Presentar dias que no hayan capturado ventas");
            Console.WriteLine("5.- Salir del menú\n");
            char opc;
            Console.WriteLine("Elija que opcion desea entrar: ");
            opc = Convert.ToChar(Console.ReadLine());

            if (opc == '1')
            {
                capturaVentas();
            }
            else
                if (opc == '2')
            {
                totalVendido();
            }
            else
                if (opc == '3')
            {
                totalDia();
            }
            else
                if (opc == '4')
            {
                diasSinCapturar();
            }
            else
                Console.ReadLine();

        }

    }
}
