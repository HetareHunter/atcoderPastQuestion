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
            var N = int.Parse(input[0]);
            var K = int.Parse(input[1]);

            var sum = 0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    string roomNum = i.ToString() + "0" + j.ToString();
                    sum += int.Parse(roomNum);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
