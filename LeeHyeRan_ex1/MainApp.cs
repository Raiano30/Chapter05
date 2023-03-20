using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeHyeRan_ex1
{
    class MainApp
    {
        static void Main(string[] args) //문제1
        {
            for (int i = 0; i < 5; i++) //5행
            {
                for (int j = 0; j <= i; j++) //[0<=0][0<=1][0<=2][0<=3][0<=4] 1,2,3,4,5
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //*
            //**
            //***
            //****
            //*****
        }
    }
}
