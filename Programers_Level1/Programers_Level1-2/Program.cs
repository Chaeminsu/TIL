using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_2
{
    
    class Program
    {
        static int[] answer = new int[] {1,2,3,4,5};
        static void Main(string[] args)
        {
            foreach (int item in solution(answer))
            {
                Console.WriteLine($"{item}");
            }
        }
        public static int[] solution(int[] answers)
        {
            List<int> answer = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();

            Queue<int> q = new Queue<int>(answers);
            Queue<int> q_first = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            Queue<int> q_second = new Queue<int>(new int[] { 2, 1, 2, 3, 2, 4, 2, 5 });
            Queue<int> q_third = new Queue<int>(new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            int F_Point = 0;
            int S_Point = 0;
            int T_Point = 0;

            do
            {
                int nowAnswer = q.Dequeue();
                int f_Answer = q_first.Dequeue();
                int s_Answer = q_second.Dequeue();
                int t_Answer = q_third.Dequeue();

                if (nowAnswer == f_Answer)
                    F_Point++;
                if (nowAnswer == s_Answer)
                    S_Point++;
                if (nowAnswer == t_Answer)
                    T_Point++;


                q_first.Enqueue(f_Answer);
                q_second.Enqueue(s_Answer);
                q_third.Enqueue(t_Answer);


            } while (q.Count > 0);

            dic.Add(1,F_Point);
            dic.Add(2,S_Point);
            dic.Add(3,T_Point);

            var descList = dic.ToArray().OrderByDescending(x => x.Value);
            int nowValue = descList.First().Value;

            foreach (var item in descList)
            {
                if (nowValue == item.Value)
                    answer.Add(item.Key);
            }
            int a = 0 % 5;

            answer.Sort();
            return answer.ToArray();
        }
    }
}
