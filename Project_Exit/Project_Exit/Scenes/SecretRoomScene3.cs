using System.ComponentModel.Design;

namespace Project_Exit.Scenes
{
    public class SecretRoomScene3 : SecretRoomField
    {
        protected bool EnterFirstTime = true;
        public SecretRoomScene3()
        {
            name = "SecretR3";

            mapData = new string[]
            {
                "########################################",
                "#                                      #",
                "#      ##                              #",
                "#                                      #",
                "#                                      #",
                "#                            ####      #",
                "#                                      #",
                "#                   ####               #",
                "#                         ####         #",
                "#      #######                         #",
                "#                                      #",
                "########################################"
            };
            map = new bool[12, 40];

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("SecretR2", '▥', new Vector2(5, 2)));
            gameObjects.Add(new Place("Ending", 'G', new Vector2(38, 10)));

            Game.Player.map = map;
        }

        protected override void StartText()
        {
            if (EnterFirstTime) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("당신은 계단을 타고 한 층을 더 내려왔습니다.");
                Util.XKeyText("저 멀리에 밖으로 나갈 수 있는 문이 보입니다.");
                EnterFirstTime = false;
            }
        }

        public override void Enter()
        {
            if (Game.prevScene == "SecretR2")
            {
                Game.Player.position = new Vector2(5, 2);
            }         


            Game.Player.map = map;
           
        }
    }
}
