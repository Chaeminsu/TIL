package com.company;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.Queue;

public class NormalRegtangle {
    public static void main(String[] args) {
        System.out.println(solution(8,12));
    }
    public static long solution(int w, int h) {
        long answer = 0;

        int temp;
        int firstNum = w;
        int secondNum = h;
        int reamin =0;

        if (w < h)
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
        int gcd = firstNum;
        float fff = w*h;


        answer = (long)(fff - (w + h - gcd));
        return answer;
    }
}
