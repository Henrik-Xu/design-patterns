using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClass02 : AbstracClass
    {
        public override void PrimitiveOperation01()
        {
            Console.WriteLine("B Achive Function01");
        }

        public override void PrimitiveOperation02()
        {
            Console.WriteLine("B Achive Function01");
        }
    }
}
