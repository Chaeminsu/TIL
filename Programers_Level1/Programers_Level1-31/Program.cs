using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_31
{
    class Program
    {
        static int[,] arr1 = { { 1, 2 }, { 2, 3 } };
        static int[,] arr2 = { { 3, 4 }, { 5, 6 } };

        static int[,] arr3 = { { 1 }, { 2 } };
        static int[,] arr4 = { { 3 }, { 4 } };



        static void Main(string[] args)
        {
            foreach (var item in solution(arr3, arr4))
            {
                Console.WriteLine($"{item}");
            }
            
        }
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr1.GetLength(1); j++)
                    answer[i, j] = arr1[i, j] + arr2[i, j];

            return answer;
        }
    }
}
