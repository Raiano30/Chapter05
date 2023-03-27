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
            //for (int i = 0; i < 5; i++) // (초기화식; 조건식; 반복식) //순서 : 조건식 참 > 실행코드 > 반복식
            //{
            //    Console.WriteLine(i);
            //}

            //int a = 5;
            ////데이터형식[] 배열이름 = new 데이터형식[용량];
            //int[] score = new int[5];
            //score[0] = 1;
            //score[1] = 2;
            //score[2] = 3;
            //score[3] = 4;
            //score[4] = 5;

            //int[] a1 = new int[] { 1, 2, 3, 4, 5 }; //new는 클래스의 생성자 //인덱스 주소가 존재 0,1,2,3,4
            //int[] a2 = new int[5] { 1, 2, 3, 4, 5 };



            //while문 별 증가
            int i = 0;
            while (i < 5)  //0이 5보다 작을때까지 반복 0,1,2,3,4(++안하면 무한반복)
            {
                int j = 0; 
                while (j <= i)  //j가 i이하인만큼 반복 (++안하면 무한반복)
                {
                    Console.Write("*");
                    j++; //0,1,2,3,4 (i가 4까지가 max)
                }
                Console.WriteLine();
                ++i; //행넘아가서 다시 1의 값으로 반복
            }
            //*
            //**
            //***
            //****
            //*****

            //while문 별 감소

            int t = 0;
            while ( t < 5) //0이 5보다 작을때까지 반복 0,1,2,3,4(++안하면 무한반복)
            {
                int f = 5;
                while ( t < f-1) // 0이 5미만이 될때까지 반복 5,4,3,2,1 (-- 해야함)
                {
                    Console.Write("*");
                    f--; //5,4,3,2,1
                }
                Console.WriteLine("*");
                ++t;
            }
            //*****
            //****
            //***
            //**
            //*
            Console.WriteLine("do while문");
            int s = 0; //0,1,2,3,4
            do
            {
                int z = 0;
                while (z <= s ) // 1,2,3,4,5
                {
                    Console.Write("*");
                    z++;
                }
                Console.WriteLine();
                s++;
            }
            while (s < 5); //5헁            
            //*
            //**
            //***
            //****
            //*****



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
            //*****
            //****
            //***
            //**
            //*

            int a = 0; //0,1,2,3,4
            do
            {
                int z = 0;
                while (z < 5 - a) // 0,1,2    //for (int j = 0; j < 5-i; j++)
                {
                    Console.Write("*");
                    z++;
                }
                Console.WriteLine();
                a++;
            }
            while (a < 5); //5헁
            //*****
            //****
            //***
            //**
            //*











        }
    }
}
