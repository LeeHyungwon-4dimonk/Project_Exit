using System.Collections;
using Project_Exit.Scenes;

namespace Project_Exit.NPCs
{
    public class Ms_N : NPC
    {
        private int TalkCount;
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
            switch(curSceneName)
            {
                case "SecretR1":
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
                    break;
                case "SecretR2":
                    if (TalkCount == 0)
                    {
                        TalkLog4();
                    }
                    else if (TalkCount == 1)
                    {
                        TalkLog5();
                    }
                    else if (TalkCount == 2)
                    {
                        TalkLog6();
                    }
                    else
                    {
                        TalkLog7();
                    }
                        break;
                case "SecretR3":
                    break;
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
            Util.NPCText("여기에 오래 있고 싶지 않아. 빨리 나갈 방법을 찾아보자.");
            Console.WriteLine();
            Util.XKeyText("당신은 무어라 더 할 말이 없어 돌아섭니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");
            
            isTalking = false;
        }

        private void TalkLog4()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("저 사람이 우리를 납치한 범인일까?");
            Util.PlayerText("글쎄, 지금으로선 정확히 알 방법이 없어.");
            Console.WriteLine();
            Util.XKeyText("문 틈으로 상황을 살펴봤지만, 상대의 움직임이 잘 보이지 않습니다");
            Console.WriteLine();
            Util.NPCText("일단 저 사람이 좋은 사람인지, 나쁜 사람인지 몰라도,");
            Util.NPCText("무언가 호신용 무기라도 없이 가는 건 미친 짓이야.");
            Util.NPCText("쓸만한 도구라도 챙겨서 가는 편이 좋을 것 같아.");
            Console.WriteLine();
            Util.XKeyText("당신은 그녀의 말에 동의하고선, 쓸만한 물건을 찾아보기로 합니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }

        private void TalkLog5()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("저 사람이 우리를 납치한 범인일까?");
            Util.PlayerText("글쎄, 지금으로선 정확히 알 방법이 없어.");
            Console.WriteLine();
            Util.XKeyText("문 틈으로 상황을 살펴봤지만, 상대의 움직임이 잘 보이지 않습니다.");
            Console.WriteLine();
            Util.NPCText("일단 저 사람이 좋은 사람인지, 나쁜 사람인지 몰라도,");
            Util.NPCText("무언가 호신용 무기라도 없이 가는 건 미친 짓이야.");
            Util.NPCText("쓸만한 도구라도 챙겨서 가는 편이 좋을 것 같아.");
            Console.WriteLine();
            Util.XKeyText("당신은 그녀의 말에 동의하고선, 쓸만한 물건을 찾아보기로 합니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }

        private void TalkLog6()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("어때, 수확이 좀 있었어?");
            Console.WriteLine();
            Util.XKeyText("당신은 지금까지의 수색의 결과물을 보여줬습니다.");
            Util.XKeyText("N양은 당신이 모은 물건들을 곰곰이 살펴 보고선, 조심스레 입을 열었습니다.");
            Console.WriteLine();
            Util.NPCText("사실은 나도 찾은 물건이 있는데, 유용할 지는 잘 모르겠어");
            Util.NPCText("일단 이 물건을 너한테 줄게.");
            Console.WriteLine();
            // TODO 아이템 주기 구현하기
            Console.WriteLine();
            Util.XKeyText("당신은 그녀에게 물건을 받고서 나아갈 준비를 합니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }

        private void TalkLog7()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPCText("조심해, 상대가 어떤 사람일지 모르니까.");
            Console.WriteLine();
            Util.XKeyText("당신은 그녀의 말을 귀담아 듣고서 나아갑니다.");
            Console.WriteLine();
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");

            isTalking = false;
        }
    }
}
