using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_35
{
    class Program
    {
        static int[] d = { 1,3,2,5,4 };
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(d, 10)}");
        }
        public static int solution(int[] d, int budget)
        {
            int answer = 0;
            Array.Sort(d);
            foreach (var item in d)
            {
                if (item > budget)
                {
                    break;
                }
                budget -= item;
                ++answer;
            }
            return answer;
        }
    }
}
