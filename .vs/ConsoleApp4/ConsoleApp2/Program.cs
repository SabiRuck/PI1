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
            /*
            int priemer = 0;
            for(int i =0; i<1000; i++)
                priemer += r.Next(101);
            Console.Write("Priemer: {0}\n", priemer / 1000);*/
            int a, b, c, cislo;
            a = 0;
            b = 0;
            c = 0;
            for(int i=0; i<1000; i++)
            {
                cislo = r.Next(4);
                switch (cislo)
                {
                    case 1:
                        a++;
                        break;
                    case 2:
                        b++;
                        break;
                    case 3:
                        c++;
                        break;
                    default:
                        break;
                }
                
            }
            
            Console.Write("Cislo 1: {0}krat\nCislo 2: {1}krat\nCislo 3: {2}krat\n", a, b, c);


        }
    }
}
