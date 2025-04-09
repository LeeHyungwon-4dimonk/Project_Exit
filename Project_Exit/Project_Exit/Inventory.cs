namespace Project_Exit
{
    public class Inventory
    {
        private Stack<string> stack = new Stack<string>();

        public Item[] items;
        private int lastAcievedIndex;
        private int selectIndex;

        private bool itemAchieved;
        public bool ItemAchieved { get { return itemAchieved; } }
        public Inventory()
        {
            items = new Item[4];
        }

        // 아이템 획득
        public void Add(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    lastAcievedIndex = i;
                    itemAchieved = true;
                    break;
                }
                if (items[items.Length - 1] != null)
                {
                    itemAchieved = false;
                    break;
                }
            }
        }

        // 아이템 사용
        public void Use(int index)
        {
            items[index].Use();
        }

        // 아이템 버리기
        public void Drop(int index)
        {
            items[index] = null;
        }

        // 획득한 아이템 출력
        public void PrintAchievedItem()
        {
            if (itemAchieved)
            {
                Console.SetCursorPosition(0, 13);
                Console.Write($"{items[lastAcievedIndex].name}를 획득했습니다.");
                itemAchieved = false;
            }
        }

        // 인벤토리 간략 출력
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
        public void PrintAll()
        {
            Console.WriteLine("===소지 중인 아이템===");
            Console.WriteLine();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {items[i].name}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. 비었음");
                }
            }
            Console.WriteLine();
        }

        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu": Menu(); break;
                    case "Detail": Detail(); break;
                    case "DropMenu": DropMenu(); break;
                    case "DropConfirm": break;
                }
            }
        }
        private void Menu()
        {
            PrintAll();
            Console.WriteLine("1. 상세 정보 확인하기");
            Console.WriteLine("2. 아이템 버리기");
            Console.WriteLine("X. 뒤로 가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("Detail");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.X:
                    stack.Pop();
                    break;
            }
        }
        private void Detail()
        {
            PrintAll();
            Console.WriteLine("상세 정보를 확인할 아이템을 선택해주세요.");
            Console.WriteLine("뒤로 가기를 하시려면 X를 눌러주세요.");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.X)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - 49;
                if (select < 0 || select > 4)
                {
                    Util.XKeyText("잘못 입력하였습니다.");
                    Util.XKeyText("뒤로 가려면 X키를 눌러주세요.");
                }
                else
                {
                    if (items[select] != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"아이템명 : {items[select].name}");
                        Console.WriteLine($"아이템 상세정보 : {items[select].description}");
                        selectIndex = select;

                        Item selectItem = items[selectIndex];
                        if (items[selectIndex].isUsable)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{items[selectIndex].name} 을/를 사용하시겠습니까? (y/n)");

                            ConsoleKey input2 = Console.ReadKey(true).Key;
                            switch (input2)
                            {
                                case ConsoleKey.Y:
                                    Console.WriteLine();
                                    selectItem.Use();
                                    Console.WriteLine($"{items[selectIndex].name} 을/를 사용하였습니다.");
                                    Util.XKeyText("뒤로 가려면 X키를 눌러주세요.");
                                    items[selectIndex] = null;
                                    stack.Pop();
                                    break;
                                case ConsoleKey.N:
                                    stack.Pop();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("사용할 수 없는 아이템입니다.");
                            Util.XKeyText("뒤로 가려면 X키를 눌러주세요.");
                        }
                    }
                }
            }
        }
        private void DropMenu()
        {
            PrintAll();
            Console.WriteLine("버릴 아이템을 선택해주세요.");
            Console.WriteLine("뒤로 가기를 하시려면 X를 눌러주세요.");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.X)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - 49;
                if (select < 0 || select > 4)
                {
                    Util.XKeyText("잘못 입력하였습니다.");
                    Util.XKeyText("뒤로 가려면 X키를 눌러주세요.");
                }
                else
                {
                    if (items[select] != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{items[selectIndex].name} 을/를 버리시겠습니까? (y/n)");

                        ConsoleKey input2 = Console.ReadKey(true).Key;
                        switch (input2)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine();
                                Console.WriteLine($"{items[selectIndex].name} 을/를 버렸습니다.");
                                Util.XKeyText("뒤로 가려면 X키를 눌러주세요.");
                                items[selectIndex] = null;
                                stack.Pop();
                                break;
                            case ConsoleKey.N:
                                stack.Pop();
                                break;
                        }
                    }
                }
            }
        }
    }
}
