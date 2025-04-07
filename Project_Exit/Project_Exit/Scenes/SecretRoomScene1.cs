namespace Project_Exit.Scenes
{
    internal class SecretRoomScene1 : BaseScene
    {
        private string[] mapData;
        private bool[,] map;

        private bool isReadingP = true;

        public SecretRoomScene1()
        {
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒                                      ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
            };
            map = new bool[12, 40];

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            }
        }
        public override void Render()
        {
            PrintMap();
            StartText();
            
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {

        }

        public override void Result()
        {

        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 1);
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
                        Console.Write('▒');
                    }
                }
                Console.WriteLine();
            }
        }
        private void StartText()
        {
            if (isReadingP) // 최초 1회만 출력되도록 함
            {
                Console.WriteLine();
                Console.WriteLine("여긴 어디지?");
                Util.XKeyText("당신은 어떤 지저분한 방에서 눈을 뜹니다");
                Util.XKeyText("당신은 몸에 있던 먼지를 털어내고");
                Util.XKeyText("움직여 보기로 합니다.");
                isReadingP = false;
            }
        }
    }
}
