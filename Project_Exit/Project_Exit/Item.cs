using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Project_Exit
{
    public abstract class Item : GameObject
    {
        public string name;
        public string description;

        public Item(Vector2 position)
            : base(ConsoleColor.Yellow, 'I', position, true)
        {
            
        }
        public override void Interact(Player player)
        {            
            player.inventory.Add(this);
        }

        public abstract void Use();  
    }
}
