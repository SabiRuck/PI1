using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); 
            int znamka = r.Next(1, 6);

            switch(znamka)
            { 
                // vyborny chvalitebny dobry dostatocny nedostatocny
                case 1:
                    Console.Write("Monika dostala Vyborny\n");
                    break;
                case 2:
                    Console.Write("Monika dostala Chvalitebny\n");
                    break;
                case 3:
                    Console.Write("Monika dostala Dobry\n");
                    break;
                case 4:
                    Console.Write("Monika dostala Dostatocny\n");
                    break;
                case 5:
                    Console.Write("Monika dostala Nedostatocny a prepadla\n");
                    break;
                default:
                    break;
            }



        }
    }
}
