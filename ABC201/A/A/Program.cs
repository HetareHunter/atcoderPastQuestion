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
            var A = new int[3];
            A[0] = int.Parse(input[0]);
            A[1] = int.Parse(input[1]);
            A[2] = int.Parse(input[2]);
            Array.Sort(A);

            if (Math.Abs(A[1] - A[0]) == Math.Abs(A[2] - A[1]))
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
