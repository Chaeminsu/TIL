package com.company;

import java.io.Console;
import java.lang.reflect.Array;
import java.util.Arrays;

public class MajorityNumberFind {

    static int[] arr1 = { 3, 5, 3, 3, 3, 4, 3, 1 };
    static int[] arr2 = { 1, 5, 3, 6, 3, 4, 3, 1 };


    public static void main(String[] args)
    {
       System.out.println("첫번째 배열 1, 5, 3, 3, 3, 4, 3, 1 중 과반수 = " + Solution(arr1));
       System.out.println("두번째 배열 1, 5, 3, 6, 3, 4, 3, 1 중 과반수 = " + Solution(arr2));
    }

    public static int Solution(int[] nums)
    {
        int result = 0;
        int majorityNum = (nums.length) / 2;

        var _array = Arrays.stream(nums).distinct().toArray();
        int count = 0;

        for (int item: _array)
        {
            int count2 = (int)(Arrays.stream(nums).filter(x -> x == item).count());

            for (int i =0; i < nums.length; i++)
            {
                if (item == nums[i])
                {
                    count++;
                    continue;
                }
            }
            if (count2 > majorityNum)
            {
                result = item;
                break;
            }
            else
            {
                return -1;
            }
        }
        return result;
    }


}
