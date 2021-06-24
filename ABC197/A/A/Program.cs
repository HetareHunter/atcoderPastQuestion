using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var moji = S.ToCharArray();
            var tmp = moji[0];
            moji[0] = moji[1];
            moji[1] = moji[2];
            moji[2] = tmp;
            Console.WriteLine(new string(moji));
        }
    }
}
