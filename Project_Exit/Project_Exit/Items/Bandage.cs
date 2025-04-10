using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.Items
{
    // 밴드는 소모성 아이템으로 사용 시 효과가 즉시 발동
    public sealed class Bandage : Item
    {
        public Bandage(Vector2 position)
            : base(position, true)
        {
            name = "붕대";
            description = "체력을 2 회복합니다";
        }

        public override void Use()
        {
            Game.Player.HPHeal(2);
        }
    }
}
