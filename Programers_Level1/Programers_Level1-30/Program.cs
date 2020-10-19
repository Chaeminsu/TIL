using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_30
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"{solution("01033334444")}");
        }
        public static string solution(string phone_number)
        {
            string answer = "";
            int beforeCount = phone_number.Substring(0, (phone_number.Length - 4)).Length;
            string beforeNumber = "";
            for (int i = 0; i < beforeCount; i++)
                beforeNumber += "*";
            string reamintNum = phone_number.Substring((phone_number.Length - 4), 4);
            return answer = beforeNumber + reamintNum;
            #region 풀이 2
            //string answer = "";
            //char[] dd = phone_number.Substring(0, (phone_number.Length - 4)).Select(x => x = '*').ToArray();
            //string beforeNumber = new string(dd);
            //string reamintNum = phone_number.Substring((phone_number.Length - 4), 4);
            //return answer = beforeNumber + reamintNum;
            #endregion
        }
    }
}
