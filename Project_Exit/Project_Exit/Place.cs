using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit
{
    // 맵에 표시되는 장소 이동 지점 표시
    public class Place : GameObject
    {
        private string scene;
        public Place(string scene, char symbol, Vector2 position) 
            : base(ConsoleColor.Blue, symbol, position, false)
        {
            this.scene = scene;
        }
        // 플레이어와 상호작용 시 씬 전환
        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
