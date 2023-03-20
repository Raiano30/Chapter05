using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeHyeRan_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자로부터 입력받은 횟수만큼 별을 반복 출력
            Console.Write("반복 횟수를 입력하세요 : ");
            string str = Console.ReadLine();
            int num = int.Parse(str); //6

            for (int i = 0; i < num; i++) //5행 12345
            {
                for (int j = 0; j <= i; j++) //[0<=0][0<=1][0<=2][0<=3][0<=4]  1,2,3,4,5
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
