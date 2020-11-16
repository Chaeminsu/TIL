package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.logging.Logger;

public class PhoneNumberBookList {

    static String[] phone_book = {"12","123","1235","567","88"};
    private final static Logger LOG = Logger.getGlobal();

    public static void main(String[] args) {
        System.out.println(solution(phone_book));
    }
    public static boolean solution(String[] phone_book) {
        boolean answer = true;

        HashMap<String, String[]> _hashmap = new HashMap<>();

        for (int i = 0; i < phone_book.length; i++)
            _hashmap.put(phone_book[i], phone_book);

        for (String _key: _hashmap.keySet())
        {
            for (String value :_hashmap.get(_key))
            {
                if (_key.length() >= value.length() ) {
                    continue;
                }
                else
                {
                    if (value.indexOf(_key) == 0)
                        return false;
                }


            }
            if(answer == false) break;
        }

        return answer;
    }
}
