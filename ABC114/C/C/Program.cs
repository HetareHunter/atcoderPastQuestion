using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static long N;
        static void Main(string[] args)
        {
            N = long.Parse(Console.ReadLine());
            string s = "";
            Console.WriteLine(DFS(s));
        }

        static int DFS(string s)
        {
            int ret = 0;
            List<char> numList = new List<char> { '3', '5', '7' };

            if (s.Length > 0)
            {
                if ((long.Parse(s) > N))
                {
                    return ret;
                }
                else
                {
                    bool numExists = true;
                    foreach (var num in numList)
                    {
                        if (!s.Contains(num.ToString()))
                        {
                            numExists = false;
                        }
                    }
                    if (numExists)
                    {
                        ret++;
                    }
                }

            }

            foreach (var num in numList)
            {
                s += num.ToString();
                ret += DFS(s);
                s = s.Remove(s.Length - 1);
            }
            return ret;
        }
    }
}
