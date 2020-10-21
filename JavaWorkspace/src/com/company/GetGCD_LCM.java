package com.company;

import java.util.Arrays;

public class GetGCD_LCM {

    public static void main(String[] args) {
        for (int item: solution(3,12)) {
            System.out.println(item);
        }

    }
    public static int[] solution(int n, int m)
    {
        int[] answer = {};
        int temp;
        int firstNum = n;
        int secondNum = m;
        int reamin =0;

        if (n < m)
        {
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }
        while(secondNum != 0)
        {
            reamin = firstNum % secondNum;
            firstNum = secondNum;
            secondNum = reamin;
        }
        int GCD = firstNum;
        int LCM = n * m / GCD;

        answer = new int[]{GCD,LCM};
        return answer;
    }
}
