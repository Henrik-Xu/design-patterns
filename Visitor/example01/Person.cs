using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  public  enum EAction
    {
        Success=1,
        Failed=2,
        FallInLove=3,
    }
  public abstract  class Person
    {
        protected EAction action;
        public EAction Action
        {
            get { return action; }
            set { action = value; }
        }
        public abstract void GetConclusion();
    }
   public class Man:Person
    {
        public override void GetConclusion()
        {
            if(action==EAction.Success)
            {
                Console.WriteLine($"When Man {action}. man backward has a great woman");
            }
            else if(action==EAction.Failed)
            {
                Console.WriteLine($"When Man {action},He wants to drink.");
            }
            else if(action==EAction.FallInLove)
            {
                Console.WriteLine($"When Man {action},He Know Everything.");
            }
        }
    }
   public class Woman:Person
    {
        public override void GetConclusion()
        {
            if (action == EAction.Success)
            {
                Console.WriteLine($"When Woman {action}. woman backward has a  bad man");
            }
            else if (action == EAction.Failed)
            {
                Console.WriteLine($"When Woman {action}. woman wants to buy buy buy");
            }
            else if (action == EAction.FallInLove)
            {
                Console.WriteLine($"When Woman {action},He Know nothing.");
            }
        }
    }
}
