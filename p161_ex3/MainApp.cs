using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("몇 월이 궁금하세요?");
            string month = Console.ReadLine();

            switch (month)
            {
                case "1": case "3": case "5": case "7": case "8": case "10": case "12":
                    Console.WriteLine($"{month}월은 : 31일까지 있습니다.");
                    break;
                case "2":
                    Console.WriteLine($"{month}월은 : 28일까지 있습니다.");
                    break;
                case "4": case "6": case "9": case "11":
                    Console.WriteLine($"{month}월은 : 30일까지 있습니다.");
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                    break;
            }
        }
    }
}
