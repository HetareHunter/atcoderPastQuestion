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
            var N = int.Parse(Console.ReadLine());//N個の山
            var mountain = new List<Mountain>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ');
                mountain.Add(new Mountain(input[0], int.Parse(input[1])));
            }
            
            mountain.Sort((a, b) => b.Height - a.Height);
            Console.WriteLine(mountain[1].Name);
        
        }


    }
    public class Mountain
    {
        public string Name;
        public int Height;

        public Mountain(string name, int height)
        {
            this.Name = name;
            this.Height = height;
        }

    }
}
