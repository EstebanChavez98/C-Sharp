using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHT = new Hashtable();
            myHT.Add(0, "zero");
            myHT.Add(1, "one");
            myHT.Add(2, "two");
            myHT.Add(3, "three");
            myHT.Add(4, "four");

            Hashtable mad = new Hashtable();
            mad.Add(1, "holi");

            Console.WriteLine(mad);

            Console.ReadKey();
        }
    }
}
