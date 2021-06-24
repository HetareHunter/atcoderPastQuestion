using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine(); //2Nの文字列が入るので必ず偶数の文字列となる
            var Q = int.Parse(Console.ReadLine());
            var T2Count = 0;
            char[] moji = S.ToCharArray();
            int T;
            int A;
            int B;

            for (int i = 0; i < Q; i++)
            {
                var input = Console.ReadLine().Split(' ');
                T = int.Parse(input[0]);
                A = int.Parse(input[1]);
                B = int.Parse(input[2]);

                if (T == 1)
                {
                    if (T2Count % 2 != 0)
                    {
                        ChangeHalfToHalf(moji, N);
                    }
                    T2Count = 0;
                    ChangeAB(moji, A - 1, B - 1);
                }
                else
                {
                    T2Count++;
                }
            }

            if (T2Count % 2 != 0)
            {
                ChangeHalfToHalf(moji, N);
            }
            Console.WriteLine(new string(moji));
        }

        /// <summary>
        /// 文字列SのA番目の文字とB番目の文字を入れ替える
        /// </summary>
        /// <param name="S"></param>
        /// <param name="indexA"></param>
        /// <param name="indexB"></param>
        /// <returns></returns>
        static void ChangeAB(char[] moji, int indexA, int indexB)
        {
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
        static void ChangeHalfToHalf(char[] moji, int N)
        {
            ////char[] moji = S.ToCharArray();
            //char[] firstHalf = new char[N];
            //char[] secondHalf = new char[N];
            //for (int i = 0; i < N; i++)
            //{
            //    firstHalf[i] = moji[i];
            //}
            string S = new string(moji);
            string firstHalfstr = S.Substring(0, N);

            //for (int i = N; i < 2 * N; i++)
            //{
            //    secondHalf[i - N] = moji[i];
            //}
            string secondHalfstr = S.Substring(N, N);

            string newMoji = secondHalfstr + firstHalfstr;
            for (int i = 0; i < N; i++)
            {
                moji[i] = newMoji[i];
            }
            //for (int i = 0; i < N; i++)
            //{
            //    moji[i + N] = firstHalf[i];
            //}
        }
    }
}