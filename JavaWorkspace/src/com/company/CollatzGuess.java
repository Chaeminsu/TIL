package com.company;

import java.util.Arrays;

public class CollatzGuess {
    public enum collatz
    {
        Even,
        Odd,
        End
    }
    public static void main(String[] args) {
        System.out.println(solution(6));
        System.out.println(solution(16));
        System.out.println(solution(626331));
    }
    public static int solution(int num) {
        long answer = num;
        int count = 0;

        CollatzGuess.collatz cl;
        if (num == 1) return 0;

        cl = answer % 2 == 0 ? collatz.Even : collatz.Odd;

        while(count <= 500)
        {
            switch (cl)
            {
                case Even:
                {
                    answer = answer / 2;
                    count++;
                    cl = collatz.End;
                    break;
                }
                case Odd:
                {
                    answer = 3 * answer + 1;
                    count++;
                    cl = collatz.End;
                    break;
                }
                case End:
                {
                    if (answer != 1)
                    {
                        cl = answer % 2 == 0 ? collatz.Even : collatz.Odd;
                    }
                    else
                    {
                        return  count;
                    }
                }
            }
        }
        if (count >=500) count = -1;
        return count;
    }
}
