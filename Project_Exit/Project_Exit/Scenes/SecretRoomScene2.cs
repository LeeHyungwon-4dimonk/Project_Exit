using System.Reflection.Metadata.Ecma335;

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
                "#                                      #",
                "#                                      #",
                "#        ####                          #",
                "#                                      #",
                "#                            ####      #",
                "#                                      #",
                "#                   ####               #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "########################################"
            };
            map = new bool[12, 40];

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("SecretR1", '▥', new Vector2(38, 6)));
            gameObjects.Add(new Place("SecretR3", '▥', new Vector2(5, 2)));

            npcList = new List<NPC>();

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            
            Game.Player.map = map;
        }        
        
        protected override void StartText()
        {
            if (EnterFirstTime) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Util.XKeyText("당신은 계단을 타고 한 층을 내려왔습니다.");
                Util.XKeyText("이곳에는 누군가 다른 사람이 있는 것 같습니다.");
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
            else if (Game.prevScene == "SecretR3")
            {
                Game.Player.position = new Vector2(5, 2);
            }
            Game.Player.map = map;
        }
    }
}
