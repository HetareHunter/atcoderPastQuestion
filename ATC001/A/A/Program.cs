using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static char[][] maze;
        static bool[][] researched;
        static int H;
        static int W;
        static bool arrival = false;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            H = int.Parse(input[0]);
            W = int.Parse(input[1]);
            int max_H = 500;
            int max_W = 500;
            maze = new char[max_H][];
            researched = new bool[max_H][];
            for (int i = 0; i < H; i++)
            {
                maze[i] = new char[max_W];
                researched[i] = new bool[max_W];
                var inputState = Console.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    
                    maze[i][j] = inputState[j];
                }
            }

            Search(0, 0);
            if (arrival)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void Search(int x,int y)
        {
            if (x < 0 || x >= W || y < 0 || y >= H || maze[x][y] == '#')
            {
                return;
            }

            if (maze[x][y] == 'g')
            {
                arrival = true;
            }

            if (researched[x][y])
            {
                return;
            }

            researched[x][y] = true;

            Search(x + 1, y);
            Search(x - 1, y);
            Search(x, y + 1);
            Search(x, y - 1);
        }
    }
}
