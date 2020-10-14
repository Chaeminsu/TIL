using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_14
{
    class Program
    {
        static int value = 10;

        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(value)}");
        }

        public static int solution(int n)
        {
            int answer = 0;
            bool[] list = Enumerable.Repeat<bool>(false, n).ToArray();
            list[0] = true;
            for (int i = 2; i <= n; i++)
            {
                if (list[i -1] == true) continue;
                for (int j = i + i; j <= n; j = j + i)
                {
                    list[j - 1] = true;
                }
            }
            answer = list.Where(x => x == false).Count();
            return answer;
        }
    }
}

