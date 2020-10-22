package com.company;


public class Countryof124
{

    public static void main(String[] args)
    {
        System.out.println(solution(11));
    }
    public static String solution(int n)
    {
        StringBuffer answer = new StringBuffer();
        while (n > 0)
        {
            int remain = n % 3;
            if (remain == 0)
            {
                answer.append(4);
                n = n / 3 - 1;
            }
            else
            {
                answer.append(remain);
                n = n / 3;
            }
        }
        return answer.reverse().toString();
    }
}
