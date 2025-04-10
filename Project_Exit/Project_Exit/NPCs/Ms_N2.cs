using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Project_Exit.Items;

namespace Project_Exit.NPCs
{
    // N양 NPC를 맵 위치에 따라서 분리하여 제작하기로 결정
    // 해당 N양은 두 번째 맵의 N양
    public class Ms_N2 : NPC
    {
        // Queue를 사용하여 매번 다른 대화를 출력하도록 의도함
        Queue<int> talkLog = new Queue<int>();
        public Ms_N2(Vector2 position)
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
                    case 2: TalkLog2(); break;
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
            Util.NPC_NText("저 사람이 우리를 납치한 범인일까?");
            Util.PlayerText("글쎄, 지금으로선 정확히 알 방법이 없어.");
            Console.WriteLine();
            Util.XKeyText("문 틈으로 상황을 살펴봤지만, 상대의 움직임이 잘 보이지 않습니다");
            Console.WriteLine();
            Util.NPC_NText("일단 저 사람이 좋은 사람인지, 나쁜 사람인지 몰라도,");
            Util.NPC_NText("무언가 호신용 무기라도 없이 가는 건 미친 짓이야.");
            Util.NPC_NText("쓸만한 도구라도 챙겨서 가는 편이 좋을 것 같아.");
            Console.WriteLine();
            Util.XKeyText("당신은 그녀의 말에 동의하고선, 쓸만한 물건을 찾아보기로 합니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }        

        private void TalkLog2()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_NText("어때, 수확이 좀 있었어?");
            Console.WriteLine();
            Util.XKeyText("당신은 지금까지의 수색의 결과물을 보여줬습니다.");
            Util.XKeyText("N양은 당신이 모은 물건들을 곰곰이 살펴 보고선, 조심스레 입을 열었습니다.");
            Console.WriteLine();
            Util.NPC_NText("사실은 나도 찾은 물건이 있는데, 유용할 지는 잘 모르겠어");
            Util.NPC_NText("일단 이 물건을 너한테 줄게.");
            Console.WriteLine();
            // N양이 주는 아이템은 붕대
            // 플레이어의 인벤토리에 공간이 있을 경우 아이템을 지급
            // 인벤토리 자리가 없을 경우 다음 대화로 넘어가지 않고
            // 아이템을 받을 때까지 현재 대화를 반복
            Bandage bandage = new Bandage(Game.Player.position);
            for (int i = 0; i < Game.Player.inventory.items.Length; i++)
            {
                if (Game.Player.inventory.items[i] == null)
                {                    
                    Game.Player.inventory.Add(bandage);
                    Util.XKeyText("당신은 그녀에게 붕대를 받고서 나아갈 준비를 합니다.");
                    // 아이템을 수령하면 다음 대화로 넘어감
                    talkLog.Dequeue();
                    break;
                }
                if (Game.Player.inventory.items[Game.Player.inventory.items.Length - 1] != null)
                {
                    Util.NPC_NText("들고 있는 게 너무 많은 것 같은데,");
                    Util.NPC_NText("주머니에 든 걸 비워주고 다시 말을 걸어줘.");
                    break;
                }
            }           
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }

        private void TalkLog3()
        {
            Console.SetCursorPosition(0, 14);
            Util.NPC_NText("조심해, 상대가 어떤 사람일지 모르니까.");
            Console.WriteLine();
            Util.XKeyText("당신은 그녀의 말을 귀담아 듣고서 나아갑니다.");
            Console.WriteLine();
            Util.XKeyText("대화를 종료하려면 X키를 누르세요.");

            isTalking = false;
        }
    }
}
