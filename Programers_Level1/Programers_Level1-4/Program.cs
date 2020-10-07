using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_4
{
    class Program
    {
        static int total = 6;
        static int[] lost = {5,6 };
        static int[] reserve = { 4,5};

        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(total, lost, reserve)}");
        }

        public static int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            if (n <= 1) return 0;
             
            int[] total = new int[n];
            total = total.Select(x => x = 1).ToArray();

            for (int i = 0; i < lost.Length; i++)
                total[lost[i] - 1] -= 1;

            for (int i = 0; i < reserve.Length; i++)
                total[reserve[i] - 1] += 1;


            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] == 0 && i == 0)
                {
                    if (total[i + 1] == 2)
                    {
                        total[i] += 1;
                        total[i + 1] -= 1;
                    }
                }
                if (total[i] == 0 && i == total.Length -1)
                {
                    if (total[i - 1] == 2)
                    {
                        total[i] += 1;
                        total[i - 1] -= 1;
                    }
                }

                if (total[i] == 0 && i > 1 && i < total.Length - 1)
                {
                    if (total[i - 1] == 2)
                    {
                        total[i] += 1;
                        total[i - 1] -= 1;
                    }

                    if (total[i + 1] == 2)
                    {
                        total[i] += 1;
                        total[i + 1] -= 1;
                    }
                }
            }

            answer = total.Where(x => x >= 1).Count();
            return answer;
         }
    }
}
