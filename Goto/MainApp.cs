using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("종료 조건(숫자)을 입력하세요 :");
            string input = Console.ReadLine();
            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            for (int i = 0; i < 2; i++) //2번
            {
                for (int j = 0; j < 2; j++) //2번 
                {
                    for (int k = 0; k < 3; k++) //3번
                    {
                        if(exit_number++ == input_number) //후위연산 하니까 값은 0 // 참이면 goto레이블로 점프
                        {
                            goto EXIT_FOR;

                            Console.WriteLine(exit_number);
                        }
                    }
                }
            }

            goto EXIT_PROGRAM; //레이블로 점프

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program");


        }
    }
}
