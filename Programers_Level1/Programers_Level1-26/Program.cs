using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_26
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in solution(72,30))
            {
                Console.WriteLine(item);
            }
            
        }
        public static int[] solution(int n ,int m)
        {
            int[] answer = { };
            int temp, remain, firstNum = n, SecondNum = m;
            if (n < m)
            {
                temp = firstNum;
                firstNum = SecondNum;
                SecondNum = temp;
            }
            while (SecondNum != 0)
            {
                remain = firstNum % SecondNum;
                firstNum = SecondNum;
                SecondNum = remain;

            }
            int GCD = firstNum;
            // 최소 공배수
            int LCM = n * m / GCD;

            answer = new int[] { GCD, LCM };
            return answer;
        }
    }
}
