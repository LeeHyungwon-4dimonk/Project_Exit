using System.Collections;

namespace Project_Exit.NPCs
{
    public class Ms_N : NPC
    {
        int TalkCount;
        public int Likeablity { get { return likeablity; } }
        public Ms_N(Vector2 position)
            : base(ConsoleColor.DarkYellow, 'N', position)
        {
            name = "N양";
            likeablity = 0;
            isTalking = false;
        }

        public override void Interact(Player player)
        {
            Talk();
            TalkCount++;
        }

        public override void Talk()
        {
            if (TalkCount == 0)
            {
                TalkLog1();
            }
            else if (TalkCount == 1)
            {
                TalkLog2();
            }
            else
            {
                TalkLog3();
            }    
        }

        private void TalkLog1()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("...으음, 여기는...");
            Console.WriteLine();
            Util.XKeyText("당신은 이 여성과 아는 사이임을 알게 됩니다.");
            Util.XKeyText("같은 대학의 같은 과 동기인 N양 입니다.");
            Console.WriteLine();
            Util.NPCText("P군...! 여긴 어디야?");
            Console.WriteLine();
            Util.XKeyText("N양은 혼란스러워 보입니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }
        private void TalkLog2()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("미안해, 이제는 진정했어.");
            Console.WriteLine();
            Util.XKeyText("N양은 천천히 심호흡을 하고서 다시금 말을 잇습니다.");
            Console.WriteLine();
            Util.NPCText("우리가 어쩌다가 여기에 왔는지 기억나?");
            Util.PlayerText("아니, 정확히 기억나지는 않아.");
            Util.NPCText("곤란하네, 휴대폰이라든지 연락할 수단은 있어?");
            Console.WriteLine();
            Util.XKeyText("그녀의 질문에 소지품을 뒤져봤지만 휴대폰은 찾지 못했습니다.");
            Util.XKeyText("아무래도 잃어버렸거나 누가 가져간 것 같습니다.");
            Console.WriteLine();
            Util.NPCText("어쩔 수가 없네. 그러면 이곳을 어떻게든 탈출해야만 할 것 같아.");
            Console.WriteLine();
            Util.XKeyText("그녀의 말에 당신은 고개를 끄덕이고는 N양을 일으켜 세웁니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }
        private void TalkLog3()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("무언가 더 할 말이 있어?");
            Console.WriteLine();
            Util.XKeyText("당신은 무어라 할 말이 없어 돌아섭니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");
        }
    }
}
