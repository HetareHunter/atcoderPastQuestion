using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static int n;
        static int[] a;
        static int[][] x;
        static int[][] y;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            x = new int[n][];
            y = new int[n][];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                x[i] = new int[a[i]];
                y[i] = new int[a[i]];
                for (int j = 0; j < a[i]; j++)
                {
                    var input = Console.ReadLine().Split(' ');
                    x[i][j] = int.Parse(input[0]);
                    y[i][j] = int.Parse(input[1]);
                }
            }
            var res = 0;

            for (int bit = 0; bit < (1 << n); bit++) //n人の人を順番に決め打ちで正直者と不親切な人を決める
            {
                if (Judge(bit))
                {
                    var honest = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if ((bit >> i & 1) > 0)
                        {
                            honest++;
                        }
                    }
                    res = Math.Max(res, honest);
                }
            }

            Console.WriteLine(res);
        }

        /// <summary>
        /// 証言と決め打ちした正直者に矛盾がないか判断する
        /// </summary>
        /// <param name="bit"></param>
        /// <returns></returns>
        static bool Judge(int bit)
        {
            //i人目の証言を検証する
            for (int i = 0; i < n; i++)
            {
                if (!((bit >> i & 1) > 0))
                {
                    continue;
                }

                for (int j = 0; j < a[i]; j++)
                {
                    if (y[i][j] == 1 && !((bit >> x[i][j] & 1) > 0))
                    {
                        return false;
                    }

                    if (y[i][j] == 0 && ((bit >> x[i][j] & 1) > 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
