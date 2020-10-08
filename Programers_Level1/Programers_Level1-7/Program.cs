using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_7
{
    class Program
    {
        static int[] array = { 8,9,7,11 };

        static void Main(string[] args)
        {
            foreach (int item in solution(array, 5))
            {
                Console.WriteLine($"{item}");
            }
        }

        public static int[] solution(int[] arr, int divisor)
        {
            List<int> answer = new List<int>();

            answer = arr.Where(x => x % divisor == 0).OrderBy(y => y).ToList();

            if (answer.Count <= 0)
                answer.Add(-1);

            return answer.ToArray();
        }
    }
}
