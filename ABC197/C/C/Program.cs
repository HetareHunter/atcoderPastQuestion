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
            var input = Console.ReadLine().Split(' ');
            var A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(input[i]);
            }
            var res = int.MaxValue;

            //bit全探索
            for (int bit = 0; bit < (1 << N - 1); bit++) //N-1は数列の区切ることができる場所の数
            {
                var xored = 0;
                var ored = 0;
                for (int i = 0; i <= N; i++)
                {
                    if (i < N)
                    {
                        ored |= A[i];
                    }
                    if (i == N || (bit >> i & 1) > 0) //bitが1になっているかどうか、つまり区切られているかどうか
                    {
                        xored ^= ored;
                        ored = 0;
                    }
                }
                res = Math.Min(res, xored);
            }
            Console.WriteLine(res);
        }
    }
}
