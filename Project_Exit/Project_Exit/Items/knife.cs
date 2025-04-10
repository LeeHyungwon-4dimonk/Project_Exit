﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Exit.Items
{
    public class knife : Item
    {
        // 칼은 이벤트성 아이템으로 소유시 엔딩에 영향을 미침
        public knife(Vector2 position) : base(position, false)
        {
            name = "칼";
            description = "날카로운 칼입니다. 위험한 흉기가 될 수도 있습니다.";
        }
    }
}
