package com.company;

import java.lang.reflect.Array;
import java.util.*;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class PracticeTest {
    static int[] answers = {1,3,2,4,2};

    public static void main(String[] args) {
        for (int item: solution(answers))
        {
            System.out.println(item);
        }
    }
    static int[] solution(int[] answers)
    {
        List<Integer> answer = new ArrayList<>();
        HashMap<Integer, Integer> _map = new HashMap<>();

        Queue<Integer> q = new LinkedList<>();
        for (int i= 0; i < answers.length; i++)
            q.offer(answers[i]);

        Queue<Integer> q_first = new LinkedList<Integer>(Arrays.asList(1,2,3,4,5));
        Queue<Integer> q_second = new LinkedList<Integer>(Arrays.asList( 2, 1, 2, 3, 2, 4, 2, 5));
        Queue<Integer> q_third = new LinkedList<Integer>(Arrays.asList( 3, 3, 1, 1, 2, 2, 4, 4, 5, 5));

        int F_Point = 0;
        int S_Point = 0;
        int T_Point = 0;

        do {
            int nowAnswer = q.poll();
            int f_Answer = q_first.poll();
            int s_Answer = q_second.poll();
            int t_Answer = q_third.poll();

            if (nowAnswer == f_Answer)
                F_Point++;
            if (nowAnswer == s_Answer)
                S_Point++;
            if (nowAnswer == t_Answer)
                T_Point++;

            q_first.offer(f_Answer);
            q_second.offer(s_Answer);
            q_third.offer(t_Answer);

        }while(q.stream().count() > 0);

        _map.put(1,F_Point);
        _map.put(2,S_Point);
        _map.put(3,T_Point);

        List<Integer> KeySetList = new ArrayList<>(_map.keySet());
        KeySetList.sort((x,y) -> _map.get(y).compareTo(_map.get(x)));

        int MaxCount = _map.get(KeySetList.get(0));

        for (Integer i : KeySetList)
        {
            if (MaxCount == _map.get(i))
            {
                answer.add(i);
            }
        }
        return answer.stream().mapToInt(Integer::intValue).toArray();

    }
}
