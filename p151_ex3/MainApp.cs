﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);

            if(number >= 50)
            {
                Console.WriteLine($"입력하신 숫자{number}는(은) 50이상의 수 입니다. ");
            }
            else
            {
                Console.WriteLine($"입력하신 숫자{number}는(은) 50미만의 수 입니다. ");
            }
        }
    }
}
