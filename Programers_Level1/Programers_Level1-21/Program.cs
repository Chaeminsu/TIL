using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in solution(12345))
            {
                Console.WriteLine(item);
            }
          

        }
        public static int[] solution(long n)
        {
            int[] answer = new int[] { };
            answer = n.ToString().Select(x => int.Parse(x.ToString())).Reverse().ToArray();
            return answer;
        }
    }
}
