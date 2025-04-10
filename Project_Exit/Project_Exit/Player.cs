using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit
{
    public class Player
    {
        private int MaxPlayerHP = 5;
        private int curPlayerHP = 5;
        public int CurPlayerHP { get { return curPlayerHP; } }

        public Vector2 position;
        public bool[,] map;

        public Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }

        // HP 회복
        public void HPHeal(int amount)
        {
            curPlayerHP += amount;
            if(curPlayerHP > MaxPlayerHP)
            {
                curPlayerHP = MaxPlayerHP;
            }
        }

        // 플레이어 출력
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        // 플레이어 행동
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:                   
                case ConsoleKey.DownArrow:                    
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                // 인벤토리 오픈 기능
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
        }

        // 플레이어 움직임
        private void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}
