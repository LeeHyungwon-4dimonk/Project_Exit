using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Project_Exit.Items;

namespace Project_Exit.NPCs
{
    public class Ms_N2 : NPC
    {
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
            if (talkLog.Count > 1)
            {
                switch (talkLog.Peek())
                {
                    case 1: TalkLog1(); talkLog.Dequeue(); break;
                    case 2: TalkLog2(); break;
                }
            }
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
            Bandage bandage = new Bandage(Game.Player.position);
            for (int i = 0; i < Game.Player.inventory.items.Length; i++)
            {
                if (Game.Player.inventory.items[i] == null)
                {                    
                    Game.Player.inventory.Add(bandage);
                    Util.XKeyText("당신은 그녀에게 붕대를 받고서 나아갈 준비를 합니다.");
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
