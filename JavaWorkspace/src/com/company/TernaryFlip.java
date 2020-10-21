package com.company;

import java.lang.reflect.Array;
import java.util.*;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class TernaryFlip {
    public static void main(String[] args) {
        System.out.println(solution(45));
        System.out.println(solution(125));
    }
    public static int solution(int n) {
        int answer = 0;
        int division;
        int lastValue;

        Stack<Integer> s = new Stack<Integer>();
        while(true)
        {
            division = n / 3;
            lastValue = n % 3;
            s.push(lastValue);
            n = division;
            if (division == 0) break;
        }

        long s_length = s.stream().count();
        for (int i = 0; i < s_length; i++)
        {
            answer+= s.pop() * Math.pow(3,i);
        }
        return  answer;

    }
}
