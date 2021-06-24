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

            var milkSolid = A + B;
            var ans = 0;

            if (milkSolid >= 15 && B >= 8)
            {
                ans = 1;
            }
            else if (milkSolid >= 10 && B >= 3)
            {
                ans = 2;
            }
            else if (milkSolid >= 3)
            {
                ans = 3;
            }
            else
            {
                ans = 4;
            }

            Console.WriteLine(ans);
        }
    }
}
