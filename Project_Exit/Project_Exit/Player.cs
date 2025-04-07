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
        private int playerHP = 5;
        public int PlayerHP { get { return playerHP; } }

        private int playerMental = 5;
        public int PlayerMental { get { return playerMental; } }

        public Vector2 position;
        public bool[,] map;

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input)
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
