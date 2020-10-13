using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(125));
        }
        public static int solution(int n)
        {
            int answer = 0;
            int division;
            int lastValue;

            Stack<int> s = new Stack<int>();

            while (true)
            {
                division = n / 3;
                lastValue = n % 3;
                s.Push(lastValue);
                n = division;
                if (division == 0) break;
            }

            int s_lenght = s.Count;

            for (int i = 0; i < s_lenght; i++)
                answer += (int)(s.Pop() * Math.Pow(3, i));

            return answer;
        }
      
    }
}
