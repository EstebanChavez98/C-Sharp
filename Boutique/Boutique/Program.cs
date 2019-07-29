using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulos, i;
            double importe, totalImporte = 0, importeDescuento, descuento, pagoTotal;

            do
            {
                Console.WriteLine("Cantidad de articulos a llevar: ");
                articulos = Convert.ToInt32(Console.ReadLine());

            } while (articulos < 1);

            for(i=1; i<=articulos; i++)
            {
                do
                {
                    Console.WriteLine("Importe del articulo {0}:", i);
                    importe = Convert.ToDouble(Console.ReadLine());

                } while (importe < 1);

                totalImporte = totalImporte + importe;

            }
            if (totalImporte < 300)
            {
                descuento = 0;
                importeDescuento = 0;
            }

            else
            if (totalImporte >= 300 && totalImporte <= 600)
            {
                descuento = 0.07;
                importeDescuento = (totalImporte * descuento);
            }
            else
                if (totalImporte >= 601 && totalImporte <= 1000)
            {
                descuento = 0.10;
                importeDescuento = (totalImporte * descuento);
            }
            else
            {
                descuento = 0.15;
                importeDescuento = (totalImporte * descuento);
            }

            pagoTotal = totalImporte - importeDescuento;

            Console.WriteLine("");
            Console.WriteLine("Cantidad de articulos: {0}", articulos);
            Console.WriteLine("Importe total: {0}", totalImporte);
            if (descuento == 0)
                Console.WriteLine("No se aplicó descuento");
            else
            Console.WriteLine("Descuento a aplicar: {0} %", descuento);
            Console.WriteLine("Importe a descontar: {0}", importeDescuento);
            Console.WriteLine("Total a pagar: {0}", pagoTotal);

            Console.ReadKey();
        }
    }
}
