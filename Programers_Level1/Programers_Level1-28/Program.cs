using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_Level1_28
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{solution(1)}");
        }
        public enum collatz
        {
            Even,
            Odd,
            End,
        }

        public static int solution(int num)
        {
            long answer = num;
            int cnt = 0;
            
            collatz collatz = new collatz();

            if (num == 1) return 0;
            collatz = answer % 2 == 0 ? collatz.Even : collatz.Odd;

            while (true)
            {
                switch (collatz)
                {
                    case Solution.collatz.Even:
                        {
                            answer = answer / 2;
                            cnt++;
                            collatz = collatz.End;
                            break;
                        }

                      
                    case Solution.collatz.Odd:
                        {
                            answer = 3 * answer + 1;
                            cnt++;
                            collatz = collatz.End;
                            break;
                        }
                       
                    case Solution.collatz.End:
                        {
                            if (answer != 1)
                                collatz = answer % 2 == 0 ? collatz.Even : collatz.Odd;
                            else if (cnt >= 500)
                            {
                                return -1;
                            }
                                
                            else
                            {
                                return cnt;
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
