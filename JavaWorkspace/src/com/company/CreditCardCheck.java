package com.company;

import java.util.*;
import java.util.logging.Logger;
import java.util.regex.Pattern;

public class CreditCardCheck {

    static String[] card_numbers = {"3285-3764-9934-2453", "3285376499342453", "3285-3764-99342453", "328537649934245", "3285376499342459", "3285-3764-9934-2452"};
    private final static Logger LOG = Logger.getGlobal();
    public static void main(String[] args) {
        for (int item: solution(card_numbers)) {
            System.out.println(item);
        }
    }

    public static int[] solution(String[] card_numbers) {
        ArrayList<Integer> answer = new ArrayList<>();
        LinkedHashMap<String, Boolean> _hashmap = new LinkedHashMap<>();

        // 정규식에 의한 카드 형식 체크
        for (String cardNum: card_numbers) {
            if (Pattern.matches("\\d{16}", cardNum) || Pattern.matches("\\d{4}[-]\\d{4}[-]\\d{4}[-]\\d{4}", cardNum))
                _hashmap.put(cardNum, true);
            else
                _hashmap.put(cardNum, false);
        }

        // 유효성 검사
        for (String value : _hashmap.keySet()) {
            List<String> tempArray;

            if (_hashmap.get(value) == true)
            {
                if(value.contains("-"))
                {
                    String value2 = value.replace("-", "");
                    value2.toCharArray();
                    tempArray = Arrays.asList(value2.split(""));
                }
                else
                {
                    tempArray = Arrays.asList(value.split(""));
                }

                _hashmap.put(value, Luhn(tempArray));
            }
        }
        // Value 값이 true 인것들만 추가
        for (String Item : _hashmap.keySet())
        {
            if (_hashmap.get(Item) == true)
                answer.add(1);
            else
                answer.add(0);
        }

        return answer.stream().mapToInt(Integer::intValue).toArray();
    }
    public static boolean Luhn(List<String> arr)
    {
        boolean result = false;
        int OddSum = 0;
        int EvenSum = 0;
        for (int i = arr.size() -1; i >= 0; i--)
        {
            if (i % 2 == 0) // 짝수
            {
                int intValue = Integer.parseInt(arr.get(i)) * 2;

                int nextValue = 0;
                if (intValue >= 10)
                {
                    if(intValue == 10)
                        nextValue = 1;
                    else
                    {
                        int newNum = intValue % 10;
                        nextValue = newNum + intValue / 10;
                    }

                }
                else
                    nextValue = intValue;

                OddSum += nextValue;
            }
            else // 홀수
            {
                int intValue = Integer.parseInt(arr.get(i));
                EvenSum += intValue;
            }
        }

        if ((OddSum + EvenSum) % 10 == 0)
            result = true;

        return result;
    }

}
