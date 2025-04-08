using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.Scenes
{
    internal class PrologueScene : BaseScene
    {
        public override void Render()
        {
            Util.XKeyText("당신은 어둠 속에서 눈을 떴다.");
            Util.XKeyText("이곳은 어둡고 퀴퀴한 냄새가 나고");
            Util.XKeyText("춥고 딱딱한 바닥에 몸서리치며");
            Util.XKeyText("깨어납니다.");
            Console.WriteLine("Press Any Key to Continue...");
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
            Game.ChangeScene("SecretR1");
        }
    }
}
