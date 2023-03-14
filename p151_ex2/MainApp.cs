using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력해주세요 : ");

            string str = Console.ReadLine();
            int number = int.Parse(str);

            if(number >= 90)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) A학점입니다.");
            }
            else if(number >= 80)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) B학점입니다.");
            }
            else if (number >= 70)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) C학점입니다.");
            }
            else
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) D학점입니다.");
            }
        }
    }
}
