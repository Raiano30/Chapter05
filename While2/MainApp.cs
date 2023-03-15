using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0); //do while문은 마지막에 꼭 세미콜론!

            do// 조건에 앞서 무조건 최초 한번은 실행된다.
            {
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);

        }
    }
}
