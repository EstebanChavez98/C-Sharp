using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Primero", 1);
            dic.Add("Segundo", 2);
            dic.Add("Tercero", 3);
            dic.Add("Cuarto", 4);

            if (dic.ContainsKey("Segundo") == true)
            {
                Console.WriteLine(   dic["Segundo"].ToString());
            }
            else

            {
                Console.WriteLine("LLave no encontrada");
            }


            

            Console.ReadKey();
            Console.WriteLine("Accediendo por medio de for");
            for (int i = 0; i < dic.Count; i++)
            {
                var element = dic.ElementAt(i);
                string Key = element.Key;
                int Value = element.Value;
                Console.WriteLine( Key + "  " + Value);
            }
            Console.ReadKey();
            
             foreach (var key in dic.Keys)
            {
                Console.WriteLine(" LLave {0}",key);
                Console.WriteLine("Objeto {0}",dic[key].ToString());

            }
             
             foreach (var value in dic.Values)
            {
                Console.WriteLine(value.ToString());
            }

            Console.ReadKey();
        }
    }
}
