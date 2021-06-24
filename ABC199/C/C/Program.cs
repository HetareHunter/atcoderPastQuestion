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
            var S = Console.ReadLine(); //2Nの文字列が入るので必ず偶数の文字列となる
            var Q = int.Parse(Console.ReadLine());
            var T2 = false;
            char[] moji = S.ToCharArray();

            for (int i = 0; i < Q; i++)
            {
                var input = Console.ReadLine().Split(' ');
                int T = int.Parse(input[0]);
                int A = int.Parse(input[1]);
                int B = int.Parse(input[2]);

                if (T == 1)
                {
                    ChangeAB(moji, A - 1, B - 1, N, T2);
                }
                else
                {
                    T2 = T2 ? false : true;
                }
            }

            S = new string(moji);
            if (T2)
            {
                S = ChangeHalfToHalf(S, N);
            }
            Console.WriteLine(S);
        }

        /// <summary>
        /// 文字列SのA番目の文字とB番目の文字を入れ替える
        /// </summary>
        /// <param name="moji"></param>
        /// <param name="indexA"></param>
        /// <param name="indexB"></param>
        /// <param name="N"></param>
        /// <param name="t2"></param>
        static void ChangeAB(char[] moji, int indexA, int indexB, int N, bool t2)
        {
            if (t2)
            {
                if (indexA <= N - 1)
                {
                    indexA += N;
                }
                else
                {
                    indexA -= N;
                }

                if (indexB <= N - 1)
                {
                    indexB += N;
                }
                else
                {
                    indexB -= N;
                }
            }

            char mojitmp = moji[indexA];
            moji[indexA] = moji[indexB];
            moji[indexB] = mojitmp;
        }

        /// <summary>
        /// 文字列Sの前半部分と後半部分を入れ替える
        /// </summary>
        /// <param name="S"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        static string ChangeHalfToHalf(string S, int N)
        {
            string firstHalfstr = S.Substring(0, N);
            string secondHalfstr = S.Substring(N, N);
            string newMoji = secondHalfstr + firstHalfstr;
            return newMoji;
        }
    }
}
