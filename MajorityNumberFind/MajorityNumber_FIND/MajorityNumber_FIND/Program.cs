using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityNumber_FIND
{
    class Program
    {
        public static int[] arr1 = { 3, 5, 3, 3, 3, 4, 3, 1 };
        public static int[] arr2 = { 1, 5, 3, 6, 3, 4, 3, 1 };

        public static void Main(string[] args)
        {
            Console.WriteLine("첫번째 배열 1, 5, 3, 3, 3, 4, 3, 1 중 과반수 {0}", Solution(arr1));

            Console.WriteLine("두번째 배열 1, 5, 3, 6, 3, 4, 3, 1 중 과반수 {0}", Solution(arr2));
        }
        private static int Solution(int[] nums)
        {
            int result = 0;

            int majorityNum = (nums.Length / 2);

            foreach (int item in nums.Distinct().ToArray())
            {
                int vv = nums.Count(x => x == item);

                if (vv > majorityNum)
                {
                    result = item;
                    break;
                }
                else
                {
                    result = -1;
                    continue;
                }
            }
            return result;
        }

    }
}