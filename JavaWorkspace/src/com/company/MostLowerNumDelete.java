package com.company;

import java.lang.reflect.Array;
import java.util.*;

public class MostLowerNumDelete {

    static int[] arr = {1,5,7,3,2,6};
    public static void main(String[] args)
    {
        for (int item: solution(arr)) {
            System.out.println(item);
        }

    }
    public static int[] solution(int[] arr) {
        int[] answer = {};
        List<Integer> b = new ArrayList<>();
        List<Integer> c = new ArrayList<>();

        for (int i = 0; i < arr.length; i++)
        {
            b.add(arr[i]);
            c.add(arr[i]);
        }
       Collections.sort(b);
        c.remove(b.get(0));

        return c.stream().mapToInt(Integer::intValue).toArray();
     // int[] answer = {};

     // if (arr.length <= 1) {
     //     answer = new int[]{-1};
     //     return answer;
     // }

     // int value = Arrays.stream(arr).min().getAsInt();
     // answer = Arrays.stream(arr).filter(x -> x != value).toArray();
     // return answer;
    }
}
