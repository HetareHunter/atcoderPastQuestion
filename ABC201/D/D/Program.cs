using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static int H;
        static int W;
        static string[] A;
        static int taka = -9999;
        static int ao = -9999;
        static bool[][] research;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            H = int.Parse(input[0]);
            W = int.Parse(input[1]);
            A = new string[H];
            research = new bool[H][];
            for (int i = 0; i < H; i++)
            {
                research[i] = new bool[W];
                A[i] = Console.ReadLine();
            }
            var player = 0;//0ならたかはし、１ならあおき
            var takaNow = 0;
            var aoNow = 0;
            Search(0, 0,player,takaNow,aoNow);
            if (taka == -9999) taka = 0;
            if (ao == -9999) ao = 0;
            if (taka > ao)
            {
                Console.WriteLine("Takahashi");
            }
            else if(taka<ao)
            {
                Console.WriteLine("Aoki");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            
        }
        static void Search(int y,int x,int playerNum,int takaNow,int aoNow)
        {
            if (y < 0 || y >= H || x < 0 || x >= W || research[y][x])
            {
                return;
            }

            if (A[y][x] == '+')
            {
                if (playerNum % 2 == 0) takaNow++;
                else aoNow++;
            }
            else
            {
                if (playerNum % 2 == 0) takaNow--;
                else aoNow--;
            }
            taka = Math.Max(taka, takaNow);
            ao = Math.Max(ao, aoNow);
            playerNum++;

            Search(y + 1, x, playerNum, takaNow, aoNow);
            Search(y, x + 1, playerNum, takaNow, aoNow);
        }
    }
}
