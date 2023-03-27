using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) //행이 5개 1,2,3,4,5
            {
                for (int j = 0; j <= i; j++) //행이 늘어나는 만큼 별도 늘어남//1,2,3,4,5
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
            Console.WriteLine();

            for (int i = 0; i < 5; i++) //행이 5개 1,2,3,4,5
            {
                for (int j = 0; j < 5-i; j++) //행이 늘어나는 만큼 별도 늘어남//1,2,3,4,5
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


            for (int i = 0; i < 5; i++) //행이 5개
            {
                for (int j = 0; j < 4-i; j++) //4,3,2,1,0
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) //1,2,3,4,5
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("while문으로 작성");
            //    *
            //   **
            //  ***
            // ****
            //*****

            //int start;
            //for (int i = 0; i < 5 ; i++) //행이 5개
            //{
            //    start = 1;
            //    for (int j = 0; j < 5; j++) //행안에서 반복
            //    {
            //        Console.Write(start); // 처음에 1출력 ++ 5번되므로 12345 출력
            //        start++;
            //    }
            //    Console.WriteLine();
            //}
            //12345
            //12345
            //12345
            //12345
            //12345

            //for (int i = 0; i < 5; i++) //5행
            //{
            //    //스페이스
            //    for (int j = 0; j < i; j++) //처음에는 없어야 함 0,1,2,3,4
            //    {
            //        Console.Write(" ");
            //    }
            //    //별
            //    for (int j = 0; j < 5-i; j++) //5,4,3,2,1
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //*****
            // ****
            //  ***
            //   **
            //    *
            //for (int i = 0; i < 5; i++) //행이 5개
            //{
            //    for (int j = 0; j < 4-i; j++) //4,3,2,1,0
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < (i*2)+1; j++) //1, 3, 5, 7, 9
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //    *
            //   ***
            //  *****
            // *******
            //*********
            //for (int i = 0; i < 5; i++) //행이 5개
            //{
            //    for (int j = 0; j < 4 - i; j++) //4,3,2,1,0
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < (i * 2) + 1; j++) //1, 3, 5, 7, 9
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < 4; i++) //행이 4개
            //{
            //    for (int j = 0; j < 1 + i; j++) // 빈칸 하나씩 증가
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 7 - (i * 2); j++) //별7개 //7, 5, 3, 1
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //      *
            //     ***
            //    *****
            //   *******
            //  *********
            //   *******
            //    *****
            //     ***
            //      *
            //

            int ii = 0;
            while(ii < 5)
            {
                int jj = 0;
                while (jj <= ii)
                {
                    Console.Write("*");
                    jj++;
                }
                Console.WriteLine();
                ++ii;
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
