using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters
{
    abstract class CodesClass
    {
        public CodesClass(int arg)
        {
            RunCode(arg);
        }

        public abstract void RunCode(int arg);
    }
}
