using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);
            var c = int.Parse(input[2]);

            if (a == b)
            {
                Console.WriteLine(c);
            }
            else if (b == c)
            {
                Console.WriteLine(a);
            }
            else if (c == a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
