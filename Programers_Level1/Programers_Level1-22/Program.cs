using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(118372)}");
            string[] strArray = n.ToString().Select(x => x.ToString()).ToArray();
            Array.Sort(strArray, new MyCompare());
        }

        public static long solution(long n)
        {
            long answer = 0;
            string[] strArray2 = n.ToString().Select(x => x.ToString()).OrderBy(y => y).Reverse().ToArray();
            answer = Int32.Parse(string.Join("", strArray2));
            return answer;
        }
        public class MyCompare : IComparer<string>
        {
            public MyCompare()
            {
            }
            public int Compare(string x, string y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
