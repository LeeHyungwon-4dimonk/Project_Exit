using Project_Exit.Items;
using Project_Exit.NPCs;

namespace Project_Exit.Scenes
{
    public class SecretRoomScene2 : SecretRoomField
    {
        protected bool EnterFirstTime = true;

        public SecretRoomScene2()
        {
            name = "SecretR2";

            mapData = new string[]
            {
                "########################################",
                "#                              #       #",
                "#                              #       #",
                "#                                      #",
                "#          ##                  #       #",
                "#         ###                  #       #",
                "#         ###                  #       #",
                "#                              #       #",
                "#                              #       #",
                "#                              #       #",
                "#                              #       #",
                "########################################"
            };
            map = new bool[12, 40];

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("SecretR1", '▥', new Vector2(38, 6)));
            gameObjects.Add(new Place("Ending", '▥', new Vector2(5, 2)));
            gameObjects.Add(new Rope(new Vector2(37, 3)));
            gameObjects.Add(new knife(new Vector2(10, 4)));

            npcList = new List<NPC>();
            npcList.Add(new Ms_N2(new Vector2(36, 8)));
            npcList.Add(new Mr_C(new Vector2(9, 5)));

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            map[8, 36] = false;
            map[5, 9] = false;

            Game.Player.map = map;
        }

        protected override void StartText()
        {
            if (EnterFirstTime) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Util.XKeyText("당신은 N양을 데리고 계단을 타고 한 층을 내려왔습니다.");
                Util.XKeyText("위층 보다는 조금 더 깨끗해 보이는 방이 보입니다.");
                Util.XKeyText("계단의 마지막 단을 밟은 순간 인기척이 느껴집니다.");
                Console.WriteLine();
                Util.NPC_NText("누군가가 있는 것 같아! 섣불리 나가면 안 될 것 같아.");
                Console.WriteLine();
                Util.XKeyText("인기척은 바로 내려온 방 너머에서 느껴집니다.");
                Util.XKeyText("당신은 조심해서 움직이기로 합니다.");
                Console.WriteLine("계속하려면 아무 키나 누르세요.");
                EnterFirstTime = false;
            }
        }

        public override void Enter()
        {
            if (Game.prevScene == "SecretR1")
            {
                Game.Player.position = new Vector2(38, 6);
            }            
            Game.Player.map = map;
        }
    }
}
