using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int hps = 1000;
            int hpb = 1000;

            while(hpb>0 && hps>0)
            {
                hpb -= r.Next(10);
                if (hpb <= 0)
                    Console.WriteLine("Batman died!");
                else
                    Console.WriteLine("Batman hp: " + hpb);

                hps -= r.Next(10);
                if (hps <= 0)
                    Console.WriteLine("Superman died!");
                else
                    Console.WriteLine("Superman hp: " + hps);
                Console.Write("---------------------\n");
            }
            
        }
    }
}
