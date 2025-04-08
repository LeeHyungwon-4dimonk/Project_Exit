using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit
{
    public class Inventory
    {
        public Item[] items;
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
