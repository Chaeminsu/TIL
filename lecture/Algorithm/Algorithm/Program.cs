using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.intitialize(25, player);
            player.Initialize(1, 1, board);

            Console.CursorVisible = false;
            int lastTick = 0;
            const int WAIT_TICK = 1000 / 30;
          
            while (true)
            {
                #region  프레임 관리
                int currentTick = System.Environment.TickCount;
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                int deltaTick = currentTick - lastTick;
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직
                player.Update(deltaTick);
                // 렌더링
                Console.SetCursorPosition(0, 0);
                board.Rander();

                
            }



        }
    }
}
