using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Project_Exit.Scenes;

namespace Project_Exit
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver = false;
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            End();
        }

        /// <summary>
        /// 게임의 초기 설정을 진행
        /// </summary>
        private static void Start()
        {
            Console.CursorVisible = false;
            gameOver = false ;

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];
        }

        /// <summary>
        /// 게임의 마무리 작업 진행
        /// </summary>
        private static void End()
        {

        }
    }
}
