package com.company;

import java.util.*;
import java.util.Queue;

public class GotyaTwoNumberSum {

    static int[] numbers = new int[] {2,1,3,4,1};

    public static void main(String[] args) {

        for (int item: solution(numbers)) {
            System.out.println(item);
        }
    }
    static int[] solution(int[] numbers)
    {
        int[] answer = new int[]{};
        List<Integer> sumList = new ArrayList<>();
        Queue<Integer> q = new LinkedList();

        for (int i = 0; i < numbers.length; i++)
            q.offer(numbers[i]);

        int index = 1;

        do
        {
          int nowNum = q.poll();

          for (int j = index; j < numbers.length; j++)
          {
             sumList.add(nowNum + numbers[j]);
          }
          index++;
        }while(q.stream().count() > 0);

        sumList.sort((x,y) -> x.compareTo(y));
        answer  = sumList.stream().distinct().mapToInt(Integer::intValue).toArray();
        return answer;
    }
}
