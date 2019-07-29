using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAuto
{
    class Program
    {
        List<Auto> listaAutos = new List<Auto>(); 
        static void Main(string[] args)
        {

            Program pro = new ListAuto.Program();
            int opc, opc2;
            do
            {
                pro.menu();
                Console.WriteLine("A cual opcion desea entrar?");
                opc = Convert.ToInt32(Console.ReadLine());
                while(opc<1 || opc>2)
                {
                    Console.WriteLine("No existe esa opcion, elija una opcion: ");
                    opc = Convert.ToInt32(Console.ReadLine());

                }
                switch(opc)
                {
                    case 1:
                        pro.agregaAutor();
                        break;
                    case 2:
                        pro.consultaAutos();
                        break;
                }

                Console.WriteLine("Desea seguir en el menú?");
                opc2 = Convert.ToInt32(Console.ReadLine());
            } while (opc2 != 2);
            Console.ReadKey();
        }

        public void agregaAutor()
        {  // terminar el alta de autos
            // pedir datos: NumSerie
            Console.WriteLine("ALTA DE AUTO");
            Console.WriteLine("Numero de Serie: ");
            string numeroS=Console.ReadLine().ToUpper();
            if(buscaNumSerie(numeroS)==false)
            {
                //Nombre, Modelo, Marca, numMaxPasajeros

                Console.WriteLine("Nombre del auto: ");
                string nombre = Console.ReadLine().ToUpper();

                Console.WriteLine("Modelo del auto: ");
                int modelo = Convert.ToInt32(Console.ReadLine());
                while(modelo<2000 || modelo>DateTime.Now.Year+1)
                {
                    Console.WriteLine("Modelo de auto invalido. Vuelva ingresar el modelo.");
                    modelo = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Marca del auto: ");
                string marca = Console.ReadLine().ToUpper();

                Console.WriteLine("Maxima capacidad de pasajeros: ");
                int pasajeros = Convert.ToInt32(Console.ReadLine());

                Auto auto = new ListAuto.Auto(numeroS, nombre, modelo, marca, pasajeros);
                listaAutos.Add(auto);
            }
            else
            {
                Console.WriteLine("Numero de Serie {0} Duplicado", numeroS);
            }
        }

        public void consultaAutos()
        {
            Console.WriteLine("----Lista de autos---------");
            for(int i=0; i<listaAutos.Count; i++)
            {
                Console.WriteLine(listaAutos[i]); 
            }
        }

        public void modificaMarca()
        {
            Console.WriteLine("Numero de Serie");
            string numeroS = Console.ReadLine();

            foreach (Auto item in listaAutos)
            {
                if(numeroS.Equals(item.pNumSerie))
                {
                    Console.WriteLine("Marca Actual {0}", item.pMarca);
                    Console.WriteLine("Proporciona la marca nueva");
                    string marca = Console.ReadLine();
                    item.pMarca = marca;
                }
            }
        }

        public void borraAuto()
        {
            //listaautos.removeat();
            Console.WriteLine("Eliminar Auto");
            Console.WriteLine("Dame el Numero de Serie");
            string numeroS = Console.ReadLine();
            int lugar = buscaNumSeriePos(numeroS);
            if(lugar>=0)
            {
                Console.WriteLine("Desea borrar {0} {1}?", listaAutos[lugar].pNumSerie, listaAutos[lugar].pNombre);
                string confirmar = Console.ReadLine();
                if (confirmar=="1")
                {
                    listaAutos.RemoveAt(lugar);
                }
            }
            else
            {
                Console.WriteLine("Numero de Serie {0} no encontrado", numeroS);
            }
        }

        public void menu()
        {
            Console.WriteLine("----------MENU-----------");
            Console.WriteLine("1.- Alta de autos.");
            Console.WriteLine("2.- Mostrar autos.");
            Console.WriteLine("3.- Modificar. \n");
        }

        //consulta de autos - utilizando for -
        // Hacer Menú 1.- Alta, 2.- Mostrar Autos 3.- Modificar

        public bool buscaNumSerie(string numS)
        {
            bool retorno = false;
            foreach (Auto item in listaAutos)
            {
                if(numS.CompareTo(item.pNumSerie)==0)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public int buscaNumSeriePos(string numS)
        {
            int posicion = -1;
            for(int i=0;i<listaAutos.Count;i++)
            {
                if (numS==listaAutos[i].pNumSerie)
                {
                    posicion = i;
                    break;
                }
            }
            return posicion;
        }
    }
}
