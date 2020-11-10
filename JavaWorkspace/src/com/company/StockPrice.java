package com.company;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;

public class StockPrice {
    static int[] prices = {1,2,3,2,3};
    public static void main(String[] args) {
        for (int item: solution(prices)) {
            System.out.println(item);
        }
    }
    public static int[] solution(int[] prices) {
        ArrayList<Integer> answer = new ArrayList<>();
        Queue<Integer> q = new LinkedList<>();

        for (int i = 0; i < prices.length; i++)
        {
            q.offer(prices[i]);
        }

        int index = 1;

            while(q.size() > 0) {
                int now = q.poll();
                int intCount = 0;
                for (int j = index; j < prices.length; j++)
                {
                    intCount++;
                    if (now > prices[j] || j == prices.length -1)
                    {
                        answer.add(intCount);
                        break;
                    }
                    index++;
                }
            }

        return answer.stream().mapToInt(Integer::intValue).toArray();
    }
}
