using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class ConcreteDecoratorB:Decorator
    {
        public string addedState;

        public override void Operation()
        {
            base.Operation();

            AddedBehavior();
            Console.WriteLine("Specific Object B Operation");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("Added Behavior");
        }
    }
}
