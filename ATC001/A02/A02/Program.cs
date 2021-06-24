using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02
{
    class Program
    {
        static char[][] c;
        static int H;
        static int W;
        static bool ans = false;
        static bool[][] reserched;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            H = int.Parse(input[0]);
            W = int.Parse(input[1]);

            c = new char[501][];
            reserched = new bool[501][];
            int start_x = 0;
            int start_y = 0;
            for (int i = 0; i < H; i++)
            {
                c[i] = new char[501];
                reserched[i] = new bool[501];
                var input_c = Console.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    c[i][j] = input_c[j];
                    if (input_c[j] == 's')
                    {
                        start_x = j;
                        start_y = i;
                    }
                }
            }
            Search(start_x, start_y);
            if (ans)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static void Search(int x, int y)
        {
            if (x < 0 || x >= W || y < 0 || y >= H || c[y][x] == '#')
            {
                return;
            }

            if (c[y][x] == 'g')
            {
                ans = true;
                return;
            }

            if (reserched[y][x])
            {
                return;
            }
            reserched[y][x] = true;

            Search(x + 1, y);
            Search(x - 1, y);
            Search(x, y + 1);
            Search(x, y - 1);
        }
    }
}
