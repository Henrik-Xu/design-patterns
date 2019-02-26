using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class ConcreteDecoratorA:Decorator
    {
        public string addedState;

        public override void Operation()
        {
            base.Operation();

            addedState = "New State";
            Console.WriteLine("Specific Object A Operation ");
        }

    }

}
