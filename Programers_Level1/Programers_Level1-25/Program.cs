using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{solution(3)}");
        }
        public static String solution(int num)
        {
            String answer = "";
            return answer = num % 2 == 0 ? "Even" : "Odd";
        }
    }
}
