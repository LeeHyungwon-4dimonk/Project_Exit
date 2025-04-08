using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Exit.Items;

namespace Project_Exit
{
    public class Inventory
    {
        public Item[] items;
        private int lastAcievedIndex;

        private bool itemAchieved;
        public bool ItemAchieved { get { return itemAchieved; } }
        public Inventory()
        {
            items = new Item[4];            
        }

        public void Add(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == null)
                {
                    items[i] = item;
                    lastAcievedIndex = i;
                    itemAchieved = true;
                    break;
                }
                if(items[items.Length-1] != null)
                {
                    itemAchieved = false;
                    break;
                }
            }            
        }

        public void Use(int index)
        {
            items[index].Use();
        }        

        public void Drop(int index)
        {
            items[index] = null;            
        }

        public void PrintAchievedItem()
        {
            if (itemAchieved)
            {
                Console.SetCursorPosition(0, 13);
                Console.Write($"{items[lastAcievedIndex].name}를 획득했습니다.");
                itemAchieved = false;
            }            
        }

        public void BrieflyPrint()
        {
            Console.SetCursorPosition(0, 12);
            Console.Write("인벤토리 : ");
            for (int i = 0; i < items.Length; i++)
            {                
                if (items[i] != null)
                {
                    Console.Write(" ■ ");
                }
                else
                {
                    Console.Write(" □ ");
                }
            }
        }        
    }
}
