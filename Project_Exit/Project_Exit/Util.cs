using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exit
{
    public static class Util
    {
        static ConsoleKey input;
        // X키를 눌러야지 넘어가는 텍스트를 구현
        public static void XKeyText(string text)
        {
            Console.WriteLine(text);
            while (true)
            {                
                input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.X)
                {                    
                    break;
                }
                else // X키 외의 키를 누르면 무반응으로 설정
                {
                    continue;
                }
            }                      
        }

        // 플레이어 대사 출력용 색깔 텍스트
        public static void PlayerText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"P군 : {text}");
            Console.ResetColor();
            while (true)
            {
                input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.X)
                {
                    break;
                }
                else // X키 외의 키를 누르면 무반응으로 설정
                {
                    continue;
                }
            }
        }

        // NPC 대사 출력용 색깔 텍스트
        public static void NPCText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"N양 : {text}");
            Console.ResetColor();
            while (true)
            {
                input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.X)
                {
                    break;
                }
                else // X키 외의 키를 누르면 무반응으로 설정
                {
                    continue;
                }
            }
        }
    }
}
