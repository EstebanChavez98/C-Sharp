using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, mayusculas;
            int edad;
            
            Console.WriteLine("Nombre de la persona: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Edad de la persona: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Edad: {0}\n", edad);

            mayusculas = nombre.ToUpper();

            Console.WriteLine("Hola, {0}", mayusculas);

            if (edad > 17)
                Console.WriteLine("Eres MAYOR de edad, tienes {0} años, vas a poder votar en las proximas elecciones", edad);
            else
                Console.WriteLine("Eres MENOR de edad, tienes {0} años, aun no podras votar en las proximas elecciones", edad);
            
            Console.ReadKey();

        }
    }
}
