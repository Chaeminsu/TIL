using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(123)}");
        }
        public static int solution(int n)
        {
            int answer = 0;
            string value = n.ToString();
            int result;

            for (int i = 0; i < value.Length; i++)
            {
                int.TryParse(value[i].ToString(), out result);
                answer += result;
            }
         
            return answer;
        }
    }
}
