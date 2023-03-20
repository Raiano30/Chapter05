using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeHyeRan_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) // 5행
            {
                for (int j = 0; j < 5-i; j++)  //[5-0][5-1][5-2][5-3][5-4] 5,4,3,2,1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //*****
            //****
            //***
            //**
            //*
        }
    }
}
