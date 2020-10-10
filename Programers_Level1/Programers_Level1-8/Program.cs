using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_8
{
    class Program
    {
        static int a = 3, b = 5;

        static void Main(string[] args)
        {
            Console.WriteLine(solution(a,b));
        }
        public static long solution(int a, int b)
        {
            long answer = 0;
            if (a == b)
            {
                answer = a;
                return answer;
            }

            int start = 0;
            int end = 0;

            if (a > b)
            {
                start = b;
                end = a;
            }
            else
            {
                start = a;
                end = b;
            }

            for (int i = start; i <= end; i++)
            {
                answer += i;
            }


            return answer;
        }
    }
}
