using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programers_Level1_11
{
    class Program
    {
        static string s = "Zbcdefg";
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(s)}");
        }
        public static string solution(string s)
        {
            string answer = "";
            char[] v = s.AsEnumerable().Select(x => x).OrderByDescending(y => y).ToArray();
            answer = new string(v);
            return answer;
        }
       
    }
}
