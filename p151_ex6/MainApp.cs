using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요. (ex.2) : ");
            string str = Console.ReadLine();
            int grade = Int32.Parse(str);

            Console.Write("현재 본인의 점수를 입력해 주세요. (ex.85) : ");
            string str3 = Console.ReadLine();
            int score = Int32.Parse(str3);

            if (grade < 4 && grade > 0)
            {
                if (score >= 60 && score <= 100)
                {
                    Console.WriteLine($"입력하신 점수{score}는(은) 합격 입니다.");
                }
                else if (score < 60 && score >= 0)
                {
                    Console.WriteLine($"입력하신 점수{score}는(은) 불합격 입니다.");
                }
                else
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요");
                }
            }
            else if(grade == 4)
            {
                if (score >= 70 && score < 100)
                {
                    Console.WriteLine($"입력하신 점수{score}는(은) 합격 입니다.");
                }
                else if (score < 70 && score >= 0)
                {
                    Console.WriteLine($"입력하신 점수{score}는(은) 불합격 입니다.");
                }
                else
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요");
                }
            }
            else
            {
                Console.WriteLine("학년을 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
            }
        }
    }
}
