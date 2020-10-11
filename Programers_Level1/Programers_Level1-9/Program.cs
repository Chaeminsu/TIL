using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_9
{
    class Program
    {
        static string[] strings = { "abce", "abcd", "cdx" };
        static int n = 2;
        static void Main(string[] args)
        {
            
            foreach (string item in solution(strings, n))
            {
                Console.WriteLine($"{item}");
            }
        }
        public static string[] solution(string[] strings, int n)
        {
            Array.Sort(strings, new MyComparer(n));
            return strings;

            //string[] answer = new string[] { };
            //Dictionary<string, string> dic = new Dictionary<string, string>();

            //for (int i = 0; i < strings.Length; i++)
            //    dic.Add(strings[i], strings[i][n].ToString());

            //answer = dic.OrderBy(x => x.Value).ThenBy(y => y.Key).Select(x => x.Key).ToArray();

            //return answer;
        }
        public class MyComparer : IComparer<string>
        {
            public int index;
            
            public MyComparer(int argument)
            {
                index = argument;
            }

            public int Compare(string x, string y)
            {
                int retval = x[index].CompareTo(y[index]);

                if (retval != 0)
                {
                    return retval;
                }
                else
                {
                    return x.CompareTo(y);
                }
            }
        }
    }
}
