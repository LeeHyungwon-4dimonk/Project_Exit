using Project_Exit.NPCs;

namespace Project_Exit.Scenes
{
    public class SecretRoomField : BaseScene
    {
        protected string[] mapData;
        protected bool[,] map;

        protected List<GameObject> gameObjects;
        protected List<NPC> npcList;

        private ConsoleKey input;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            foreach (NPC npc in npcList)
            {
                npc.Print();                
            }
            Game.Player.Print();
            Game.Player.inventory.BrieflyPrint();            
            Game.Player.inventory.PrintAchievedItem();
            StartText();
            
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Action(input);
            // NPC와 상호작용 가능한 영역에 진입했는지 확인하고,
            // 대화 가능 여부를 결정 - 해당 위치에서 X키를 누르면 대화 시작
            foreach (NPC npc in npcList)
            {
                npc.isTalking = npc.IsInteractable() ? true : false;
            }
        }

        public override void Result()
        {
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position && input != ConsoleKey.X)
                {
                    go.Interact(Game.Player);
                    // 게임오브젝트가 아이템이고, 아이템이 인벤토리에 들어갔을 경우
                    // 인벤토리에 넣는 것이 실패하면 안 사라짐
                    if (go.isOnce == true && Game.Player.inventory.ItemAchieved)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
            // NPC와 대화가 가능한 상태이고, X키를 눌렀을 경우 대화 시작
            foreach (NPC npc in npcList)
            {
                if (npc.isTalking == true && input == ConsoleKey.X)
                {
                    npc.Interact(Game.Player);
                }
            }
        }

        // 맵 출력
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }

        // 맵 진입 시 출력되는 텍스트
        protected virtual void StartText() { }
    }
}
