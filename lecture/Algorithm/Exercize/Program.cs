using System;
using System.Collections.Generic;

namespace Exercize
{
    class Graph
    {
        int[,] adj = new int[6, 6]
        {
            {0,1,0,1,0,0},
            {1,0,1,1,0,0},
            {0,1,0,0,0,0},
            {1,1,0,0,1,0},
            {0,0,0,1,0,1},
            {0,0,0,0,1,0},
        };

        List<int>[] adj2 = new List<int>[]
        {
            new List<int>() { 1,3 },
            new List<int>() { 0,2,3},
            new List<int>() { 1},
            new List<int>() { 0,1,4},
            new List<int>() { 3,5},
            new List<int>() { 4},
        };

        bool[] visited = new bool[6];

        public void DFS(int now)
        {
            // 1 Now 부터 방문
            Console.WriteLine("{0} - visited!", now);
            visited[now] = true;
            // 2 now 와 연결된 정점들을 하나씩 확인후 [아직 미방문 상태라면] 방문



            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0)
                    continue;

                if (visited[next])
                    continue;

                DFS(next); // 반복작업의 재귀함수

            }
        }
        public void DFS2(int now)
        {
            Console.WriteLine("{0} - visited!", now);
            visited[now] = true;

            foreach (int next in adj2[now])
            {
                if (visited[next])
                    continue;
                DFS2(next);
            }




        }
        public void SearchAll()
        {
            visited = new bool[6];

            for (int now = 0; now < 6; now++)
                if (visited[now] == false)
                    DFS(now);                

        }


        public void BFS(int start)
        {
            bool[] found = new bool[6];
            int[] parent = new int[6];
            int[] distance = new int[6];


            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            found[start] = true;
            parent[start] = start;
            distance[start] = 0;

            while (q.Count > 0)
            {
                int now = q.Dequeue();
                Console.WriteLine(now);

                for (int next = 0; next < 6; next++)
                {
                    if (adj[now, next] == 0)
                        continue;
                    if (found[next])
                        continue;

                    q.Enqueue(next);
                    found[next] = true;
              
                    parent[next] = now;
                    distance[next] = distance[now] + 1;

                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // DFS ( 깊이 우선 탐색 Depth First Search)
            Graph graph = new Graph();
            graph.BFS(0);



            // BFS ( 너비 우선 탐색 Breadth First Search)




        }
    }
}
