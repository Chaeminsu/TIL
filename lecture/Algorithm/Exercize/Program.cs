using System;
using System.Collections.Generic;

namespace Exercize
{
    class Graph
    {

        int[,] adj = new int[6, 6]
        {
            {-1,15,-1,35,-1,-1},
            {15,-1,05,10,-1,-1},
            {-1,05,-1,-1,-1,-1},
            {35,10,-1,-1,05,-1},
            {-1,-1,-1,05,-1,05},
            {-1,-1,-1,-1,05,-1},
        };

      
        //int[,] adj = new int[6, 6]
        //{
        //    {0,1,0,1,0,0},
        //    {1,0,1,1,0,0},
        //    {0,1,0,0,0,0},
        //    {1,1,0,0,1,0},
        //    {0,0,0,1,0,1},
        //    {0,0,0,0,1,0},
        //};

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

        public void Dijikstra(int start)
        {
            bool[] visited = new bool[6];
            int[] distance = new int[6];
            int[] parent = new int[6];

            Array.Fill(distance, Int32.MaxValue);

            distance[start] = 0;
            parent[start] = start;
            while (true)
            {
                // 제일 좋은 후보 찾기
                // 가장 유력한 후보의 거리와 번호를 저장

                int closeset = Int32.MaxValue;
                int now = -1;

                for (int i = 0; i < 6; i++)
                {
                    //이미 방문한 정점은 스킵
                    if (visited[i])
                        continue;
                    // 예악된 적 없거나, 기존 후보보다 멀리 있으면 스킵
                    if (distance[i] == Int32.MaxValue || distance[i] >= closeset)
                        continue;

                    // 여태껏 발견한 가장 후보 정보 갱신
                    closeset = distance[i];
                    now = i;


                }

                if (now == -1)
                    break;
                // 제일 좋은 후보 찾음.
                visited[now] = true;
                // 방문한 정점과 인접한 정점들을 조사해서, 상황에 따라 발견한 최단거리를 갱신한다.
                for (int next = 0; next < 6; next++)
                {
                    // 연결되지 않은 정점 스킵
                    if (adj[now, next] == -1)
                    {
                        continue;
                    }
                    // 이미 방ㅈ문한 정점 스킵
                    if (visited[next])
                    {
                        continue;
                    }

                    // 새로 조사된 정점의 최단거리를 계산한다.
                    int nextDis = distance[now] + adj[now, next];

                    //기존 발견 한 최단거리가 새로 조사된 최단거리보다 크면 정보 갱신
                    if (nextDis < distance[next])
                    {
                        distance[next] = nextDis;
                        parent[next] = now;
                    }
                }
            }
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


    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();

    }

    class Program
    {
        public static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "R1 개발실" };
            {
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "디자인팀" };
                    //node.Children.Add(new TreeNode<string>() { Data = "전투" });
                    //node.Children.Add(new TreeNode<string>() { Data = "경제" });
                    //node.Children.Add(new TreeNode<string>() { Data = "스토리" });
                    root.Children.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "프로그래밍팀" };
                    node.Children.Add(new TreeNode<string>() { Data = "서버" });
                    node.Children.Add(new TreeNode<string>() { Data = "클라" });
                    node.Children.Add(new TreeNode<string>() { Data = "엔진" });
                    root.Children.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "아트팀" };
                    //node.Children.Add(new TreeNode<string>() { Data = "배경" });
                    //node.Children.Add(new TreeNode<string>() { Data = "캐릭터" });
                    root.Children.Add(node);
                }
            }

            return root;
        }

        public static void  PrintTree(TreeNode<string> root)
        {

            Console.WriteLine(root.Data);

            foreach (TreeNode<string> Child in root.Children)
                PrintTree(Child);




        }
        public static int GetHeight(TreeNode<string> root)
        {
            int heigth = 0;

            foreach (TreeNode<string> Child in root.Children)
            {
                int newHeight = GetHeight(Child)+1;
                if (heigth < newHeight)
                {
                    heigth = newHeight;
                }
            }
            return heigth;
        }
        static void Main(string[] args)
        {
            TreeNode<string> root = MakeTree();
            PrintTree(root);

            Console.WriteLine(GetHeight(root));
           
        }
    }
}
