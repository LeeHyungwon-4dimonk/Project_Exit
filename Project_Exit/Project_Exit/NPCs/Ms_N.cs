using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.NPCs
{
    public class Ms_N : NPC
    {
        public string name;
        private int likeablity;
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
            isTalking = true;
        }
        
        public override void Talk()
        {
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("안녕하세요");
            isTalking = false;
        }
    }
}
