using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
   public abstract class Operation
    {
        public double NumberA { get; set; } = 0;
        public double NumberB { get; set; } = 0;

        public abstract double GetResult();
    }
}
