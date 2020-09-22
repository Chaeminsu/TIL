using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Pos
    {
        public Pos(int y, int x) { Y = y; X = x; }

        public int Y;
        public int X;
    }

    class Player
    {
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        Random _random = new Random();
        Board _board;

        enum Dir
        {
            Up, // 0
            Left, // 1
            Down, // 2
            Right, // 3

        }

        int _dir = (int)Dir.Up;
        List<Pos> _points = new List<Pos>();

        public void Initialize(int posY, int posX, Board board)
        {
            PosX = posX;
            PosY = posY;
            _board = board;

            AStar();



        }

        struct PQNode : IComparable<PQNode>
        {
            public int F;
            public int G;
            public int Y;
            public int X;

            public int CompareTo(PQNode other)
            {
                if (F == other.F)
                {
                    return 0;
                }
                return F < other.F ? 1 : -1;
            }
        }

        const int MOVE_TICK = 10;
        int _sumTick = 0;
        int _lastIndex = 0;
        public void Update(int deltaTick)
        {
            if (_lastIndex >= _points.Count)
            {
                _lastIndex = 0;
                _points.Clear();
                _board.intitialize(_board.Size, this);
                Initialize(1,1,_board);
                return;
            }
            _sumTick += deltaTick;
            if (_sumTick >= MOVE_TICK)
            {
                _sumTick = 0;
                // 이동 로직 필요
                PosY = _points[_lastIndex].Y;
                PosX = _points[_lastIndex].X;
                _lastIndex++;
            }
        }
        public void AStar()
        {
            // 점수 매기기
            //  F = G +H
            // F = 최종점수 (작을수록 좋음, 경로에 따라 달라짐) 
            // G = 시작점에서 해당 좌표 까지 이동하는데 드는 비용(작을 수록 좋음, 경로에따라 달라짐)
            // H = 목적지에서 얼마나 가까운지(작을수록 좋음, 고정)


            // U L D R  UL DL DR UR
            int[] deltaY = new int[] { -1, 0, 1, 0,};
            int[] deltaX = new int[] { 0, -1, 0, 1,};
            int[] cost = new int[] { 10, 10, 10, 10 };

            // (y, x) 방문 여부 
            bool[,] closed = new bool[_board.Size, _board.Size];

            // ( y, x) 발견 여부
            // 발견 X = MaxValue
            // 발견 O -  F = G +H
            int[,] open = new int[_board.Size, _board.Size];

            for (int y = 0; y < _board.Size; y++)
                for (int x = 0; x < _board.Size; x++)
                    open[y, x] = Int32.MaxValue;

            Pos[,] parent = new Pos[_board.Size, _board.Size];


            PriorityQueue<PQNode> pq = new PriorityQueue<PQNode>();


            // 시작점 발견
            open[PosY, PosX] = 10 *(Math.Abs(_board.DestY - PosY) + Math.Abs(_board.DestX - PosX));
            pq.push(new PQNode() { F = 10*(Math.Abs(_board.DestY - PosY) + Math.Abs(_board.DestX - PosX)), G = 0, X = PosX, Y = PosY });
            parent[PosY, PosX] = new Pos(PosY, PosX);

            while (pq.Count > 0)
            {
               PQNode node = pq.Pop();
                if (closed[node.Y, node.X])
                {
                    continue;
                }
                closed[node.Y, node.X] = true;

                if (node.Y == _board.DestY && node.X == _board.DestX)
                {
                    break;
                }

                for (int i = 0; i < deltaY.Length; i++)
                {
                    int nextY = node.Y + deltaY[i];
                    int nextX = node.X + deltaX[i];

                    if (nextX < 0 || nextX > _board.Size || nextY < 0 || nextY > _board.Size)
                        continue;

                    if (_board.Tile[nextY, nextX] == Board.TileType.Wall)
                    {
                        continue;
                    }
                    if (closed[nextY, nextX])
                    {
                        continue;
                    }

                    int g = node.G + cost[i];
                    int h = 10 *(Math.Abs(_board.DestY - nextY) + Math.Abs(_board.DestX - nextX));

                    if (open[nextY, nextX] < g + h)
                    {
                        continue;
                    }

                    open[nextY, nextX] = g + h;
                    pq.push(new PQNode() { F = g + h, G = g, Y = nextY, X = nextX });
                    parent[nextY, nextX] = new Pos(node.Y,node.X);

                }
               


            }

            calcPathFromParent(parent);



        }
        public void BFS()
        {
            int[] deltaY = new int[] { -1,0,1,0 };
            int[] deltaX = new int[] { 0,-1,0,1 };

            bool[,] found = new bool[_board.Size, _board.Size];
            Pos[,] parent = new Pos[_board.Size, _board.Size];

            Queue<Pos> q = new Queue<Pos>();

            q.Enqueue(new Pos(PosY, PosX));
            found[PosY, PosX] = true;
            parent[PosY, PosX] = new Pos(PosY, PosX);

            while (q.Count > 0)
            {
                Pos pos = q.Dequeue();
                int nowY = pos.Y;
                int nowX = pos.X;

                for (int i = 0; i < 4; i++)
                {
                    int nextY = nowY + deltaY[i];
                    int nextX = nowX + deltaX[i];


                    if (nextX < 0 || nextX > _board.Size || nextY < 0 || nextY > _board.Size)
                        continue;

                    if (_board.Tile[nextY, nextX] == Board.TileType.Wall)
                    {
                        continue;
                    }
                    if (found[nextY,nextX])
                    {
                        continue;
                    }

                    q.Enqueue(new Pos(nextY, nextX));
                    found[nextY, nextX] = true;
                    parent[nextY, nextX] = new Pos(nowY, nowX);
                }
            }

            calcPathFromParent(parent);

        }
        void calcPathFromParent(Pos[,] parent)
        {
            int y = _board.DestY;
            int x = _board.DestX;

            while (parent[y, x].Y != y || parent[y, x].X != x)
            {
                _points.Add(new Pos(y, x));
                Pos pos = parent[y, x];
                y = pos.Y;
                x = pos.X;
            }
            _points.Add(new Pos(y, x));
            _points.Reverse();
        }
        public void RightHand()
        {
            //현재 바라고보 있는 방향을 기준으로 좌표 변화를 나타낸다.
            int[] frontY = new int[] { -1, 0, 1, 0 };
            int[] frontX = new int[] { 0, -1, 0, 1 };
            int[] rightY = new int[] { 0, -1, 0, 1 };
            int[] rightX = new int[] { 1, 0, -1, 0 };

            _points.Add(new Pos(PosY, PosX));
            //목적지 도착전 실행
            while (PosY != _board.DestY || PosX != _board.DestX)
            {
                //1. 현재 바라보는 방향 기준 오른쪽 진행 가능 여부 확인
                if (_board.Tile[PosY + rightY[_dir], PosX + rightX[_dir]] == Board.TileType.Empty)
                {
                    // 오른쪽 방향으로 90회전 
                    _dir = (_dir - 1 + 4) % 4;
                    // 앞으로 전진 
                    PosX = PosX + frontX[_dir];
                    PosY = PosY + frontY[_dir];
                    _points.Add(new Pos(PosY, PosX));

                }
                else if (_board.Tile[PosY + frontY[_dir], PosX + frontX[_dir]] == Board.TileType.Empty)
                {
                    // 앞으로 전진
                    PosX = PosX + frontX[_dir];
                    PosY = PosY + frontY[_dir];
                    _points.Add(new Pos(PosY, PosX));
                }
                else
                {
                    //2. 왼쪽으로 90 회전
                    _dir = (_dir + 1 + 4) % 4;
                }
            }
        }

    }
}
