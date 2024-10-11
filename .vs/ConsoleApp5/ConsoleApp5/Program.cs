using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int[] cisla = new int[100];

            int[] trpaslici = new int[7];

            for (int i = 0; i < trpaslici.Length; i++)
                trpaslici[i] = r.Next(50, 100);
            
            Console.WriteLine("Najmensi trpaslin mal: " + trpaslici.Max() + "cm");
            // Console.WriteLine("Bol" + trpaslici.));
        }   

    }
}
