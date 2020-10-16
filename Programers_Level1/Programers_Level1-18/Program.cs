using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{solution(0)}");
            Console.WriteLine($"{solution(5)}");

        }
        public static int solution(int n)
        {
            int answer = 0;
            //answer = Enumerable.Range(1, n).Where(x => n % x == 0).Sum();
            if (n == 0) return answer;
            int[] intLIst = Enumerable.Range(1, n).ToArray();
            for (int i = 1; i < n; i++)
            {
                if (intLIst[i] == 0) continue;
                if (n % intLIst[i] == 0)
                    answer += intLIst[i];
            }
            answer += 1;
            return answer;
        }
    }
}
