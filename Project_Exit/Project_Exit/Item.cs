using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Project_Exit
{
    public class Item : GameObject
    {
        public string name;
        public string description;

        // 아이템의 사용 가능 여부
        // 소모형 아이템은 사용 가능(사용 시 즉시 효과),
        // 이벤트성 아이템은 사용 불가능(소유 시 효과)
        // * 이벤트성 아이템
        // : 단순히 가지고 있는 것만으로 이벤트가 달라지는 효력을 가진 아이템
        public bool isUsable;

        public Item(Vector2 position, bool isUsable)
            : base(ConsoleColor.Yellow, 'I', position, true)
        {
            this.isUsable = isUsable;
        }

        // 상호작용 시 플레이어의 인벤토리에 들어감
        public override void Interact(Player player)
        {            
            player.inventory.Add(this);
        }

        // 소모형 아이템만 해당 기능을 구현
        public virtual void Use() { }  
    }
}
