using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_5
{
    
    class Program
    {
        // 2016년 1월 1일 - 금요일 일땨ㅐ
        // 2016년 a월 b일 의 요일을 맞추시오
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(5,24)}");
        }

        public static string solution(int a, int b)
        {
            #region 풀이 1
            string answer = "";
            string[] dayName = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU", };
            int days = 0;

            for (int i = 1; i < a; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                    days += 31;
                else if (i == 2)
                    days += 29;
                else
                    days += 30;
            }
            days += b - 1;
            answer = dayName[days % 7];
            return answer;
            #endregion
            #region 풀이 2
            //string answer = "";

            //DateTime dateValue = new DateTime(2016, a, b);
            //answer = dateValue.DayOfWeek.ToString().Substring(0, 3).ToUpper();

            //return answer;
            #endregion

        }
    }
}
