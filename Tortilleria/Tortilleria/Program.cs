using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortilleria
{
    class Program
    {

        double cantidadPago, cantidadPeso, pesos, kilos;
        double totalPago, totalPeso;

        static void Main(string[] args)
        {
            // menu

            Program pro = new Tortilleria.Program();

            char opc, opc2;

            do
            {
                Console.WriteLine("--------TORTILLERIA--------");
                Console.WriteLine("Elija la opcion de compra: \n");
                Console.WriteLine("1. Comprar por kilos. ");
                Console.WriteLine("2. Comprar por pesos. ");

                opc = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("");

                if (opc == '1')
                {
                    pro.VenderPeso();
                }
                else
                    if (opc == '2')
                {
                    pro.VenderImporte();
                }

                Console.WriteLine("Desea seguir con el menú? (1/SI) (2/NO)");
                opc2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("");
                

            } while (opc2!='2');

            pro.PresentarTotal();
        }

        public void VenderPeso()
        {
            Console.WriteLine("Kilos a comprar: ");
            kilos = Convert.ToDouble(Console.ReadLine());

            while(kilos<0)
            {
                Console.WriteLine("Kilos invalidos, vuelva a ingresar los kilos: ");
                kilos = Convert.ToDouble(Console.ReadLine());
            }
 
            cantidadPeso = cantidadPeso + kilos;            
            totalPago = kilos * 17;
            Console.WriteLine("Total a pagar: {0}", totalPago);
            cantidadPago = cantidadPago + totalPago;
            totalPago = 0;
        }

        public void VenderImporte()
        {
            double kiloTortilla = 17, pesoTortilla;
            Console.WriteLine("Pesos en tortillas a comprar: ");
            pesos = Convert.ToDouble(Console.ReadLine());

            while (pesos < 0)
            {
                Console.WriteLine("Pesos invalidos, vuelva a ingresar la cantidad de pesos: ");
                pesos = Convert.ToDouble(Console.ReadLine());
            }

            pesoTortilla = pesos / kiloTortilla;
            cantidadPago = cantidadPago + pesos;
            cantidadPeso = cantidadPeso + pesoTortilla;
            Console.WriteLine("Peso de tortillas: {0}", pesoTortilla);
            pesoTortilla = 0;
        }

        public void PresentarTotal()
        {
            double pago, cambio;
            Console.WriteLine("Total en Pesos vendido: ${0} Kilogramos Vendido: {1}/n", cantidadPago, cantidadPeso);

            Console.WriteLine("Con cuanto pagará? ");
            pago = Convert.ToDouble(Console.ReadLine());
            while(pago<cantidadPago)
            {
                Console.WriteLine("Pago insuficiente. vuelva ingresar la cantidad de pago: ");
                pago = Convert.ToDouble(Console.ReadLine());

            }
            cambio = pago - cantidadPago;

            Console.WriteLine("Pago: {0}", pago);
            Console.WriteLine("Cambio: {0}", cambio);
            Console.ReadKey();
        }
    }
}
