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
                if (npc.isTalking == true)
                {
                    npc.Talk();
                }
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
            Game.Player.Move(input);
        }

        public override void Result()
        {
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position && input != ConsoleKey.X)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
            foreach (NPC npc in npcList)
            {
                if(npc.IsInteractable())
                {
                    npc.Interact(Game.Player);
                }
            }
        }
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
        protected virtual void StartText() { }
    }
}
