using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._2
{
    class Codes : CodesClass
    {
        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            Console.WriteLine("인자값을 활용한 실행코드 출력은 따로 알아두도록 한다.");
        }

    }
}
