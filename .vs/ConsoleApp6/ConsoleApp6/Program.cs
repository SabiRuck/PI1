using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] pocty = new int[100];

            for(int i =0; i<10000; i++)
            {
                int num = r.Next(100);
                pocty[num]++;
            }
            for(int i=0; i<pocty.Length; i++)
            {
                Console.Write("cislo: {0}   krat: {1}\n", i, pocty[i]);
            }
        }

    }
}
