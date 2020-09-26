using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest2
{
    class Program
    {
        static int[] progresses = new int[] { 95, 90, 99, 99, 80, 99 };
        static int[] speeds = new int[] { 1, 1, 1, 1, 1, 1 };

        static void Main(string[] args)
        {
            foreach (var item in solution(progresses, speeds))
            {
                Console.WriteLine(item);
            }

        }
        public static int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();


            for (int i = 0; i < progresses.Length; i++)
                q.Enqueue(new KeyValuePair<int, int>(i, progresses[i]));

            while (true)
            {
                if (q.Count == 0) break;
                for (int i = 0; i < q.Count; i++)
                {
                    KeyValuePair<int, int> item = q.Dequeue();
                    q.Enqueue(new KeyValuePair<int, int>(item.Key, item.Value + speeds[item.Key]));
                }
                int count = 0;
                if (q.Peek().Value >= 100 )
                {
                    bool flag = false;
                    for (int i = 0; i < q.Count; i++)
                    {
                        KeyValuePair<int, int> item = q.Dequeue();
                        if (flag == false && item.Value >= 100)
                        {
                            i = -1;
                            count++;

                        }
                        else
                        {
                            q.Enqueue(item);
                            flag = true;
                        }
                    }
                }
                if (count > 0)
                {
                    answer.Add(count);
                }

            }

            return answer.ToArray();

        }
    }
}
