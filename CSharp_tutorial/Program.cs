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
            if(arg >= 15 && arg <= 37)       // chapter 2
            {
                new Chapters._2.Codes(arg);
            }
            else if(arg <= 97)  // chapter 3
            {
                new Chapters._3.Codes(arg);
            }
            else if(arg <= 115) // chapter 4
            {
                
            }
            else if(arg <= 145) // chapter 5
            {
                
            }
            else if(arg <= 181) // chapter 6
            {

            }
            else if(arg <= 217) // chapter 7
            {
                
            }
            else if(arg <= 285) // chapter 8
            {
                
            }
            else if(arg <= 305) // chapter 9
            {

            }
            else if(arg <= 329) // chapter 10
            {

            }
            else if(arg <= 371) // chapter 11
            {

            }
            else if(arg <= 399) // chapter 12
            {

            }
            else if(arg <= 425) // chapter 13
            {

            }
            else if(arg <= 455) // chapter 14
            {

            }
            else if(arg <= 479) // chapter 15
            {

            }
            else if(arg <= 515) // chapter 16
            {

            }
            else if(arg <= 547) // chapter 17
            {

            }
            else if(arg <= 571) // chapter 18
            {

            }
            else if(arg <= 605) // chapter 19
            {

            }
            else if(arg <= 663) // chapter 20
            {

            }
            else if(arg <= 713) // chapter 21
            {

            }
            else if(arg <= 763) // chapter 22
            {

            }
        }
    }
}
