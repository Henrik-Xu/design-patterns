using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0) throw new Exception("除数不能为0");
            return NumberA / NumberB;
        }
    }
}
