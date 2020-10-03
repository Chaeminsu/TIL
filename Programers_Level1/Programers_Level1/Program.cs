using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_1
{
    class Program
    {
        static int[] numbers = { 2, 1, 3, 4, 1 };
        static int[] numbers2 = { 5, 0, 2, 7};
        static void Main(string[] args)
        {
            //정수 배열 numbers가 주어집니다.
            //numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를 
            //배열에 오름차순으로 담아 return 하도록 solution 함수를 완성해주세요.

            foreach (int item in solution(numbers2))
            {
                Console.WriteLine($"{item}");
            }
        }
        public static int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> sumList = new List<int>();
            Queue<int> q = new Queue<int>(numbers);
            int index = 1;
            do
            {
                int nowNum = q.Dequeue();
                for (int i = index; i < numbers.Length; i++)
                {
                    sumList.Add(nowNum + numbers[i]);
                }
                index++;
            } while (q.Count > 0);
            sumList.Sort();
            answer = sumList.Distinct().ToArray();
            return answer;
        }
    }
}
