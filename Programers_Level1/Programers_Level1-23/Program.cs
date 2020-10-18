using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(121)}");
        }
        public static long solution(long n)
        {
            long answer = 0;
            int result;

            if (int.TryParse(Math.Sqrt(n).ToString(), out result))
            {
                answer = (long)Math.Pow((result + 1), 2);
            }
            else
            {
                answer = -1;
            }
               

            return answer;
        }
    }
}
