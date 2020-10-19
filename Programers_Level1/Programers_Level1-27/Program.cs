using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_27
{
    class Program
    {
        static int[] arr = { 1, 2, 3, 4 };
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(arr)}");
        }
        public static double solution(int[] arr)
        {
            double answer = 0;
            answer = arr.Average();
            return answer;
        }
    }
}
