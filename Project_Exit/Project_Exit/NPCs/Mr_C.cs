namespace Project_Exit.NPCs
{
    // NPC - C군
    // 엔딩 분기점에 해당하는 캐릭터로,
    // 해당 캐릭터에게 어떤 상호작용을 하느냐에 따라
    // 해당 캐릭터에서 얻을 수 있는 정보 및 생사가 결정됨
    // 필수적 상호작용 대상이 아니며, 무시하고 지나가는 것 또한 의도된 것
    public class Mr_C : NPC
    {
        Queue<int> talkLog = new Queue<int>();
        private bool eventHappened = false;
        public Mr_C(Vector2 position)
            : base(ConsoleColor.Red, 'C', position)
        {
            name = "C군";
            isTalking = false;
            talkLog.Enqueue(1);
            talkLog.Enqueue(2);
            talkLog.Enqueue(3);
            talkLog.Enqueue(4);
            talkLog.Enqueue(5);
            talkLog.Enqueue(6);
        }

        public override void Interact(Player player)
        {
            Talk();
        }

        public override void Talk()
        {
            if (talkLog.Peek() == 1)    // 대화 분기점
            {
                TurningPoint();
            }
            else if (talkLog.Peek() == 2)   // 1번 엔딩 반복 출력문
            {
                Ending1_E();
            }
            else if (talkLog.Peek() == 3)   // 2-1번 엔딩
            {
                Ending2_2();
            }
            else if (talkLog.Peek() == 4)   // 2-2번 엔딩
            {
                Ending2_3();
            }
            else if (talkLog.Peek() == 5)   // 2-3 엔딩 반복 출력문
            {
                Ending2_E();
            }
            else if (talkLog.Peek() == 6)   // 3번 엔딩 반복 출력문
            {
                Ending3_E();
            }
        }

        private void TurningPoint()
        {
            Console.SetCursorPosition(0, 14);
            Util.XKeyText("책상 위에 한 남자가 잠을 청하고 있습니다.");
            Util.XKeyText("남자는 곤히 잠에 든 듯 깨어날 기미가 보이지 않습니다.");
            Console.WriteLine();
            Util.XKeyText("지금이라면 도망치거나, 아니면 남자를 제압할 수 있을 것 같습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 남자를 칼로 찌른다. ( 칼 소지품 필요 )");
            Console.WriteLine("2. 남자를 밧줄로 포박한다 ( 밧줄 소지품 필요 )");
            Console.WriteLine("3. 이대로 조용히 도망친다.");
            Console.WriteLine();
            input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1: Ending1(); break;
                case ConsoleKey.D2: Ending2(); break;
                case ConsoleKey.D3: Ending3(); break;
                default: Console.WriteLine("잘못된 입력입니다."); break;
            }
            isTalking = false;
        }
        private void Ending1()
        {
            for (int i = 0; i < Game.Player.inventory.items.Length; i++)
            {
                // 인벤토리에 칼이 있을 경우 1번 엔딩
                if (Game.Player.inventory.items[i] != null && Game.Player.inventory.items[i].name == "칼")
                {
                    Util.XKeyText("당신을 칼을 들어 남자를 뒤에서 공격했습니다.");
                    Util.XKeyText("N양이 당신을 채 막기도 전에 일어난 일입니다.");
                    Console.WriteLine();
                    Util.NPC_NText("꺄아아아악!");
                    Console.WriteLine();
                    Util.XKeyText("N양은 당신이 저지른 짓을 보고 충격을 받아 주저앉습니다.");
                    Util.XKeyText("다른 방법을 택할 수는 없었을까요?");
                    Util.XKeyText("당신은 피 묻은 칼을 바닥에 버렸고,");
                    Util.XKeyText("무심하게 N양을 바라봅니다.");
                    // 칼 아이템을 버렸으니 인벤토리에서 제거
                    Game.Player.inventory.items[i] = null;
                    Console.WriteLine();
                    Util.XKeyText("대화를 종료하려면 X키를 누르세요.");
                    eventHappened = true;
                    talkLog.Dequeue();

                    isTalking = false;

                    break;
                }                
            }
            // 인벤토리에 칼이 없을 경우 데드엔딩
            if (eventHappened == false)
            {
                Util.XKeyText("당신에게는 남자를 제압할 칼이 없었습니다.");
                Util.XKeyText("당신과 남자는 몸싸움을 벌였고,");
                Util.XKeyText("당신보다 더 힘 쎈 남자에게 제압 당하면서 칼에 찔렸습니다.");
                Util.XKeyText("N양의 비명소리가 아득해지면서 당신은 정신을 잃습니다.");
                Game.GameOver();
                Game.ChangeScene("DeadEnding");
            }

            isTalking = false;
        }
        private void Ending2()
        {
            for (int i = 0; i < Game.Player.inventory.items.Length; i++)
            {
                // 인벤토리에 밧줄이 있을 경우 2번 엔딩
                if (Game.Player.inventory.items[i] != null && Game.Player.inventory.items[i].name == "밧줄")
                {
                    Util.XKeyText("당신은 남자의 등 뒤에서 양 팔을 강하게 붙잡아 포박합니다.");
                    Util.XKeyText("남자는 갑작스런 공격에 몸부림을 칩니다.");
                    Console.WriteLine();
                    Util.NPC_CText("으윽, 뭐하는...!");
                    Console.WriteLine();
                    Util.XKeyText("위험천만한 몸싸움이 벌어졌지만,");
                    Util.XKeyText("당신은 비몽사몽한 상태의 남자를 제압할 수 있었습니다.");
                    // 아이템 사용으로 인한 제거
                    Game.Player.inventory.items[i] = null;
                    Util.XKeyText("남자는 묶인 채로 주저앉습니다.");
                    Console.WriteLine();
                    Util.XKeyText("대화를 종료하려면 X키를 누르세요."); ;
                    eventHappened = true;
                    talkLog.Dequeue();
                    talkLog.Dequeue();

                    break;
                }                
            }
            // 인벤토리에 밧줄이 없을 경우 데드엔딩
            if (eventHappened == false)
            {
                Util.XKeyText("당신에게는 남자를 제압할 밧줄이 없었습니다.");
                Util.XKeyText("당신과 남자는 몸싸움을 벌였고,");
                Util.XKeyText("당신보다 더 힘 쎈 남자에게 제압 당하면서 칼에 찔렸습니다.");
                Util.XKeyText("N양의 비명소리가 아득해지면서 당신은 정신을 잃습니다.");
                Game.GameOver();
                Game.ChangeScene("DeadEnding");
            }

            isTalking = false;
        }
        private void Ending3()
        {
            // 3번 엔딩
            Util.XKeyText("당신과 N양은, 괜히 남자를 건드리지 않고 가기로 합니다.");
            Util.XKeyText("남자는 당신들이 지나갈 때까지도 여전히 잠을 자고 있습니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");
            talkLog.Dequeue();
            talkLog.Dequeue();
            talkLog.Dequeue();
            talkLog.Dequeue();
            talkLog.Dequeue();

            isTalking = false;
        }
        private void Ending1_E()
        {
            // 1번 엔딩 반복 출력문
            Console.SetCursorPosition(0, 14);
            Util.XKeyText("남자는 더 이상 움직이지 않습니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
        private void Ending2_2()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_CText("네놈들! 이게 느닷없이 뭐 하는 짓이냐!");
            Util.PlayerText("그건 저희가 할 말인데요? 저희를 납치한 이유가 뭡니까?");
            Console.WriteLine();
            Util.XKeyText("납치라는 말에 남자의 눈이 휘둥그레집니다.");
            Util.XKeyText("자신은 그런 것과는 전혀 관계가 없다는 듯 보입니다.");
            Console.WriteLine();
            Util.NPC_CText("납치라니 그게 무슨 말도 안 되는 소리야?");
            Util.NPC_CText("너희들 둘 다 길바닥에 뻗어 있는 걸 데려와 줬는데!");
            Util.PlayerText("...에엥?");
            Console.WriteLine();
            Util.XKeyText("가만 돌이커 생각해보니, 어제 N양과 과 모임에 갔었던 것 같습니다.");
            Util.XKeyText("거기서 술을 무진장 마셨는데...");
            Console.WriteLine();
            Util.XKeyText("이제서야 모든 퍼즐이 맞춰지는 것 같습니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            talkLog.Dequeue();
            
            isTalking = false;
        }
        private void Ending2_3()
        {
            Console.SetCursorPosition(0, 14);
            Util.PlayerText("...그러면 대체 왜 책상에 이만한 칼이 있는 건데요!");
            Util.NPC_CText("아, 이거? 오해할 만한 위치에 있긴 했군.");
            Util.NPC_CText("내가 정육점을 하는 사람이라서 말이지.");
            Util.NPC_CText("여느 때처럼 고기를 자르고 칼을 갈려고 했는데,");
            Util.NPC_CText("그만 깜빡 잠들어버렸지 뭐냐.");
            Console.WriteLine();
            Util.XKeyText("남자는 칼을 정리합니다.");
            for (int i = 0; i < Game.Player.inventory.items.Length; i++)
            {
                if (Game.Player.inventory.items[i] != null && Game.Player.inventory.items[i].name == "칼")
                {                    
                    // 아이템 수거로 인해 인벤토리에 있을 시 제거
                    Game.Player.inventory.items[i] = null;
                }
            }
            // TODO 필드에 칼 있을 때 제거 작업
            Console.WriteLine();
            Util.NPC_CText("하여튼 너네 둘, 머리가 아프거나 숙취가 있다거나 하나?");
            Util.NPC_NText("아, 아뇨! 없어요!");
            Util.PlayerText("...없습니다.");
            Util.NPC_CText("그러면 후딱 돌아가버려! 나참 사람을 구했더니 이런 취급이나 받고.");
            Console.WriteLine();
            Util.XKeyText("남자는 심통이 난 것 같습니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요."); ;

            talkLog.Dequeue();

            isTalking = false;
        }
        private void Ending2_E()
        {
            // 2번 엔딩 반복 출력문
            Console.SetCursorPosition(0, 14);
            Util.NPC_CText("하여튼 이 자식들아, 아무리 대학생활을 즐긴다고 해도,");
            Util.NPC_CText("길바닥에서 뻗고 노숙하는 것도 청춘은 아녀!");
            Console.WriteLine();
            Util.XKeyText("당신과 N양은 남자한테 뻘쭘하게 인사하고는 자리를 뜹니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
        private void Ending3_E()
        {
            // 3번 엔딩 반복 출력문
            Console.SetCursorPosition(0, 14);
            Util.XKeyText("남자는 여전히 곤히 자고 있습니다.");
            Util.XKeyText("괜히 건들지 않는 편이 좋아 보입니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
    }
}
