using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("============================");
            Console.WriteLine("        Project Exit     ");
            Console.WriteLine();
            Console.WriteLine("               시나리오 :"   );
            Console.WriteLine("                   by 이형원");
            Console.WriteLine("============================");
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
            Game.ChangeScene("Prologue");
        }
    }
}
