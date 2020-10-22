package com.company;

import java.lang.reflect.Array;
import java.util.*;

public class Main {
    static  int[] deltaY = new int[]{ -1,0,1,0 };
    static  int[] deltaX = new int[]{ 0,-1,0,1 };
    static  int count = 0;
    static class Pos
    {
        public Pos(int y, int x) { Y = y; X = x; }

        public int Y;
        public int X;
    }
    static class Found
    {
        public boolean[][] bArray;
        public Found(int size)
        {
            bArray = new boolean[size][size];
            for (boolean[] a: bArray) Arrays.fill(a,false);
        }
        public void Swap(Found Before, Found After)
        {
            boolean[][] temp = Before.bArray;
            Before.bArray = After.bArray;
            After.bArray = temp;
        }
    }
    static int[][] board  = {{0,1,1,0,0,0},
                             {0,1,1,0,1,1},
                             {0,0,0,0,1,1},
                             {0,0,0,0,1,1},
                             {1,1,0,0,1,0},
                             {1,1,1,0,0,0}};
    static int[][] board2  = {{1,0,0,0},
                             {1,0,0,0},
                             {0,0,0,0},
                             {0,0,1,1}};


    public static void main(String[] args) {
        solution(6,board);
    }
     static void solution(int sizeOfMatrix, int[][] matrix)
    {
        List<Integer> dd = new ArrayList<>();
        Found find =new Found(sizeOfMatrix);

        for (int y = 0; y < sizeOfMatrix; y++)
        {
            for (int x = 0; x < sizeOfMatrix; x++)
            {
                if (matrix[y][x] == 1 && find.bArray[y][x] == false)
                {
                    Found visit = BFS(y,x,find,matrix);
                    find.Swap(find,visit);
                    dd.add(count);
                    count = 0;
                }
                else
                {
                    find.bArray[y][x] = true;
                }
            }
        }
        System.out.println(dd.stream().count());

        if (dd.stream().count() != 0)
        {
            dd.sort(Integer::compareTo);
            StringBuilder sb= new StringBuilder();
            for (int value: dd) {
                sb.append(value).append(" ");
            }
            String answer = sb.toString();
            System.out.println(answer.trim());
        }
    }


    static Found BFS(int y, int x,Found found ,int[][] board)
    {
        Pos StartPos = new Pos(y,x);
        Queue<Pos> q = new LinkedList<>();

        q.offer(StartPos);
        found.bArray[StartPos.Y][StartPos.X] = true;

        while(q.stream().count() > 0)
        {
            count++;
            Pos pos = q.poll();
            int nowY = pos.Y;
            int nowX = pos.X;

            for (int i = 0; i < 4; i++)
            {
                int nextY = nowY + deltaY[i];
                 int nextX = nowX + deltaX[i];

                if (nextX < 0 || nextX >= board.length || nextY < 0 || nextY >= board.length) continue;
                if (board[nextY][nextX] == 0) continue; // 1만 찾을것
                if (found.bArray[nextY][nextX]) continue;

                q.offer(new Pos(nextY, nextX));
                found.bArray[nextY][nextX] = true;

            }
        }
        return found;
    }
}
