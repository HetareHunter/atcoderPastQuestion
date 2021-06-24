using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var S = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                S.Add(input[i]);
                if (S[i] == '6')
                {
                    S[i] = '9';
                }
                else if (S[i] == '9')
                {
                    S[i] = '6';
                }
            }
            S.Reverse();
            Console.WriteLine(new String(S.ToArray()));
        }
    }
}
