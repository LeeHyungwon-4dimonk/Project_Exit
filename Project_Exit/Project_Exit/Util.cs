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

        // X키를 눌러야지 넘어가는 텍스트를 구현 ( 한 줄 씩 출력 )
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
        // Z키를 눌러야지 넘어가는 텍스트를 구현 ( NPC와의 대화 종료용 )
        public static void ZKeyText(string text)
        {
            Console.WriteLine(text);
            while (true)
            {
                input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.Z)
                {
                    break;
                }
                else // X키 외의 키를 누르면 무반응으로 설정
                {
                    continue;
                }
            }
        }

        // 플레이어 대사 출력용 색깔 텍스트 및 X키 입력 후 넘어가기
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

        // NPC - N양 대사 출력용 색깔 텍스트 및 X키 입력 후 넘어가기
        public static void NPC_NText(string text)
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

        // NPC - C군 대사 출력용 색깔 텍스트 및 X키 입력 후 넘어가기
        public static void NPC_CText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"C군 : {text}");
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
