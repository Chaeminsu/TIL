using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_3
{
    class Program
    {
        static int[] array = { 1, 35, 2, 6,10000 , 100, 4 };
        static int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

        static void Main(string[] args)
        {
            foreach (int item in solution(array, commands))
            {
                Console.WriteLine($"{item}");
            }
        }
        public static int[] solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();
            string strArray = string.Join(",", array); 

            int count = 0;
            int startNum = 0;
            int lengthNum = 0;

            foreach (int item in commands)
            {
                if (count == 0)
                {
                    count++;
                    startNum = item;
                    continue;
                }

                if (count == 1)
                {
                    count++;
                    lengthNum = item;
                    continue;
                }

                if (count == 2)
                {
                    count = 0;

                    int[] resultArr = new int[lengthNum - startNum + 1];
                    int index = 0;

                    for (int i = startNum - 1; i < lengthNum; i++)
                    {
                        resultArr[index] = array[i];
                        index++;
                    }
                    Array.Sort(resultArr);
                    answer.Add(resultArr[item - 1]);
                }

            }
            return answer.ToArray();
        }
    }
}
