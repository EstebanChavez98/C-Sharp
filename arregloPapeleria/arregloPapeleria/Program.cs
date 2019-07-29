using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arregloPapeleria
{
    class Program
    {
        string[] arregloNomArticulos = new string[10];
        int[] arregloCantidad = new int[10];
        double[] arregloPrecio = new double[10];
        int pos = 0;
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.altaArticulos();   
            char opc, opc2;
            
            do
            {
                pro.menu();
                opc = Convert.ToChar(Console.ReadLine());
                if (opc == '1')
                {
                    pro.consultaArticulos();
                }
                else
                    if (opc == '2')
                {
                    pro.ventaArticulo();
                }
                else
                {
                    pro.modificaNombre();
                }
                Console.WriteLine("Quiere salir del menú? (1/SI 2/NO)");
                opc2= Convert.ToChar(Console.ReadLine());
            } while (opc2 != '1');

            pro.imprimirInventario();

        Console.ReadKey();

        }

        public void menu()
        {
            Console.WriteLine("---------PAPELERIA--------\n");
            Console.WriteLine("1.- Consulta de articulos");
            Console.WriteLine("2.- Venta de articulo: ");
            Console.WriteLine("3.- Modificar nombre: ");

           /* char opc;
            opc = Convert.ToChar(Console.ReadLine());
            if(opc=='1')
            {
                consultaArticulos();
            }
            else
                if(opc=='2')
            {
                ventaArticulo();
            }
            else
            {
                modificaNombre();
            }*/
        }

        public void altaArticulos()
        {
            Console.WriteLine("ALTA DE ARTICULOS");

            for (int i = 0; i < arregloNomArticulos.Length; i++)
            {
                Console.WriteLine("Nombre del articulo: ");
                string nombre = Console.ReadLine();

                while (buscaNombre(nombre) == true)
                {
                    Console.WriteLine("Nombre {0} dublicado, vuelva ingresar el nombre: ", nombre);
                    nombre = Console.ReadLine();
                }

                arregloNomArticulos[i] = nombre;

                Console.WriteLine("Cantidad del articulo en inventario: ");
                int canArticulo = Convert.ToInt32(Console.ReadLine());

                while (canArticulo < 1)
                {
                    Console.WriteLine("Cantidad Invalida, vuelva ingresar la cantidad: ");
                    canArticulo = Convert.ToInt32(Console.ReadLine());
                }
                arregloCantidad[i] = canArticulo;

                Console.WriteLine("Precio del articulo: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                while (precio < 1)
                {
                    Console.WriteLine("Precio invalido, vuelva ingresar el precio: ");
                    precio = Convert.ToDouble(Console.ReadLine());
                }

                arregloPrecio[i] = precio;

                pos++;
            }
        }

        public void consultaArticulos()
        {
            Console.WriteLine("Seleccione el articulo que desea ver");
            for(int i=0; i<arregloNomArticulos.Length; i++)
            {
                Console.WriteLine(i+".- "+arregloNomArticulos[i]);
            }
            string nomArticulo = Console.ReadLine();
            int lugar1 = buscaPos(nomArticulo);

            while(lugar1==-1)
            {
                Console.WriteLine("El articulo no existe, vuelva ingresar nombre: ");
                nomArticulo = Console.ReadLine();
                lugar1 = buscaPos(nomArticulo);
            }

            Console.WriteLine("Cantidad en existencia: {0}", arregloCantidad[lugar1]);
            Console.WriteLine("Precio del articulo: {0}", arregloPrecio[lugar1]);

        }

        public void imprimirInventario()
        {
            for(int i=0; i<arregloNomArticulos.Length; i++)
            {
                Console.WriteLine("Nombre del articulo: {0}", arregloNomArticulos[i]);
                Console.WriteLine("Cantidad de articulo en inventario: {0}", arregloCantidad[i]);
                Console.WriteLine("Precio del articulo: {0}\n", arregloPrecio[i]);
            }
        }

        public void ventaArticulo()
        {
            Console.WriteLine("Que articulo desea comprar?");
            string nomArt = Console.ReadLine();
            int lugar = buscaPos(nomArt);

            while(lugar ==-1)
            {
                Console.WriteLine("Articulo {0} No existe, introdusca de nuevo el articulo: ", nomArt);
                nomArt = Console.ReadLine();
                lugar = buscaPos(nomArt);
            }
            Console.WriteLine("Cuantos desea comprar? ");
            int canArt = Convert.ToInt32(Console.ReadLine());

            while(canArt>arregloCantidad[lugar])
            {
                Console.WriteLine("No tenemos esa cantidad, vuelva a pedir cuantos desea:");
                canArt = Convert.ToInt32(Console.ReadLine());
            }
            arregloCantidad[lugar] = arregloCantidad[lugar] - canArt;

            double total = canArt * arregloPrecio[lugar];
            Console.WriteLine("Total a pagar: {0}", total);
        }

        public void modificaNombre()
        {
            Console.WriteLine("- MODIFICACION NOMBRE DE ARTICULOS -");
            Console.WriteLine("Introduzca el nombre del articulo: ");
            string nombre = Console.ReadLine();
            int lugar = buscaPos(nombre);

            if(lugar==-1)
            {
                Console.WriteLine("Articulo {0} No existe", nombre);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nuevo Nombre: ");
                string nuevoNombre = Console.ReadLine();

                while (buscaNombre(nuevoNombre)==true)
                {
                    Console.WriteLine("Ya existe el articulo, vuelva ingresar el nuevo nombre: ");
                    nuevoNombre = Console.ReadLine();
                }
                arregloNomArticulos[lugar] = nuevoNombre;
            }
        }

        public bool buscaNombre(string nomBuscar)
        {
            bool encontro = false;
            for(int i=0; i<pos; i++)
            {
                if(arregloNomArticulos[i].Equals(nomBuscar))
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        public int buscaPos(string nomBuscar)
        {
            int pos1 = -1;
            for (int i = 0; i < pos; i++)
            {
                if (arregloNomArticulos[i].Equals(nomBuscar))
                {
                    pos1 = i;
                    break;
                }
            }
            return pos1;
        }
    }
}
