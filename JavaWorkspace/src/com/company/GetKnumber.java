package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class GetKnumber {

    static int[] array = {1,5,2,6,3,7,4};
    static int[][] commands = {{2,5,3}, {4,4,1},{1,7,3}};
    
    public static void main(String[] args) {
        for (int item: solution(array,commands))
            System.out.println(item);
    }
    static int[] solution(int[] array, int[][] commands )
    {
        List<Integer> answer = new ArrayList<>();

        int startNum =0;
        int lengthNum = 0;
        int kNum =0;

        for(int i = 0; i < commands.length; i++)
        {
            startNum = commands[i][0];
            lengthNum = commands[i][1];
            kNum = commands[i][2];

            int[] resutlArr =new int[lengthNum - startNum + 1];
            int index = 0;

            for (int j= startNum - 1; j < lengthNum; j++)
            {
                resutlArr[index] = array[j];
                index++;
            }
            Arrays.sort(resutlArr);
            answer.add(resutlArr[kNum - 1]);
        }
        return answer.stream().mapToInt(Integer::intValue).toArray();
    }
}
