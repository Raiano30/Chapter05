using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class MainApp
    {
        
        static void Main(string[] args) //분기문 = [조건문]
        {
            Console.WriteLine("숫자를 입력하세요. : ");

            string input = Console.ReadLine(); //ReadLine() 사용자 입력값을 받는다.
            int number = Int32.Parse(input); //string을 int로 형변환. ,Int.Parse로 써도 된다.

            if (number < 0)     //input =="10"
            {
                Console.WriteLine("음수");
            }
            else if(number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            {
                Console.WriteLine("0");
            }
               
            if(number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("양수");
            }
            //-------------------------------------------------
            //string str = number%2 == 0 ? "짝수" : "양수";       //[조건연산자]로 가능하면 이걸로 사용. 더 빠르다. 코딩테스트 단골
            Console.WriteLine(number % 2 == 0 ? "짝수" : "양수");
            //0313 집에서 확인
        }
    }
}
