﻿using Project_Exit.Items;
using Project_Exit.NPCs;

namespace Project_Exit.Scenes
{
    public class SecretRoomScene1 : SecretRoomField
    {
        protected bool isReadingP = true;
        public SecretRoomScene1()
        {
            name = "SecretR1";

            mapData = new string[]
            {
                "########################################",
                "#       #                              #",
                "#       #                              #",
                "#       #                              #",
                "#       #                              #",
                "#                                      #",
                "#                                      #",
                "#       #                              #",
                "#       #                              #",
                "#       #                              #",
                "#       #                              #",
                "########################################"
            };
            map = new bool[12, 40];

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("SecretR2", '▥', new Vector2(38, 6)));
            gameObjects.Add(new Bandage(new Vector2(12, 8)));

            npcList = new List<NPC>();
            npcList.Add(new Ms_N(new Vector2(5, 10)));

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;                    
                }                
            }
            

            Game.Player.position = new Vector2(1, 2);
            Game.Player.map = map;
        }

        protected override void StartText()
        {
            if (isReadingP) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Util.XKeyText("당신은 다락 같은 곳에서 눈을 떴습니다.");
                Util.XKeyText("주변을 둘러 보니 나갈 수 있는 길이 보이고,");
                Util.XKeyText("같은 방 안 저만치에는 쓰러진 여성 한 명이 보입니다.");
                Util.XKeyText("당신은 조심스레 움직여 보기로 합니다.");
                Console.WriteLine("계속하려면 아무 키나 누르세요.");
                isReadingP = false;
            }
        }

        public override void Enter()
        {
            if (Game.prevScene == "Prologue")
            {
                Game.Player.position = new Vector2(1, 2);
            }
            else if (Game.prevScene == "SecretR2")
            {                
                Game.Player.position = new Vector2(38, 6);
            }
            Game.Player.map = map;
        }
    }
}
