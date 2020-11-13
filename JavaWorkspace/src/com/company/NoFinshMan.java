package com.company;
import java.util.*;
import java.util.logging.Logger;
import java.util.stream.Collectors;

public class NoFinshMan {

    static String[] participant = {"mislav", "stanko", "mislav",  "ana"};
    static String[] completion =  {"stanko", "ana", "mislav"};
    private final static Logger LOG = Logger.getGlobal();

    public static void main(String[] args) {
        System.out.println(solution(participant,completion));
    }
    public static String solution(String[] participant, String[] completion) {
        String answer = "";
        Map<String, Integer> _hashMap = new HashMap<>();
        for (String person: participant)
        {
            if (_hashMap.get(person) == null)
                _hashMap.put(person, 1);
            else
                _hashMap.put(person, _hashMap.get(person) + 1);

        }
        for (String com_person: completion)
            _hashMap.put(com_person, _hashMap.get(com_person) - 1);

        for (String Value : _hashMap.keySet())
        {
            if (_hashMap.get(Value) >= 1)
            {
                answer = Value;
                break;
            }
        }

        return answer;
    }
}
