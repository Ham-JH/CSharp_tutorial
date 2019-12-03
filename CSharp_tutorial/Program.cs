using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial
{
    class Program
    {
        private static Chapters._2.Codes chap2;
        private static Chapters._3.Codes chap3;

        static void Main(string[] args)
        { 
            chap2 = new Chapters._2.Codes();
            chap3 = new Chapters._3.Codes();

            Console.Write("페이지 위치 입력 : ");
            Switcher(Convert.ToInt32(Console.ReadLine()));
        }

        public static void Switcher(int arg)
        {
            if(arg <= 37)       // chapter 2
            {
                chap2.RunCode(arg);
            }
            else if(arg <= 97)  // chapter 3
            {
                chap3.RunCode(arg);
            }
        }
    }
}
