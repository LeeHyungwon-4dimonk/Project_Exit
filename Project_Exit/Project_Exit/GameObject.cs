﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit
{
    public abstract class GameObject : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 position;

        // 오브젝트가 일회성인지 여부
        public bool isOnce;

        public GameObject(ConsoleColor color, char symbol, Vector2 position, bool isOnce)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.isOnce = isOnce;
        }

        // 오브젝트 출력
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
