using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_24
{
    class Program
    {
        static int[] arr = { 4,3,2,1 };

        static void Main(string[] args)
        {
            //int[] answer = new int[] { };
            //if (arr.Length <= 1)
            //{
            //    answer = new int[] { -1 };
            //    return answer;
            //}
            //int temp = arr.Min();
            //answer = arr.Select(x => x).Where(y => y != temp).ToArray();
            //return answer;
            foreach (var item in solution(arr))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] solution(int[] arr)
        {
            List<int> b = new List<int>(arr);
            List<int> c = new List<int>(arr);
            b.Sort();
            c.Remove(b[0]);
            if (c.Count == 0)
            {
                c.Add(-1);
            }
            return c.ToArray();



           
        }
       
    }
}
