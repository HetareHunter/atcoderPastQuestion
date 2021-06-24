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
            var S = Console.ReadLine();
            var xNum = 0;
            var quesNum = 0;
            
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'x') xNum++;
                else if (S[i] == '?') quesNum++;
            }
            var maruNum = 10 - xNum - quesNum;
            if (maruNum >= 5)
            {
                Console.WriteLine(0);
                return;
            }
            var calNum = quesNum + maruNum;
            Console.WriteLine(Math.Pow(calNum,4)-1);
        }
    }
}
