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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" 스토리를 짤 시간이 없었어서");
            Console.WriteLine("    시나리오가 부실합니다   ");
            Console.WriteLine("    너그러이 봐주세요ㅠㅠ   ");
            Console.ResetColor();
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
