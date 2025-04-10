using Project_Exit.NPCs;
using Project_Exit.Scenes;

namespace Project_Exit
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static string prevScene;

        private static Player player;
        public static Player Player { get { return player; } }

        private static bool gameOver = false;

        // 엔딩 루트를 결정하는 변수
        private static int endingNum = 0;
        public static int EndingNum {  get { return endingNum; } }
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                if (curScene != sceneDic["Title"])
                {
                    Console.WriteLine("                                          텍스트를 넘기려면 : X");
                }
                if (curScene != sceneDic["Title"] && curScene != sceneDic["Prologue"])
                {
                    Console.WriteLine();
                    Console.WriteLine("                                          인벤토리 : I");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                                          HP : {Player.CurPlayerHP} / {Player.MaxPlayerHP}");
                    Console.ResetColor();
                }
                curScene.Render();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
                if(curScene == sceneDic["Ending"])
                {
                    GameOver();
                }
            }

            End();
        }

        /// <summary>
        /// 게임의 초기 설정을 진행
        /// </summary>
        private static void Start()
        {
            Console.CursorVisible = false;
            gameOver = false;            

            player = new Player();
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Prologue", new PrologueScene());
            sceneDic.Add("SecretR1", new SecretRoomScene1());
            sceneDic.Add("SecretR2", new SecretRoomScene2());
            sceneDic.Add("Ending", new EndingScene());
            sceneDic.Add("DeadEnding", new DeadScene());

            curScene = sceneDic["Title"];
        }

        public static void ChangeScene(string sceneName)
        {
            prevScene = curScene.name;

            curScene = sceneDic[sceneName];
            curScene.Enter();
        }

        /// <summary>
        /// 게임의 마무리 작업 진행
        /// </summary>
        private static void End()
        {
            Console.Clear();
            curScene.Render();
            curScene.Input();
            Console.WriteLine();
            curScene.Update();
            Console.WriteLine();
            curScene.Result();
        }

        // 게임이 끝났음을 선언
        public static void GameOver()
        {
            gameOver = true;
        }
        
        public static void EndingBranch(int num)
        {
            endingNum = num;
        }
    }
}
