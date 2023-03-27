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
            Console.WriteLine("while문");
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

            int t = 0;
            while (t < 5) //0이 5보다 작을때까지 반복 0,1,2,3,4(++안하면 무한반복)
            {
                int f = 5;
                while (t < f - 1) // 0이 5미만이 될때까지 반복 5,4,3,2,1 (-- 해야함)
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
                while (z <= s) // 1,2,3,4,5
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
