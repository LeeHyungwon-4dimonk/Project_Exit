using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Exit.Scenes;

namespace Project_Exit
{
    public abstract class NPC : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 position;
        public bool isTalking;
        public ConsoleKey input;
        public string name;
        public NPC(ConsoleColor color, char symbol, Vector2 position)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

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

        public abstract void Interact(Player player);

        public abstract void Talk();
    }
}

