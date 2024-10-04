using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char operacia;

            a = Convert.ToInt32(Console.ReadLine());
            operacia = Convert.ToChar(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (operacia == '+')
                Console.Write("{0}+{1}={2}\n", a, b, (a + b));
            else if (operacia == '-')
                Console.Write("{0}-{1}={2}\n", a, b, (a - b));
            else if (operacia == '*')
                Console.Write("{0}*{1}={2}\n", a, b, (a * b));
            else if (operacia == '/')
                Console.Write("{0}/{1}={2}\n", a, b, (a / b));
            else
                Console.Write("WTF?!\n");


        }
    }
}
