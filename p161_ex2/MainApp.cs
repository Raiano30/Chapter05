using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            Console.Write("두 번째 정수를 입력해주세요. : ");
            string input2 = Console.ReadLine();
            int num2 = Int32.Parse(input2);

            Console.Write("연산기호를 입력해주세요. ex)+, -, *, /, % : ");
            string sum = Console.ReadLine();
            int value = 0;
            switch (sum)
            {
                case "+":
                    //Console.WriteLine($"입력하신 {num} + {num2}의 결과값은 {num + num2}입니다.");
                    value = num + num2;
                    break;
                case "-":
                    //Console.WriteLine($"입력하신 {num} - {num2}의 결과값은 {num - num2}입니다.");
                    value = num - num2;
                    break;
                case "*":
                    //Console.WriteLine($"입력하신 {num} * {num2}의 결과값은 {num * num2}입니다.");
                    value = num * num2;
                    break;
                case "/":
                    //Console.WriteLine($"입력하신 {num} / {num2}의 결과값은 {num / num2}입니다.");
                    value = num / num2;
                    break;
                case "%":
                    //Console.WriteLine($"입력하신 {num} % {num2}의 결과값은 {num % num2}입니다.");
                    value = num % num2;
                    break;
                default:
                    Console.WriteLine("잘못된 연산기호입니다.");
                    return;
                    //break; 
            }

            Console.WriteLine($"입력하신 {num} {sum} {num2}의 결과값은 {value}입니다.");
                //switch문 밖에서 콘솔 표출할 때는 defalt break 아니라 return해야 메소드 밖으로 감
        }
    }
}
