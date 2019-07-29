using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPorRango
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1, valor2;
            int numero, contador=0;

            Console.WriteLine("Dame el valor inicial: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el valor final: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            //Validar que valor1<valor2

            while(valor1>valor2)
            {
                Console.WriteLine("Valor inicial {0}, es incorrecto, vuelva ingresar el valor: ", valor1);
                valor1 = Convert.ToInt32(Console.ReadLine());
                contador++;
            }

            do
            {
                Console.WriteLine("Escriba un numero dentro del rango: ");
                numero = Convert.ToInt32(Console.ReadLine());

            } while (numero < valor1 || numero > valor2);

            /*if(valor1>=valor2)
            {
                Console.WriteLine("Valor Inicial {0}, incorrecto", valor1);

            }
            else
            {
                do
                {
                    Console.WriteLine("Escriba un numero dentro del rango: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                } while (numero > valor2 || numero < valor1);
            }
            */
            Console.WriteLine("");
            Console.WriteLine("Numero de intentos fallidos: {0}", contador);
            Console.WriteLine("El numero {0} está dentro del rango.");
            Console.ReadKey();
        }
    }
}
