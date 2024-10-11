using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int c1, c2;
            c2 = 0;
            for (int i=0; i<10; i++)
            {
                
                c1 = r.Next(3);
                while(c1 == c2)
                {
                    c1 = r.Next(4);
                }
                
                c2 = c1;
                Console.WriteLine(c1);
            }
        }
    }
}
