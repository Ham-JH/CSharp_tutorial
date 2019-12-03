using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._3
{
    class Codes : CodesClass
    {
        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            switch(arg)
            {
                case 48:

                    break;
            }
        }

        public override void WriteText(int arg)
        {
            throw new NotImplementedException();
        }
    }
}
