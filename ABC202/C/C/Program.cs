using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            int[] ANum = new int[N + 1];
            int[] BNum = new int[N + 1];
            int[] BIndex = new int[N + 1];
            var inputA = Console.ReadLine().Split(' ');
            var inputB = Console.ReadLine().Split(' ');
            var inputC = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(inputA[i]);
                B[i] = int.Parse(inputB[i]);
                C[i] = int.Parse(inputC[i]);
                BIndex[C[i]]++;
                ANum[A[i]]++;
                BNum[B[i]]++;
            }

            var count = 0;
            for (int i = 0; i < N; i++)
            {
                if (BIndex[i+1] > 0 && ANum[i] > 0)
                {
                    var bcount = BNum[i] + BIndex[i+1];
                    count +=bcount;
                }

            }

            Console.WriteLine(count);
        }
    }
}
