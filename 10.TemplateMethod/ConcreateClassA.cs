using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreateClassA : AbstracClass
    {
        public override void PrimitiveOperation01()
        {
            Console.WriteLine("A Achive Function01");
        }

        public override void PrimitiveOperation02()
        {
            Console.WriteLine("A Achive Function02");
        }
    }
}
