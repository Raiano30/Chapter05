using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0) //while (조건식) 참일 동안 반복함
            {
                Console.WriteLine($"i : {i--}");
            }
            // i : 10
            // i : 9
            // i : 8
        }
    }
}
