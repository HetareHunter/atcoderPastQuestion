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
            var input = Console.ReadLine().Split(' ');
            var R = int.Parse(input[0]);
            var X = int.Parse(input[1]);
            var Y = int.Parse(input[2]);

            var dis = Distance(0, 0, X, Y);
            var steps = dis / R;
            if (dis < R)
            {
                Console.WriteLine(2);
            }
            else if (dis % R == 0)
            {
                Console.WriteLine(dis / R);
            }
            else
            {
                Console.WriteLine(Math.Ceiling(steps));
            }
            
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
    }
}
