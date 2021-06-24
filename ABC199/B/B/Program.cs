using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var inputA = Console.ReadLine().Split(' ');
            var inputB = Console.ReadLine().Split(' ');
            var A = new int[N];
            var B = new int[N];

            var xmin = 0;
            var xmax = 9999;

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(inputA[i]);
                B[i] = int.Parse(inputB[i]);

                if (A[i] <= B[i])
                {
                    if (xmin < A[i])
                    {
                        xmin = A[i];
                    }

                    if (xmax > B[i])
                    {
                        xmax = B[i];
                    }

                }
            }

            if (xmin <= xmax)
            {
                Console.WriteLine(Math.Abs(xmin - xmax) + 1);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
