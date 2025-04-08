namespace Project_Exit.NPCs
{
    public class Ms_N : NPC
    {
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
        }

        public override void Talk()
        {
            Console.SetCursorPosition(0, 14);
            Util.XKeyText("안녕하세요");
            Util.XKeyText("당신은 누구신가요?");
            Util.XKeyText("제 이름은 N양이라고 해요");
            Console.WriteLine("대화를 종료하려면 X키 외의 아무 키를 누르세요.");
            
            isTalking = false;
        }
    }
}
