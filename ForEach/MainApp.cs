﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            //0
            //1
            //2
            //3
            //4
            //배열 > 리스트 > 컬렉션 > 딕셔너리
        }
    }
}
