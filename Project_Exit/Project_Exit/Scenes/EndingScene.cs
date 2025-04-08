using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Exit.Scenes
{
    internal class EndingScene : BaseScene
    {
        private ConsoleKey input;
        public EndingScene()
        {
            name = "Ending";
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("============================");
            Console.WriteLine(" 플레이 해주셔서 감사합니다 ");
            Console.WriteLine();
            Console.WriteLine("                 제작 :");
            Console.WriteLine("                   by 이형원");
            Console.WriteLine("============================");
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
    }
}
