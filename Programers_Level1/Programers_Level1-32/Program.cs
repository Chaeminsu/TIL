using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_32
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in solution(2, 5))
            {
                Console.WriteLine(item);
            }

            foreach (var item in solution(-4, 2))
            {
                Console.WriteLine(item);
            }

        }
        public static long[] solution(int x, int n)
        {
            List<long> answer = new List<long>();

            int count = 0;
            long input = x;

            while (count != n)
            {
                answer.Add(input);
                count++;
                input += x;
            }
            return answer.ToArray();
        }
    }
}
