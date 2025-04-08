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
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
                "#                                      #",
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
            gameObjects.Add(new Place("SecretR2", '▥', new Vector2(38, 6)));

            Game.Player.position = new Vector2(1, 2);
            Game.Player.map = map;
        }

        protected override void StartText()
        {
            if (isReadingP) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("여긴 어디지?");
                Util.XKeyText("당신은 어떤 지저분한 방에서 눈을 뜹니다");
                Util.XKeyText("당신은 몸에 있던 먼지를 털어내고");
                Util.XKeyText("움직여 보기로 합니다.");
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
