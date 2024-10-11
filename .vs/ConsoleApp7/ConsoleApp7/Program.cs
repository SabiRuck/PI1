using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> zoznam = new List<int>();
            zoznam.Add(5);
            zoznam.RemoveAt(0);
            zoznam.Sort();*/

            List<string> names = new List<string>();

            while(true)
            {
                Console.WriteLine("Zadaj meno: ");
                string newName = Console.ReadLine();
                if (names.Contains(newName))
                    Console.WriteLine("Meno sa uz v liste nachadza");
                else
                    names.Add(newName);
            }
        }
    }
}
