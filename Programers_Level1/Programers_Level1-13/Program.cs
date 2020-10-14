using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_13
{
    class Program
    {
        static string[] strArray = { "Jane", "Kim" };
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(strArray)}");
        }

        public static string solution(string[] seoul)
        {
            string answer = "";
            int index = seoul.ToList().FindIndex(x => x.Equals("Kim") == true);
            answer = $"김서방은 {index}에 있다";
            return answer;
        }
    }
}
