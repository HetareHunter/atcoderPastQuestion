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
            var N = long.Parse(input[0]);//友達の数
            var money = long.Parse(input[1]);//初めに持っているお金の数

            var friends = new List<Friend>();

            for (int i = 0; i < N; i++)
            {
                var input2 = Console.ReadLine().Split(' ');
                friends.Add(new Friend(long.Parse(input2[0]), int.Parse(input2[1])));
            }

            var village = 0L;
            village += money;
            friends = friends.OrderBy(x => x.address).ToList();

            for (int i = 0; i < N; i++)
            {

                if (friends[i].address > village)
                {
                    break;
                }
                village += friends[i].incomeGain;
            }
            Console.WriteLine(village);
        }

    }

    class Friend
    {
        /// <summary>
        /// 友達のいる村の番号
        /// </summary>
        public long address;
        /// <summary>
        /// 友達からもらえる金
        /// </summary>
        public int incomeGain;

        public Friend(long address, int income)
        {
            this.address = address;
            this.incomeGain = income;
        }
    }
}
