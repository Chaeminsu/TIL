package com.company;

import java.util.*;

public class SkillTree {
    static String[] skill_trees = {"BACDE", "CBADF", "AECB", "BCA"};
    public static void main(String[] args) {
        System.out.println(solution("CBD", skill_trees));
    }
    public static class Player
    {
        String skillTrees;
        Boolean isOk = false;
        public Player(String mySkill)
        {
            skillTrees = mySkill;
        }
        public void CheckMySkillTree(String skill)
        {
            char[] processSkill = skill.toCharArray();
            ArrayList<Integer> _list = new ArrayList<>();

            for (int i = 0; i < skill.length(); i++)
            {
                int index = skillTrees.indexOf(processSkill[i]);
                _list.add(index == -1 ? 99 : index);
            }


            ArrayList<Integer> _sortList = (ArrayList<Integer>) _list.clone();
            _sortList.sort((x,y) -> x.compareTo(y));

            for (int i = 0; i < _sortList.size(); i++)
            {
                if (_sortList.get(i) != _list.get(i))
                {
                    isOk =false;
                    return;
                }
                isOk = true;
            }
        }
        public Boolean LearedOK()
        {
            return isOk;
        }
    }
    public static int solution(String skill, String[] skill_trees) {
        int answer = 0;
        Queue<Player> q = new LinkedList<>();
        for (int i = 0; i < skill_trees.length; i++)
            q.offer(new Player(skill_trees[i]));

        int plCount = q.size();
        for (int j = 0; j < plCount; j++)
        {
            Player _player = q.poll();
            _player.CheckMySkillTree(skill);
            if (_player.LearedOK())
                answer++;
        }
        return answer;
    }
}
