using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.Scenes
{
    public class PrologueScene : BaseScene
    {
        public PrologueScene()
        {
            name = "Prologue";
        }
        public override void Render()
        {
            Util.XKeyText("당신은 어둠 속에서 눈을 떴습니다.");
            Util.XKeyText("이곳은 당신이 알던 곳과는 다른,");
            Util.XKeyText("낯선 곳임을 알게 됩니다.");
            Util.XKeyText("춥고 딱딱한 바닥에 몸서리치며 깨어난 당신은,");
            Util.XKeyText("천천히 주변을 살펴봅니다.");
            Console.WriteLine();
            Util.PlayerText("여긴 어디지?");
            Console.WriteLine();
            Util.XKeyText("두려움이 엄습했지만, 가만히 있을 수만은 없었습니다.");
            Console.WriteLine();
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
