package com.company;


import java.util.Arrays;
import java.util.List;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Find_PrimeNumber {
    public static void main(String[] args) {
        System.out.println(solution(10));
    }
    public static int solution(int n) {
        long answer = 0;

        int[] _intList;
        Stream<Integer> intStream  = IntStream.rangeClosed(0,n).boxed();
        _intList = intStream.mapToInt(Integer::intValue).toArray();
        _intList[0]= 0;
        _intList[1]= 0;

       for (int i = 2; i*i <= n; i++)
       {
           if (_intList[i]==0) continue;
           for (int j = i + i; j <= n; j+=i)
               _intList[j]=0;
       }
        answer = Arrays.stream(_intList).filter(x -> x != 0).count();
        return (int)answer;
    }
}
