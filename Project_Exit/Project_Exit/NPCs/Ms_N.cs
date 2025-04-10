using System.Collections;

namespace Project_Exit.NPCs
{
    // N양 NPC를 맵 위치에 따라서 분리하여 제작하기로 결정
    // 해당 N양은 첫 번째 맵의 N양
    public class Ms_N : NPC
    {
        // Queue를 사용하여 매번 다른 대화를 출력하도록 의도함
        Queue<int> talkLog = new Queue<int>();
        public Ms_N(Vector2 position)
            : base(ConsoleColor.DarkYellow, 'N', position)
        {
            name = "N양";
            isTalking = false;          
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
            // 큐에 저장된 값이 한 개 이상일 경우
            // 대화를 출력하고 저장된 값을 빼는 방식으로
            // 대화를 매번 다르게 출력함
            if (talkLog.Count > 1)
            {
                switch (talkLog.Peek())
                {
                    case 1: TalkLog1(); talkLog.Dequeue(); break;
                    case 2: TalkLog2(); talkLog.Dequeue(); break;
                }
            }
            // 큐에 저장된 값이 한 개일 경우
            // 마지막 대화 로그를 반복 출력함
            else
            {
                TalkLog3();
            }
        }

        private void TalkLog1()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_NText("...으음, 여기는...");
            Console.WriteLine();
            Util.XKeyText("당신은 이 여성과 아는 사이임을 알게 됩니다.");
            Util.XKeyText("같은 대학의 같은 과 동기인 N양 입니다.");
            Console.WriteLine();
            Util.NPC_NText("P군...! 여긴 어디야?");
            Console.WriteLine();
            Util.XKeyText("N양은 혼란스러워 보입니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
        private void TalkLog2()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_NText("미안해, 이제는 진정했어.");
            Console.WriteLine();
            Util.XKeyText("N양은 천천히 심호흡을 하고서 다시금 말을 잇습니다.");
            Console.WriteLine();
            Util.NPC_NText("우리가 어쩌다가 여기에 왔는지 기억나?");
            Util.PlayerText("아니, 정확히 기억나지는 않아.");
            Util.NPC_NText("곤란하네, 휴대폰이라든지 연락할 수단은 있어?");
            Console.WriteLine();
            Util.XKeyText("그녀의 질문에 소지품을 뒤져봤지만 휴대폰은 찾지 못했습니다.");
            Util.XKeyText("아무래도 잃어버렸거나 누가 가져간 것 같습니다.");
            Console.WriteLine();
            Util.NPC_NText("어쩔 수가 없네. 그러면 이곳을 어떻게든 탈출해야만 할 것 같아.");
            Console.WriteLine();
            Util.XKeyText("그녀의 말에 당신은 고개를 끄덕이고는 N양을 일으켜 세웁니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
        private void TalkLog3()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_NText("여기에 오래 있고 싶지 않아. 빨리 나갈 방법을 찾아보자.");
            Console.WriteLine();
            Util.XKeyText("당신은 무어라 더 할 말이 없어 돌아섭니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
    }
}
