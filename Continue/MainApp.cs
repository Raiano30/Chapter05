using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if( i % 2 == 0) //짝수면
                {
                    continue; //현재의 반복을 건너뛴다. i++로 넘어간다.
                }
                Console.WriteLine($"{i} : 홀수");
            }
            //1 : 홀수
            //3 : 홀수
            //5 : 홀수
            //7 : 홀수
            //9 : 홀수
        }
    }
}
