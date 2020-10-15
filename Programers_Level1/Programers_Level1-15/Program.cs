using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(3)}");
            Console.WriteLine($"{solution(4)}");
        }
        public static string solution(int n)
        {
            string answer = "";
            var a = Enumerable.Range(1, n).Select(x => x % 2 == 0 ? "박" : "수");
            answer = string.Join("", a.ToArray());
            return answer;
        }
    }
}
