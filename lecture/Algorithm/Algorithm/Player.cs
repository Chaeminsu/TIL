using System;
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

        public void Initialize(int posY, int posX,  Board board)
        {
            PosX = posX;
            PosY = posY;
            _board = board;

            //현재 바라고보 있는 방향을 기준으로 좌표 변화를 나타낸다.
            int[] frontY = new int[] {-1, 0, 1, 0 };
            int[] frontX = new int[] { 0, -1, 0, 1 };
            int[] rightY = new int[] { 0, -1, 0, 1 };
            int[] rightX = new int[] { 1, 0, -1, 0 };

            _points.Add(new Pos(PosY, PosX));
            //목적지 도착전 실행
            while (PosY != board.DestY || PosX != board.DestX)
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
                else if (_board.Tile[PosY + frontY[_dir],PosX + frontX[_dir]] == Board.TileType.Empty)
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
        const int MOVE_TICK = 10;
        int _sumTick = 0;
        int _lastIndex = 0;
        public void Update(int deltaTick)
        {
            if (_lastIndex >= _points.Count)
            {
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

    }
}
