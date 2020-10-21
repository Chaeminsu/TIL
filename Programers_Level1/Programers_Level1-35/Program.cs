using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_35
{
    class Program
    {
        static int[] d = { 1,3,2,5,4 };
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(d, 9)}");
        }
        public static int solution(int[] d, int budget)
        {
            int answer = 0;
            List<int> _list = new List<int>();
            Queue<List<int>> q = new Queue<List<int>>();
            int sumD = 0;

            for (int i = 0; i < d.Length; i++)
            {
                sumD = d[i];
                for (int j = i + 1; j < d.Length; j++)
                {
                    if (sumD + d[j] <= budget)
                    {
                        sumD += d[j];
                        _list.Add(d[j]);
                        continue;
                    }
                }
                _list.Add(d[i]);
                q.Enqueue(_list);
                _list = new List<int>();
            }
            answer = q.Dequeue().Count;
            for (int i = 0; i < q.Count; i++)
            {
                if (answer < q.Peek().Count)
                {
                    answer = q.Dequeue().Count;
                }
            }
            return answer;
        }
    }
}
