using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) // (초기화식; 조건식; 반복식) //순서 : 조건식 참 > 실행코드 > 반복식
            {
                Console.WriteLine(i);
            }
        }
    }
}
