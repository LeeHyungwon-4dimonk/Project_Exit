using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Exit.Scenes;

namespace Project_Exit
{
    // 게임 내에서 상호작용 가능한 NPC
    public abstract class NPC : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 position;
        
        // NPC의 이름
        public string name;

        // NPC와의 대화 중 여부
        public bool isTalking;
        public ConsoleKey input;

        public NPC(ConsoleColor color, char symbol, Vector2 position)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
        }

        // NPC 출력
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        // NPC와의 상호작용은
        // NPC 기준 상하좌우 위치에서만 가능 ( 해당 여부 판단용 )
        public bool IsInteractable()
        {
            if ((Game.Player.position.x - 1 == position.x && Game.Player.position.y == position.y)
                ||(Game.Player.position.x + 1 == position.x && Game.Player.position.y == position.y)
                ||(Game.Player.position.x == position.x && Game.Player.position.y - 1 == position.y)
                ||(Game.Player.position.x == position.x && Game.Player.position.y + 1 == position.y))
            {
                return true;
            }
            return false;
        }

        // 상호작용 기능
        public abstract void Interact(Player player);

        // 대화 기능
        public abstract void Talk();
    }
}

