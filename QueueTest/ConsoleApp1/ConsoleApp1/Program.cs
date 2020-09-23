using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] value = new int[] { 1, 2, 3, 2, 3 };
        static void Main(string[] args)
        {
            foreach (int item in solution(value))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] solution(int[] prices)
        {
            List<int> answer = new List<int>();

            Queue<int> q = new Queue<int>(prices);
            int index = 1;
            while (q.Count > 0)
            {
                int nowPrice = q.Dequeue();
                int time = 0;

                for (int i = index; i < prices.Length; i++)
                {
                    time++;
                    if (nowPrice > prices[i] || i == prices.Length - 1)
                    {
                        answer.Add(time);
                        break;
                    }
                }
                index++;
            }
            answer.Add(0);
            return answer.ToArray();
        }
    }
}