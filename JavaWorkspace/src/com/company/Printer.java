package com.company;

import java.lang.reflect.Array;
import java.util.*;

public class Printer {

    static int[] priorities = {2,1,3,2};
    static int location = 2;

    static int[] priorities2 = {1, 1, 9, 1, 1, 1};
    static int location2 = 0;

    public static void main(String[] args) {
        System.out.println(solution(priorities, location));
        System.out.println(solution(priorities2, location2));
    }
    static class myPrint
    {
        int document;
        int priorities;
        public myPrint(int docu, int prio)
        {
            this.document = docu;
            this.priorities = prio;
        }

    }
    public static int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<myPrint> q = new LinkedList<>();

        for (int i =0; i<priorities.length; i++)
            q.offer(new myPrint(i, priorities[i]));

        while (q.size() > 0)
        {
            Boolean flag = false;
            for (myPrint print: q) {
                if (q.peek().priorities < print.priorities) {
                    flag = true;
                }
            }

            if(flag)
            {
                q.offer(q.poll());
            }
            else
            {
                if (q.poll().document == location)
                {
                    answer = priorities.length - q.size();
                }
            }

        }

        return answer;

    }
}
