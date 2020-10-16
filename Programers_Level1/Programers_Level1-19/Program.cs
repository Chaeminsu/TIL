using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution("try hello world")}");
        }

        public static string solution(string s)
        {
            string answer = "";
            int wordIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += s[i];
                    wordIndex = 0;
                    continue;
                }
                if (wordIndex % 2 == 0)
                {
                    answer += s[i].ToString().ToUpper();
                    wordIndex++;
                }
                else
                {
                    answer += s[i].ToString().ToLower();
                    wordIndex++;
                }
            }
            return answer;
        }
    }
}
