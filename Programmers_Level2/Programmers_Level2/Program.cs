using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_Level2
{
    class Program
    {
        static int n = 4;
        static void Main(string[] args)
        {
            foreach (int item in solution(n))
            {
                Console.Write($"{item}");
            }
        }
        public static int[] solution(int n)
        {
            List<int> answer = new List<int>();
            int[,] arrays = new int[n,n];

            int num = 1;
            int x = -1, y = 0;
            int sumNum = Enumerable.Range(1, n).Sum();

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i % 3 == 0)
                        x++;
                    else if (i % 3 == 1)
                        y++;
                    else if (i % 3 == 2)
                    {
                        x--;
                        y--;
                    }
                    arrays[x, y] = num++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arrays[i, j] == 0) break;
                    answer.Add(arrays[i, j]);
                }
            }
            




            return answer.ToArray();
        }
    }
}

