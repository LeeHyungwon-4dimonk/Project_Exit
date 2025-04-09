using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.NPCs
{
    public class Mr_C : NPC
    {
        Queue<int> talkLog = new Queue<int>();
        public Mr_C(Vector2 position)
            : base(ConsoleColor.Red, 'C', position, false)
        {
            name = "C군";
            isTalking = false;
            unableToAct = false;
            talkLog.Enqueue(1);
            talkLog.Enqueue(2);
            talkLog.Enqueue(3);
        }

        public override void Interact(Player player)
        {
            Talk();
        }

        public override void Talk()
        {
            if (talkLog.Count > 1)
            {
                switch (talkLog.Peek())
                {
                    case 1: TalkLog1(); talkLog.Dequeue(); break;
                    case 2: TalkLog2(); talkLog.Dequeue(); break;
                }
            }
            else
            {
                TalkLog3();
            }
        }

        public delegate void TalkLog();

        private void TalkLog1()
        {
            Console.SetCursorPosition(0, 14);
            Util.XKeyText("책상 위에 한 남자가 잠을 청하고 있습니다.");
            Util.XKeyText("남자는 곤히 잠에 든 듯 깨어날 기미가 보이지 않습니다.");
            Console.WriteLine();
            Util.XKeyText("지금이라면 도망치거나, 아니면 남자를 제압할 수 있을 것 같습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 남자를 칼로 찌른다. ( 칼 소지품 필요)");
            Console.WriteLine("2. 남자를 밧줄로 포박한다 ( 밧줄 소지품 필요)");
            Console.WriteLine("3. 이대로 조용히 도망친다.");
            isTalking = false;
        }
        private void TalkLog2()
        {
            Util.NPC_CText("너 뭐야2");

            isTalking = false;
        }
        private void TalkLog3()
        {
            Util.NPC_CText("너 뭐야3");

            isTalking = false;
        }
    }
}
