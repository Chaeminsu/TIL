using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{solution("abcd")}");
            Console.WriteLine($"{solution("34234")}");

        }

        public static bool solution(string s)
        {
            bool answer = true;
            int result;

            if (s.Length == 4 || s.Length == 6)
            {
                if (!int.TryParse(s, out result))
                    answer = false;
            }
            else
            {
                return false;
            }
           
            return answer;
        }
    }
}
