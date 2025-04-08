using System.Reflection.Metadata.Ecma335;

namespace Project_Exit.Scenes
{
    public class SecretRoomScene2 : BaseScene
    {
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

        private bool isReadingP = true;

        private ConsoleKey input;

        public SecretRoomScene2()
        {
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

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("SecretR1", '▥', new Vector2(38, 6)));

            Game.Player.position = new Vector2(1, 2);
            Game.Player.map = map;
        }
        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            Game.Player.Print();
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
                if (Game.Player.position == go.position && input!= ConsoleKey.X)
                {
                    go.Interact(Game.Player);
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
        private void StartText()
        {
            if (isReadingP) // 최초 1회만 출력되도록 함
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("당신은 계단을 타고 한 층을 내려왔습니다.");
                isReadingP = false;
            }
        }
    }
}
