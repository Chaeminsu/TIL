using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(10)}");
            Console.WriteLine($"{solution(13)}");
        }
        public static bool solution(int x)
        {
            bool answer = true;
            int inputNumSum = x.ToString().Select(y => int.Parse(y.ToString())).Sum();
            return answer = x % inputNumSum == 0 ? true : false;
        }
    }
}
