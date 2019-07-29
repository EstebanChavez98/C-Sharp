using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNacimiento
{
    class Program
    {
        public string Fecha_actual()
        {
            return DateTime.Now.ToString();
        }


        int dia, mes, año;

        static void Main(string[] args)
        {
            Program pro = new FechaNacimiento.Program();
            pro.nacimiento();
        }

        public void nacimiento()
        {
            int edad;
            char opc;
            Fecha fecha = new FechaNacimiento.Fecha(dia, mes, año);

            

            do
            {
                Console.WriteLine("Ingresa el año de nacimiento: ");
                año = Convert.ToInt32(Console.ReadLine());
                while (año < 1)
                {
                    Console.WriteLine("Año no valido, vuelva ingresar el año: ");
                    año = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingresa el mes: ");
                mes = Convert.ToInt32(Console.ReadLine());
                while(mes<1 || mes>12)
                {
                    Console.WriteLine("Mes no valido. Vuelva ingresar el mes: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                }

                if (mes == 2)
                {
                    if (esBisiesto())
                    {
                        Console.WriteLine("Ingresa el dia: ");
                        dia = Convert.ToInt32(Console.ReadLine());
                        while (dia < 1 || dia > 29)
                        {
                            Console.WriteLine("Dia invalido. Ingresa el dia: ");
                            dia = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresa el dia: ");
                        dia = Convert.ToInt32(Console.ReadLine());
                        while (dia < 1 || dia > 28)
                        {
                            Console.WriteLine("Dia invalido. Ingresa el dia: ");
                            dia = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                else
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine("Ingresa el dia: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    while (dia < 1 || dia > 30)
                    {
                        Console.WriteLine("Dia invalido. Ingresa el dia: ");
                        dia = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("Ingresa el dia: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    while (dia < 1 || dia > 31)
                    {
                        Console.WriteLine("Dia invalido. Ingresa el dia: ");
                        dia = Convert.ToInt32(Console.ReadLine());
                    }
                }

                fecha.setDia(dia);
                fecha.setMes(mes);
                fecha.setAño(año);

               // Console.WriteLine(Convert.ToString(DateTime.);
                if (fecha.getMes() < Convert.ToInt32(DateTime.Today.Month))
                {
                    edad = Convert.ToInt32(DateTime.Now.Year - fecha.getAño());
                    Console.WriteLine("Los Años de la persona son: {0}", edad);
                    if (edad > 19)
                        Console.WriteLine("Es mayor de edad.");
                    else
                        Console.WriteLine("Es menor de edad. ");
                }
                else
                {
                    if (fecha.getMes() > Convert.ToInt32(DateTime.Today.Month))
                    {
                        edad = Convert.ToInt32(DateTime.Now.Year - (fecha.getAño() + 1));
                        Console.WriteLine("Los Años de la persona son: {0}", edad);
                        if (edad > 19)
                            Console.WriteLine("Es mayor de edad.");
                        else
                            Console.WriteLine("Es menor de edad. ");
                    }
                    else
                    {
                        if (fecha.getMes() == Convert.ToInt32(DateTime.Today.Month))
                        {
                            if (fecha.getDia() <= Convert.ToInt32(DateTime.Today.Day))
                            {
                                edad = Convert.ToInt32(DateTime.Now.Year - fecha.getAño());
                                Console.WriteLine("Los Años de la persona son: {0}", edad);
                                if (edad > 19)
                                    Console.WriteLine("Es mayor de edad.");
                                else
                                    Console.WriteLine("Es menor de edad. ");
                            }
                            else
                            {
                                edad = Convert.ToInt32(DateTime.Now.Year - (fecha.getAño() + 1));
                                Console.WriteLine("Los Años de la persona son: {0}", edad);
                                if (edad > 19)
                                    Console.WriteLine("Es mayor de edad.");
                                else
                                    Console.WriteLine("Es menor de edad. ");
                            }
                        }
                    }
                }
                Console.WriteLine(Fecha_actual());

                Console.WriteLine("Desea salir del programa? (1/SI 2/NO)");
                opc = Convert.ToChar(Console.ReadLine());
            } while (opc != '1');

            Console.ReadKey();
        }

        public Boolean esBisiesto()
        {
            Boolean bisiesto;
            if ((año % 4 == 0) && ((año % 100 != 0) || (año % 400 == 0)))
                bisiesto = true;
            else
                bisiesto = false;

            return bisiesto;
        }

    }


}

