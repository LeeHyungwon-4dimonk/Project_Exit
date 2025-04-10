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
            int endingNumber = Game.EndingNum;
            switch (endingNumber)
            {
                case 1: Ending1(); break;
                case 2: Ending2(); break;
                default: Ending3(); break;
            }

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

        public void Ending1()
        {
            Util.XKeyText("당신과 N양은 무사히 집에서 탈출했습니다.");
            Util.XKeyText("하지만 N양은 탈출을 도와준 고마움 대신에");
            Util.XKeyText("혼자서 돌아가겠다는 말을 남기고서 도망치듯 자리를 빠져 나갑니다.");
            Console.WriteLine();
            Util.XKeyText("그대로 혼자 돌려보내도 괜찮았을까요?");
            Console.WriteLine();
            Util.XKeyText("당신은 이후로 얼마 안 가 경찰에 붙잡혀 살인 혐의로 구속됩니다.");
            Console.WriteLine();
            Util.XKeyText("                      Ending 1 : 극단적");
            Console.WriteLine();
            Util.XKeyText("계속하려면 X키를 눌러주세요.");
        }
        public void Ending2()
        {
            Util.XKeyText("당신과 N양은 무사히 집에서 탈출했습니다.");
            Util.XKeyText("하지만 N양과 같이 바닥에 뻗어 있었다는 사실에");
            Util.XKeyText("수치심이 올라와, N양과 한동안 말없이 같이 길을 걸었습니다.");
            Console.WriteLine();
            Util.XKeyText("한참을 걸어서 집이 가까워지던 때에 N양이 입을 엽니다.");
            Console.WriteLine();
            Util.NPC_NText("우리 이번 일은 절대 아무한테도 말하지 않기다?");
            Util.NPC_NText("수치사할 것 같으니까");
            Util.PlayerText("그래.");
            Console.WriteLine();
            Util.XKeyText("당분간은 술 마시는 걸 자제해야 할 것 같습니다.");
            Util.XKeyText("이런 생각을 하면서 집으로 향합니다.");
            Console.WriteLine();
            Util.XKeyText("                      Ending 2 : 해프닝");
            Console.WriteLine();
            Util.XKeyText("계속하려면 X키를 눌러주세요.");
        }
        public void Ending3()
        {
            Util.XKeyText("당신과 N양은 무사히 집에서 탈출했습니다.");
            Util.XKeyText("하지만 그 탈출한 장소가 멀어지는 것을 보면서도");
            Util.XKeyText("여전히 의문점이 남습니다.");
            Console.WriteLine();
            Util.XKeyText("당신과 N양은 왜 그곳에 납치되었던 걸까요?");
            Console.WriteLine();
            Util.XKeyText("의문이 잠시 들기도 했지만,");
            Util.XKeyText("당장은 이 두려운 장소에서 벗어나는 게 먼저였습니다.");
            Console.WriteLine();
            Util.XKeyText("                      Ending 3 : 의문");
            Console.WriteLine();
            Util.XKeyText("계속하려면 X키를 눌러주세요.");
        }
    }
}
