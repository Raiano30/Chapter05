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
            for (int i = 0; i < 5; i++) // (초기화식; 조건식; 반복식) //순서 : 조건식 참 > 실행코드 > 반복식
            {
                Console.WriteLine(i);
            }

            int a = 5;
            //데이터형식[] 배열이름 = new 데이터형식[용량];
            int[] score = new int[5];
            score[0] = 1;
            score[1] = 2;
            score[2] = 3;
            score[3] = 4;
            score[4] = 5;

            int[] a1 = new int[] { 1, 2, 3, 4, 5 }; //new는 클래스의 생성자 //인덱스 주소가 존재 0,1,2,3,4
            int[] a2 = new int[5] { 1, 2, 3, 4, 5 };



        }
    }
}
