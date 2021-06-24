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
            var N = Console.ReadLine();
            var digits = N.Length;

            for (int i = 0; i < digits; i++)
            {
                string reverseN= new string(N.Reverse().ToArray());
                if (N.Equals(reverseN))
                {
                    Console.WriteLine("Yes");
                    return;
                }
                N = N.Insert(0, "0");
            }
            Console.WriteLine("No");
        }
    }
}
