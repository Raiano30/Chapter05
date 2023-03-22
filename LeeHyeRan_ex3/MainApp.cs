using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeHyeRan_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //while문, do문
            int i = 0;
            while (i < 5)
            {
                int j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                ++i;
            }


            int r = 5;
            do
            {
                int z = 0;
                while (z < r) //5,4,3,2,1
                {
                    Console.Write("*");
                    z++;
                }
                Console.WriteLine();
                r--;
            }
            while (r > 0); //5헁



        }
    }
}
