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
            while(true)
            {
                input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.X)
                {
                    Console.WriteLine(text);
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
