using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacimientos
{
    class Program
    {
        public String Fecha_actual()
        {
            return DateTime.Now.ToString();
        }

        public void menu()
        {
            
        }

        public void Calcular_edad()
        {

        }
        static void Main(string[] args)
        {
            Program nacimiento = new Program();
            int opc = 0;
            int dia = 0, mes = 0, año = 0;
            Fecha fecha = new Fecha(dia, mes, año);


            do
            {
                while (!fecha.fechaCorrecta())
                {
                    Console.WriteLine("Ingrese el dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el mes");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el año de nacimiento");
                    año = Convert.ToInt32(Console.ReadLine());
                    fecha.setAño(año);
                    fecha.setDia(dia);
                    fecha.setMes(mes);

                }

                //DateTime dn = new DateTime(fecha.getAño(),fecha.getMes(),fecha.getDia());

                if (fecha.getMes() < DateTime.Today.Month)
                {
                    Console.WriteLine("Los Años de la persona son: " + Convert.ToString(DateTime.Now.Year - fecha.getAño()));
                }
                else
                {
                    if (fecha.getMes() == DateTime.Today.Month)
                    {
                        if (fecha.getDia() <= DateTime.Today.Day)
                        {
                            Console.WriteLine("Los años de la persona son: {0}", Convert.ToString(DateTime.Now.Year - fecha.getAño()));
                        }
                        else
                        {
                            Console.WriteLine("Los años de la persona son: {0}", Convert.ToString(DateTime.Now.Year - (fecha.getAño() - 1)));
                        }
                    }
                }
                Console.WriteLine("Desea salir del programa? (1/si 2/no)");
                opc = Convert.ToInt32(Console.ReadLine());

            } while (opc != '1');

            Console.ReadKey();
        }
    }
}
