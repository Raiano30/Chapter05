using System;

namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. : ");
            string str1 = Console.ReadLine();
            int int1 = Int32.Parse(str1);
            
            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. : ");
            string str2 = Console.ReadLine();
            int int2 = Int32.Parse(str2);

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. : ");
            string str3 = Console.ReadLine();
            int int3 = Int32.Parse(str3);

            Console.WriteLine($"{int1}, {int2}, {int3}");

            int max;
            int min;
            if(int1 > int2 && int1 > int3)
            {
                max = int1;
                if(int2 < int3)
                {
                    min = int2;
                }
                else
                {
                    min = int3;
                }
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3} 중 최대값은 {max}이며, 최소값은 {min}입니다.");
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3}의 합은 {int1 + int2 + int3}이며, 평균은 {(int1 + int2 + int3) / 3}입니다. ");
            }
            else if(int2 > int1 && int2 >int3)
            {
                max = int2;
                if(int1 < int3)
                {
                    min = int1;
                }
                else
                {
                    min = int3;
                }
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3} 중 최대값은 {max}이며, 최소값은 {min}입니다.");
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3}의 합은 {int1 + int2 + int3}이며, 평균은 {(int1 + int2 + int3) / 3}입니다. ");
            }
            else
            {
                max = int3;
                if (int1 < int2)
                {
                    min = int1;
                }
                else
                {
                    min = int2;
                }
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3} 중 최대값은 {max}이며, 최소값은 {min}입니다.");
                Console.WriteLine($"입력하신 {int1}, {int2}, {int3}의 합은 {int1 + int2 + int3}이며, 평균은 {(int1 + int2 + int3) / 3}입니다. ");
            }
        }
    }
}
