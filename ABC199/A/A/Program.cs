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
            var A = int.Parse(input[0]);
            var B = int.Parse(input[1]);
            var C = int.Parse(input[2]);

            var squareAB = A * A + B * B;
            var squareC = C * C;
            if (squareAB < squareC)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
