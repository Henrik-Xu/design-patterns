using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Action
    {
        public abstract void GetManConclusion();
        public abstract void GetWomanConclusion();
    }

    public class Success : Action
    {
        public override void GetManConclusion()
        {
            Console.WriteLine($"When Man {this.GetType().Name}. man backward has a great woman");
        }

        public override void GetWomanConclusion()
        {
            Console.WriteLine($"When Woman {this.GetType().Name}. woman backward has a  bad man");
        }
    }

    public class Failed : Action
    {
        public override void GetManConclusion()
        {
            Console.WriteLine($"When Man {this.GetType().Name},He wants to drink.");
        }

        public override void GetWomanConclusion()
        {
            Console.WriteLine($"When Woman {this.GetType().Name}. woman wants to buy buy buy");
        }
    }

    public class FallInLove : Action
    {
        public override void GetManConclusion()
        {
            Console.WriteLine($"When Man {this.GetType().Name},He Know Everything.");
        }

        public override void GetWomanConclusion()
        {
            Console.WriteLine($"When Woman {this.GetType().Name},She Know nothing.");
        }
    }

    public class Marriage : Action
    {
        public override void GetManConclusion()
        {
            Console.WriteLine($"When Man {this.GetType().Name},He Has No Money.");
        }

        public override void GetWomanConclusion()
        {
            Console.WriteLine($"When Woman {this.GetType().Name},She Has Much Money.");
        }
    }

    public abstract  class PersonAdvance
    {
        public abstract void Accept(Action visitor);
    }
    public class ManAdvance : PersonAdvance
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion();
        }
    }

    public class WomanAdvance : PersonAdvance
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion();
        }
    }

    public class ObjectStructure
    {
        private IList<PersonAdvance> elements = new List<PersonAdvance>();

        public void Attach(PersonAdvance personAdvance)
        {
            elements.Add(personAdvance);
        }
        public void Detach(PersonAdvance personAdvance)
        {
            elements.Remove(personAdvance);
        }

      public void Display(Action visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }

}
