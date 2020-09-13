using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_digits_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12 = 3
            int A = Solution(12);
            Console.WriteLine("12 = {0}", A.ToString());
            // 123 = 6
            int A2 = Solution(123);
            Console.WriteLine("123 = {0}", A2.ToString());
            // 987 = 24
            int A3 = Solution(987);
            Console.WriteLine("987 = {0}", A3.ToString());

            int A4 = Solution(10000000);
            Console.WriteLine("10000000 = {0}", A4.ToString());
        }

        public static int Solution(int n)
        {
            int answer = 0;
            string strNum = n.ToString();
            for (int i = 0; i < strNum.Length; i++)
                answer += Int32.Parse(strNum.Substring(i, 1));
            return answer;
        }
    }
}
