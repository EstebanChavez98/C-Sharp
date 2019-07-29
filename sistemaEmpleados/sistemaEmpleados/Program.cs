using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEmpleados
{
    class Program
    {
        Empleado[] arregloEmp = new Empleado[10];
        Puestos[] arregloPuesto = new Puestos[100];
        int totalEmp = 0;
        int totalPst = 0;
        static void Main(string[] args)
        {
            Program pro = new Program();

            char opc2;

            do
            {
                pro.menu();

                char opc = Convert.ToChar(Console.ReadLine());

                if (opc == '1')
                {
                    pro.altaEmpleados();
                }
                else
                {
                    if (opc == '2')
                    {
                        pro.altaPuestos();
                    }
                    else
                    {
                        if (opc == '3')
                        {
                            pro.capturaDiasClave();
                        }
                        else
                        {
                            if (opc == '4') 
                            {
                                pro.modificaDato();
                            }
                            else
                            {
                                if(opc=='5')
                                {
                                    pro.informacionEmpleado();
                                }
                                else
                                {
                                    if(opc=='6')
                                    {
                                        pro.imprimirEmpleados();
                                    }
                                    else
                                    {
                                        if(opc=='7')
                                        {
                                            pro.imprimirPuestos();
                                        }
                                        else
                                        {
                                            if (opc == '8')
                                            {
                                                pro.nomina();
                                            }
                                            else
                                            {
                                                pro.consultaEmpleado();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("Desea salir del menú? (1/SI 2/NO)");
                opc2 = Convert.ToChar(Console.ReadLine());

            } while (opc2 != '1');
            Console.ReadKey();
        }

        public void menu()
        {
            Console.WriteLine("-------------sistema de empleados:-----------------");
            Console.WriteLine("1.- Alta de empleado");
            Console.WriteLine("2.- Alta de puestos");
            Console.WriteLine("3.- Capturar dias laborados de empleado.");
            Console.WriteLine("4.- Modificar dato de empleado. ");
            Console.WriteLine("5.- Informacion de empleado.");
            Console.WriteLine("6.- Imprimir informacion de empleados.");
            Console.WriteLine("7.- Imprimir informacion de puestos. ");
            Console.WriteLine("8.- Nomina. ");
            Console.WriteLine("9.- Consulta de empleados.");
        }

        public void informacionEmpleado()
        {
            Console.WriteLine("De que empleado busca informacion?");

            for(int i=0;i<totalEmp;i++)
            {
                Console.WriteLine("- {0}", arregloEmp[i].nombre);
            }

            string nom = Console.ReadLine().ToUpper();

            int lugar = buscaEmpleadoNombre(nom);

            while(buscaEmpleadoNombre(nom)==-1)
            {
                Console.WriteLine("El nombre no está en la lista, vuelva ingresar el nombre: ");
                nom = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Clave de empleado: {0}", arregloEmp[lugar].pClaveEmpleado);
            Console.WriteLine("Nombre de empleado: {0}", arregloEmp[lugar].nombre);
            Console.WriteLine("Departamento: {0}", arregloEmp[lugar].pDepartamento);
            Console.WriteLine("Puesto: {0}", arregloEmp[lugar].pNombrePuesto);
            Console.WriteLine("Sueldo: {0}", arregloEmp[lugar].pSueldoDiario);
            Console.WriteLine("Dias trabajados: {0}", arregloEmp[lugar].pDiasLaborados);
        }

        public void imprimirEmpleados()
        {
            for (int i = 0; i < totalEmp; i++)
            {
                Console.WriteLine("Clave de empleado: {0}", arregloEmp[i].pClaveEmpleado);
                Console.WriteLine("Nombre de empleado: {0}", arregloEmp[i].nombre);
                Console.WriteLine("Departamento: {0}", arregloEmp[i].pDepartamento);
                Console.WriteLine("Puesto: {0}", arregloEmp[i].pNombrePuesto);
                Console.WriteLine("Sueldo: {0}", arregloEmp[i].pSueldoDiario);
                Console.WriteLine("Dias Trabajados: {0}\n", arregloEmp[i].pDiasLaborados);
            }    
        }

        public void imprimirPuestos()
        {
            for (int i =0; i<totalPst; i++)
            {
                Console.WriteLine("Clave de puesto: {0}", arregloPuesto[i].pClavePuesto);
                Console.WriteLine("Nombre de puesto: {0}", arregloPuesto[i].pNombrePuesto);
                Console.WriteLine("Horario de puesto: {0}", arregloPuesto[i].pHorario);
            }
        }

        public void nomina()
        {
            double pago, totalPago=0;
            for (int i = 0; i < totalEmp; i++)
            {
                if (arregloEmp[i].pDiasLaborados > 0)
                {
                    pago = arregloEmp[i].pDiasLaborados * arregloEmp[i].pSueldoDiario;
                    totalPago += pago;
                    Console.WriteLine("Clave de empleado: {0}", arregloEmp[i].pClaveEmpleado);
                    Console.WriteLine("Nombre de empleado: {0}", arregloEmp[i].nombre);
                    Console.WriteLine("Dias trabajados: {0}", arregloEmp[i].pDiasLaborados);
                    Console.WriteLine("Total a pagar: {0}", pago);
                }
            }
                Console.WriteLine("Total de Nomina --> {0:C}", totalPago);
        }

        public void altaEmpleados()
        {
            if (totalPst < 1)
            {
                Console.WriteLine("Primero dé de alta algun puesto.");
            }
            else
            {
                Console.WriteLine("Clave del empleado: ");
                string claveEmpleado = Console.ReadLine().ToUpper();

                if (buscaEmpleado(claveEmpleado) == -1)
                {
                    //no existe clave, procedo a capturar los demas datos
                    //Nombre, departamento y sueldo
                    string nombre, departamento;
                    double sueldoDiario;
                    Console.WriteLine("Nombre del empleado: ");
                    nombre = Console.ReadLine().ToUpper();

                    while (buscaNombre(nombre) == true)
                    {
                        Console.WriteLine("Nombre {0}, ya existe, ingrese otro nombre: ", nombre);
                        nombre = Console.ReadLine().ToUpper();
                    }

                    Console.WriteLine("Departamento en la que se encuentra el empleado: ");
                    departamento = Console.ReadLine().ToUpper();

                    Console.WriteLine("Puestos disponibles para el empleado: ");

                    for (int i = 0; i < totalPst; i++)
                    {
                        Console.WriteLine("-{0}, CLAVE: {1}", arregloPuesto[i].pNombrePuesto, arregloPuesto[i].pClavePuesto);
                    }

                    Console.WriteLine("Puesto para el empleado: ");
                    string clavepst = Console.ReadLine().ToUpper();

                    while (buscaPuesto(clavepst) == -1)
                    {
                        Console.WriteLine("La clave de puesto {0} no existe, volver a introducir clave:", clavepst);
                        clavepst = Console.ReadLine().ToUpper();
                    }

                    int lugar = buscaPuesto(clavepst);

                    string puesto = arregloPuesto[lugar].pNombrePuesto;
                    Console.WriteLine("Sueldo diario del empleado: ");
                    sueldoDiario = Convert.ToDouble(Console.ReadLine());

                    //Validar que el nombre no esté duplicado


                    Empleado emp = new Empleado(claveEmpleado, nombre, departamento, clavepst, puesto, sueldoDiario);
                    arregloEmp[totalEmp] = emp;
                    totalEmp++;
                }
                else
                {
                    Console.WriteLine("Clave de empleado {0}, ya existe", claveEmpleado);
                }
            }
        }

        public void capturaDiasClave()
        {
            Console.WriteLine("Desea buscar por clave o por nombre?");
            Console.WriteLine("1.- Clave");
            Console.WriteLine("2.- Nombre");

            char opc = Convert.ToChar(Console.ReadLine());

            if (opc == '1') 
            {
                Console.WriteLine("Clave del empleado: ");
                string claveEmpleado = Console.ReadLine().ToUpper();
                int lugar = buscaEmpleado(claveEmpleado);
                if (buscaEmpleado(claveEmpleado) == -1)
                {
                    Console.WriteLine("Clave de Empleado {0}, NO existe: ", claveEmpleado);
                }
                else
                {
                    Console.WriteLine("Dias Laborados: ");
                    int numDias = Convert.ToInt32(Console.ReadLine());

                    while(numDias<1)
                    {
                        Console.WriteLine("Dias invalidos, vuelva ingresar los dias laborados");
                        numDias = Convert.ToInt32(Console.ReadLine());
                    }

                    //validar numeros positivos mayores a cero
                    arregloEmp[lugar].pDiasLaborados = numDias;
                }
            }
            else
            {
                Console.WriteLine("Nombre del empleado: ");
                string nombre = Console.ReadLine().ToUpper();
                int lugar = buscaEmpleadoNombre(nombre);
                if (buscaEmpleadoNombre(nombre) == -1)
                {
                    Console.WriteLine("Nombre de Empleado {0}, NO existe: ", nombre);
                }
                else
                {
                    Console.WriteLine("Dias Laborados: ");
                    int numDias = Convert.ToInt32(Console.ReadLine());

                    while(numDias<1)
                    {
                        Console.WriteLine("Dias invalidos, vuelva ingresar los dias laborados");
                        numDias = Convert.ToInt32(Console.ReadLine());
                    }

                    //validar numeros positivos mayores a cero
                    arregloEmp[lugar].pDiasLaborados = numDias;
                }
            }
        }

        public void altaPuestos()
        {
            Console.WriteLine("----------ALTA DE PUESTOS----------");

            Console.WriteLine("Clave de puesto: ");
            string clavePuesto = Console.ReadLine().ToUpper();

            if(buscaPuesto(clavePuesto)==-1)
            {
                Console.WriteLine("Nombre de puesto: ");
                string nomPuesto = Console.ReadLine().ToUpper();

                while(buscaPuestoNombre(nomPuesto)==true)
                {
                    Console.WriteLine("El puesto {0} ya existe, ingrese otro puesto.", nomPuesto);
                    nomPuesto = Console.ReadLine().ToUpper();
                }

                Console.WriteLine("Horario del puesto: ");
                string horario = Console.ReadLine().ToUpper();

                Puestos pst = new Puestos(clavePuesto, nomPuesto, horario);

                arregloPuesto[totalPst] = pst;
                totalPst++;
            }
            else
            {
                Console.WriteLine("La clave {0} ya existe: ", clavePuesto);
            }

        }

        public void consultaEmpleado()
        {
            Console.WriteLine("Que desea consultar?");
            Console.WriteLine("1.- Departamento");
            Console.WriteLine("2.- Sueldo\n");

            char opc = Convert.ToChar(Console.ReadLine());

            if (opc == '1')
            {
                Console.WriteLine("Cual departamento desea buscar?");
                string departamento1 = Console.ReadLine().ToUpper();

                while(buscaDepartamentoEmpleado(departamento1)==false)
                {
                    Console.WriteLine("El departamento {0}, NO existe, vuelva ingresar el departamento", departamento1);
                    departamento1 = Console.ReadLine().ToUpper();
                }

                for (int i = 0; i < totalEmp; i++) 
                {
                    if(arregloEmp[i].pDepartamento == departamento1)
                    {
                        Console.WriteLine("Clave de empleado: {0}", arregloEmp[i].pClaveEmpleado);
                        Console.WriteLine("Nombre de empleado: {0}", arregloEmp[i].nombre);
                        Console.WriteLine("Departamento: {0}", arregloEmp[i].pDepartamento);
                        Console.WriteLine("Puesto: {0}", arregloEmp[i].pNombrePuesto);
                        Console.WriteLine("Sueldo: {0}", arregloEmp[i].pSueldoDiario);
                    }
                }
            }
            else
            {
                Console.WriteLine("Que sueldo desea buscar? ");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                while (sueldo < 0)
                {
                    Console.WriteLine("Sueldo invalido, vuelva a ingresarlo: ");
                    sueldo = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Desea buscar los empleados mayor que el sueldo o menor que el sueldo ingresado?");
                Console.WriteLine("1.- mayor que el sueldo ingresado");
                Console.WriteLine("2.- menor que el sueldo ingresado");

                char opc2 = Convert.ToChar(Console.ReadLine());

                if (opc2 == '1')
                {
                    for (int i = 0; i < totalEmp; i++)
                    {
                        if (arregloEmp[i].pSueldoDiario > sueldo)
                        {
                            Console.WriteLine("Clave de empleado: {0}", arregloEmp[i].pClaveEmpleado);
                            Console.WriteLine("Nombre de empleado: {0}", arregloEmp[i].nombre);
                            Console.WriteLine("Departamento: {0}", arregloEmp[i].pDepartamento);
                            Console.WriteLine("Sueldo: {0}", arregloEmp[i].pSueldoDiario);
                        }
                    }

                }

                else
                {
                    for (int i = 0; i < totalEmp; i++)
                    {
                        if (arregloEmp[i].pSueldoDiario < sueldo) 
                        {
                            Console.WriteLine("Clave de empleado: {0}", arregloEmp[i].pClaveEmpleado);
                            Console.WriteLine("Nombre de empleado: {0}", arregloEmp[i].nombre);
                            Console.WriteLine("Departamento: {0}", arregloEmp[i].pDepartamento);
                            Console.WriteLine("Sueldo: {0}", arregloEmp[i].pSueldoDiario);
                        }
                    }
                }
            }
        }

        public void modificaDato()
        {
            Console.WriteLine("- MODIFICACION DE DATOS DEL EMPLEADO -\n");
            Console.WriteLine("Desea buscar por clave o por nombre?");
            Console.WriteLine("1.- Clave");
            Console.WriteLine("2.- Nombre\n");

            char opc = Convert.ToChar(Console.ReadLine());

            if (opc == '1')
            {
                Console.WriteLine("Introduzca la clave del empleado: ");
                string claveEmpleado = Console.ReadLine().ToUpper();
                int lugar = buscaEmpleado(claveEmpleado);

                if (lugar == -1)
                {
                    Console.WriteLine("La clave {0} NO existe", claveEmpleado);
                }
                else
                {
                    Console.WriteLine("Que dato desea modificar?");
                    Console.WriteLine("1.- Nombre");
                    Console.WriteLine("2.- Departamento");
                    Console.WriteLine("3.- Sueldo");
                    Console.WriteLine("4.- Puesto");

                    int opc2 = Convert.ToInt32(Console.ReadLine());

                    string nuevoNombre;
                    string nuevoDepartamento;
                    double nuevoSueldo;
                    string nuevoPuesto;
                    if (opc2 == 1)
                    {
                        Console.WriteLine("Nuevo nombre: ");
                        nuevoNombre = Console.ReadLine().ToUpper();

                        while (buscaNombre(nuevoNombre) == true)
                        {
                            Console.WriteLine("Nombre {0}, ya existe, ingrese otro nombre: ", nuevoNombre);
                            nuevoNombre = Console.ReadLine().ToUpper();
                        }
                        arregloEmp[lugar].nombre = nuevoNombre;
                    }
                    else
                    {
                        if (opc2 == 2)
                        {
                            Console.WriteLine("Nuevo departamento: ");
                            nuevoDepartamento = Console.ReadLine().ToUpper();
                            while(buscaDepartamentoEmpleado(nuevoDepartamento)==true)
                            {
                                Console.WriteLine("Departamento invalido, ingrese otro departamento");
                                nuevoDepartamento = Console.ReadLine().ToUpper();
                            }

                            arregloEmp[lugar].pDepartamento = nuevoDepartamento;
                        }
                        else
                        {
                            if (opc2 == 3)
                            {
                                Console.WriteLine("Nuevo sueldo:");
                                nuevoSueldo = Convert.ToDouble(Console.ReadLine());

                                arregloEmp[lugar].pSueldoDiario = nuevoSueldo;
                            }
                            else
                            {
                                Console.WriteLine("Nuevo puesto: ");
                                nuevoPuesto = Console.ReadLine().ToUpper();

                                while(buscaPuesto(nuevoPuesto)==-1)
                                {
                                    Console.WriteLine("Clave de puesto {0} no existe, vuelva a ingresar la clave:", nuevoPuesto);
                                    nuevoPuesto = Console.ReadLine().ToUpper();
                                }

                                arregloEmp[lugar].pClavePuesto = nuevoPuesto;
                            }
                        }
                    }

                }
            }
            else
            {
                {
                    Console.WriteLine("Introduzca el nombre del empleado: ");
                    string nombre = Console.ReadLine().ToUpper();
                    int lugar = buscaEmpleadoNombre(nombre);
                    if (lugar == -1)
                    {
                        Console.WriteLine("El empleado {0} NO existe", nombre);
                    }
                    else
                    {
                        Console.WriteLine("Que dato desea modificar?");
                        Console.WriteLine("1.- Departamento");
                        Console.WriteLine("2.- Sueldo");
                        Console.WriteLine("3.- Puesto");

                        int opc2 = Convert.ToInt32(Console.ReadLine());
                        string nuevoDepartamento;
                        double nuevoSueldo;
                        string nuevoPuesto;
                        if (opc2 == 1)
                        {
                            Console.WriteLine("Nuevo departamento: ");
                            nuevoDepartamento = Console.ReadLine().ToUpper();

                            while (buscaDepartamentoEmpleado(nuevoDepartamento) == true)
                            {
                                Console.WriteLine("Departamento invalido, ingrese otro departamento");
                                nuevoDepartamento = Console.ReadLine().ToUpper();
                            }

                            arregloEmp[lugar].pDepartamento = nuevoDepartamento;
                        }
                        else
                        {
                            if (opc2 == 2)
                            {
                                Console.WriteLine("Nuevo sueldo:");
                                nuevoSueldo = Convert.ToDouble(Console.ReadLine());

                                arregloEmp[lugar].pSueldoDiario = nuevoSueldo;
                            }
                            else
                            {
                                Console.WriteLine("Nuevo puesto:");
                                nuevoPuesto = Console.ReadLine().ToUpper();

                                while(buscaPuesto(nuevoPuesto)==-1)
                                {
                                    Console.WriteLine("el puesto {0} no existe, vuelva ingresar puesto: ");
                                    nuevoPuesto = Console.ReadLine().ToUpper();
                                }

                                arregloEmp[lugar].pClavePuesto = nuevoPuesto;
                            }
                        }

                    }
                }
            }
        }

        public int buscaEmpleado(string clave)
        {
            int lugar = -1;

            for(int i=0; i<totalEmp; i++)
            {
                if(arregloEmp[i].pClaveEmpleado==clave)
                {
                    lugar = i;
                    break;
                }
            }

            return lugar;
        }

        public int buscaPuesto(string clave)
        {
            int lugar = -1;

            for (int i = 0; i < totalPst; i++)
            {
                if (arregloPuesto[i].pClavePuesto == clave)
                {
                    lugar = i;
                    break;
                }
            }

            return lugar;
        }

        public int buscaEmpleadoNombre(string nombre)
        {
            int lugar = -1;

            for (int i = 0; i < totalEmp; i++)
            {
                if (arregloEmp[i].nombre == nombre)
                {
                    lugar = i;
                    break;
                }
            }

            return lugar;
        }

        public bool buscaNombre(string nomBuscar)
        {
            bool encontro = false;
            for (int i = 0; i <totalEmp; i++)
            {
                if (arregloEmp[i].nombre.Equals(nomBuscar))
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        public int buscaDepartamento(string depto)
        {
            int lugar = -1;

            for (int i = 0; i < totalEmp; i++)
            {
                if (arregloEmp[i].pDepartamento == depto)
                {
                    lugar = i;
                    break;
                }
            }

            return lugar;
        }

        public bool buscaPuestoNombre(string nomBuscar)
        {
            bool encontro = false;
            for (int i = 0; i < totalEmp; i++)
            {
                if (arregloPuesto[i].pNombrePuesto.Equals(nomBuscar))
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }
        public bool buscaDepartamentoEmpleado(string deptoBuscar)
        {
            bool encontro = false;
            for (int i = 0; i < totalEmp; i++)
            {
                if (arregloEmp[i].pDepartamento.Equals(deptoBuscar))
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }
    }
}
