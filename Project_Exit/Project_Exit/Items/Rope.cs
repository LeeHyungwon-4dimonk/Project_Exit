using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit.Items
{
    public sealed class Rope : Item
    {
        // 밧줄은 이벤트성 아이템으로 소유시 엔딩에 영향을 미침
        public Rope(Vector2 position) : base(position, false)
        {
            name = "밧줄";
            description = "무언가를 단단히 묶을 수 있는 튼튼한 줄입니다";
        }
    }
}
