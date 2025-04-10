using Project_Exit.NPCs;
using Project_Exit.Scenes;

namespace Project_Exit
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static BaseScene Curscene { get { return curScene; } }
        public static string prevScene;

        private static Player player;
        public static Player Player { get { return player; } }

        private static bool gameOver = false;
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                if (curScene != sceneDic["Title"])
                {
                    Console.WriteLine("                                          텍스트를 넘기려면 : X");
                    Console.WriteLine("                                          인벤토리 : I");
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
        public static void GameOver()
        {
            gameOver = true;            
        }
    }
}
