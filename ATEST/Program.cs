using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEST
{
    class Program
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine($"input : {a}, {b}");
            int result = a + b; //지역변수
            return result;

        }
        static void Main(string[] args) //프로그램 시작시 가장 먼저 실행
        {
            Plus(3, 4); //세미콜론 읽기 전에 Plus 메소드로 올라가서 반환값을 가져온다. 담는 변수가 없으니 가져오고 끝
            int a = Plus(1, 2); // 세미콜론 읽기 전 Plus 메소드에서 3의 값을 가져온다. a변수에 담는다.
            Console.WriteLine("a"); //3 출력

        }
    }
}
