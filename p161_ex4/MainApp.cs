using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("알고싶은 월을 입력해주세요. : ");
                string month = Console.ReadLine();
                string season = "";

                switch (month)
                {
                    case "12": case "1": case "2":
                        //Console.WriteLine($"입력하신 {month}월은 겨울입니다.");
                        season = "겨울";
                        break;
                    case "3": case "4": case "5":
                        //Console.WriteLine($"입력하신 {month}월은 봄입니다.");
                        season = "봄";
                        break;
                    case "6": case "7": case "8":
                        //Console.WriteLine($"입력하신 {month}월은 여름입니다.");
                        season = "여름";
                        break;
                    case "9": case "10": case "11":
                        //Console.WriteLine($"입력하신 {month}월은 가을입니다.");
                        season = "가을";
                        break;
                    default:
                        Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                        //break;
                        return; //메소드 밖으로 나가기 때문 아래 값이 출력되지 않는다.
                }
                Console.WriteLine($"입력하신 {month}월은 {season}입니다.");
            }
            //Console.Write("알고싶은 월을 입력해주세요. : ");
            //string month = Console.ReadLine();
            //string season = "";

            //switch (month)
            //{
            //    case "12": case "1": case "2":
            //        //Console.WriteLine($"입력하신 {month}월은 겨울입니다.");
            //        season = "겨울";
            //        break;
            //    case "3": case "4": case "5":
            //        //Console.WriteLine($"입력하신 {month}월은 봄입니다.");
            //        season = "봄";
            //        break;
            //    case "6": case "7": case "8":
            //        //Console.WriteLine($"입력하신 {month}월은 여름입니다.");
            //        season = "여름";
            //        break;
            //    case "9": case "10": case "11":
            //        //Console.WriteLine($"입력하신 {month}월은 가을입니다.");
            //        season = "가을";
            //        break;
            //    default:
            //        Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
            //        //break;
            //        return; //메소드 밖으로 나가기 때문 아래 값이 출력되지 않는다.
            //}
            //Console.WriteLine($"입력하신 {month}월은 {season}입니다.");
        }
    }
}
