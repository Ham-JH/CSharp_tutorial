using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial
{
    class Program
    {
        //private static Chapters._2.Codes chap2;
        //private static Chapters._3.Codes chap3;

        static void Main(string[] args)
        {
            Console.Write("페이지 위치 입력 : ");
            Switcher(Convert.ToInt32(Console.ReadLine()));
        }

        public static void Switcher(int arg)
        {
            if(arg >= 15 && arg <= 37)       // chapter 2 : 처음 만드는 C# 프로그램
            {
                new Chapters._2.Codes(arg);
            }
            else if(arg <= 97)  // chapter 3 : 데이터 보관하기
            {
                new Chapters._3.Codes(arg);
            }
            else if(arg <= 115) // chapter A : 문자열 다루기
            {
                new Chapters.A.Codes(arg);
            }
            else if(arg <= 145) // chapter 4 : 데이터를 가공하는 연산자
            {
                new Chapters._4.Codes(arg);
            }
            else if(arg <= 181) // chapter 5 : 코드의 흐름 제어하기
            {
                new Chapters._5.Codes(arg);
            }
            else if(arg <= 217) // chapter 6 : 메소드로 코드 간추리기
            {
                
            }
            else if(arg <= 285) // chapter 7 : 클래스
            {
                
            }
            else if(arg <= 305) // chapter 8 : 인터페이스와 추상 클래스
            {

            }
            else if(arg <= 329) // chapter 9 : 프로퍼티
            {

            }
            else if(arg <= 371) // chapter 10 : 배열과 컬렉션, 그리고 인덱서
            {

            }
            else if(arg <= 399) // chapter 11 : 일반화 프로그래밍
            {

            }
            else if(arg <= 425) // chapter 12 : 예외 처리하기
            {

            }
            else if(arg <= 455) // chapter 13 : 대리자와 이벤트
            {

            }
            else if(arg <= 479) // chapter 14 : 람다식
            {

            }
            else if(arg <= 515) // chapter 15 : LINQ
            {

            }
            else if(arg <= 547) // chapter 16 : 리플렉션과 애트리뷰트
            {

            }
            else if(arg <= 571) // chapter 17 : dynamic 형식
            {

            }
            else if(arg <= 605) // chapter 18 : 파일 다루기
            {

            }
            else if(arg <= 663) // chapter 19 : 스레드와 태스크
            {

            }
            else if(arg <= 713) // chapter 20 : WinForm으로 만드는 사용자 인터페이스
            {

            }
            else if(arg <= 763) // chapter 21 : 네트워크 프로그래밍
            {

            }
            else if(arg <= 779) // chapter 22 : 가비지 컬렉션
            {

            }
        }
    }
}
