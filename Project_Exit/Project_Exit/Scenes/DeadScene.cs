using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Exit.Scenes
{
    internal class DeadScene : BaseScene
    {
        public DeadScene()
        {
            name = "DeadEnding";
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("============================");
            Console.WriteLine("         Game Over          ");
            Console.WriteLine("      당신은 죽었습니다     ");
            Console.WriteLine();
            Console.WriteLine("        준비도 없이         ");
            Console.WriteLine("    남에게 덤비지 맙시다    ");
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
