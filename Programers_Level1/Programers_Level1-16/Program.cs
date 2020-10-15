using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution("1234")}");
            Console.WriteLine($"{solution("-1234")}");
        }
        public static int solution(string s)
        {
            int answer = 0;
            int result = 0;
            int.TryParse(s, out result);
            answer = result;

            return answer;
        }
    }
}
