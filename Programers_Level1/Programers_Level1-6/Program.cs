using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_6
{
    class Program
    {
        static string dd = "abcde";
        static string ddd = "qwer";
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(dd)}");

            Console.WriteLine($"{solution(ddd)}");
        }
        public static string solution(string s)
        {
            string answer = "";
            #region 풀이 1

            if (s.Length % 2 == 0)
                answer = s.AsEnumerable().ElementAt(s.Length / 2 - 1).ToString() + s.AsEnumerable().ElementAt(s.Length / 2).ToString();
            else
                answer = s.AsEnumerable().ElementAt(s.Length / 2).ToString();

            return answer;
            #endregion


            #region 풀이 2
            int length = s.Length;
            if (length % 2 == 0)
            {
                int pointer = length / 2 - 1;
                answer = (s[pointer].ToString() + s[++pointer].ToString());
            }
            else
            {
                int pointer = length / 2 - 1;
                answer = (s[++pointer]).ToString();
            }

            return answer;
            #endregion


        }
    }
}
