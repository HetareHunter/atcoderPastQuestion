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
            var input = Console.ReadLine().Split(' ');

            var H = int.Parse(input[0]);
            var W = int.Parse(input[1]);
            var X = int.Parse(input[2]);
            var Y = int.Parse(input[3]);

            var S = new string[999999];
            for (int i = 0; i < H; i++)
            {
                S[i] = Console.ReadLine();
            }

            int ans = 1;
            if (X >= 2)
            {
                for (int i = X - 2; i >= 0; i--) //上方向に走査
                {
                    if (S[i][Y - 1] == '#')
                    {
                        break;
                    }
                    else
                    {
                        ans++;
                    }
                }
            }
            if (X <= H - 1)
            {
                for (int i = X; i < H; i++)//下方向に走査
                {
                    if (S[i][Y - 1] == '#')
                    {
                        break;
                    }
                    else
                    {
                        ans++;
                    }
                }
            }

            if (Y >= 2)
            {
                for (int i = Y - 2; i >= 0; i--)//左方向に走査
                {
                    if (S[X - 1][i] == '#')
                    {
                        break;
                    }
                    else
                    {
                        ans++;
                    }
                }
            }
            if (Y <= W - 1)
            {
                for (int i = Y; i < W; i++)//右方向に走査
                {
                    if (S[X - 1][i] == '#')
                    {
                        break;
                    }
                    else
                    {
                        ans++;
                    }
                }
            }

            Console.WriteLine(ans);
        }
    }
}
